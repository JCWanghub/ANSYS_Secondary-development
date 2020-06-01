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
        Me.求解button = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Tab图 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
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
        Me.显示Button = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Tab图.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        '求解button
        '
        Me.求解button.Location = New System.Drawing.Point(11, 497)
        Me.求解button.Name = "求解button"
        Me.求解button.Size = New System.Drawing.Size(143, 25)
        Me.求解button.TabIndex = 8
        Me.求解button.Text = "后台计算"
        Me.求解button.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label29)
        Me.GroupBox1.Controls.Add(Me.TextBox13)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(301, 187)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "工艺参数"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(213, 161)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 12)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "W/(m^2·℃)"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(213, 107)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 12)
        Me.Label20.TabIndex = 16
        Me.Label20.Text = "W/(m^2·℃)"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(211, 134)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(71, 12)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "W/(m^2·℃)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(213, 80)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 12)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "W/(m^2·℃)"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(166, 157)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(39, 21)
        Me.TextBox9.TabIndex = 13
        Me.TextBox9.Text = "25"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(166, 130)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(39, 21)
        Me.TextBox5.TabIndex = 12
        Me.TextBox5.Text = "10"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(166, 103)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(39, 21)
        Me.TextBox4.TabIndex = 11
        Me.TextBox4.Text = "20"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(166, 76)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(39, 21)
        Me.TextBox2.TabIndex = 10
        Me.TextBox2.Text = "10"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 161)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 12)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "炉顶与外界对流换热系数"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 12)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "炉底与外界对流换热系数"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 12)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "保温区与外界对流换热系数"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "钢棒区与外界对流换热系数"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(213, 53)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(71, 12)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "W/(m^2·℃)"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(166, 50)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(39, 21)
        Me.TextBox13.TabIndex = 4
        Me.TextBox13.Text = "20"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(9, 53)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(149, 12)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "熔体区与外界对流换热系数"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(213, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(48, 21)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "35"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(267, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(17, 12)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "℃"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(69, 20)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(51, 21)
        Me.TextBox3.TabIndex = 2
        Me.TextBox3.Text = "950"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(148, 23)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 12)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "环境温度"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(125, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 12)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "℃"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "熔体温度"
        '
        'Tab图
        '
        Me.Tab图.Controls.Add(Me.TabPage1)
        Me.Tab图.Controls.Add(Me.TabPage2)
        Me.Tab图.Controls.Add(Me.TabPage3)
        Me.Tab图.Cursor = System.Windows.Forms.Cursors.Default
        Me.Tab图.Location = New System.Drawing.Point(325, 12)
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
        Me.TabPage2.Text = "电压分布"
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
        Me.TabPage3.Text = "温度分布"
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
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.TextBox11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.TextBox6)
        Me.GroupBox3.Controls.Add(Me.TextBox8)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 337)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(301, 141)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "槽帮结构参数"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(129, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 12)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "mm"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 33)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 12)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "槽电压"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(59, 86)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(61, 21)
        Me.TextBox11.TabIndex = 2
        Me.TextBox11.Text = "180"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(132, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 12)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "mm"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(10, 89)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(41, 12)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "槽电阻"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(59, 30)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(62, 21)
        Me.TextBox6.TabIndex = 2
        Me.TextBox6.Text = "40"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(59, 60)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(61, 21)
        Me.TextBox8.TabIndex = 2
        Me.TextBox8.Text = "40"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 63)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 12)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "槽电阻"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(126, 63)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(17, 12)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "mm"
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
        Me.GroupBox2.Location = New System.Drawing.Point(12, 18)
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
        Me.ansys启动程序.Text = "D:\Program Files\ANSYS Inc\v191\ansys\bin\winx64\MAPDL.exe"
        '
        '工作目录
        '
        Me.工作目录.Location = New System.Drawing.Point(68, 45)
        Me.工作目录.Name = "工作目录"
        Me.工作目录.Size = New System.Drawing.Size(182, 21)
        Me.工作目录.TabIndex = 33
        Me.工作目录.Text = "D:\I\ansys\test"
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
        '显示Button
        '
        Me.显示Button.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.显示Button.Location = New System.Drawing.Point(167, 497)
        Me.显示Button.Name = "显示Button"
        Me.显示Button.Size = New System.Drawing.Size(146, 25)
        Me.显示Button.TabIndex = 35
        Me.显示Button.Text = "读取结果"
        Me.显示Button.UseVisualStyleBackColor = True
        '
        '主界面Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 537)
        Me.Controls.Add(Me.显示Button)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Tab图)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.求解button)
        Me.MaximumSize = New System.Drawing.Size(1003, 576)
        Me.Name = "主界面Form"
        Me.Text = "Ansys仿真程序"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Tab图.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents 求解button As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Tab图 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ansys启动程序 As TextBox
    Friend WithEvents 工作目录 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents 工作设置Button As Button
    Friend WithEvents 启动Button As Button
    Friend WithEvents 项目名称 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents 显示Button As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label11 As Label
End Class
