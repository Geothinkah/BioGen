﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.CbxPresidents = New System.Windows.Forms.CheckBox()
        Me.CbxEvents = New System.Windows.Forms.CheckBox()
        Me.CbxBirthdays = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSelectBiography = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
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
        Me.BtnView.Location = New System.Drawing.Point(200, 188)
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
        Me.CbxPresidents.Location = New System.Drawing.Point(25, 113)
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
        Me.CbxEvents.Location = New System.Drawing.Point(25, 173)
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
        Me.CbxBirthdays.Location = New System.Drawing.Point(25, 143)
        Me.CbxBirthdays.Name = "CbxBirthdays"
        Me.CbxBirthdays.Size = New System.Drawing.Size(92, 24)
        Me.CbxBirthdays.TabIndex = 20
        Me.CbxBirthdays.Text = "Birthdays"
        Me.CbxBirthdays.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.OldLace
        Me.Panel1.Controls.Add(Me.BtnSelectBiography)
        Me.Panel1.Controls.Add(Me.BtnView)
        Me.Panel1.Controls.Add(Me.CbxEvents)
        Me.Panel1.Controls.Add(Me.CbxBirthdays)
        Me.Panel1.Controls.Add(Me.CbxPresidents)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 222)
        Me.Panel1.TabIndex = 22
        '
        'BtnSelectBiography
        '
        Me.BtnSelectBiography.BackColor = System.Drawing.Color.Bisque
        Me.BtnSelectBiography.Location = New System.Drawing.Point(3, 3)
        Me.BtnSelectBiography.Name = "BtnSelectBiography"
        Me.BtnSelectBiography.Size = New System.Drawing.Size(267, 36)
        Me.BtnSelectBiography.TabIndex = 22
        Me.BtnSelectBiography.Text = "Select Biography"
        Me.BtnSelectBiography.UseVisualStyleBackColor = False
        '
        'FrmSelectView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(297, 250)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnExit)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(140, 180)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(297, 250)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(297, 250)
        Me.Name = "FrmSelectView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Select View"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnView As Button
    Friend WithEvents CbxPresidents As CheckBox
    Friend WithEvents CbxEvents As CheckBox
    Friend WithEvents CbxBirthdays As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSelectBiography As Button
End Class
