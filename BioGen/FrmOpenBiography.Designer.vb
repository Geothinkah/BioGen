<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOpenBiography
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpenBiography))
        Me.LstvOpenBiography = New System.Windows.Forms.ListView()
        Me.txtvName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtvBirthDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtvLiving = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnOption = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LstvOpenBiography
        '
        Me.LstvOpenBiography.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.LstvOpenBiography.AutoArrange = False
        Me.LstvOpenBiography.BackColor = System.Drawing.Color.OldLace
        Me.LstvOpenBiography.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstvOpenBiography.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.txtvName, Me.txtvBirthDate, Me.txtvLiving})
        Me.LstvOpenBiography.FullRowSelect = True
        Me.LstvOpenBiography.GridLines = True
        Me.LstvOpenBiography.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LstvOpenBiography.HideSelection = False
        Me.LstvOpenBiography.Location = New System.Drawing.Point(12, 12)
        Me.LstvOpenBiography.MultiSelect = False
        Me.LstvOpenBiography.Name = "LstvOpenBiography"
        Me.LstvOpenBiography.Size = New System.Drawing.Size(506, 386)
        Me.LstvOpenBiography.TabIndex = 0
        Me.LstvOpenBiography.UseCompatibleStateImageBehavior = False
        Me.LstvOpenBiography.View = System.Windows.Forms.View.Details
        '
        'txtvName
        '
        Me.txtvName.Text = "Biography Name"
        Me.txtvName.Width = 250
        '
        'txtvBirthDate
        '
        Me.txtvBirthDate.Text = "Birth Date"
        Me.txtvBirthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtvBirthDate.Width = 125
        '
        'txtvLiving
        '
        Me.txtvLiving.Text = "Living"
        Me.txtvLiving.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtvLiving.Width = 100
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Bisque
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExit.Location = New System.Drawing.Point(442, 404)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(75, 29)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnOption
        '
        Me.BtnOption.BackColor = System.Drawing.Color.Bisque
        Me.BtnOption.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnOption.Location = New System.Drawing.Point(361, 404)
        Me.BtnOption.Name = "BtnOption"
        Me.BtnOption.Size = New System.Drawing.Size(75, 29)
        Me.BtnOption.TabIndex = 9
        Me.BtnOption.Text = "Option"
        Me.BtnOption.UseVisualStyleBackColor = False
        '
        'FrmOpenBiography
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(534, 444)
        Me.Controls.Add(Me.BtnOption)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.LstvOpenBiography)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(25, 155)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOpenBiography"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Open Biography"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LstvOpenBiography As ListView
    Friend WithEvents txtvName As ColumnHeader
    Friend WithEvents txtvBirthDate As ColumnHeader
    Friend WithEvents txtvLiving As ColumnHeader
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnOption As Button
End Class
