<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelectView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSelectView))
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.CbxBirthdays = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CbxDeaths = New System.Windows.Forms.CheckBox()
        Me.CbxBirthDate = New System.Windows.Forms.CheckBox()
        Me.ClbCategories = New System.Windows.Forms.CheckedListBox()
        Me.BtnSelectBiography = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Bisque
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExit.Location = New System.Drawing.Point(988, 602)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(142, 44)
        Me.BtnExit.TabIndex = 0
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnView
        '
        Me.BtnView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnView.BackColor = System.Drawing.Color.Bisque
        Me.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnView.Location = New System.Drawing.Point(204, 337)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(64, 31)
        Me.BtnView.TabIndex = 4
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = False
        '
        'CbxBirthdays
        '
        Me.CbxBirthdays.AutoSize = True
        Me.CbxBirthdays.BackColor = System.Drawing.Color.OldLace
        Me.CbxBirthdays.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CbxBirthdays.Location = New System.Drawing.Point(3, 32)
        Me.CbxBirthdays.Name = "CbxBirthdays"
        Me.CbxBirthdays.Size = New System.Drawing.Size(92, 24)
        Me.CbxBirthdays.TabIndex = 20
        Me.CbxBirthdays.Text = "Birthdays"
        Me.CbxBirthdays.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OldLace
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.ClbCategories)
        Me.Panel1.Controls.Add(Me.BtnSelectBiography)
        Me.Panel1.Controls.Add(Me.BtnView)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(292, 380)
        Me.Panel1.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 167)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 24)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Category Choices"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.OldLace
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.CbxDeaths)
        Me.Panel2.Controls.Add(Me.CbxBirthdays)
        Me.Panel2.Controls.Add(Me.CbxBirthDate)
        Me.Panel2.Location = New System.Drawing.Point(22, 45)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(247, 97)
        Me.Panel2.TabIndex = 28
        '
        'CbxDeaths
        '
        Me.CbxDeaths.AutoSize = True
        Me.CbxDeaths.BackColor = System.Drawing.Color.OldLace
        Me.CbxDeaths.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CbxDeaths.Location = New System.Drawing.Point(3, 62)
        Me.CbxDeaths.Name = "CbxDeaths"
        Me.CbxDeaths.Size = New System.Drawing.Size(78, 24)
        Me.CbxDeaths.TabIndex = 23
        Me.CbxDeaths.Text = "Deaths"
        Me.CbxDeaths.UseVisualStyleBackColor = False
        '
        'CbxBirthDate
        '
        Me.CbxBirthDate.AutoSize = True
        Me.CbxBirthDate.BackColor = System.Drawing.Color.OldLace
        Me.CbxBirthDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CbxBirthDate.Location = New System.Drawing.Point(3, 2)
        Me.CbxBirthDate.Name = "CbxBirthDate"
        Me.CbxBirthDate.Size = New System.Drawing.Size(106, 24)
        Me.CbxBirthDate.TabIndex = 24
        Me.CbxBirthDate.Text = "Birth Dates"
        Me.CbxBirthDate.UseVisualStyleBackColor = False
        '
        'ClbCategories
        '
        Me.ClbCategories.AllowDrop = True
        Me.ClbCategories.BackColor = System.Drawing.Color.OldLace
        Me.ClbCategories.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClbCategories.CheckOnClick = True
        Me.ClbCategories.FormattingEnabled = True
        Me.ClbCategories.Location = New System.Drawing.Point(21, 191)
        Me.ClbCategories.Name = "ClbCategories"
        Me.ClbCategories.Size = New System.Drawing.Size(248, 128)
        Me.ClbCategories.TabIndex = 25
        Me.ClbCategories.ThreeDCheckBoxes = True
        '
        'BtnSelectBiography
        '
        Me.BtnSelectBiography.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSelectBiography.BackColor = System.Drawing.Color.Bisque
        Me.BtnSelectBiography.Location = New System.Drawing.Point(3, 6)
        Me.BtnSelectBiography.Name = "BtnSelectBiography"
        Me.BtnSelectBiography.Size = New System.Drawing.Size(286, 36)
        Me.BtnSelectBiography.TabIndex = 22
        Me.BtnSelectBiography.Text = "Change Biography"
        Me.BtnSelectBiography.UseVisualStyleBackColor = False
        '
        'FrmSelectView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(317, 404)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnExit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(125, 180)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSelectView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Select View"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnView As Button
    Friend WithEvents CbxBirthdays As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSelectBiography As Button
    Friend WithEvents CbxDeaths As CheckBox
    Friend WithEvents CbxBirthDate As CheckBox
    Friend WithEvents ClbCategories As CheckedListBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
End Class
