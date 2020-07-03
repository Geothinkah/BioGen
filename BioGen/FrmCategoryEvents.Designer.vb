<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCategoryEvents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCategoryEvents))
        Me.BtnOption = New System.Windows.Forms.Button()
        Me.DtpCateBeginDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RbtnNo = New System.Windows.Forms.RadioButton()
        Me.RbtnYes = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnOption
        '
        Me.BtnOption.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOption.BackColor = System.Drawing.Color.Bisque
        Me.BtnOption.Location = New System.Drawing.Point(349, 204)
        Me.BtnOption.Name = "BtnOption"
        Me.BtnOption.Size = New System.Drawing.Size(83, 26)
        Me.BtnOption.TabIndex = 1
        Me.BtnOption.Text = "Exit"
        Me.BtnOption.UseVisualStyleBackColor = False
        '
        'DtpCateBeginDate
        '
        Me.DtpCateBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpCateBeginDate.Location = New System.Drawing.Point(73, 14)
        Me.DtpCateBeginDate.Name = "DtpCateBeginDate"
        Me.DtpCateBeginDate.Size = New System.Drawing.Size(110, 26)
        Me.DtpCateBeginDate.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.OldLace
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Date"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OldLace
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.DtpEndDate)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnOption)
        Me.Panel1.Controls.Add(Me.DtpCateBeginDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(445, 238)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OldLace
        Me.Panel2.Controls.Add(Me.RbtnNo)
        Me.Panel2.Controls.Add(Me.RbtnYes)
        Me.Panel2.Location = New System.Drawing.Point(266, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(163, 29)
        Me.Panel2.TabIndex = 9
        '
        'RbtnNo
        '
        Me.RbtnNo.AutoSize = True
        Me.RbtnNo.Checked = True
        Me.RbtnNo.Location = New System.Drawing.Point(98, 3)
        Me.RbtnNo.Name = "RbtnNo"
        Me.RbtnNo.Size = New System.Drawing.Size(47, 24)
        Me.RbtnNo.TabIndex = 1
        Me.RbtnNo.TabStop = True
        Me.RbtnNo.Text = "No"
        Me.RbtnNo.UseVisualStyleBackColor = True
        '
        'RbtnYes
        '
        Me.RbtnYes.AutoSize = True
        Me.RbtnYes.Location = New System.Drawing.Point(25, 3)
        Me.RbtnYes.Name = "RbtnYes"
        Me.RbtnYes.Size = New System.Drawing.Size(55, 24)
        Me.RbtnYes.TabIndex = 0
        Me.RbtnYes.Text = "Yes"
        Me.RbtnYes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Description"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(16, 79)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(413, 110)
        Me.TextBox1.TabIndex = 7
        '
        'DtpEndDate
        '
        Me.DtpEndDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpEndDate.Location = New System.Drawing.Point(266, 47)
        Me.DtpEndDate.Name = "DtpEndDate"
        Me.DtpEndDate.Size = New System.Drawing.Size(102, 26)
        Me.DtpEndDate.TabIndex = 6
        Me.DtpEndDate.Visible = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.OldLace
        Me.Label2.Location = New System.Drawing.Point(207, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Range"
        '
        'FrmCategoryEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(469, 262)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1400, 180)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCategoryEvents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Events"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnOption As Button
    Friend WithEvents DtpCateBeginDate As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DtpEndDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents RbtnNo As RadioButton
    Friend WithEvents RbtnYes As RadioButton
End Class
