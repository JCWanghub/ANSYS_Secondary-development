<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class 主界面Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(主界面Form))
        Me.后台计算button = New System.Windows.Forms.Button()
        Me.Tab图 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.启动Button = New System.Windows.Forms.Button()
        Me.工作设置Button = New System.Windows.Forms.Button()
        Me.ansys启动程序 = New System.Windows.Forms.TextBox()
        Me.工作目录 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.项目名称 = New System.Windows.Forms.TextBox()
        Me.帮助Button = New System.Windows.Forms.Button()
        Me.读取结果Button = New System.Windows.Forms.Button()
        Me.初始化Button = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Current1 = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Resistivity1 = New System.Windows.Forms.TextBox()
        Me.Resistivity5 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Resistivity7 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Resistivity2 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Resistivity4 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Resistivity6 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Resistivity8 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Resistivity3 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.生成报告Button = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Tab图.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        '后台计算button
        '
        Me.后台计算button.Location = New System.Drawing.Point(10, 399)
        Me.后台计算button.Name = "后台计算button"
        Me.后台计算button.Size = New System.Drawing.Size(83, 25)
        Me.后台计算button.TabIndex = 8
        Me.后台计算button.Text = "后台计算"
        Me.后台计算button.UseVisualStyleBackColor = True
        '
        'Tab图
        '
        Me.Tab图.Controls.Add(Me.TabPage1)
        Me.Tab图.Controls.Add(Me.TabPage2)
        Me.Tab图.Controls.Add(Me.TabPage3)
        Me.Tab图.Controls.Add(Me.TabPage4)
        Me.Tab图.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tab图.Location = New System.Drawing.Point(325, 11)
        Me.Tab图.Name = "Tab图"
        Me.Tab图.SelectedIndex = 0
        Me.Tab图.Size = New System.Drawing.Size(655, 515)
        Me.Tab图.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(647, 489)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "示意图"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(635, 477)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.PictureBox2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(647, 489)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "建模"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(635, 477)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PictureBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(647, 489)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "划分网格"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(635, 477)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 0
        Me.PictureBox3.TabStop = False
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.PictureBox4)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(647, 489)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "云图"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(635, 477)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 0
        Me.PictureBox4.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.启动Button)
        Me.GroupBox2.Controls.Add(Me.工作设置Button)
        Me.GroupBox2.Controls.Add(Me.ansys启动程序)
        Me.GroupBox2.Controls.Add(Me.工作目录)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.项目名称)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 109)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "项目设置"
        '
        '启动Button
        '
        Me.启动Button.Location = New System.Drawing.Point(256, 70)
        Me.启动Button.Name = "启动Button"
        Me.启动Button.Size = New System.Drawing.Size(31, 23)
        Me.启动Button.TabIndex = 14
        Me.启动Button.Text = "..."
        Me.启动Button.UseVisualStyleBackColor = True
        '
        '工作设置Button
        '
        Me.工作设置Button.Location = New System.Drawing.Point(256, 43)
        Me.工作设置Button.Name = "工作设置Button"
        Me.工作设置Button.Size = New System.Drawing.Size(31, 23)
        Me.工作设置Button.TabIndex = 34
        Me.工作设置Button.Text = "..."
        Me.工作设置Button.UseVisualStyleBackColor = True
        '
        'ansys启动程序
        '
        Me.ansys启动程序.Location = New System.Drawing.Point(68, 71)
        Me.ansys启动程序.Name = "ansys启动程序"
        Me.ansys启动程序.Size = New System.Drawing.Size(182, 21)
        Me.ansys启动程序.TabIndex = 2
        Me.ansys启动程序.Text = "C:\Program Files\ANSYS Inc\v192\ansys\bin\winx64\MAPDL.exe"
        '
        '工作目录
        '
        Me.工作目录.Location = New System.Drawing.Point(68, 45)
        Me.工作目录.Name = "工作目录"
        Me.工作目录.Size = New System.Drawing.Size(182, 21)
        Me.工作目录.TabIndex = 33
        Me.工作目录.Text = "D:\ansys_re\test"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 12)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "项目名称"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 12)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "ansys路径"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "工作目录"
        '
        '项目名称
        '
        Me.项目名称.Location = New System.Drawing.Point(68, 19)
        Me.项目名称.Name = "项目名称"
        Me.项目名称.Size = New System.Drawing.Size(219, 21)
        Me.项目名称.TabIndex = 28
        Me.项目名称.Text = "ansys开发"
        '
        '帮助Button
        '
        Me.帮助Button.Location = New System.Drawing.Point(167, 440)
        Me.帮助Button.Name = "帮助Button"
        Me.帮助Button.Size = New System.Drawing.Size(146, 25)
        Me.帮助Button.TabIndex = 8
        Me.帮助Button.Text = "帮助"
        Me.帮助Button.UseVisualStyleBackColor = True
        '
        '读取结果Button
        '
        Me.读取结果Button.Location = New System.Drawing.Point(113, 399)
        Me.读取结果Button.Name = "读取结果Button"
        Me.读取结果Button.Size = New System.Drawing.Size(91, 25)
        Me.读取结果Button.TabIndex = 35
        Me.读取结果Button.Text = "读取结果"
        Me.读取结果Button.UseVisualStyleBackColor = True
        '
        '初始化Button
        '
        Me.初始化Button.Location = New System.Drawing.Point(9, 440)
        Me.初始化Button.Name = "初始化Button"
        Me.初始化Button.Size = New System.Drawing.Size(146, 25)
        Me.初始化Button.TabIndex = 8
        Me.初始化Button.Text = "初始化"
        Me.初始化Button.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox3.Controls.Add(Me.Label35)
        Me.GroupBox3.Controls.Add(Me.Current1)
        Me.GroupBox3.Controls.Add(Me.Label34)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 142)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(301, 68)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "电场参数"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(127, 19)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(11, 12)
        Me.Label35.TabIndex = 25
        Me.Label35.Text = "A"
        '
        'Current1
        '
        Me.Current1.Location = New System.Drawing.Point(70, 15)
        Me.Current1.Name = "Current1"
        Me.Current1.Size = New System.Drawing.Size(51, 21)
        Me.Current1.TabIndex = 24
        Me.Current1.Text = "3.00e5"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(12, 19)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(53, 12)
        Me.Label34.TabIndex = 23
        Me.Label34.Text = "电流强度"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Resistivity1)
        Me.GroupBox4.Controls.Add(Me.Resistivity5)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Resistivity7)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Resistivity2)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Resistivity4)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Resistivity6)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.Resistivity8)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Resistivity3)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label33)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label32)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.Label31)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.Label30)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 229)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(301, 134)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "电阻率"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "阳极导杆"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(151, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 12)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "熔体区"
        '
        'Resistivity1
        '
        Me.Resistivity1.Location = New System.Drawing.Point(63, 19)
        Me.Resistivity1.Name = "Resistivity1"
        Me.Resistivity1.Size = New System.Drawing.Size(51, 21)
        Me.Resistivity1.TabIndex = 2
        Me.Resistivity1.Text = "2.34e-7"
        '
        'Resistivity5
        '
        Me.Resistivity5.Location = New System.Drawing.Point(63, 77)
        Me.Resistivity5.Name = "Resistivity5"
        Me.Resistivity5.Size = New System.Drawing.Size(51, 21)
        Me.Resistivity5.TabIndex = 22
        Me.Resistivity5.Text = "2.45e-5"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(9, 81)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(53, 12)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "阴极炭块"
        '
        'Resistivity7
        '
        Me.Resistivity7.Location = New System.Drawing.Point(63, 106)
        Me.Resistivity7.Name = "Resistivity7"
        Me.Resistivity7.Size = New System.Drawing.Size(51, 21)
        Me.Resistivity7.TabIndex = 21
        Me.Resistivity7.Text = "4.78e-7"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(118, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 12)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Ω•m"
        '
        'Resistivity2
        '
        Me.Resistivity2.Location = New System.Drawing.Point(196, 19)
        Me.Resistivity2.Name = "Resistivity2"
        Me.Resistivity2.Size = New System.Drawing.Size(51, 21)
        Me.Resistivity2.TabIndex = 20
        Me.Resistivity2.Text = "5.52e-5"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 12)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "阳极炭块"
        '
        'Resistivity4
        '
        Me.Resistivity4.Location = New System.Drawing.Point(196, 48)
        Me.Resistivity4.Name = "Resistivity4"
        Me.Resistivity4.Size = New System.Drawing.Size(51, 21)
        Me.Resistivity4.TabIndex = 19
        Me.Resistivity4.Text = "1.20e-3"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(151, 81)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 12)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "钢棒糊"
        '
        'Resistivity6
        '
        Me.Resistivity6.Location = New System.Drawing.Point(196, 77)
        Me.Resistivity6.Name = "Resistivity6"
        Me.Resistivity6.Size = New System.Drawing.Size(51, 21)
        Me.Resistivity6.TabIndex = 18
        Me.Resistivity6.Text = "5.65e-6"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(151, 52)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(29, 12)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "槽帮"
        '
        'Resistivity8
        '
        Me.Resistivity8.Location = New System.Drawing.Point(196, 106)
        Me.Resistivity8.Name = "Resistivity8"
        Me.Resistivity8.Size = New System.Drawing.Size(51, 21)
        Me.Resistivity8.TabIndex = 17
        Me.Resistivity8.Text = "5.00e10"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(151, 110)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(29, 12)
        Me.Label24.TabIndex = 7
        Me.Label24.Text = "内衬"
        '
        'Resistivity3
        '
        Me.Resistivity3.Location = New System.Drawing.Point(63, 48)
        Me.Resistivity3.Name = "Resistivity3"
        Me.Resistivity3.Size = New System.Drawing.Size(51, 21)
        Me.Resistivity3.TabIndex = 16
        Me.Resistivity3.Text = "4.55e-5"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(9, 110)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(53, 12)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "阴极钢棒"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(118, 81)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(29, 12)
        Me.Label33.TabIndex = 15
        Me.Label33.Text = "Ω•m"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(118, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 12)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "Ω•m"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(251, 23)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(29, 12)
        Me.Label32.TabIndex = 14
        Me.Label32.Text = "Ω•m"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(118, 110)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(29, 12)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "Ω•m"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(251, 52)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(29, 12)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "Ω•m"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(251, 110)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(29, 12)
        Me.Label27.TabIndex = 11
        Me.Label27.Text = "Ω•m"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(251, 81)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(29, 12)
        Me.Label30.TabIndex = 12
        Me.Label30.Text = "Ω•m"
        '
        '生成报告Button
        '
        Me.生成报告Button.Location = New System.Drawing.Point(231, 399)
        Me.生成报告Button.Name = "生成报告Button"
        Me.生成报告Button.Size = New System.Drawing.Size(82, 25)
        Me.生成报告Button.TabIndex = 5
        Me.生成报告Button.Text = "生成报告"
        Me.生成报告Button.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(10, 487)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(309, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "一键转换"
        Me.Button1.UseVisualStyleBackColor = True
        '
        '主界面Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 539)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.读取结果Button)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Tab图)
        Me.Controls.Add(Me.初始化Button)
        Me.Controls.Add(Me.帮助Button)
        Me.Controls.Add(Me.后台计算button)
        Me.Controls.Add(Me.生成报告Button)
        Me.MaximumSize = New System.Drawing.Size(1100, 600)
        Me.Name = "主界面Form"
        Me.Text = "Ansys电压仿真程序"
        Me.Tab图.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents 后台计算button As Button
    Friend WithEvents Tab图 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ansys启动程序 As TextBox
    Friend WithEvents 工作目录 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents 帮助Button As Button
    Friend WithEvents 工作设置Button As Button
    Friend WithEvents 启动Button As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents 项目名称 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents 读取结果Button As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents 初始化Button As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label35 As Label
    Friend WithEvents Current1 As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Resistivity1 As TextBox
    Friend WithEvents Resistivity5 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Resistivity7 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Resistivity2 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Resistivity4 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Resistivity6 As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Resistivity8 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents Resistivity3 As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents 生成报告Button As Button
    Friend WithEvents Button1 As Button
End Class
