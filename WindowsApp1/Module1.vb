Imports System.IO
Imports System.Environment

Module mainModule
    Public tr1 As New TextWriterTraceListener(System.IO.File.CreateText("c:\users\victor sperber\desktop\TraceOutput.txt"))
    Public tagfile As String
    Public separatorsfile As String
    Sub main()
        tagfile = Environment.GetFolderPath(SpecialFolder.Desktop) + "\tags.txt"
        If Not File.Exists(tagfile) Then
            MsgBox("you need to have the tag file (tags.txt) on your desktop")
            Exit Sub
        End If
        separatorsfile = Environment.GetFolderPath(SpecialFolder.Desktop) + "\separators.txt"
        If Not File.Exists(separatorsfile) Then
            MsgBox("you need to have the separators file (separators.txt) on your desktop")
            Exit Sub
        End If
        Debug.Listeners.Add(tr1)
        Debug.WriteLine(vbCrLf & "=============================================== " & TimeOfDay.ToLongTimeString)
        System.Windows.Forms.Application.Run(Form1)
    End Sub
End Module
