Imports System.IO
Imports System.Web.Mail

Public Class Main_Screen

    Private busyworking As Boolean = False
    Private AutoUpdate As Boolean = False
    Dim shownminimizetip As Boolean = False

    Dim offlist As String = ""

    Private Sub Error_Handler(ByVal ex As Exception, Optional ByVal identifier_msg As String = "")
        Try
            If ex.Message.IndexOf("Thread was being aborted") < 0 Then
                Dim Display_Message1 As New Display_Message()
                Display_Message1.Message_Textbox.Text = "The Application encountered the following problem: " & vbCrLf & identifier_msg & ": " & ex.ToString
                Display_Message1.Timer1.Interval = 1000
                Display_Message1.ShowDialog()
                Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs")
                If dir.Exists = False Then
                    dir.Create()
                End If
                dir = Nothing
                Dim filewriter As System.IO.StreamWriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs\" & Format(Now(), "yyyyMMdd") & "_Error_Log.txt", True)
                filewriter.WriteLine("#" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & " - " & identifier_msg & ": " & ex.ToString)
                filewriter.WriteLine("")
                filewriter.Flush()
                filewriter.Close()
                filewriter = Nothing
            End If
            StatusLabel.Text = "Error Reported"
        Catch exc As Exception
            MsgBox("An error occurred in the application's error handling routine. The application will try to recover from this serious error." & vbCrLf & vbCrLf & exc.ToString, MsgBoxStyle.Critical, "Critical Error Encountered")
        End Try
    End Sub

    Private Sub Activity_Handler(ByVal message As String)
        Try
            Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs")
            If dir.Exists = False Then
                dir.Create()
            End If
            dir = Nothing
            Dim filewriter As System.IO.StreamWriter = New System.IO.StreamWriter((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs\" & Format(Now(), "yyyyMMdd") & "_Activity_Log.txt", True)
            filewriter.WriteLine("#" & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & " - " & message)
            filewriter.WriteLine("")
            filewriter.Flush()
            filewriter.Close()
            filewriter = Nothing
            StatusLabel.Text = "Activity Logged"
        Catch ex As Exception
            Error_Handler(ex, "Activity Handler")
        End Try
    End Sub

    Private Sub Main_Screen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Control.CheckForIllegalCrossThreadCalls = False
            Me.Text = My.Application.Info.ProductName & " (" & Format(My.Application.Info.Version.Major, "0000") & Format(My.Application.Info.Version.Minor, "00") & Format(My.Application.Info.Version.Build, "00") & "." & Format(My.Application.Info.Version.Revision, "00") & ")"
            NotifyIcon1.BalloonTipText = "You have chosen to hide " & My.Application.Info.ProductName & ". To bring it back up, simply click here."
            NotifyIcon1.BalloonTipTitle = My.Application.Info.ProductName
            NotifyIcon1.Text = "Click to bring up " & My.Application.Info.ProductName
            loadSettings()
            StatusLabel.Text = "Application Loaded"
        Catch ex As Exception
            Error_Handler(ex, "Application Loading")
        End Try
    End Sub

    Private Sub loadSettings()
        Try

            Dim configfile As String = (Application.StartupPath & "\config.sav").Replace("\\", "\")
            If My.Computer.FileSystem.FileExists(configfile) Then
                Dim reader As StreamReader = New StreamReader(configfile)
                Dim lineread As String
                Dim variablevalue As String
                While reader.Peek <> -1
                    lineread = reader.ReadLine
                    If lineread.IndexOf("=") <> -1 Then
                        variablevalue = lineread.Remove(0, lineread.IndexOf("=") + 1)
                        If lineread.StartsWith("LCA_Machines=") Then
                            LCA_Machines.Text = variablevalue
                        End If
                        If lineread.StartsWith("LCA_Emails=") Then
                            LCA_Emails.Text = variablevalue
                        End If
                    End If
                End While
                reader.Close()
                reader = Nothing
            End If
            StatusLabel.Text = "Application Settings Loaded"
        Catch ex As Exception
            Error_Handler(ex, "Load Settings")
        End Try
    End Sub

    Private Sub SaveSettings()
        Try
            Dim configfile As String = (Application.StartupPath & "\config.sav").Replace("\\", "\")
            Dim writer As StreamWriter = New StreamWriter(configfile, False)
            writer.WriteLine("LCA_Machines=" & LCA_Machines.Text)
            writer.WriteLine("LCA_Emails=" & LCA_Emails.Text)
            writer.Flush()
            writer.Close()
            writer = Nothing
            StatusLabel.Text = "Application Settings Saved"
        Catch ex As Exception
            Error_Handler(ex, "Save Settings")
        End Try
    End Sub

    Private Sub Main_Screen_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            SaveSettings()
            If AutoUpdate = True Then
                If My.Computer.FileSystem.FileExists((Application.StartupPath & "\AutoUpdate.exe").Replace("\\", "\")) = True Then
                    Dim startinfo As ProcessStartInfo = New ProcessStartInfo
                    startinfo.FileName = (Application.StartupPath & "\AutoUpdate.exe").Replace("\\", "\")
                    startinfo.Arguments = "force"
                    startinfo.CreateNoWindow = False
                    Process.Start(startinfo)
                End If
            End If
            StatusLabel.Text = "Application Shutting Down"
        Catch ex As Exception
            Error_Handler(ex, "Closing Application")
        End Try
    End Sub
    Private Sub NotifyIcon1_BalloonTipClicked(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyIcon1.BalloonTipClicked
        Try
            Me.WindowState = FormWindowState.Normal
            Me.ShowInTaskbar = True
            NotifyIcon1.Visible = False
            Me.Refresh()
        Catch ex As Exception
            Error_Handler(ex, "Click on NotifyIcon")
        End Try
    End Sub


    Private Sub NotifyIcon1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon1.MouseClick
        Try
            Me.WindowState = FormWindowState.Normal
            Me.ShowInTaskbar = True
            NotifyIcon1.Visible = False
            Me.Refresh()
        Catch ex As Exception
            Error_Handler(ex, "Click on NotifyIcon")
        End Try
    End Sub


    Private Sub NotifyIcon1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NotifyIcon1.Click
        Try
            Me.WindowState = FormWindowState.Normal
            Me.ShowInTaskbar = True
            NotifyIcon1.Visible = False
            Me.Refresh()
        Catch ex As Exception
            Error_Handler(ex, "Click on NotifyIcon")
        End Try
    End Sub

    Private Sub Main_Screen_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        Try
            If Me.WindowState = FormWindowState.Minimized Then
                Me.ShowInTaskbar = False
                NotifyIcon1.Visible = True
                If shownminimizetip = False Then
                    NotifyIcon1.ShowBalloonTip(1)
                    shownminimizetip = True
                End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "Change Window State")
        End Try
    End Sub

    Private Sub HelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HelpToolStripMenuItem1.Click
        Try
            HelpBox1.ShowDialog()
            StatusLabel.Text = "Help Dialog Viewed"
        Catch ex As Exception
            Error_Handler(ex, "Display Help Screen")
        End Try
    End Sub

    Private Sub AutoUpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutoUpdateToolStripMenuItem.Click
        Try
            StatusLabel.Text = "AutoUpdate Requested"
            AutoUpdate = True
            Me.Close()
        Catch ex As Exception
            Error_Handler(ex, "AutoUpdate")
        End Try
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem1.Click
        Try
            AboutBox1.ShowDialog()
            StatusLabel.Text = "About Dialog Viewed"
        Catch ex As Exception
            Error_Handler(ex, "Display About Screen")
        End Try
    End Sub

    Private Sub Control_Enabler(ByVal IsEnabled As Boolean)
        Try
            Select Case IsEnabled
                Case True
                    LCA_Emails.Enabled = True
                    LCA_Machines.Enabled = True
                    Button1.Enabled = True
                    MenuStrip1.Enabled = True
                    Label6.Enabled = True
                    Me.ControlBox = True
                Case False
                    LCA_Emails.Enabled = False
                    LCA_Machines.Enabled = False
                    Label6.Enabled = False
                    Button1.Enabled = False
                    MenuStrip1.Enabled = False
                    Me.ControlBox = False
            End Select
            StatusLabel.Text = "Control Enabler Run"
        Catch ex As Exception
            Error_Handler(ex, "Control Enabler")
        End Try
    End Sub


    Private Function DosShellCommand(ByVal AppToRun As String) As String
        Dim s As String = ""
        Try
            Dim myProcess As Process = New Process

            myProcess.StartInfo.FileName = "cmd.exe"
            myProcess.StartInfo.UseShellExecute = False
            myProcess.StartInfo.CreateNoWindow = True
            myProcess.StartInfo.RedirectStandardInput = True
            myProcess.StartInfo.RedirectStandardOutput = True
            myProcess.StartInfo.RedirectStandardError = True
            myProcess.Start()
            Dim sIn As StreamWriter = myProcess.StandardInput
            sIn.AutoFlush = True

            Dim sOut As StreamReader = myProcess.StandardOutput
            Dim sErr As StreamReader = myProcess.StandardError
            sIn.Write(AppToRun & _
               System.Environment.NewLine)
            sIn.Write("exit" & System.Environment.NewLine)
            s = sOut.ReadToEnd()
            If Not myProcess.HasExited Then
                myProcess.Kill()
            End If

            'MessageBox.Show("The 'dir' command window was closed at: " & myProcess.ExitTime & "." & System.Environment.NewLine & "Exit Code: " & myProcess.ExitCode)

            sIn.Close()
            sOut.Close()
            sErr.Close()
            myProcess.Close()
            'MessageBox.Show(s)
        Catch ex As Exception
            Error_Handler(ex, "DOS Shell Command")
        End Try
        Return s
    End Function

    Public Function TextMail(ByVal strTo As String, ByVal strSubj As String, ByVal strBody As String, Optional ByRef strErrMsg As String = "") As Boolean
        Dim objMail As MailMessage
        Try
            Dim emailaddys As String()
            emailaddys = strTo.Split(";")
            Dim counter As Integer = 0
            For counter = 0 To emailaddys.Length - 1
                objMail = New MailMessage
                objMail.BodyFormat = MailFormat.Text
                objMail.From = "LiveCheckAlerter@uct.ac.za"
                objMail.To = emailaddys(counter).Trim
                objMail.Subject = strSubj
                objMail.Body = strBody

                SmtpMail.SmtpServer = "mail.uct.ac.za"
                SmtpMail.Send(objMail)
            Next
            TextMail = True
        Catch ex As Exception
            TextMail = False
            Error_Handler(ex, "Send Mail")
        End Try
    End Function

    Public Function TextMail(ByVal SmtpServer As String, ByVal strFrom As String, ByVal strTo As String, ByVal strSubj As String, ByVal strBody As String, Optional ByRef strErrMsg As String = "") As Boolean
        Dim objMail As MailMessage
        Try
            Dim emailaddys As String()
            emailaddys = strTo.Split(";")

            Dim counter As Integer = 0
            For counter = 0 To emailaddys.Length - 1


                objMail = New MailMessage
                objMail.BodyFormat = MailFormat.Text
                objMail.From = strFrom
                objMail.To = emailaddys(counter).Trim
                objMail.Subject = strSubj
                objMail.Body = strBody

                SmtpMail.SmtpServer = SmtpServer
                SmtpMail.Send(objMail)
            Next
            TextMail = True
        Catch ex As Exception
            TextMail = False
            Error_Handler(ex, "Send Mail")
        End Try
    End Function

    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            Dim targets As String()
            targets = LCA_Machines.Text.Split(";")

            Dim counter As Integer = 0
            For counter = 0 To targets.Length - 1
                StatusLabel.Text = "Checking " & targets(counter)
                Try

                    Dim error_encounter As Boolean = False
                    Dim error_message As String = ""
                    Try
                        Dim ProcID As Integer
                        Dim apppath As String = Application.StartupPath


                        If apppath.EndsWith("\") Then
                            apppath = apppath.Remove(apppath.Length - 1, 1)
                        End If

                        If System.IO.File.Exists(apppath & "\result.txt") = True Then
                            System.IO.File.Delete(apppath & "\result.txt")
                        End If
                        Dim runprog As String = """" & apppath & "\ping.exe"" """ & targets(counter).Trim & """ > """ & apppath & "\result.txt"""
                        DosShellCommand(runprog)

                        If System.IO.File.Exists(apppath & "\result.txt") = True Then
                            Dim reader As System.IO.StreamReader = New System.IO.StreamReader(apppath & "\result.txt", True)
                            Dim resultstring As String
                            resultstring = reader.ReadToEnd()
                            reader.Close()
                            If resultstring.LastIndexOf("could not find host") > 0 Then
                                error_encounter = True
                                error_message = resultstring
                            End If
                            If resultstring.LastIndexOf("Destination host unreachable.") > 0 Then
                                error_encounter = True
                                error_message = resultstring
                            End If

                            If resultstring.LastIndexOf("Request timed out.") > -1 Then
                                Dim temp As String = resultstring
                                temp = temp.Remove(0, temp.IndexOf("Request timed out.", 0) + 1)
                                If temp.IndexOf("Request timed out.") > -1 Then
                                    temp = temp.Remove(0, temp.IndexOf("Request timed out.", 0) + 1)
                                End If
                                If temp.IndexOf("Request timed out.") > -1 Then
                                    temp = temp.Remove(0, temp.IndexOf("Request timed out.", 0) + 1)
                                End If
                                If temp.IndexOf("Request timed out.") > -1 Then
                                    error_encounter = True
                                    error_message = resultstring
                                End If
                            End If

                        Else
                            error_encounter = True
                        End If

                    Catch ex As Exception
                        error_encounter = True
                    End Try
                    Dim sendoffmail As Boolean = True
                    Dim addtoofflist As Boolean = True
                    Dim sendonmail As Boolean = False
                    Dim removefromofflist As Boolean = False

                    If error_encounter = True Then

                        If offlist.Length > 0 Then
                            For Each var In offlist.Split(";")
                                If targets(counter).ToLower = var.ToLower Then
                                    sendoffmail = False
                                    addtoofflist = False
                                End If
                            Next
                        End If
                        If addtoofflist = True Then
                            offlist = offlist & targets(counter) & ";"
                            If offlist.EndsWith(";") Then
                                offlist.Remove(offlist.Length - 1, 1)
                            End If
                        End If
                        If sendoffmail = True Then
                            Try
                                StatusLabel.Text = "Sending Error Notification"
                                Activity_Handler(targets(counter) & " failed. Sending Error Notification")
                                Dim body As String
                                body = "An ICMP ping test has failed and yielded the following results below. This could imply that the machine has either seized operating, is down because of a power outage, or that network traffic is being seriously hampered. Please dispatch or inform the necessary maintenance staff."
                                body = body & vbCrLf & vbCrLf & "******************************" & vbCrLf & vbCrLf
                                error_message = error_message.Replace(Chr(13), " ")
                                body = body & error_message.Trim
                                body = body & vbCrLf & vbCrLf & "******************************" & vbCrLf & vbCrLf & "This is an auto-generated email submitted from " & My.Application.Info.ProductName & " at " & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & ", running on:"
                                body = body & vbCrLf & vbCrLf & "Machine Name: " + Environment.MachineName
                                body = body & vbCrLf & "OS Version: " & Environment.OSVersion.ToString()
                                body = body & vbCrLf & "User Name: " + Environment.UserName

                                TextMail("mail.uct.ac.za", "LiveCheckAlerter@uct.ac.za", LCA_Emails.Text, "LiveCheck Alerter: Machine Reported Offline", body)
                            Catch ex As Exception
                                Error_Handler(ex, "Send Error Mail")
                            End Try
                        End If
                        Panel2.Controls.Item(counter).Text = targets(counter)
                        Panel2.Controls.Item(counter).ForeColor = Color.Red
                    Else
                        If offlist.Length > 0 Then
                            For Each var In offlist.Split(";")
                                If targets(counter).ToLower = var.ToLower Then
                                    sendonmail = True
                                    removefromofflist = True
                                End If
                            Next
                        End If
                        If removefromofflist = True Then
                            offlist = offlist.Replace(targets(counter), "")
                            offlist = offlist.Replace(";;", ";")
                            If offlist = ";" Then
                                offlist = ""
                            End If
                        End If
                        If sendonmail = True Then
                            Try
                                StatusLabel.Text = "Sending Okay Notification"
                                Activity_Handler(targets(counter) & " passed. Sending Okay Notification")
                                Dim body As String
                                body = targets(counter) & " appears to be back online after earlier being reported offline by LiveCheck Alerter."
                                body = body & vbCrLf & vbCrLf & "******************************" & vbCrLf & vbCrLf & "This is an auto-generated email submitted from " & My.Application.Info.ProductName & " at " & Format(Now(), "dd/MM/yyyy hh:mm:ss tt") & ", running on:"
                                body = body & vbCrLf & vbCrLf & "Machine Name: " + Environment.MachineName
                                body = body & vbCrLf & "OS Version: " & Environment.OSVersion.ToString()
                                body = body & vbCrLf & "User Name: " + Environment.UserName

                                TextMail("mail.uct.ac.za", "LiveCheckAlerter@uct.ac.za", LCA_Emails.Text, "LiveCheck Alerter: Machine Back Online", body)
                            Catch ex As Exception
                                Error_Handler(ex, "Send Okay Mail")
                            End Try
                        End If
                        Panel2.Controls.Item(counter).Text = targets(counter)
                        Panel2.Controls.Item(counter).ForeColor = Color.Green

                    End If
                Catch ex As Exception
                    Error_Handler(ex, "LiveCheck Operation")
                End Try
            Next
        e.Result = "Success"
        Catch ex As Exception
            Error_Handler(ex, "LiveCheck Operation")
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Try
            Control_Enabler(True)
            If e.Cancelled = False And e.Error Is Nothing Then
                StatusLabel.Text = "LiveCheck Operation Complete"
            Else
                StatusLabel.Text = "LiveCheck Operation Failed"
            End If
            busyworking = False
            Timer1.Start()
        Catch ex As Exception
            Error_Handler(ex, "LiveCheck Operation Complete")
        End Try
    End Sub

    Private Sub ActivityLogLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ActivityLogLink.LinkClicked
        Try
            Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs")
            If dir.Exists = False Then
                dir.Create()
            End If
            dir = Nothing
            Process.Start((Application.StartupPath & "\").Replace("\\", "\") & "Activity Logs")
            StatusLabel.Text = "Showing Activity Logs"
        Catch ex As Exception
            Error_Handler(ex, "Activity Log Link")
        End Try
    End Sub

    Private Sub ErrorLogLink_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles ErrorLogLink.LinkClicked
        Try
            Dim dir As System.IO.DirectoryInfo = New System.IO.DirectoryInfo((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs")
            If dir.Exists = False Then
                dir.Create()
            End If
            dir = Nothing
            Process.Start((Application.StartupPath & "\").Replace("\\", "\") & "Error Logs")
            StatusLabel.Text = "Showing Error Logs"
        Catch ex As Exception
            Error_Handler(ex, "Error Log Link")
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Try
            TimerLabel.Text = Integer.Parse(TimerLabel.Text) - 1
            While TimerLabel.Text.Length < 4
                TimerLabel.Text = "0" & TimerLabel.Text
            End While

            If TimerLabel.Text = "0000" Then
                Timer1.Stop()
                runworker()
                TimerLabel.Text = "0300"
            End If
            If busyworking = False Then
                If StatusLabel.Text <> "Waiting Mode Activated" Then
                    StatusLabel.Text = "Waiting Mode Activated"
                End If
            End If
        Catch ex As Exception
            Error_Handler(ex, "Timer Tick")
        End Try
    End Sub

    Private Sub runworker()
        Try
            busyworking = True
            Control_Enabler(False)
            Timer1.Stop()
            StatusLabel.Text = "Initializing Monitor Operation"
            Dim targets As String() = LCA_Machines.Text.Split(";")
            Panel2.Controls.Clear()
            For counter As Integer = 0 To targets.Length - 1
                Dim lab As Label = New Windows.Forms.Label
                lab.Height = 13
                lab.Width = 131
                lab.Left = 3
                lab.Top = 7 + counter * lab.Height
                lab.AutoEllipsis = True
                lab.Visible = True
                lab.Enabled = True
                lab.Text = ""
                lab.ForeColor = Color.Green
                Panel2.Controls.Add(lab)
                lab = Nothing
            Next
            BackgroundWorker1.RunWorkerAsync()
        Catch ex As Exception
            Error_Handler(ex, "Run Worker")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Button1.Text = "Stop Timer" Then
                Timer1.Stop()
                TimerLabel.Text = "0300"
                Button1.Text = "Start Timer"
                StatusLabel.Text = "Monitoring is Disabled"
                StatusLabel.Text = "Timer Stopped"
            Else
                Timer1.Start()
                Button1.Text = "Stop Timer"
                StatusLabel.Text = "Waiting Mode Activated"
                StatusLabel.Text = "Timer Started"
            End If
        Catch ex As Exception
            Error_Handler(ex, "Stop Timer Click")
        End Try
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Try
            StatusLabel.Text = "LiveCheck Forced"
            Timer1.Stop()
            runworker()
            TimerLabel.Text = "0300"
        Catch ex As Exception
            Error_Handler(ex, "Force Monitor")
        End Try
    End Sub
End Class
