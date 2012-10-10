Public Class Form1
    Dim directory As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Browse.Click
        Dim OpenFile As New OpenFileDialog()
        OpenFile.Title = "Open File"
        OpenFile.Filter = "Executable (*.exe)|*.exe"
        OpenFile.FileName = ""
        OpenFile.FilterIndex = 0
        OpenFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer)
        OpenFile.CheckFileExists = True
        OpenFile.CheckPathExists = True
        If OpenFile.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
            txt_Directory.Text = (OpenFile.FileName.Replace(OpenFile.SafeFileName, ""))
            directory = txt_Directory.Text
        End If
    End Sub

    Private Sub btn_Launch_Click(sender As Object, e As EventArgs) Handles btn_Launch.Click
        directory = txt_Directory.Text
        If My.Computer.FileSystem.DirectoryExists(directory) Then
            If My.Computer.FileSystem.FileExists(directory + "\LaunchPad.exe") Then
                Shell(directory + "\LaunchPad.exe")
                Threading.Thread.Sleep(5000)
                If My.Computer.FileSystem.FileExists(directory + "\GraphicsData\materials_3.xml") Then
                    Dim reader As New System.IO.StreamReader(directory + "\GraphicsData\materials_3.xml")
                    Dim sLine As String = ""
                    Dim lines As New ArrayList()
                    Do
                        sLine = reader.ReadLine()
                        If Not sLine Is Nothing Then
                            lines.Add(sLine)
                        End If
                    Loop Until sLine Is Nothing
                    reader.Close()
                    Dim writer As New System.IO.StreamWriter(directory + "\GraphicsData\materials_3.xml")
                    Dim out As String = ""
                    For Each line As String In lines
                        If line.Contains("<Object Class=""IntParameter""    Name=""FogEnable"" Variable=""FogEnable"" Default=""1"" />") Then
                            line = line.Replace("Default=""1""", "Default=""0""")
                        ElseIf line.Contains("<Object Class=""IntParameter""    Name=""FogShadows"" Variable=""FogShadowsEnable"" Default=""1"" />") Then
                            line = line.Replace("Default=""1""", "Default=""0""")
                        End If
                        out += line + vbNewLine
                    Next
                    writer.Write(out)
                    writer.Close()
                    Close()
                Else
                    MsgBox("ERROR! materials_3.xml not found! Check game directory.", MsgBoxStyle.Critical, "ERROR!")
                End If
            Else
                MsgBox("ERROR! LaunchPad.exe not found! Check game directory.", MsgBoxStyle.Critical, "ERROR!")
            End If
        Else
            MsgBox("ERROR! Game directory not found! Please check set game directory.", MsgBoxStyle.Critical, "ERROR!")
        End If
    End Sub


    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        directory = txt_Directory.Text
        My.Settings.Directory = directory
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Directory.Text = My.Settings.Directory
    End Sub
End Class
