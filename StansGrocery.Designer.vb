<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StansGroceryForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Display = New System.Windows.Forms.ComboBox()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.CategoryButton = New System.Windows.Forms.RadioButton()
        Me.AisleButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 25
        Me.DisplayListBox.Location = New System.Drawing.Point(676, 169)
        Me.DisplayListBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(648, 679)
        Me.DisplayListBox.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(6, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1372, 40)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(72, 36)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem, Me.SelectFormToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(85, 36)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(275, 44)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SelectFormToolStripMenuItem
        '
        Me.SelectFormToolStripMenuItem.Name = "SelectFormToolStripMenuItem"
        Me.SelectFormToolStripMenuItem.Size = New System.Drawing.Size(275, 44)
        Me.SelectFormToolStripMenuItem.Text = "Select Form"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(1152, 96)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(176, 44)
        Me.SearchButton.TabIndex = 3
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 169)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Category"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 96)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Look up Item"
        '
        'Display
        '
        Me.Display.FormattingEnabled = True
        Me.Display.Location = New System.Drawing.Point(180, 169)
        Me.Display.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(458, 33)
        Me.Display.TabIndex = 8
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(180, 96)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(934, 31)
        Me.SearchBox.TabIndex = 9
        '
        'CategoryButton
        '
        Me.CategoryButton.AutoSize = True
        Me.CategoryButton.Location = New System.Drawing.Point(15, 67)
        Me.CategoryButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.CategoryButton.Name = "CategoryButton"
        Me.CategoryButton.Size = New System.Drawing.Size(130, 29)
        Me.CategoryButton.TabIndex = 10
        Me.CategoryButton.TabStop = True
        Me.CategoryButton.Text = "Category"
        Me.CategoryButton.UseVisualStyleBackColor = True
        '
        'AisleButton
        '
        Me.AisleButton.AutoSize = True
        Me.AisleButton.Location = New System.Drawing.Point(15, 130)
        Me.AisleButton.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.AisleButton.Name = "AisleButton"
        Me.AisleButton.Size = New System.Drawing.Size(90, 29)
        Me.AisleButton.TabIndex = 11
        Me.AisleButton.TabStop = True
        Me.AisleButton.Text = "Aisle"
        Me.AisleButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AisleButton)
        Me.GroupBox2.Controls.Add(Me.CategoryButton)
        Me.GroupBox2.Location = New System.Drawing.Point(0, 263)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(173, 187)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(180, 263)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(458, 585)
        Me.DisplayLabel.TabIndex = 13
        '
        'StansGroceryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1372, 892)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "StansGroceryForm"
        Me.Text = "Stans Grocery"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Display As ComboBox
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents CategoryButton As RadioButton
    Friend WithEvents AisleButton As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DisplayLabel As Label
End Class
