<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpenEvents
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
        Dim EventDescription As System.Windows.Forms.ColumnHeader
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpenEvents))
        Me.BtnOption = New System.Windows.Forms.Button()
        Me.LstvEvents = New System.Windows.Forms.ListView()
        Me.EventDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        EventDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'EventDescription
        '
        EventDescription.Text = "Description"
        EventDescription.Width = 502
        '
        'BtnOption
        '
        Me.BtnOption.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnOption.BackColor = System.Drawing.Color.Bisque
        Me.BtnOption.Location = New System.Drawing.Point(512, 449)
        Me.BtnOption.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BtnOption.Name = "BtnOption"
        Me.BtnOption.Size = New System.Drawing.Size(97, 35)
        Me.BtnOption.TabIndex = 0
        Me.BtnOption.Text = "Option"
        Me.BtnOption.UseVisualStyleBackColor = False
        '
        'LstvEvents
        '
        Me.LstvEvents.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.LstvEvents.AutoArrange = False
        Me.LstvEvents.BackColor = System.Drawing.Color.Bisque
        Me.LstvEvents.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstvEvents.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.EventDate, EventDescription})
        Me.LstvEvents.FullRowSelect = True
        Me.LstvEvents.GridLines = True
        Me.LstvEvents.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LstvEvents.HideSelection = False
        Me.LstvEvents.Location = New System.Drawing.Point(12, 12)
        Me.LstvEvents.MultiSelect = False
        Me.LstvEvents.Name = "LstvEvents"
        Me.LstvEvents.Size = New System.Drawing.Size(597, 417)
        Me.LstvEvents.TabIndex = 0
        Me.LstvEvents.UseCompatibleStateImageBehavior = False
        Me.LstvEvents.View = System.Windows.Forms.View.Details
        '
        'EventDate
        '
        Me.EventDate.Text = "Date"
        Me.EventDate.Width = 90
        '
        'FrmOpenEvents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(622, 498)
        Me.Controls.Add(Me.LstvEvents)
        Me.Controls.Add(Me.BtnOption)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmOpenEvents"
        Me.Text = "FrmOpenEvents"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnOption As Button
    Friend WithEvents LstvEvents As ListView
    Friend WithEvents EventDate As ColumnHeader
End Class
