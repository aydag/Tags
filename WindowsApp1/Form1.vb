Imports System.IO
Imports System
Imports System.Reflection
Imports System.Text
Public Class Form1
    Dim myremovefunction As Boolean = False
    Dim i As Integer = 0
    Dim Theseparator As String = ""
    Dim removeAllDirectoryTags As Boolean = False
    Dim recurseCounter As Integer = 0
    Dim thesender As Button
    Dim SW As New StreamWriter("c:\users\victor sperber\desktop\dblog.txt")

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Getseparators()
        i = SeparatorsListbox.Items.IndexOf(".")
        SeparatorsListbox.SelectedIndex = i
        Theseparator = SeparatorsListbox.SelectedItem
        GetTags()
        '   SelectFolder()
        For Each cControl In Me.Controls
            cControl.visible = False
        Next
        Dim alpha = 128 : Dim red = 255 : Dim green = 255 : Dim blue = 255
        Me.BtnSelectFolder.BackColor = Color.FromArgb(alpha, red, green, blue)
        Me.BtnSelectFolder.Visible = True
    End Sub

    ' select the base folder for operations

    Private Sub SelectFolder()
        Dim methodName = MethodBase.GetCurrentMethod
        Debug.WriteLine(methodName)
        With FolderBrowserDialog
            Dim fbd = New FolderBrowserDialog
            fbd.Description = "select the folder to operate on"
            If .ShowDialog = DialogResult.OK Then
                validatePath(.SelectedPath)
                TboxSelectedFolder.Text = .SelectedPath
            Else
                Exit Sub
            End If
        End With
        If SeparatorsListbox.Items.Count = 0 Then
            Getseparators()
        End If
        If TagListBox.Items.Count = 0 Then
            GetTags()
        End If
        Me.BtnSelectFolder.Visible = False
    End Sub

    ' calls SelectFolder and displays all the hidden controls

    Private Sub BtnSelectFolder_Click(sender As Object, e As EventArgs) Handles BtnSelectFolder.Click, BtnSelectFolder_2.Click
        Dim methodName = MethodBase.GetCurrentMethod
        Debug.WriteLine(methodName)
        SelectFolder()
        For Each cControl In Me.Controls
            cControl.enabled = True
            cControl.visible = True
        Next
        BtnSelectFolder.Visible = False
    End Sub

    ' provides event handles for button controls

    Private Sub Buttons_Click(sender As Object, e As EventArgs) Handles BtnRefreshTagList.Click, BtnAddTag.Click, BtnRemoveTag.Click,
            BtnClearOutput.Click, BtnRefreshSeparators.Click, BtnRemoveAllDirectoryTags.Click, BtnShowAllTaggedDirectories.Click, btnShowDirectoriesWithSpecificTag.Click, BtnShowAllDirectories.Click
        Dim methodName = MethodBase.GetCurrentMethod
        Debug.WriteLine(methodName)
        Buttonsprocessor(DirectCast(sender, Button))
        Debug.Flush()
        SW.Flush()
    End Sub

    ' processes all the buttons

    Sub Buttonsprocessor(ByVal mySender As Button)
        Dim methodName = MethodBase.GetCurrentMethod
        Debug.WriteLine(methodName)

        Select Case mySender.Name
            Case "BtnAddTag", "BtnRemoveTag", "BtnRemoveAllDirectoryTags", "BtnClearOutput", "BtnShowAllDirectories", "BtnShowAllTaggedDirectories", "btnShowDirectoriesWithSpecificTag"
                Debug.WriteLine(mySender.Name + " button pressed")
                ShowDirectories(mySender)
                If Not mySender Is BtnClearOutput Then
                End If
            Case "BtnRefreshTagList", "BtnRefreshSeparators"
                Debug.WriteLine(mySender.Name + " button pressed")
                refreshThem(mySender)
            Case Else
                Debug.WriteLine("don't understand:")
        End Select
    End Sub
    ' Shows All, AllTagged, All with specic tag

    Sub ShowDirectories(ByVal mysendername As Button)

        Dim methodName = MethodBase.GetCurrentMethod
        Debug.WriteLine(methodName)
        With FolderBrowserDialog
            If TboxSelectedFolder.Text = "" Then
                '   MsgBox("select the folder to operate on")
                Dim fbd = New FolderBrowserDialog
                fbd.Description = "Select the folder to operate on"
                fbd.ShowDialog()
                If .ShowDialog = DialogResult.OK Then
                    TboxSelectedFolder.Text = .SelectedPath
                    Exit Sub
                End If
            End If
            If TagListBox.SelectedItems.Count = 0 Then MsgBox("No tag selected") : Exit Sub

            OutputListBox.Items.Clear()
            ' if it's clear output then no more needs to be done
            If mysendername Is BtnClearOutput Then Exit Sub

            ' finally call printdirtree passing the name of the specific button to be processed
            recurseCounter = 0
            thesender = DirectCast(mysendername, Button)
            Printdirtree(TboxSelectedFolder.Text, (0))
            Debug.WriteLine(vbCrLf & "returned from printDirTree")
            For Each cControl In Me.Controls
                cControl.enabled = False
            Next
            OutputListBox.Enabled = True
            Me.BtnSelectFolder_2.Enabled = True
        End With
    End Sub

    ' recursive function processes subfolders thanks to Balena

    Sub Printdirtree(ByVal dir As String, Optional ByVal level As Integer = 0)
        '  Dim methodName = MethodBase.GetCurrentMethod
        recurseCounter += 1
        Debug.WriteLine(recurseCounter & "  " & level)
        '   Debug.WriteLine(recurseCounter)
        If recurseCounter > 50 Then
            MsgBox("it appears that your are stuck in a loop!") : Exit Sub
        End If
        If thesender Is BtnAddTag Or thesender Is BtnRemoveTag Then
            TboxSelectedFolder.Text = RenameIt(dir)
        Else
            TboxSelectedFolder.Text = dir
        End If
        i = TboxSelectedFolder.Text.LastIndexOf("\")
        Dim builder As New StringBuilder
        builder.Append("."c)
        builder.Append(level * 2)
        builder.Append(TboxSelectedFolder.Text.Substring(i))
        Dim s As String = builder.ToString
        SW.WriteLine(s)
        OutputListBox.Items.Add((New String("."c, level * 2) & TboxSelectedFolder.Text.Substring(i)))
        ' do not recurse if subdirectories checkbox is not checked
        If CHbox.Checked = False And Not thesender Is BtnShowAllDirectories Then Exit Sub
        dir = TboxSelectedFolder.Text
        Try
            For Each subdir As String In Directory.GetDirectories(dir)
                Debug.WriteLine(subdir)
                Printdirtree(subdir, level + 1)
            Next
        Catch ex As System.IO.PathTooLongException
            MsgBox("Two " & ex.Source)
        Catch ex As System.IO.DirectoryNotFoundException
            MsgBox("Three  " & ex.StackTrace)
        Catch ex As System.IO.IOException
            MsgBox("Four   " & ex.Message & ex.StackTrace)
        Catch ex As System.SystemException
            MsgBox("Five " & ex.Message)

        Finally
            '  Debug.WriteLine(recurseCounter)
            Debug.Flush()
        End Try
    End Sub

    ' folder rename by adding or removing tags

    Function RenameIt(ByVal foldername As String)
        Dim methodName = MethodBase.GetCurrentMethod
        Debug.WriteLine(methodName)
        Dim testfile As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(foldername)
        Dim filename As String = testfile.Name
        Dim folderpath = testfile.DirectoryName
        Dim newfilename As String = ""

        If thesender Is BtnAddTag Then
            ' add
            newfilename = filename + TBoxSelectedTag.Text
        Else
            ' remove
            If thesender Is BtnRemoveTag Then
                newfilename = filename.Replace(TBoxSelectedTag.Text, "")
            End If
        End If
        If thesender Is BtnRemoveAllDirectoryTags Then
            ' remove ALL tags
            Dim i As Integer = filename.IndexOf(Theseparator)
            If i >= 0 Then
                newfilename = filename.Substring(0, i)
            Else
                newfilename = filename
                MsgBox("no tag to remove")
                '   If newfilename = filename Then
            End If
        End If
        ' End If
        '  End If
        If Not newfilename = filename Then
            Debug.WriteLine("foldername = " & foldername & " -  old filename = " & filename & " -  newfilename = " & newfilename)
            Try
                My.Computer.FileSystem.RenameDirectory(foldername, newfilename)
            Catch ex As System.IO.FileNotFoundException
                MsgBox(ex.ToString, ex.StackTrace, ex.TargetSite)
            Catch ex As System.IO.PathTooLongException
                MsgBox(ex.TargetSite)
            Catch ex As System.IO.DirectoryNotFoundException
                MsgBox(ex.StackTrace)
            Catch ex As System.IO.IOException
                MsgBox(ex.Message)
            Catch ex As System.SystemException
                MsgBox(ex.Message)
            Finally
                Debug.WriteLine(recurseCounter)
                Debug.Flush()
            End Try
        End If
        Debug.WriteLine("FUNCTION RETURNS " + folderpath + "\" + newfilename)
        Return folderpath + "\" + newfilename
    End Function

    Private Sub Getseparators()
        Dim methodName = MethodBase.GetCurrentMethod
        Debug.WriteLine(methodName)

        If Not File.Exists(separatorsfile) Then
            MsgBox("you need to have the separators file (separators.txt) on your desktop")
        Else
            Dim lines() As String = IO.File.ReadAllLines(separatorsfile)
            SeparatorsListbox.Items.AddRange(lines)
        End If
    End Sub

    Private Sub GetTags()
        Dim methodName = MethodBase.GetCurrentMethod
        Debug.WriteLine(methodName)

        If Not File.Exists(tagfile) Then
            MsgBox("you need to have the tag file (tags.txt) on your desktop")
        Else
            Dim lines() As String = IO.File.ReadAllLines(tagfile)
            TagListBox.Items.AddRange(lines) 'Add your string of lines to your list box.
        End If
    End Sub
    Private Sub Taglistbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TagListBox.SelectedIndexChanged
        Dim methodName = MethodBase.GetCurrentMethod
        Debug.WriteLine(methodName)
        TBoxSelectedTag.Text = SeparatorsListbox.SelectedItem + TagListBox.SelectedItem
    End Sub

    Private Sub refreshThem(ByVal mySender As Button)
        Dim methodName = MethodBase.GetCurrentMethod
        Debug.WriteLine(methodName)

        If mySender Is BtnRefreshTagList Then
            TagListBox.Items.Clear()
            GetTags()
            TBoxSelectedTag.Text = ""
        Else
            SeparatorsListbox.Items.Clear()
            Getseparators()
        End If
    End Sub

    Private Sub validatePath(path1 As String)
        Dim methodName = MethodBase.GetCurrentMethod
        Debug.WriteLine(methodName)
        Try
            If Not Directory.Exists(path1) Then
                MsgBox("directory " & path1 & " does not exist")
                debug.writeline("directory " & path1 & " does not exist")
            End If
        Catch ex As UnauthorizedAccessException
            MsgBox("unauthorised access to path. Close File explorer and File history and try again")
        End Try
    End Sub

    Private Sub BtnSelectFolder_2_Click(sender As Object, e As EventArgs) Handles BtnSelectFolder_2.Click
        Dim methodName = MethodBase.GetCurrentMethod
        Debug.WriteLine(methodName)
    End Sub

    Private Sub Form1_closing(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Closing
        Dim methodName = MethodBase.GetCurrentMethod
        Debug.WriteLine(methodName)
        Debug.Flush()
        Tr1.Close()
        tr1.Dispose()
        Application.Exit()
    End Sub

End Class
