Public Class Form1
    Dim allFiles As New ArrayList
    Dim weight As Integer
    Dim inprogress As Boolean = False
    'Dim totality As Integer = 0

    Dim sep As String = "--------------------"
    Dim report As String = "DeMacify " + Application.ProductVersion + " report" + vbCrLf + sep + vbCrLf

    Sub putReport(ByVal str As String)
        report += str + vbCrLf

    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size


    End Sub

    Private Sub dir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dir.Click
        If inprogress Then Return
        folder.ShowNewFolderButton = False
        If folder.ShowDialog <> Windows.Forms.DialogResult.OK Or Not My.Computer.FileSystem.DirectoryExists(folder.SelectedPath) Then perform.Enabled = False : perform.Text = "<select a folder first>" : perform.ForeColor = Color.DarkRed : Return
        perform.Enabled = True
        Label1.Text = folder.SelectedPath
        perform.Text = "DeMacify!"
        perform.ForeColor = Color.Black
    End Sub
    Sub recurseWeightOfDir(ByVal dir As System.IO.DirectoryInfo)
        For Each f As IO.FileInfo In dir.GetFiles
            weight += f.Length
        Next
        For Each d As IO.DirectoryInfo In dir.GetDirectories
            recurseWeightOfDir(d)
        Next
    End Sub
    Sub processFolder(ByVal dir As String)
        Dim p As New ArrayList
        Try
            Dim files As System.IO.FileInfo() = FileIO.FileSystem.GetDirectoryInfo(dir).GetFiles
            Dim dirs As System.IO.DirectoryInfo() = FileIO.FileSystem.GetDirectoryInfo(dir).GetDirectories

            Application.DoEvents()
            If dir = folder.SelectedPath Then process.Maximum = UBound(files) + UBound(dirs) + 2
            If dir = folder.SelectedPath Then process.Value = 0

            For Each file As System.IO.FileInfo In files
                If dir = folder.SelectedPath Then
                    Try
                        process.Value += 1
                    Catch ex As Exception

                    End Try
                End If
                '  totality += 1
                If (unDSS.Checked = True And file.Name = ".DS_Store") Then allFiles.Add("File: " + file.FullName) : weight += file.Length

                If (unUnder.Checked And file.Name.StartsWith("._")) Then allFiles.Add("File: " + file.FullName) : weight += file.Length

            Next

           Application.DoEvents()
 
            For Each d As System.IO.DirectoryInfo In dirs
                

                If (unFsevents.Checked And (d.Name = ".fseventsd" Or d.Name = ".Spotlight-V100" Or d.Name = ".TemporaryItems")) Or (unTrash.Checked And d.Name = ".Trashes") Then
                    allFiles.Add("Dir: " + d.FullName)
                    recurseWeightOfDir(d)
                Else
                    If dir = folder.SelectedPath Then
                        Try
                            process.Value += 1
                        Catch ex As Exception

                        End Try
                    End If

                    processFolder(d.FullName)
                End If

            Next

        Catch ex As Exception
            putReport("Error while scanning: " + ex.Message)
        End Try
       

    End Sub
    Sub deleteEmAll()
        putReport("Deleting " + allFiles.Count.ToString + " files...")

        For i As Integer = 0 To allFiles.Count - 1

            report += allFiles.Item(i) + " : "
            process.Value = (i / allFiles.Count) * 100
            Try

                If allFiles.Item(i).ToString.StartsWith("File: ") Then
                    My.Computer.FileSystem.DeleteFile(allFiles.Item(i).ToString.Substring(5))
                    putReport("Removed")
                ElseIf allFiles.Item(i).ToString.StartsWith("Dir: ") Then
                    My.Computer.FileSystem.DeleteDirectory(allFiles.Item(i).ToString.Substring(4), FileIO.DeleteDirectoryOption.DeleteAllContents)
                    putReport("Removed")
                Else
                    putReport("Wat.")
                End If

            Catch ex As Exception
                putReport("FAIL")
                putReport(sep)
                putReport(ex.Message)
                putReport(sep)
            End Try
            Application.DoEvents()
        Next
    End Sub

    Private Sub perform_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles perform.Click
        If inprogress Then Return
        inprogress = True
        weight = 0
        GroupBox1.Enabled = False
        process.MarqueeAnimationSpeed = 100
        putReport("Started scan of " + folder.SelectedPath + " at " + Now.ToString)

        perform.ForeColor = Color.Green
        perform.Text = "Enumerating..."
        processFolder(folder.SelectedPath)
        perform.Text = "Found " + allFiles.Count.ToString + " files of " + CStr(Math.Round(weight / 1024)) + "K"
        putReport("Found  " + allFiles.Count.ToString + " files.")

        process.Value = 0
        process.Maximum = 100
        process.Minimum = 0

        If allFiles.Count = 0 Then
            MsgBox("This folder has not been touched by a Mac yet!", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Nothing found")
            inprogress = False
            GroupBox1.Enabled = True
            Return
        End If
        deleteEmAll()

        inprogress = False
        putReport(sep)
        putReport("Total freed: approx. " + CStr(Math.Round(weight / 1024)) + "K")

        putReport("Total files/folders deleted: " + allFiles.Count.ToString)
        putReport(sep)
        putReport("-=[ DeMacify by vladkorotnev a.k.a. AkasakaRyuunosuke, 2013 ]=-")
        perform.Text = "DeMacified with success"
        If MsgBox("Completed. Freed about " + CStr(Math.Round(weight / 1024)) + "K. Show report?", MsgBoxStyle.YesNo + MsgBoxStyle.Information, "Done") = MsgBoxResult.Yes Then
            '--- Begin madskillz of being too lazy to draw it in VS10
            Dim repf As New Form
            Dim tf As New TextBox
            tf.Parent = repf
            tf.Dock = DockStyle.Fill
            tf.Multiline = True
            tf.ScrollBars = ScrollBars.Vertical
            tf.ReadOnly = True
            tf.BackColor = Color.White
            tf.Text = report
            repf.Text = "Report"
            repf.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
            repf.Show()

        End If
        report = ""
        allFiles.Clear()
        GroupBox1.Enabled = True
    End Sub

   

    Private Sub Label2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.DoubleClick
        Label2.Text = Label2.Text.Replace("vladkorotnev", "Akasaka Ryuunosuke")
    End Sub
End Class
