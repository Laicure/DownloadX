Public Class MainX
    Dim SaveFolder As String = Nothing
    Dim BulkList As New HashSet(Of String)
    Dim errored As Boolean = False
    Dim forceCan As Boolean = False

#Region "Form"
    Private Sub MainX_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "DownloadX v" & My.Application.Info.Version.ToString
        Me.Icon = My.Resources.arrow_down_bold_hexagon_outline
        Me.Activate()
    End Sub

    Private Sub MainX_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Hide()
    End Sub
#End Region

    Private Sub butDL_Click(sender As Object, e As EventArgs) Handles butDL.Click
        'Busy? Empty?
        If bgDL.IsBusy Or String.IsNullOrWhiteSpace(txUrl.Text) Then
            LbStat.Text = "Cancelling..."
            txUrl.Focus()
            forceCan = True
            Exit Sub
        End If

        Dim bulker As HashSet(Of String) = New HashSet(Of String)(txUrl.Lines.Where(Function(x) Not String.IsNullOrWhiteSpace(x)))
        BulkList.Clear()
        BulkList.TrimExcess()
        For Each strr As String In bulker
            If Uri.IsWellFormedUriString(strr, UriKind.Absolute) Then
                BulkList.Add(strr)
            End If
        Next

        txUrl.Text = String.Join(vbCrLf, BulkList)

        'check bulk
        If BulkList.Count = 0 Then
            txUrl.Focus()
            Exit Sub
        End If

        butDL.Text = "Cancel"
        LbStat.Text = "Preparing..."
        If fbBrowse.ShowDialog = Windows.Forms.DialogResult.OK Then
            SaveFolder = fbBrowse.SelectedPath
            bgDL.RunWorkerAsync(SaveFolder)
        Else
            LbStat.Text = "Ready!"
        End If
    End Sub

    Private Sub butClear_Click(sender As Object, e As EventArgs) Handles butClear.Click
        txUrl.Text = ""
        BulkList.Clear()
        BulkList.TrimExcess()
    End Sub

#Region "Download bgWorker"
    Private Sub bgDL_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgDL.DoWork
        Try
            LbStat.Invoke(DirectCast(
                          Sub()
                              LbStat.Text = "Downloading..."
                          End Sub, MethodInvoker)
                )
            Using webber As New Net.WebClient
                'set credentials
                Dim Creden As New Net.NetworkCredential
                webber.UseDefaultCredentials = False
                If chUseCreden.Checked Then
                    If Not String.IsNullOrWhiteSpace(txCredenUser.Text) Then
                        Creden.UserName = txCredenUser.Text
                    End If
                    If Not String.IsNullOrWhiteSpace(txCredenPass.Text) Then
                        Creden.Password = txCredenPass.Text
                    End If
                    If Not String.IsNullOrWhiteSpace(txCredenDomain.Text) Then
                        Creden.Domain = txCredenDomain.Text
                    End If

                    webber.Credentials = Creden
                Else
                    webber.Credentials = Net.CredentialCache.DefaultNetworkCredentials
                End If

                Dim UrlList As HashSet(Of String) = New HashSet(Of String)(BulkList)
                Dim xx As Integer = 0
                For Each urlxx As String In UrlList
                    If forceCan Then
                        forceCan = False
                        Exit For
                    Else
                        LbStat.Invoke(DirectCast(
                                      Sub()
                                          LbStat.Text = "Downloading " & urlxx
                                      End Sub, MethodInvoker)
                                  )
                        xx += 1
                        If My.Computer.FileSystem.FileExists(e.Argument.ToString & "\" & xx) Then
                            My.Computer.FileSystem.DeleteFile(e.Argument.ToString & "\" & xx, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently, FileIO.UICancelOption.DoNothing)
                        End If

                        webber.DownloadFile(urlxx, e.Argument.ToString & "\" & "DL_" & xx)
                    End If
                Next
            End Using
            errored = False
        Catch ex As Exception
            errored = True
            MessageBox.Show(Err.Description, Err.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bgDL_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgDL.RunWorkerCompleted
        If My.Computer.FileSystem.DirectoryExists(SaveFolder) And Not errored Then
            LbStat.Text = "Downloaded" & vbCrLf & "and Ready!"
            Process.Start("explorer", SaveFolder)
        Else
            LbStat.Text = "Something went wrong :("
        End If

        butDL.Text = "Download!"
    End Sub
#End Region

    Private Sub chUseCreden_CheckedChanged(sender As Object, e As EventArgs) Handles chUseCreden.CheckedChanged
        gbCreden.Enabled = chUseCreden.Checked
    End Sub

End Class