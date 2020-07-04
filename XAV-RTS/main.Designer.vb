<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main
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
        Me.checkerID = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.infoLabel = New System.Windows.Forms.Label()
        Me.tAccountPanel = New System.Windows.Forms.Panel()
        Me.hideCombi = New System.Windows.Forms.ComboBox()
        Me.hideLabel = New System.Windows.Forms.Label()
        Me.greetingspanel = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_greetings_proceed = New System.Windows.Forms.Button()
        Me.newBusinessOwner = New System.Windows.Forms.TextBox()
        Me.newBusinessName = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.existingBusiness = New System.Windows.Forms.RadioButton()
        Me.businessSelector = New System.Windows.Forms.ComboBox()
        Me.loginpanel = New System.Windows.Forms.Panel()
        Me.passTB = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.menutabs = New System.Windows.Forms.MenuStrip()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeBusinessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteBusinessToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrialBalanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbl_businessID = New System.Windows.Forms.Label()
        Me.greetingspanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.loginpanel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menutabs.SuspendLayout()
        Me.SuspendLayout()
        '
        'checkerID
        '
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Firebrick
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(854, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 33)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'infoLabel
        '
        Me.infoLabel.AutoSize = True
        Me.infoLabel.BackColor = System.Drawing.Color.Transparent
        Me.infoLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infoLabel.ForeColor = System.Drawing.Color.Black
        Me.infoLabel.Location = New System.Drawing.Point(29, 455)
        Me.infoLabel.Name = "infoLabel"
        Me.infoLabel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.infoLabel.Size = New System.Drawing.Size(0, 23)
        Me.infoLabel.TabIndex = 10
        '
        'tAccountPanel
        '
        Me.tAccountPanel.AutoScroll = True
        Me.tAccountPanel.BackColor = System.Drawing.Color.Transparent
        Me.tAccountPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tAccountPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tAccountPanel.Location = New System.Drawing.Point(0, 80)
        Me.tAccountPanel.Name = "tAccountPanel"
        Me.tAccountPanel.Size = New System.Drawing.Size(893, 368)
        Me.tAccountPanel.TabIndex = 11
        Me.tAccountPanel.Visible = False
        '
        'hideCombi
        '
        Me.hideCombi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hideCombi.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hideCombi.FormattingEnabled = True
        Me.hideCombi.Location = New System.Drawing.Point(190, 44)
        Me.hideCombi.Name = "hideCombi"
        Me.hideCombi.Size = New System.Drawing.Size(170, 29)
        Me.hideCombi.TabIndex = 1
        Me.hideCombi.Visible = False
        '
        'hideLabel
        '
        Me.hideLabel.AutoSize = True
        Me.hideLabel.BackColor = System.Drawing.Color.Transparent
        Me.hideLabel.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hideLabel.Location = New System.Drawing.Point(29, 47)
        Me.hideLabel.Name = "hideLabel"
        Me.hideLabel.Size = New System.Drawing.Size(157, 23)
        Me.hideLabel.TabIndex = 0
        Me.hideLabel.Text = "For the month of:"
        Me.hideLabel.Visible = False
        '
        'greetingspanel
        '
        Me.greetingspanel.BackColor = System.Drawing.Color.Transparent
        Me.greetingspanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.greetingspanel.Controls.Add(Me.PictureBox2)
        Me.greetingspanel.Controls.Add(Me.Label1)
        Me.greetingspanel.Controls.Add(Me.btn_greetings_proceed)
        Me.greetingspanel.Controls.Add(Me.newBusinessOwner)
        Me.greetingspanel.Controls.Add(Me.newBusinessName)
        Me.greetingspanel.Controls.Add(Me.RadioButton2)
        Me.greetingspanel.Controls.Add(Me.existingBusiness)
        Me.greetingspanel.Controls.Add(Me.businessSelector)
        Me.greetingspanel.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.greetingspanel.Location = New System.Drawing.Point(125, 171)
        Me.greetingspanel.Name = "greetingspanel"
        Me.greetingspanel.Size = New System.Drawing.Size(608, 199)
        Me.greetingspanel.TabIndex = 2
        Me.greetingspanel.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.XAV_RTS.My.Resources.Resources.Open_file_document_paper_folder
        Me.PictureBox2.Location = New System.Drawing.Point(19, 60)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(101, 97)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Please Select a Business:"
        '
        'btn_greetings_proceed
        '
        Me.btn_greetings_proceed.BackColor = System.Drawing.Color.YellowGreen
        Me.btn_greetings_proceed.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btn_greetings_proceed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btn_greetings_proceed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_greetings_proceed.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_greetings_proceed.Location = New System.Drawing.Point(475, -3)
        Me.btn_greetings_proceed.Name = "btn_greetings_proceed"
        Me.btn_greetings_proceed.Size = New System.Drawing.Size(111, 42)
        Me.btn_greetings_proceed.TabIndex = 9
        Me.btn_greetings_proceed.Text = "PROCEED"
        Me.btn_greetings_proceed.UseVisualStyleBackColor = False
        '
        'newBusinessOwner
        '
        Me.newBusinessOwner.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newBusinessOwner.Location = New System.Drawing.Point(164, 159)
        Me.newBusinessOwner.Name = "newBusinessOwner"
        Me.newBusinessOwner.Size = New System.Drawing.Size(422, 32)
        Me.newBusinessOwner.TabIndex = 8
        Me.newBusinessOwner.Text = "Full Name"
        '
        'newBusinessName
        '
        Me.newBusinessName.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newBusinessName.Location = New System.Drawing.Point(164, 122)
        Me.newBusinessName.Name = "newBusinessName"
        Me.newBusinessName.Size = New System.Drawing.Size(422, 32)
        Me.newBusinessName.TabIndex = 7
        Me.newBusinessName.Text = "Name of the business"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(138, 92)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(207, 26)
        Me.RadioButton2.TabIndex = 6
        Me.RadioButton2.Text = "Create New Business:"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'existingBusiness
        '
        Me.existingBusiness.AutoSize = True
        Me.existingBusiness.Checked = True
        Me.existingBusiness.Location = New System.Drawing.Point(138, 64)
        Me.existingBusiness.Name = "existingBusiness"
        Me.existingBusiness.Size = New System.Drawing.Size(14, 13)
        Me.existingBusiness.TabIndex = 5
        Me.existingBusiness.TabStop = True
        Me.existingBusiness.UseVisualStyleBackColor = True
        '
        'businessSelector
        '
        Me.businessSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.businessSelector.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.businessSelector.FormattingEnabled = True
        Me.businessSelector.Location = New System.Drawing.Point(164, 52)
        Me.businessSelector.Name = "businessSelector"
        Me.businessSelector.Size = New System.Drawing.Size(422, 31)
        Me.businessSelector.TabIndex = 2
        '
        'loginpanel
        '
        Me.loginpanel.BackColor = System.Drawing.Color.Transparent
        Me.loginpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.loginpanel.Controls.Add(Me.passTB)
        Me.loginpanel.Controls.Add(Me.PictureBox1)
        Me.loginpanel.Location = New System.Drawing.Point(268, 165)
        Me.loginpanel.Name = "loginpanel"
        Me.loginpanel.Size = New System.Drawing.Size(327, 203)
        Me.loginpanel.TabIndex = 0
        '
        'passTB
        '
        Me.passTB.Font = New System.Drawing.Font("Rockwell", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passTB.Location = New System.Drawing.Point(27, 144)
        Me.passTB.Name = "passTB"
        Me.passTB.Size = New System.Drawing.Size(275, 39)
        Me.passTB.TabIndex = 1
        Me.passTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.passTB.UseSystemPasswordChar = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.XAV_RTS.My.Resources.Resources.padlock
        Me.PictureBox1.Location = New System.Drawing.Point(106, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(114, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'menutabs
        '
        Me.menutabs.BackColor = System.Drawing.Color.Transparent
        Me.menutabs.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menutabs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionToolStripMenuItem, Me.TrialBalanceToolStripMenuItem, Me.UpdateSettingsToolStripMenuItem})
        Me.menutabs.Location = New System.Drawing.Point(0, 0)
        Me.menutabs.Name = "menutabs"
        Me.menutabs.Size = New System.Drawing.Size(893, 35)
        Me.menutabs.TabIndex = 2
        Me.menutabs.Text = "menutabs"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.ChangeBusinessToolStripMenuItem, Me.DeleteBusinessToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Image = Global.XAV_RTS.My.Resources.Resources.archives
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(105, 31)
        Me.TransactionToolStripMenuItem.Text = "Action"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Image = Global.XAV_RTS.My.Resources.Resources.add_48
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(247, 32)
        Me.AddToolStripMenuItem.Text = "New Transaction"
        '
        'ChangeBusinessToolStripMenuItem
        '
        Me.ChangeBusinessToolStripMenuItem.Image = Global.XAV_RTS.My.Resources.Resources.refresh_48
        Me.ChangeBusinessToolStripMenuItem.Name = "ChangeBusinessToolStripMenuItem"
        Me.ChangeBusinessToolStripMenuItem.Size = New System.Drawing.Size(247, 32)
        Me.ChangeBusinessToolStripMenuItem.Text = "Change Business"
        '
        'DeleteBusinessToolStripMenuItem
        '
        Me.DeleteBusinessToolStripMenuItem.Image = Global.XAV_RTS.My.Resources.Resources.deletered
        Me.DeleteBusinessToolStripMenuItem.Name = "DeleteBusinessToolStripMenuItem"
        Me.DeleteBusinessToolStripMenuItem.Size = New System.Drawing.Size(247, 32)
        Me.DeleteBusinessToolStripMenuItem.Text = "Delete Business"
        '
        'TrialBalanceToolStripMenuItem
        '
        Me.TrialBalanceToolStripMenuItem.Image = Global.XAV_RTS.My.Resources.Resources.subject_48
        Me.TrialBalanceToolStripMenuItem.Name = "TrialBalanceToolStripMenuItem"
        Me.TrialBalanceToolStripMenuItem.Size = New System.Drawing.Size(168, 31)
        Me.TrialBalanceToolStripMenuItem.Text = "Trial Balance"
        '
        'UpdateSettingsToolStripMenuItem
        '
        Me.UpdateSettingsToolStripMenuItem.Image = Global.XAV_RTS.My.Resources.Resources.settings
        Me.UpdateSettingsToolStripMenuItem.Name = "UpdateSettingsToolStripMenuItem"
        Me.UpdateSettingsToolStripMenuItem.Size = New System.Drawing.Size(115, 31)
        Me.UpdateSettingsToolStripMenuItem.Text = "Settings"
        '
        'lbl_businessID
        '
        Me.lbl_businessID.AutoSize = True
        Me.lbl_businessID.Location = New System.Drawing.Point(657, 47)
        Me.lbl_businessID.Name = "lbl_businessID"
        Me.lbl_businessID.Size = New System.Drawing.Size(39, 13)
        Me.lbl_businessID.TabIndex = 12
        Me.lbl_businessID.Text = "Label2"
        Me.lbl_businessID.Visible = False
        '
        'main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(893, 486)
        Me.Controls.Add(Me.lbl_businessID)
        Me.Controls.Add(Me.hideLabel)
        Me.Controls.Add(Me.hideCombi)
        Me.Controls.Add(Me.greetingspanel)
        Me.Controls.Add(Me.infoLabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.menutabs)
        Me.Controls.Add(Me.loginpanel)
        Me.Controls.Add(Me.tAccountPanel)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.menutabs
        Me.Name = "main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AccountingSystem"
        Me.greetingspanel.ResumeLayout(False)
        Me.greetingspanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.loginpanel.ResumeLayout(False)
        Me.loginpanel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menutabs.ResumeLayout(False)
        Me.menutabs.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents loginpanel As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents passTB As System.Windows.Forms.TextBox
    Friend WithEvents menutabs As System.Windows.Forms.MenuStrip
    Friend WithEvents TransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrialBalanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents checkerID As System.Windows.Forms.Timer
    Friend WithEvents greetingspanel As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents newBusinessName As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents existingBusiness As System.Windows.Forms.RadioButton
    Friend WithEvents newBusinessOwner As System.Windows.Forms.TextBox
    Friend WithEvents btn_greetings_proceed As System.Windows.Forms.Button
    Friend WithEvents ChangeBusinessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents infoLabel As System.Windows.Forms.Label
    Private WithEvents businessSelector As System.Windows.Forms.ComboBox
    Friend WithEvents tAccountPanel As System.Windows.Forms.Panel
    Friend WithEvents DeleteBusinessToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents hideLabel As System.Windows.Forms.Label
    Friend WithEvents hideCombi As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_businessID As System.Windows.Forms.Label

End Class
