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
        Me.components = New System.ComponentModel.Container()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.ComboLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DisplayComboBox = New System.Windows.Forms.ComboBox()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.CategoryButton = New System.Windows.Forms.RadioButton()
        Me.AisleButton = New System.Windows.Forms.RadioButton()
        Me.DisplayGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.DisplayGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'DisplayListBox
        '
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 25
        Me.DisplayListBox.Location = New System.Drawing.Point(676, 169)
        Me.DisplayListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(648, 679)
        Me.DisplayListBox.TabIndex = 1
        Me.DisplayListBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.DisplayListBox, "Items are displayed here")
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1372, 40)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(72, 36)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(220, 44)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(85, 36)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(214, 44)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SearchButton
        '
        Me.SearchButton.Location = New System.Drawing.Point(1152, 96)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(176, 44)
        Me.SearchButton.TabIndex = 1
        Me.SearchButton.Text = "Search"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'ComboLabel
        '
        Me.ComboLabel.AutoSize = True
        Me.ComboLabel.Location = New System.Drawing.Point(52, 169)
        Me.ComboLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ComboLabel.Name = "ComboLabel"
        Me.ComboLabel.Size = New System.Drawing.Size(99, 25)
        Me.ComboLabel.TabIndex = 5
        Me.ComboLabel.Text = "Category"
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
        'DisplayComboBox
        '
        Me.DisplayComboBox.FormattingEnabled = True
        Me.DisplayComboBox.Location = New System.Drawing.Point(180, 169)
        Me.DisplayComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DisplayComboBox.Name = "DisplayComboBox"
        Me.DisplayComboBox.Size = New System.Drawing.Size(458, 33)
        Me.DisplayComboBox.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.DisplayComboBox, "Drop down for selected sorting method")
        '
        'SearchBox
        '
        Me.SearchBox.Location = New System.Drawing.Point(185, 103)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(934, 31)
        Me.SearchBox.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.SearchBox, "Search for item here or type zzz to end program")
        '
        'CategoryButton
        '
        Me.CategoryButton.AutoSize = True
        Me.CategoryButton.Location = New System.Drawing.Point(9, 33)
        Me.CategoryButton.Margin = New System.Windows.Forms.Padding(6)
        Me.CategoryButton.Name = "CategoryButton"
        Me.CategoryButton.Size = New System.Drawing.Size(130, 29)
        Me.CategoryButton.TabIndex = 10
        Me.CategoryButton.Text = "Category"
        Me.CategoryButton.UseVisualStyleBackColor = True
        '
        'AisleButton
        '
        Me.AisleButton.AutoSize = True
        Me.AisleButton.Location = New System.Drawing.Point(9, 85)
        Me.AisleButton.Margin = New System.Windows.Forms.Padding(6)
        Me.AisleButton.Name = "AisleButton"
        Me.AisleButton.Size = New System.Drawing.Size(90, 29)
        Me.AisleButton.TabIndex = 11
        Me.AisleButton.Text = "Aisle"
        Me.AisleButton.UseVisualStyleBackColor = True
        '
        'DisplayGroupBox
        '
        Me.DisplayGroupBox.Controls.Add(Me.AisleButton)
        Me.DisplayGroupBox.Controls.Add(Me.CategoryButton)
        Me.DisplayGroupBox.Location = New System.Drawing.Point(12, 280)
        Me.DisplayGroupBox.Name = "DisplayGroupBox"
        Me.DisplayGroupBox.Size = New System.Drawing.Size(139, 125)
        Me.DisplayGroupBox.TabIndex = 12
        Me.DisplayGroupBox.TabStop = False
        Me.ToolTip1.SetToolTip(Me.DisplayGroupBox, "Select to sort by Category or Aisle")
        '
        'DisplayLabel
        '
        Me.DisplayLabel.Location = New System.Drawing.Point(180, 230)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(458, 585)
        Me.DisplayLabel.TabIndex = 13
        '
        'StansGroceryForm
        '
        Me.AcceptButton = Me.SearchButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1372, 892)
        Me.Controls.Add(Me.DisplayLabel)
        Me.Controls.Add(Me.DisplayGroupBox)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.DisplayComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboLabel)
        Me.Controls.Add(Me.SearchButton)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "StansGroceryForm"
        Me.Text = "Stans Grocery"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.DisplayGroupBox.ResumeLayout(False)
        Me.DisplayGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchButton As Button
    Friend WithEvents ComboLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DisplayComboBox As ComboBox
    Friend WithEvents SearchBox As TextBox
    Friend WithEvents CategoryButton As RadioButton
    Friend WithEvents AisleButton As RadioButton
    Friend WithEvents DisplayGroupBox As GroupBox
    Friend WithEvents DisplayLabel As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
End Class
