<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOpenCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpenCategory))
        Me.LstvSelectCategory = New System.Windows.Forms.ListView()
        Me.ColName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnOption = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LstvSelectCategory
        '
        Me.LstvSelectCategory.BackColor = System.Drawing.Color.OldLace
        Me.LstvSelectCategory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColName})
        Me.LstvSelectCategory.HideSelection = False
        Me.LstvSelectCategory.Location = New System.Drawing.Point(3, 7)
        Me.LstvSelectCategory.Name = "LstvSelectCategory"
        Me.LstvSelectCategory.Size = New System.Drawing.Size(207, 209)
        Me.LstvSelectCategory.TabIndex = 1
        Me.LstvSelectCategory.UseCompatibleStateImageBehavior = False
        Me.LstvSelectCategory.View = System.Windows.Forms.View.SmallIcon
        '
        'ColName
        '
        Me.ColName.Text = "Name"
        Me.ColName.Width = 200
        '
        'BtnOption
        '
        Me.BtnOption.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOption.BackColor = System.Drawing.Color.Bisque
        Me.BtnOption.Location = New System.Drawing.Point(106, 188)
        Me.BtnOption.Name = "BtnOption"
        Me.BtnOption.Size = New System.Drawing.Size(95, 31)
        Me.BtnOption.TabIndex = 2
        Me.BtnOption.Text = "Option"
        Me.BtnOption.UseVisualStyleBackColor = False
        '
        'FrmOpenCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(213, 228)
        Me.Controls.Add(Me.BtnOption)
        Me.Controls.Add(Me.LstvSelectCategory)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1395, 155)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(229, 267)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(229, 267)
        Me.Name = "FrmOpenCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Open Category"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LstvSelectCategory As ListView
    Friend WithEvents ColName As ColumnHeader
    Friend WithEvents BtnOption As Button
End Class
