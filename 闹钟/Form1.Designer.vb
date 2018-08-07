<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.程序控制ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.新闹钟ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.打开闹钟配置文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.保存闹钟配置文件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.闹钟控制ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.启用闹钟ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.所有闹钟ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.选中的闹钟ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.停用闹钟ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.所有闹钟ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.选中的闹钟ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除闹钟ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.所有闹钟ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.选中的闹钟ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.帮助ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.关于ToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.关于本软件ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.反馈ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.获取更多ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.音乐播放器ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.计时器ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.启用此闹钟ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.停用此闹钟ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.删除此闹钟ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.显示主程序ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(492, 111)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "正在获取时间"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.程序控制ToolStripMenuItem, Me.闹钟控制ToolStripMenuItem, Me.帮助ToolStripMenuItem, Me.获取更多ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(602, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '程序控制ToolStripMenuItem
        '
        Me.程序控制ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.新闹钟ToolStripMenuItem, Me.打开闹钟配置文件ToolStripMenuItem, Me.保存闹钟配置文件ToolStripMenuItem, Me.ToolStripMenuItem4, Me.退出ToolStripMenuItem, Me.退出ToolStripMenuItem1})
        Me.程序控制ToolStripMenuItem.Name = "程序控制ToolStripMenuItem"
        Me.程序控制ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.程序控制ToolStripMenuItem.Text = "程序"
        '
        '新闹钟ToolStripMenuItem
        '
        Me.新闹钟ToolStripMenuItem.Name = "新闹钟ToolStripMenuItem"
        Me.新闹钟ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.新闹钟ToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.新闹钟ToolStripMenuItem.Text = "新闹钟"
        '
        '打开闹钟配置文件ToolStripMenuItem
        '
        Me.打开闹钟配置文件ToolStripMenuItem.Name = "打开闹钟配置文件ToolStripMenuItem"
        Me.打开闹钟配置文件ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.打开闹钟配置文件ToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.打开闹钟配置文件ToolStripMenuItem.Text = "打开闹钟配置文件"
        '
        '保存闹钟配置文件ToolStripMenuItem
        '
        Me.保存闹钟配置文件ToolStripMenuItem.Name = "保存闹钟配置文件ToolStripMenuItem"
        Me.保存闹钟配置文件ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.保存闹钟配置文件ToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.保存闹钟配置文件ToolStripMenuItem.Text = "导出闹钟配置文件"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(216, 6)
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.退出ToolStripMenuItem.Text = "后台运行"
        '
        '退出ToolStripMenuItem1
        '
        Me.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1"
        Me.退出ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.退出ToolStripMenuItem1.Size = New System.Drawing.Size(219, 22)
        Me.退出ToolStripMenuItem1.Text = "退出"
        '
        '闹钟控制ToolStripMenuItem
        '
        Me.闹钟控制ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.启用闹钟ToolStripMenuItem, Me.停用闹钟ToolStripMenuItem, Me.删除闹钟ToolStripMenuItem})
        Me.闹钟控制ToolStripMenuItem.Name = "闹钟控制ToolStripMenuItem"
        Me.闹钟控制ToolStripMenuItem.Size = New System.Drawing.Size(68, 21)
        Me.闹钟控制ToolStripMenuItem.Text = "闹钟控制"
        '
        '启用闹钟ToolStripMenuItem
        '
        Me.启用闹钟ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.所有闹钟ToolStripMenuItem, Me.ToolStripMenuItem1, Me.选中的闹钟ToolStripMenuItem})
        Me.启用闹钟ToolStripMenuItem.Name = "启用闹钟ToolStripMenuItem"
        Me.启用闹钟ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.启用闹钟ToolStripMenuItem.Text = "启用闹钟"
        '
        '所有闹钟ToolStripMenuItem
        '
        Me.所有闹钟ToolStripMenuItem.Name = "所有闹钟ToolStripMenuItem"
        Me.所有闹钟ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.所有闹钟ToolStripMenuItem.Text = "所有闹钟"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(133, 6)
        '
        '选中的闹钟ToolStripMenuItem
        '
        Me.选中的闹钟ToolStripMenuItem.Name = "选中的闹钟ToolStripMenuItem"
        Me.选中的闹钟ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.选中的闹钟ToolStripMenuItem.Text = "选中的闹钟"
        '
        '停用闹钟ToolStripMenuItem
        '
        Me.停用闹钟ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.所有闹钟ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.选中的闹钟ToolStripMenuItem1})
        Me.停用闹钟ToolStripMenuItem.Name = "停用闹钟ToolStripMenuItem"
        Me.停用闹钟ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.停用闹钟ToolStripMenuItem.Text = "停用闹钟"
        '
        '所有闹钟ToolStripMenuItem1
        '
        Me.所有闹钟ToolStripMenuItem1.Name = "所有闹钟ToolStripMenuItem1"
        Me.所有闹钟ToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.所有闹钟ToolStripMenuItem1.Text = "所有闹钟"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(133, 6)
        '
        '选中的闹钟ToolStripMenuItem1
        '
        Me.选中的闹钟ToolStripMenuItem1.Name = "选中的闹钟ToolStripMenuItem1"
        Me.选中的闹钟ToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.选中的闹钟ToolStripMenuItem1.Text = "选中的闹钟"
        '
        '删除闹钟ToolStripMenuItem
        '
        Me.删除闹钟ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.所有闹钟ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.选中的闹钟ToolStripMenuItem2})
        Me.删除闹钟ToolStripMenuItem.Name = "删除闹钟ToolStripMenuItem"
        Me.删除闹钟ToolStripMenuItem.Size = New System.Drawing.Size(124, 22)
        Me.删除闹钟ToolStripMenuItem.Text = "删除闹钟"
        '
        '所有闹钟ToolStripMenuItem2
        '
        Me.所有闹钟ToolStripMenuItem2.Name = "所有闹钟ToolStripMenuItem2"
        Me.所有闹钟ToolStripMenuItem2.Size = New System.Drawing.Size(136, 22)
        Me.所有闹钟ToolStripMenuItem2.Text = "所有闹钟"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(133, 6)
        '
        '选中的闹钟ToolStripMenuItem2
        '
        Me.选中的闹钟ToolStripMenuItem2.Name = "选中的闹钟ToolStripMenuItem2"
        Me.选中的闹钟ToolStripMenuItem2.Size = New System.Drawing.Size(136, 22)
        Me.选中的闹钟ToolStripMenuItem2.Text = "选中的闹钟"
        '
        '帮助ToolStripMenuItem
        '
        Me.帮助ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.帮助ToolStripMenuItem1, Me.关于ToolStripMenuItem, Me.关于本软件ToolStripMenuItem, Me.反馈ToolStripMenuItem})
        Me.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem"
        Me.帮助ToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.帮助ToolStripMenuItem.Text = "帮助"
        '
        '帮助ToolStripMenuItem1
        '
        Me.帮助ToolStripMenuItem1.Name = "帮助ToolStripMenuItem1"
        Me.帮助ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.帮助ToolStripMenuItem1.Size = New System.Drawing.Size(181, 22)
        Me.帮助ToolStripMenuItem1.Text = "查看帮助"
        '
        '关于ToolStripMenuItem
        '
        Me.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem"
        Me.关于ToolStripMenuItem.Size = New System.Drawing.Size(178, 6)
        '
        '关于本软件ToolStripMenuItem
        '
        Me.关于本软件ToolStripMenuItem.Name = "关于本软件ToolStripMenuItem"
        Me.关于本软件ToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.关于本软件ToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.关于本软件ToolStripMenuItem.Text = "关于本软件"
        '
        '反馈ToolStripMenuItem
        '
        Me.反馈ToolStripMenuItem.Name = "反馈ToolStripMenuItem"
        Me.反馈ToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.反馈ToolStripMenuItem.Text = "反馈"
        '
        '获取更多ToolStripMenuItem
        '
        Me.获取更多ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.音乐播放器ToolStripMenuItem, Me.计时器ToolStripMenuItem})
        Me.获取更多ToolStripMenuItem.Name = "获取更多ToolStripMenuItem"
        Me.获取更多ToolStripMenuItem.Size = New System.Drawing.Size(213, 21)
        Me.获取更多ToolStripMenuItem.Text = "获取更多LSX's Software的实用软件"
        '
        '音乐播放器ToolStripMenuItem
        '
        Me.音乐播放器ToolStripMenuItem.Name = "音乐播放器ToolStripMenuItem"
        Me.音乐播放器ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.音乐播放器ToolStripMenuItem.Text = "音乐播放器"
        '
        '计时器ToolStripMenuItem
        '
        Me.计时器ToolStripMenuItem.Name = "计时器ToolStripMenuItem"
        Me.计时器ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.计时器ToolStripMenuItem.Text = "计时器"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 340)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(602, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(92, 17)
        Me.ToolStripStatusLabel1.Text = "开启的闹钟：个"
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 500
        '
        'ListView1
        '
        Me.ListView1.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.ListView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView1.CheckBoxes = True
        Me.ListView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView1.Font = New System.Drawing.Font("微软雅黑", 14.0!)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.LabelWrap = False
        Me.ListView1.Location = New System.Drawing.Point(0, 136)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.ShowGroups = False
        Me.ListView1.Size = New System.Drawing.Size(602, 204)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.启用此闹钟ToolStripMenuItem, Me.停用此闹钟ToolStripMenuItem, Me.删除此闹钟ToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(137, 70)
        '
        '启用此闹钟ToolStripMenuItem
        '
        Me.启用此闹钟ToolStripMenuItem.Name = "启用此闹钟ToolStripMenuItem"
        Me.启用此闹钟ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.启用此闹钟ToolStripMenuItem.Text = "启用此闹钟"
        '
        '停用此闹钟ToolStripMenuItem
        '
        Me.停用此闹钟ToolStripMenuItem.Name = "停用此闹钟ToolStripMenuItem"
        Me.停用此闹钟ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.停用此闹钟ToolStripMenuItem.Text = "停用此闹钟"
        '
        '删除此闹钟ToolStripMenuItem
        '
        Me.删除此闹钟ToolStripMenuItem.Name = "删除此闹钟ToolStripMenuItem"
        Me.删除此闹钟ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.删除此闹钟ToolStripMenuItem.Text = "删除此闹钟"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(602, 111)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(110, 111)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "闹钟程序已隐藏在此"
        Me.NotifyIcon1.BalloonTipTitle = "闹钟程序"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip2
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "闹钟"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.显示主程序ToolStripMenuItem, Me.退出ToolStripMenuItem2})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(137, 48)
        '
        '显示主程序ToolStripMenuItem
        '
        Me.显示主程序ToolStripMenuItem.Name = "显示主程序ToolStripMenuItem"
        Me.显示主程序ToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.显示主程序ToolStripMenuItem.Text = "显示主程序"
        '
        '退出ToolStripMenuItem2
        '
        Me.退出ToolStripMenuItem2.Name = "退出ToolStripMenuItem2"
        Me.退出ToolStripMenuItem2.Size = New System.Drawing.Size(136, 22)
        Me.退出ToolStripMenuItem2.Text = "退出"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "闹钟配置文件|*.clock"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "闹钟配置文件|*.clock"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 362)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "闹钟"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 程序控制ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 新闹钟ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 闹钟控制ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 启用闹钟ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 所有闹钟ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents 停用闹钟ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 所有闹钟ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents 帮助ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 帮助ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 关于ToolStripMenuItem As ToolStripSeparator
    Friend WithEvents 关于本软件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 删除闹钟ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 所有闹钟ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents 退出ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents Timer2 As Timer
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents 选中的闹钟ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 选中的闹钟ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents 选中的闹钟ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents 启用此闹钟ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 删除此闹钟ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 停用此闹钟ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents 显示主程序ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents 获取更多ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 音乐播放器ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 计时器ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 打开闹钟配置文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 保存闹钟配置文件ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents 反馈ToolStripMenuItem As ToolStripMenuItem
End Class
