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
        Me.CbxSelectBiographies = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblSelectedBiography = New System.Windows.Forms.Label()
        Me.BtnView = New System.Windows.Forms.Button()
        Me.CbxPresidents = New System.Windows.Forms.CheckBox()
        Me.CbxEvents = New System.Windows.Forms.CheckBox()
        Me.CbxBirthdays = New System.Windows.Forms.CheckBox()
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
        'CbxSelectBiographies
        '
        Me.CbxSelectBiographies.BackColor = System.Drawing.Color.Bisque
        Me.CbxSelectBiographies.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CbxSelectBiographies.FormattingEnabled = True
        Me.CbxSelectBiographies.Items.AddRange(New Object() {"All", "Individual"})
        Me.CbxSelectBiographies.Location = New System.Drawing.Point(128, 44)
        Me.CbxSelectBiographies.Name = "CbxSelectBiographies"
        Me.CbxSelectBiographies.Size = New System.Drawing.Size(102, 28)
        Me.CbxSelectBiographies.TabIndex = 1
        Me.CbxSelectBiographies.Text = "All"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Biographies"
        '
        'LblSelectedBiography
        '
        Me.LblSelectedBiography.AutoSize = True
        Me.LblSelectedBiography.Location = New System.Drawing.Point(42, 9)
        Me.LblSelectedBiography.Name = "LblSelectedBiography"
        Me.LblSelectedBiography.Size = New System.Drawing.Size(173, 20)
        Me.LblSelectedBiography.TabIndex = 3
        Me.LblSelectedBiography.Text = "Choose All or Individual"
        '
        'BtnView
        '
        Me.BtnView.BackColor = System.Drawing.Color.Bisque
        Me.BtnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnView.Location = New System.Drawing.Point(160, 156)
        Me.BtnView.Name = "BtnView"
        Me.BtnView.Size = New System.Drawing.Size(70, 31)
        Me.BtnView.TabIndex = 4
        Me.BtnView.Text = "View"
        Me.BtnView.UseVisualStyleBackColor = False
        '
        'CbxPresidents
        '
        Me.CbxPresidents.AutoSize = True
        Me.CbxPresidents.BackColor = System.Drawing.Color.Bisque
        Me.CbxPresidents.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CbxPresidents.Location = New System.Drawing.Point(33, 103)
        Me.CbxPresidents.Name = "CbxPresidents"
        Me.CbxPresidents.Size = New System.Drawing.Size(101, 24)
        Me.CbxPresidents.TabIndex = 18
        Me.CbxPresidents.Text = "Presidents"
        Me.CbxPresidents.UseVisualStyleBackColor = False
        '
        'CbxEvents
        '
        Me.CbxEvents.AutoSize = True
        Me.CbxEvents.BackColor = System.Drawing.Color.Bisque
        Me.CbxEvents.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CbxEvents.Location = New System.Drawing.Point(33, 163)
        Me.CbxEvents.Name = "CbxEvents"
        Me.CbxEvents.Size = New System.Drawing.Size(75, 24)
        Me.CbxEvents.TabIndex = 21
        Me.CbxEvents.Text = "Events"
        Me.CbxEvents.UseVisualStyleBackColor = False
        '
        'CbxBirthdays
        '
        Me.CbxBirthdays.AutoSize = True
        Me.CbxBirthdays.BackColor = System.Drawing.Color.Bisque
        Me.CbxBirthdays.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CbxBirthdays.Location = New System.Drawing.Point(33, 133)
        Me.CbxBirthdays.Name = "CbxBirthdays"
        Me.CbxBirthdays.Size = New System.Drawing.Size(92, 24)
        Me.CbxBirthdays.TabIndex = 20
        Me.CbxBirthdays.Text = "Birthdays"
        Me.CbxBirthdays.UseVisualStyleBackColor = False
        '
        'FrmSelectView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(281, 235)
        Me.Controls.Add(Me.CbxEvents)
        Me.Controls.Add(Me.CbxBirthdays)
        Me.Controls.Add(Me.CbxPresidents)
        Me.Controls.Add(Me.BtnView)
        Me.Controls.Add(Me.LblSelectedBiography)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbxSelectBiographies)
        Me.Controls.Add(Me.BtnExit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(297, 274)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(297, 274)
        Me.Name = "FrmSelectView"
        Me.Text = "Select View"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExit As Button
    Friend WithEvents CbxSelectBiographies As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblSelectedBiography As Label
    Friend WithEvents BtnView As Button
    Friend WithEvents CbxPresidents As CheckBox
    Friend WithEvents CbxEvents As CheckBox
    Friend WithEvents CbxBirthdays As CheckBox
End Class
