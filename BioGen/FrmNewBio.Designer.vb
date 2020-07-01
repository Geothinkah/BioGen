<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmNewBio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmNewBio))
        Me.DtpDeathDate = New System.Windows.Forms.DateTimePicker()
        Me.LblDeath = New System.Windows.Forms.Label()
        Me.CbxLiving = New System.Windows.Forms.ComboBox()
        Me.LblLiving = New System.Windows.Forms.Label()
        Me.DtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.LblName = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNickName = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnOption = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DtpDeathDate
        '
        Me.DtpDeathDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpDeathDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDeathDate.Location = New System.Drawing.Point(355, 95)
        Me.DtpDeathDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DtpDeathDate.Name = "DtpDeathDate"
        Me.DtpDeathDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DtpDeathDate.Size = New System.Drawing.Size(136, 26)
        Me.DtpDeathDate.TabIndex = 6
        Me.DtpDeathDate.Value = New Date(2005, 12, 5, 0, 0, 0, 0)
        '
        'LblDeath
        '
        Me.LblDeath.AutoSize = True
        Me.LblDeath.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDeath.Location = New System.Drawing.Point(255, 101)
        Me.LblDeath.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblDeath.Name = "LblDeath"
        Me.LblDeath.Size = New System.Drawing.Size(92, 20)
        Me.LblDeath.TabIndex = 0
        Me.LblDeath.Text = "Death Date"
        '
        'CbxLiving
        '
        Me.CbxLiving.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CbxLiving.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxLiving.FormattingEnabled = True
        Me.CbxLiving.Items.AddRange(New Object() {"Yes", "No"})
        Me.CbxLiving.Location = New System.Drawing.Point(355, 48)
        Me.CbxLiving.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CbxLiving.Name = "CbxLiving"
        Me.CbxLiving.Size = New System.Drawing.Size(83, 28)
        Me.CbxLiving.TabIndex = 5
        Me.CbxLiving.Text = "Yes"
        '
        'LblLiving
        '
        Me.LblLiving.AutoSize = True
        Me.LblLiving.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLiving.Location = New System.Drawing.Point(298, 56)
        Me.LblLiving.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblLiving.Name = "LblLiving"
        Me.LblLiving.Size = New System.Drawing.Size(49, 20)
        Me.LblLiving.TabIndex = 0
        Me.LblLiving.Text = "Living"
        '
        'DtpBirthDate
        '
        Me.DtpBirthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpBirthDate.Location = New System.Drawing.Point(99, 95)
        Me.DtpBirthDate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DtpBirthDate.Name = "DtpBirthDate"
        Me.DtpBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DtpBirthDate.Size = New System.Drawing.Size(136, 26)
        Me.DtpBirthDate.TabIndex = 3
        Me.DtpBirthDate.Value = New Date(1955, 5, 15, 23, 59, 0, 0)
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBirthDate.Location = New System.Drawing.Point(10, 95)
        Me.lblBirthDate.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(81, 20)
        Me.lblBirthDate.TabIndex = 0
        Me.lblBirthDate.Text = "Birth Date"
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(99, 13)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(392, 26)
        Me.TxtName.TabIndex = 1
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(40, 16)
        Me.LblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(51, 20)
        Me.LblName.TabIndex = 0
        Me.LblName.Text = "Name"
        '
        'BtnExit
        '
        Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(377, 137)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(84, 31)
        Me.BtnExit.TabIndex = 9
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nick Name"
        '
        'TxtNickName
        '
        Me.TxtNickName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNickName.Location = New System.Drawing.Point(99, 53)
        Me.TxtNickName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNickName.Name = "TxtNickName"
        Me.TxtNickName.Size = New System.Drawing.Size(136, 26)
        Me.TxtNickName.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.OldLace
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnOption)
        Me.Panel1.Controls.Add(Me.BtnExit)
        Me.Panel1.Controls.Add(Me.LblDeath)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtNickName)
        Me.Panel1.Controls.Add(Me.LblName)
        Me.Panel1.Controls.Add(Me.TxtName)
        Me.Panel1.Controls.Add(Me.DtpBirthDate)
        Me.Panel1.Controls.Add(Me.LblLiving)
        Me.Panel1.Controls.Add(Me.lblBirthDate)
        Me.Panel1.Controls.Add(Me.DtpDeathDate)
        Me.Panel1.Controls.Add(Me.CbxLiving)
        Me.Panel1.Location = New System.Drawing.Point(14, 14)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 187)
        Me.Panel1.TabIndex = 3
        '
        'BtnOption
        '
        Me.BtnOption.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOption.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOption.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOption.Location = New System.Drawing.Point(274, 137)
        Me.BtnOption.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnOption.Name = "BtnOption"
        Me.BtnOption.Size = New System.Drawing.Size(84, 31)
        Me.BtnOption.TabIndex = 12
        Me.BtnOption.Text = "Option"
        Me.BtnOption.UseVisualStyleBackColor = True
        '
        'FrmNewBio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(527, 218)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(30, 155)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmNewBio"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Biography"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DtpDeathDate As DateTimePicker
    Friend WithEvents LblDeath As Label
    Friend WithEvents CbxLiving As ComboBox
    Friend WithEvents LblLiving As Label
    Friend WithEvents DtpBirthDate As DateTimePicker
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents LblName As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNickName As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnOption As Button
End Class
