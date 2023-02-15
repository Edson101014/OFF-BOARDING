<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HRUser
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
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonEdit = New System.Windows.Forms.Button()
        Me.ButtonCancel = New System.Windows.Forms.Button()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.ButtonADD = New System.Windows.Forms.Button()
        Me.ComboBoxDepartment = New System.Windows.Forms.ComboBox()
        Me.ComboBoxTitle = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ButtonDelete
        '
        Me.ButtonDelete.BackColor = System.Drawing.Color.Firebrick
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonDelete.Location = New System.Drawing.Point(196, 243)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(108, 38)
        Me.ButtonDelete.TabIndex = 0
        Me.ButtonDelete.Text = "DELETE"
        Me.ButtonDelete.UseVisualStyleBackColor = False
        '
        'ButtonEdit
        '
        Me.ButtonEdit.BackColor = System.Drawing.Color.Turquoise
        Me.ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonEdit.Location = New System.Drawing.Point(196, 243)
        Me.ButtonEdit.Name = "ButtonEdit"
        Me.ButtonEdit.Size = New System.Drawing.Size(108, 38)
        Me.ButtonEdit.TabIndex = 1
        Me.ButtonEdit.Text = "EDIT"
        Me.ButtonEdit.UseVisualStyleBackColor = False
        '
        'ButtonCancel
        '
        Me.ButtonCancel.BackColor = System.Drawing.Color.DarkCyan
        Me.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonCancel.Location = New System.Drawing.Point(320, 243)
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.Size = New System.Drawing.Size(95, 38)
        Me.ButtonCancel.TabIndex = 2
        Me.ButtonCancel.Text = "CANCEL"
        Me.ButtonCancel.UseVisualStyleBackColor = False
        '
        'TextBoxName
        '
        Me.TextBoxName.Enabled = False
        Me.TextBoxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxName.Location = New System.Drawing.Point(123, 24)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(292, 22)
        Me.TextBoxName.TabIndex = 3
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Enabled = False
        Me.TextBoxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUsername.Location = New System.Drawing.Point(123, 61)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(292, 22)
        Me.TextBoxUsername.TabIndex = 4
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Enabled = False
        Me.TextBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxPassword.Location = New System.Drawing.Point(123, 95)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(292, 22)
        Me.TextBoxPassword.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 18)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "NAME:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 18)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "EMAIL:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 18)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "PASSWORD:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 18)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "USERNAME:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 18)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "TITLE:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 18)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "DEPARTMENT:"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Enabled = False
        Me.TextBoxEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxEmail.Location = New System.Drawing.Point(123, 130)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(292, 22)
        Me.TextBoxEmail.TabIndex = 12
        '
        'ButtonADD
        '
        Me.ButtonADD.BackColor = System.Drawing.Color.Lime
        Me.ButtonADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonADD.Location = New System.Drawing.Point(196, 243)
        Me.ButtonADD.Name = "ButtonADD"
        Me.ButtonADD.Size = New System.Drawing.Size(108, 38)
        Me.ButtonADD.TabIndex = 15
        Me.ButtonADD.Text = "ADD"
        Me.ButtonADD.UseVisualStyleBackColor = False
        '
        'ComboBoxDepartment
        '
        Me.ComboBoxDepartment.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxDepartment.Enabled = False
        Me.ComboBoxDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxDepartment.FormattingEnabled = True
        Me.ComboBoxDepartment.Items.AddRange(New Object() {"BDG", "SDG", "ITOPS", "PMG", "Marketing", "Finance", "Admin", "System Admin", "HR", "Interview"})
        Me.ComboBoxDepartment.Location = New System.Drawing.Point(141, 192)
        Me.ComboBoxDepartment.Name = "ComboBoxDepartment"
        Me.ComboBoxDepartment.Size = New System.Drawing.Size(274, 21)
        Me.ComboBoxDepartment.TabIndex = 123
        '
        'ComboBoxTitle
        '
        Me.ComboBoxTitle.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ComboBoxTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxTitle.Enabled = False
        Me.ComboBoxTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBoxTitle.FormattingEnabled = True
        Me.ComboBoxTitle.Items.AddRange(New Object() {"Dept Head", "Supervisor", "Interview"})
        Me.ComboBoxTitle.Location = New System.Drawing.Point(123, 163)
        Me.ComboBoxTitle.Name = "ComboBoxTitle"
        Me.ComboBoxTitle.Size = New System.Drawing.Size(292, 21)
        Me.ComboBoxTitle.TabIndex = 124
        '
        'HRUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 293)
        Me.Controls.Add(Me.ComboBoxTitle)
        Me.Controls.Add(Me.ComboBoxDepartment)
        Me.Controls.Add(Me.ButtonADD)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonEdit)
        Me.Controls.Add(Me.ButtonDelete)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "HRUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HRUser"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonEdit As Button
    Friend WithEvents ButtonCancel As Button
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents ButtonADD As Button
    Friend WithEvents ComboBoxDepartment As ComboBox
    Friend WithEvents ComboBoxTitle As ComboBox
End Class
