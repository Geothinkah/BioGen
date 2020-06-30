<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCatagory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCatagory))
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnOption = New System.Windows.Forms.Button()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Bisque
        Me.BtnExit.Location = New System.Drawing.Point(240, 65)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(85, 29)
        Me.BtnExit.TabIndex = 3
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'BtnOption
        '
        Me.BtnOption.BackColor = System.Drawing.Color.Bisque
        Me.BtnOption.Location = New System.Drawing.Point(137, 65)
        Me.BtnOption.Name = "BtnOption"
        Me.BtnOption.Size = New System.Drawing.Size(85, 29)
        Me.BtnOption.TabIndex = 2
        Me.BtnOption.Text = "Option"
        Me.BtnOption.UseVisualStyleBackColor = False
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(81, 16)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(244, 26)
        Me.TxtName.TabIndex = 1
        '
        'FrmCatagory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.OldLace
        Me.ClientSize = New System.Drawing.Size(346, 123)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.BtnOption)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnExit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1395, 175)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCatagory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Add Category"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnOption As Button
    Friend WithEvents TxtName As TextBox
End Class
