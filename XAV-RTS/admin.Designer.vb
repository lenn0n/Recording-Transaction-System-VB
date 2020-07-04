<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Me.adminPassTB = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.passUpdateBTN = New System.Windows.Forms.Button()
        Me.addTitleBTN = New System.Windows.Forms.Button()
        Me.newTitle = New System.Windows.Forms.TextBox()
        Me.titleList = New System.Windows.Forms.ListView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.prioID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bname_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.updateBusinessName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'adminPassTB
        '
        Me.adminPassTB.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminPassTB.Location = New System.Drawing.Point(19, 46)
        Me.adminPassTB.Name = "adminPassTB"
        Me.adminPassTB.Size = New System.Drawing.Size(163, 25)
        Me.adminPassTB.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(301, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 33)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "System Password:"
        '
        'passUpdateBTN
        '
        Me.passUpdateBTN.Location = New System.Drawing.Point(188, 46)
        Me.passUpdateBTN.Name = "passUpdateBTN"
        Me.passUpdateBTN.Size = New System.Drawing.Size(75, 23)
        Me.passUpdateBTN.TabIndex = 3
        Me.passUpdateBTN.Text = "Update"
        Me.passUpdateBTN.UseVisualStyleBackColor = True
        '
        'addTitleBTN
        '
        Me.addTitleBTN.Location = New System.Drawing.Point(266, 249)
        Me.addTitleBTN.Name = "addTitleBTN"
        Me.addTitleBTN.Size = New System.Drawing.Size(70, 24)
        Me.addTitleBTN.TabIndex = 6
        Me.addTitleBTN.Text = "Add"
        Me.addTitleBTN.UseVisualStyleBackColor = True
        '
        'newTitle
        '
        Me.newTitle.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.newTitle.Location = New System.Drawing.Point(61, 249)
        Me.newTitle.Name = "newTitle"
        Me.newTitle.Size = New System.Drawing.Size(199, 25)
        Me.newTitle.TabIndex = 7
        Me.newTitle.Text = "Name of Account"
        Me.newTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'titleList
        '
        Me.titleList.FullRowSelect = True
        Me.titleList.Location = New System.Drawing.Point(18, 111)
        Me.titleList.Name = "titleList"
        Me.titleList.Size = New System.Drawing.Size(320, 132)
        Me.titleList.TabIndex = 8
        Me.titleList.UseCompatibleStateImageBehavior = False
        Me.titleList.View = System.Windows.Forms.View.Details
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Accounts:"
        '
        'prioID
        '
        Me.prioID.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prioID.Location = New System.Drawing.Point(18, 249)
        Me.prioID.Name = "prioID"
        Me.prioID.Size = New System.Drawing.Size(37, 25)
        Me.prioID.TabIndex = 10
        Me.prioID.Text = "#"
        Me.prioID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(117, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Note: Click to remove items."
        '
        'bname_btn
        '
        Me.bname_btn.Location = New System.Drawing.Point(266, 323)
        Me.bname_btn.Name = "bname_btn"
        Me.bname_btn.Size = New System.Drawing.Size(70, 23)
        Me.bname_btn.TabIndex = 14
        Me.bname_btn.Text = "Update"
        Me.bname_btn.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Business Name:"
        '
        'updateBusinessName
        '
        Me.updateBusinessName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBusinessName.Location = New System.Drawing.Point(18, 321)
        Me.updateBusinessName.Name = "updateBusinessName"
        Me.updateBusinessName.Size = New System.Drawing.Size(242, 25)
        Me.updateBusinessName.TabIndex = 12
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(356, 365)
        Me.Controls.Add(Me.bname_btn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.updateBusinessName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.prioID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.titleList)
        Me.Controls.Add(Me.newTitle)
        Me.Controls.Add(Me.addTitleBTN)
        Me.Controls.Add(Me.passUpdateBTN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.adminPassTB)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents adminPassTB As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents passUpdateBTN As System.Windows.Forms.Button
    Friend WithEvents addTitleBTN As System.Windows.Forms.Button
    Friend WithEvents newTitle As System.Windows.Forms.TextBox
    Friend WithEvents titleList As System.Windows.Forms.ListView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents prioID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents bname_btn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents updateBusinessName As System.Windows.Forms.TextBox
End Class
