<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.OutputListBox = New System.Windows.Forms.ListBox()
        Me.BtnClearOutput = New System.Windows.Forms.Button()
        Me.BtnRemoveTag = New System.Windows.Forms.Button()
        Me.BtnAddTag = New System.Windows.Forms.Button()
        Me.TagListBox = New System.Windows.Forms.ListBox()
        Me.BtnRefreshTagList = New System.Windows.Forms.Button()
        Me.SeparatorsListbox = New System.Windows.Forms.ListBox()
        Me.BtnRefreshSeparators = New System.Windows.Forms.Button()
        Me.TBoxSelectedTag = New System.Windows.Forms.TextBox()
        Me.TboxSelectedFolder = New System.Windows.Forms.TextBox()
        Me.CHbox = New System.Windows.Forms.CheckBox()
        Me.BtnSelectFolder = New System.Windows.Forms.Button()
        Me.BtnShowAllDirectories = New System.Windows.Forms.Button()
        Me.BtnShowAllTaggedDirectories = New System.Windows.Forms.Button()
        Me.BtnRemoveAllDirectoryTags = New System.Windows.Forms.Button()
        Me.btnShowDirectoriesWithSpecificTag = New System.Windows.Forms.Button()
        Me.LblHeader = New System.Windows.Forms.Label()
        Me.BtnSelectFolder_2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OutputListBox
        '
        Me.OutputListBox.FormattingEnabled = True
        Me.OutputListBox.HorizontalScrollbar = True
        Me.OutputListBox.ItemHeight = 20
        Me.OutputListBox.Location = New System.Drawing.Point(1194, 157)
        Me.OutputListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OutputListBox.Name = "OutputListBox"
        Me.OutputListBox.ScrollAlwaysVisible = True
        Me.OutputListBox.Size = New System.Drawing.Size(354, 404)
        Me.OutputListBox.TabIndex = 9
        '
        'BtnClearOutput
        '
        Me.BtnClearOutput.AccessibleRole = System.Windows.Forms.AccessibleRole.Caret
        Me.BtnClearOutput.Location = New System.Drawing.Point(1194, 595)
        Me.BtnClearOutput.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnClearOutput.Name = "BtnClearOutput"
        Me.BtnClearOutput.Size = New System.Drawing.Size(356, 35)
        Me.BtnClearOutput.TabIndex = 0
        Me.BtnClearOutput.Text = "clear output"
        Me.BtnClearOutput.UseVisualStyleBackColor = True
        '
        'BtnRemoveTag
        '
        Me.BtnRemoveTag.Location = New System.Drawing.Point(634, 580)
        Me.BtnRemoveTag.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRemoveTag.Name = "BtnRemoveTag"
        Me.BtnRemoveTag.Size = New System.Drawing.Size(112, 35)
        Me.BtnRemoveTag.TabIndex = 1
        Me.BtnRemoveTag.Text = "remove tag"
        Me.BtnRemoveTag.UseVisualStyleBackColor = True
        '
        'BtnAddTag
        '
        Me.BtnAddTag.Location = New System.Drawing.Point(480, 578)
        Me.BtnAddTag.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnAddTag.Name = "BtnAddTag"
        Me.BtnAddTag.Size = New System.Drawing.Size(112, 35)
        Me.BtnAddTag.TabIndex = 2
        Me.BtnAddTag.Text = "add tag"
        Me.BtnAddTag.UseVisualStyleBackColor = True
        '
        'TagListBox
        '
        Me.TagListBox.FormattingEnabled = True
        Me.TagListBox.ItemHeight = 20
        Me.TagListBox.Location = New System.Drawing.Point(234, 157)
        Me.TagListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TagListBox.Name = "TagListBox"
        Me.TagListBox.Size = New System.Drawing.Size(178, 244)
        Me.TagListBox.TabIndex = 3
        '
        'BtnRefreshTagList
        '
        Me.BtnRefreshTagList.Location = New System.Drawing.Point(234, 469)
        Me.BtnRefreshTagList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRefreshTagList.Name = "BtnRefreshTagList"
        Me.BtnRefreshTagList.Size = New System.Drawing.Size(180, 35)
        Me.BtnRefreshTagList.TabIndex = 4
        Me.BtnRefreshTagList.TabStop = False
        Me.BtnRefreshTagList.Text = "RefreshTagList"
        Me.BtnRefreshTagList.UseVisualStyleBackColor = True
        '
        'SeparatorsListbox
        '
        Me.SeparatorsListbox.FormattingEnabled = True
        Me.SeparatorsListbox.HorizontalScrollbar = True
        Me.SeparatorsListbox.ItemHeight = 20
        Me.SeparatorsListbox.Location = New System.Drawing.Point(234, 726)
        Me.SeparatorsListbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SeparatorsListbox.Name = "SeparatorsListbox"
        Me.SeparatorsListbox.ScrollAlwaysVisible = True
        Me.SeparatorsListbox.Size = New System.Drawing.Size(109, 204)
        Me.SeparatorsListbox.TabIndex = 5
        '
        'BtnRefreshSeparators
        '
        Me.BtnRefreshSeparators.Location = New System.Drawing.Point(192, 962)
        Me.BtnRefreshSeparators.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRefreshSeparators.Name = "BtnRefreshSeparators"
        Me.BtnRefreshSeparators.Size = New System.Drawing.Size(150, 35)
        Me.BtnRefreshSeparators.TabIndex = 6
        Me.BtnRefreshSeparators.TabStop = False
        Me.BtnRefreshSeparators.Text = "refresh separators"
        Me.BtnRefreshSeparators.UseVisualStyleBackColor = True
        '
        'TBoxSelectedTag
        '
        Me.TBoxSelectedTag.Location = New System.Drawing.Point(478, 372)
        Me.TBoxSelectedTag.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TBoxSelectedTag.Name = "TBoxSelectedTag"
        Me.TBoxSelectedTag.Size = New System.Drawing.Size(178, 26)
        Me.TBoxSelectedTag.TabIndex = 7
        '
        'TboxSelectedFolder
        '
        Me.TboxSelectedFolder.Location = New System.Drawing.Point(668, 369)
        Me.TboxSelectedFolder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TboxSelectedFolder.Name = "TboxSelectedFolder"
        Me.TboxSelectedFolder.Size = New System.Drawing.Size(338, 26)
        Me.TboxSelectedFolder.TabIndex = 8
        '
        'CHbox
        '
        Me.CHbox.AutoSize = True
        Me.CHbox.Location = New System.Drawing.Point(555, 646)
        Me.CHbox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CHbox.Name = "CHbox"
        Me.CHbox.Size = New System.Drawing.Size(134, 24)
        Me.CHbox.TabIndex = 14
        Me.CHbox.Text = "subdirectories"
        Me.CHbox.UseVisualStyleBackColor = True
        '
        'BtnSelectFolder
        '
        Me.BtnSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelectFolder.Location = New System.Drawing.Point(714, 157)
        Me.BtnSelectFolder.Name = "BtnSelectFolder"
        Me.BtnSelectFolder.Size = New System.Drawing.Size(340, 158)
        Me.BtnSelectFolder.TabIndex = 15
        Me.BtnSelectFolder.Text = "select the folder to operate on" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnSelectFolder.UseVisualStyleBackColor = True
        Me.BtnSelectFolder.Visible = False
        '
        'BtnShowAllDirectories
        '
        Me.BtnShowAllDirectories.Location = New System.Drawing.Point(846, 574)
        Me.BtnShowAllDirectories.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnShowAllDirectories.Name = "BtnShowAllDirectories"
        Me.BtnShowAllDirectories.Size = New System.Drawing.Size(270, 40)
        Me.BtnShowAllDirectories.TabIndex = 10
        Me.BtnShowAllDirectories.Text = "show all directories"
        Me.BtnShowAllDirectories.UseVisualStyleBackColor = True
        '
        'BtnShowAllTaggedDirectories
        '
        Me.BtnShowAllTaggedDirectories.Location = New System.Drawing.Point(846, 623)
        Me.BtnShowAllTaggedDirectories.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnShowAllTaggedDirectories.Name = "BtnShowAllTaggedDirectories"
        Me.BtnShowAllTaggedDirectories.Size = New System.Drawing.Size(270, 35)
        Me.BtnShowAllTaggedDirectories.TabIndex = 11
        Me.BtnShowAllTaggedDirectories.Text = "show all tagged directories"
        Me.BtnShowAllTaggedDirectories.UseVisualStyleBackColor = True
        '
        'BtnRemoveAllDirectoryTags
        '
        Me.BtnRemoveAllDirectoryTags.Location = New System.Drawing.Point(846, 714)
        Me.BtnRemoveAllDirectoryTags.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnRemoveAllDirectoryTags.Name = "BtnRemoveAllDirectoryTags"
        Me.BtnRemoveAllDirectoryTags.Size = New System.Drawing.Size(270, 35)
        Me.BtnRemoveAllDirectoryTags.TabIndex = 12
        Me.BtnRemoveAllDirectoryTags.Text = "remove all directory tags"
        Me.BtnRemoveAllDirectoryTags.UseVisualStyleBackColor = True
        '
        'btnShowDirectoriesWithSpecificTag
        '
        Me.btnShowDirectoriesWithSpecificTag.Location = New System.Drawing.Point(846, 669)
        Me.btnShowDirectoriesWithSpecificTag.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShowDirectoriesWithSpecificTag.Name = "btnShowDirectoriesWithSpecificTag"
        Me.btnShowDirectoriesWithSpecificTag.Size = New System.Drawing.Size(270, 35)
        Me.btnShowDirectoriesWithSpecificTag.TabIndex = 13
        Me.btnShowDirectoriesWithSpecificTag.Text = "show directories with a specific tag"
        Me.btnShowDirectoriesWithSpecificTag.UseVisualStyleBackColor = True
        '
        'LblHeader
        '
        Me.LblHeader.AutoSize = True
        Me.LblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.Location = New System.Drawing.Point(754, 14)
        Me.LblHeader.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.Size = New System.Drawing.Size(286, 104)
        Me.LblHeader.TabIndex = 16
        Me.LblHeader.Text = "      Directories" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tag - Untag - Display"
        Me.LblHeader.UseCompatibleTextRendering = True
        '
        'BtnSelectFolder_2
        '
        Me.BtnSelectFolder_2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSelectFolder_2.Location = New System.Drawing.Point(1194, 726)
        Me.BtnSelectFolder_2.Name = "BtnSelectFolder_2"
        Me.BtnSelectFolder_2.Size = New System.Drawing.Size(356, 158)
        Me.BtnSelectFolder_2.TabIndex = 17
        Me.BtnSelectFolder_2.Text = "select the folder to operate on" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BtnSelectFolder_2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1641, 1029)
        Me.Controls.Add(Me.BtnSelectFolder_2)
        Me.Controls.Add(Me.LblHeader)
        Me.Controls.Add(Me.BtnRemoveAllDirectoryTags)
        Me.Controls.Add(Me.btnShowDirectoriesWithSpecificTag)
        Me.Controls.Add(Me.BtnRefreshSeparators)
        Me.Controls.Add(Me.BtnShowAllTaggedDirectories)
        Me.Controls.Add(Me.BtnSelectFolder)
        Me.Controls.Add(Me.BtnShowAllDirectories)
        Me.Controls.Add(Me.BtnClearOutput)
        Me.Controls.Add(Me.OutputListBox)
        Me.Controls.Add(Me.CHbox)
        Me.Controls.Add(Me.BtnRemoveTag)
        Me.Controls.Add(Me.BtnAddTag)
        Me.Controls.Add(Me.TagListBox)
        Me.Controls.Add(Me.BtnRefreshTagList)
        Me.Controls.Add(Me.SeparatorsListbox)
        Me.Controls.Add(Me.TboxSelectedFolder)
        Me.Controls.Add(Me.TBoxSelectedTag)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "tagging"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FolderBrowserDialog As FolderBrowserDialog
    Friend WithEvents OutputListBox As ListBox
    Friend WithEvents BtnClearOutput As Button
    Friend WithEvents BtnRemoveTag As Button
    Friend WithEvents BtnAddTag As Button
    Friend WithEvents TagListBox As ListBox
    Friend WithEvents BtnRefreshTagList As Button
    Friend WithEvents SeparatorsListbox As ListBox
    Friend WithEvents BtnRefreshSeparators As Button
    Friend WithEvents TBoxSelectedTag As TextBox
    Friend WithEvents TboxSelectedFolder As TextBox
    Friend WithEvents CHbox As CheckBox
    Friend WithEvents BtnSelectFolder As Button
    Friend WithEvents BtnShowAllDirectories As Button
    Friend WithEvents BtnShowAllTaggedDirectories As Button
    Friend WithEvents BtnRemoveAllDirectoryTags As Button
    Friend WithEvents btnShowDirectoriesWithSpecificTag As Button
    Friend WithEvents LblHeader As Label
    Friend WithEvents BtnSelectFolder_2 As Button
End Class
