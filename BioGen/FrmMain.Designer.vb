<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MnuMain = New System.Windows.Forms.MenuStrip()
        Me.BiographyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BiographyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FactoryResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ResearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnThisDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FamilySearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerMain = New System.Windows.Forms.Timer(Me.components)
        Me.LblTimer = New System.Windows.Forms.Label()
        Me.LblCurrentBiography = New System.Windows.Forms.Label()
        Me.RtxBiography = New System.Windows.Forms.RichTextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CopyToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TxtFacts = New System.Windows.Forms.TextBox()
        Me.PnlEditor = New System.Windows.Forms.Panel()
        Me.MnuEditor = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UndoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TimeDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TxbSearch = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.lblSelectedBiography = New System.Windows.Forms.Label()
        Me.PnlSelectView = New System.Windows.Forms.Panel()
        Me.LblBiography = New System.Windows.Forms.Label()
        Me.BtnSelectView = New System.Windows.Forms.Button()
        Me.PnlBiography = New System.Windows.Forms.Panel()
        Me.TxtEvents = New System.Windows.Forms.TextBox()
        Me.LblCategory = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatagoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MnuMain.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.PnlEditor.SuspendLayout()
        Me.MnuEditor.SuspendLayout()
        Me.PnlSelectView.SuspendLayout()
        Me.PnlBiography.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MnuMain
        '
        Me.MnuMain.BackColor = System.Drawing.Color.Bisque
        Me.MnuMain.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BiographyToolStripMenuItem, Me.ResearchToolStripMenuItem})
        Me.MnuMain.Location = New System.Drawing.Point(0, 0)
        Me.MnuMain.Name = "MnuMain"
        Me.MnuMain.Size = New System.Drawing.Size(1910, 29)
        Me.MnuMain.TabIndex = 0
        Me.MnuMain.Text = "MenuStrip1"
        '
        'BiographyToolStripMenuItem
        '
        Me.BiographyToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BiographyToolStripMenuItem1, Me.SettingsToolStripMenuItem, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem, Me.ToolStripSeparator1})
        Me.BiographyToolStripMenuItem.Name = "BiographyToolStripMenuItem"
        Me.BiographyToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.BiographyToolStripMenuItem.Text = "File"
        '
        'BiographyToolStripMenuItem1
        '
        Me.BiographyToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.EditToolStripMenuItem1, Me.DeleteToolStripMenuItem1})
        Me.BiographyToolStripMenuItem1.Name = "BiographyToolStripMenuItem1"
        Me.BiographyToolStripMenuItem1.Size = New System.Drawing.Size(151, 26)
        Me.BiographyToolStripMenuItem1.Text = "Biography"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(124, 26)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(124, 26)
        Me.EditToolStripMenuItem1.Text = "Edit"
        '
        'DeleteToolStripMenuItem1
        '
        Me.DeleteToolStripMenuItem1.Name = "DeleteToolStripMenuItem1"
        Me.DeleteToolStripMenuItem1.Size = New System.Drawing.Size(124, 26)
        Me.DeleteToolStripMenuItem1.Text = "Delete"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FactoryResetToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'FactoryResetToolStripMenuItem
        '
        Me.FactoryResetToolStripMenuItem.Name = "FactoryResetToolStripMenuItem"
        Me.FactoryResetToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.FactoryResetToolStripMenuItem.Text = "Reset All Files"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(148, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(151, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(148, 6)
        '
        'ResearchToolStripMenuItem
        '
        Me.ResearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnThisDateToolStripMenuItem, Me.FamilySearchToolStripMenuItem})
        Me.ResearchToolStripMenuItem.Name = "ResearchToolStripMenuItem"
        Me.ResearchToolStripMenuItem.Size = New System.Drawing.Size(85, 25)
        Me.ResearchToolStripMenuItem.Text = "Research"
        '
        'OnThisDateToolStripMenuItem
        '
        Me.OnThisDateToolStripMenuItem.Name = "OnThisDateToolStripMenuItem"
        Me.OnThisDateToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.OnThisDateToolStripMenuItem.Text = "On This Date"
        '
        'FamilySearchToolStripMenuItem
        '
        Me.FamilySearchToolStripMenuItem.Name = "FamilySearchToolStripMenuItem"
        Me.FamilySearchToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.FamilySearchToolStripMenuItem.Text = "Family Search"
        '
        'TimerMain
        '
        Me.TimerMain.Enabled = True
        '
        'LblTimer
        '
        Me.LblTimer.BackColor = System.Drawing.Color.Bisque
        Me.LblTimer.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimer.Location = New System.Drawing.Point(744, -3)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(403, 32)
        Me.LblTimer.TabIndex = 0
        Me.LblTimer.Text = "Timer"
        Me.LblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblCurrentBiography
        '
        Me.LblCurrentBiography.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrentBiography.ForeColor = System.Drawing.Color.Black
        Me.LblCurrentBiography.Location = New System.Drawing.Point(109, 51)
        Me.LblCurrentBiography.Name = "LblCurrentBiography"
        Me.LblCurrentBiography.Size = New System.Drawing.Size(381, 32)
        Me.LblCurrentBiography.TabIndex = 2
        Me.LblCurrentBiography.Text = "View Area"
        Me.LblCurrentBiography.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RtxBiography
        '
        Me.RtxBiography.AcceptsTab = True
        Me.RtxBiography.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.RtxBiography.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.RtxBiography.ContextMenuStrip = Me.ContextMenuStrip1
        Me.RtxBiography.ForeColor = System.Drawing.Color.White
        Me.RtxBiography.Location = New System.Drawing.Point(16, 56)
        Me.RtxBiography.Name = "RtxBiography"
        Me.RtxBiography.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.RtxBiography.Size = New System.Drawing.Size(756, 755)
        Me.RtxBiography.TabIndex = 7
        Me.RtxBiography.Text = ""
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem1, Me.CutToolStripMenuItem1, Me.PasteToolStripMenuItem1, Me.SelectAllToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(123, 92)
        '
        'CopyToolStripMenuItem1
        '
        Me.CopyToolStripMenuItem1.Name = "CopyToolStripMenuItem1"
        Me.CopyToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.CopyToolStripMenuItem1.Text = "Copy"
        '
        'CutToolStripMenuItem1
        '
        Me.CutToolStripMenuItem1.Name = "CutToolStripMenuItem1"
        Me.CutToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.CutToolStripMenuItem1.Text = "Cut"
        '
        'PasteToolStripMenuItem1
        '
        Me.PasteToolStripMenuItem1.Name = "PasteToolStripMenuItem1"
        Me.PasteToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.PasteToolStripMenuItem1.Text = "Paste"
        '
        'SelectAllToolStripMenuItem1
        '
        Me.SelectAllToolStripMenuItem1.Name = "SelectAllToolStripMenuItem1"
        Me.SelectAllToolStripMenuItem1.Size = New System.Drawing.Size(122, 22)
        Me.SelectAllToolStripMenuItem1.Text = "Select All"
        '
        'TxtFacts
        '
        Me.TxtFacts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtFacts.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TxtFacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtFacts.ForeColor = System.Drawing.Color.White
        Me.TxtFacts.Location = New System.Drawing.Point(18, 57)
        Me.TxtFacts.Multiline = True
        Me.TxtFacts.Name = "TxtFacts"
        Me.TxtFacts.ReadOnly = True
        Me.TxtFacts.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TxtFacts.Size = New System.Drawing.Size(532, 755)
        Me.TxtFacts.TabIndex = 8
        '
        'PnlEditor
        '
        Me.PnlEditor.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlEditor.BackColor = System.Drawing.Color.OldLace
        Me.PnlEditor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlEditor.Controls.Add(Me.MnuEditor)
        Me.PnlEditor.Controls.Add(Me.RtxBiography)
        Me.PnlEditor.Location = New System.Drawing.Point(584, 97)
        Me.PnlEditor.Name = "PnlEditor"
        Me.PnlEditor.Size = New System.Drawing.Size(789, 828)
        Me.PnlEditor.TabIndex = 9
        '
        'MnuEditor
        '
        Me.MnuEditor.BackColor = System.Drawing.Color.Bisque
        Me.MnuEditor.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MnuEditor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.FormatToolStripMenuItem})
        Me.MnuEditor.Location = New System.Drawing.Point(0, 0)
        Me.MnuEditor.Name = "MnuEditor"
        Me.MnuEditor.Size = New System.Drawing.Size(787, 29)
        Me.MnuEditor.TabIndex = 0
        Me.MnuEditor.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem1, Me.OpenToolStripMenuItem1, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 25)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem1
        '
        Me.NewToolStripMenuItem1.Enabled = False
        Me.NewToolStripMenuItem1.Name = "NewToolStripMenuItem1"
        Me.NewToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NewToolStripMenuItem1.Size = New System.Drawing.Size(176, 26)
        Me.NewToolStripMenuItem1.Text = "New"
        '
        'OpenToolStripMenuItem1
        '
        Me.OpenToolStripMenuItem1.Name = "OpenToolStripMenuItem1"
        Me.OpenToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem1.Size = New System.Drawing.Size(176, 26)
        Me.OpenToolStripMenuItem1.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(176, 26)
        Me.SaveAsToolStripMenuItem.Text = "Save as"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UndoToolStripMenuItem, Me.RedoToolStripMenuItem, Me.ToolStripSeparator2, Me.CopyToolStripMenuItem, Me.CutToolStripMenuItem, Me.PasteToolStripMenuItem, Me.ToolStripSeparator3, Me.DeleteToolStripMenuItem, Me.SelectAllToolStripMenuItem, Me.ToolStripSeparator4, Me.TimeDateToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(48, 25)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'UndoToolStripMenuItem
        '
        Me.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        Me.UndoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.UndoToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.UndoToolStripMenuItem.Text = "Undo"
        '
        'RedoToolStripMenuItem
        '
        Me.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        Me.RedoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.RedoToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.RedoToolStripMenuItem.Text = "Redo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(204, 6)
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'CutToolStripMenuItem
        '
        Me.CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        Me.CutToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.CutToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.CutToolStripMenuItem.Text = "Cut"
        '
        'PasteToolStripMenuItem
        '
        Me.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        Me.PasteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.PasteToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.PasteToolStripMenuItem.Text = "Paste"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(204, 6)
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'SelectAllToolStripMenuItem
        '
        Me.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        Me.SelectAllToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.SelectAllToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.SelectAllToolStripMenuItem.Text = "Select All"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(204, 6)
        '
        'TimeDateToolStripMenuItem
        '
        Me.TimeDateToolStripMenuItem.Name = "TimeDateToolStripMenuItem"
        Me.TimeDateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.TimeDateToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.TimeDateToolStripMenuItem.Text = "Time and Date"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(72, 25)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(111, 26)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'BtnSearch
        '
        Me.BtnSearch.BackColor = System.Drawing.Color.Bisque
        Me.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSearch.Location = New System.Drawing.Point(1824, 0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(74, 29)
        Me.BtnSearch.TabIndex = 10
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = False
        '
        'TxbSearch
        '
        Me.TxbSearch.BackColor = System.Drawing.Color.OldLace
        Me.TxbSearch.ForeColor = System.Drawing.Color.Black
        Me.TxbSearch.Location = New System.Drawing.Point(1392, 1)
        Me.TxbSearch.Name = "TxbSearch"
        Me.TxbSearch.Size = New System.Drawing.Size(426, 26)
        Me.TxbSearch.TabIndex = 11
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblSelectedBiography
        '
        Me.lblSelectedBiography.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSelectedBiography.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblSelectedBiography.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedBiography.Location = New System.Drawing.Point(1499, 53)
        Me.lblSelectedBiography.Name = "lblSelectedBiography"
        Me.lblSelectedBiography.Size = New System.Drawing.Size(292, 29)
        Me.lblSelectedBiography.TabIndex = 13
        Me.lblSelectedBiography.Text = "Catagory Area"
        Me.lblSelectedBiography.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlSelectView
        '
        Me.PnlSelectView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlSelectView.BackColor = System.Drawing.Color.OldLace
        Me.PnlSelectView.Controls.Add(Me.LblBiography)
        Me.PnlSelectView.Controls.Add(Me.BtnSelectView)
        Me.PnlSelectView.Controls.Add(Me.TxtFacts)
        Me.PnlSelectView.Location = New System.Drawing.Point(18, 97)
        Me.PnlSelectView.Name = "PnlSelectView"
        Me.PnlSelectView.Size = New System.Drawing.Size(550, 828)
        Me.PnlSelectView.TabIndex = 16
        '
        'LblBiography
        '
        Me.LblBiography.Location = New System.Drawing.Point(18, 34)
        Me.LblBiography.Name = "LblBiography"
        Me.LblBiography.Size = New System.Drawing.Size(514, 19)
        Me.LblBiography.TabIndex = 27
        Me.LblBiography.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnSelectView
        '
        Me.BtnSelectView.BackColor = System.Drawing.Color.Bisque
        Me.BtnSelectView.Location = New System.Drawing.Point(18, 3)
        Me.BtnSelectView.Name = "BtnSelectView"
        Me.BtnSelectView.Size = New System.Drawing.Size(514, 28)
        Me.BtnSelectView.TabIndex = 26
        Me.BtnSelectView.Text = "Select View"
        Me.BtnSelectView.UseVisualStyleBackColor = False
        '
        'PnlBiography
        '
        Me.PnlBiography.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PnlBiography.BackColor = System.Drawing.Color.OldLace
        Me.PnlBiography.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlBiography.Controls.Add(Me.TxtEvents)
        Me.PnlBiography.Controls.Add(Me.LblCategory)
        Me.PnlBiography.Controls.Add(Me.MenuStrip1)
        Me.PnlBiography.Location = New System.Drawing.Point(1382, 98)
        Me.PnlBiography.Name = "PnlBiography"
        Me.PnlBiography.Size = New System.Drawing.Size(519, 828)
        Me.PnlBiography.TabIndex = 17
        '
        'TxtEvents
        '
        Me.TxtEvents.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtEvents.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.TxtEvents.ForeColor = System.Drawing.Color.White
        Me.TxtEvents.Location = New System.Drawing.Point(19, 55)
        Me.TxtEvents.Multiline = True
        Me.TxtEvents.Name = "TxtEvents"
        Me.TxtEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtEvents.Size = New System.Drawing.Size(486, 755)
        Me.TxtEvents.TabIndex = 21
        '
        'LblCategory
        '
        Me.LblCategory.Location = New System.Drawing.Point(172, 32)
        Me.LblCategory.Name = "LblCategory"
        Me.LblCategory.Size = New System.Drawing.Size(181, 20)
        Me.LblCategory.TabIndex = 20
        Me.LblCategory.Text = "No Category Selected"
        Me.LblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Bisque
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatagoryToolStripMenuItem, Me.EventsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(517, 29)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "Catagory"
        '
        'CatagoryToolStripMenuItem
        '
        Me.CatagoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectToolStripMenuItem1, Me.AddToolStripMenuItem2, Me.RenameToolStripMenuItem, Me.DeleteToolStripMenuItem2})
        Me.CatagoryToolStripMenuItem.Name = "CatagoryToolStripMenuItem"
        Me.CatagoryToolStripMenuItem.Size = New System.Drawing.Size(85, 25)
        Me.CatagoryToolStripMenuItem.Text = "Catagory"
        '
        'SelectToolStripMenuItem1
        '
        Me.SelectToolStripMenuItem1.Name = "SelectToolStripMenuItem1"
        Me.SelectToolStripMenuItem1.Size = New System.Drawing.Size(137, 26)
        Me.SelectToolStripMenuItem1.Text = "Select"
        '
        'AddToolStripMenuItem2
        '
        Me.AddToolStripMenuItem2.Name = "AddToolStripMenuItem2"
        Me.AddToolStripMenuItem2.Size = New System.Drawing.Size(137, 26)
        Me.AddToolStripMenuItem2.Text = "Add"
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(137, 26)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'DeleteToolStripMenuItem2
        '
        Me.DeleteToolStripMenuItem2.Name = "DeleteToolStripMenuItem2"
        Me.DeleteToolStripMenuItem2.Size = New System.Drawing.Size(137, 26)
        Me.DeleteToolStripMenuItem2.Text = "Delete"
        '
        'EventsToolStripMenuItem
        '
        Me.EventsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem1, Me.EditToolStripMenuItem2, Me.DeleteToolStripMenuItem3})
        Me.EventsToolStripMenuItem.Enabled = False
        Me.EventsToolStripMenuItem.Name = "EventsToolStripMenuItem"
        Me.EventsToolStripMenuItem.Size = New System.Drawing.Size(67, 25)
        Me.EventsToolStripMenuItem.Text = "Events"
        '
        'AddToolStripMenuItem1
        '
        Me.AddToolStripMenuItem1.Name = "AddToolStripMenuItem1"
        Me.AddToolStripMenuItem1.Size = New System.Drawing.Size(124, 26)
        Me.AddToolStripMenuItem1.Text = "Add"
        '
        'EditToolStripMenuItem2
        '
        Me.EditToolStripMenuItem2.Name = "EditToolStripMenuItem2"
        Me.EditToolStripMenuItem2.Size = New System.Drawing.Size(124, 26)
        Me.EditToolStripMenuItem2.Text = "Edit"
        '
        'DeleteToolStripMenuItem3
        '
        Me.DeleteToolStripMenuItem3.Name = "DeleteToolStripMenuItem3"
        Me.DeleteToolStripMenuItem3.Size = New System.Drawing.Size(124, 26)
        Me.DeleteToolStripMenuItem3.Text = "Delete"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Copperplate Gothic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(878, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(152, 18)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Biography Area"
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.ClientSize = New System.Drawing.Size(1910, 937)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblSelectedBiography)
        Me.Controls.Add(Me.PnlBiography)
        Me.Controls.Add(Me.PnlSelectView)
        Me.Controls.Add(Me.TxbSearch)
        Me.Controls.Add(Me.BtnSearch)
        Me.Controls.Add(Me.PnlEditor)
        Me.Controls.Add(Me.LblCurrentBiography)
        Me.Controls.Add(Me.LblTimer)
        Me.Controls.Add(Me.MnuMain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MnuMain
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(1918, 928)
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Biography Generator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MnuMain.ResumeLayout(False)
        Me.MnuMain.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.PnlEditor.ResumeLayout(False)
        Me.PnlEditor.PerformLayout()
        Me.MnuEditor.ResumeLayout(False)
        Me.MnuEditor.PerformLayout()
        Me.PnlSelectView.ResumeLayout(False)
        Me.PnlSelectView.PerformLayout()
        Me.PnlBiography.ResumeLayout(False)
        Me.PnlBiography.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MnuMain As MenuStrip
    Friend WithEvents TimerMain As Timer
    Friend WithEvents LblTimer As Label
    Friend WithEvents LblCurrentBiography As Label
    Friend WithEvents BiographyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FactoryResetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RtxBiography As RichTextBox
    Friend WithEvents TxtFacts As TextBox
    Friend WithEvents PnlEditor As Panel
    Friend WithEvents MnuEditor As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxbSearch As TextBox
    Friend WithEvents NewToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents TimeDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CopyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents lblSelectedBiography As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents PnlSelectView As Panel
    Friend WithEvents PnlBiography As Panel
    Friend WithEvents ResearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OnThisDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FamilySearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnSelectView As Button
    Friend WithEvents BiographyToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatagoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents LblCategory As Label
    Friend WithEvents SelectToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TxtEvents As TextBox
    Friend WithEvents RenameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblBiography As Label
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem2 As ToolStripMenuItem
End Class
