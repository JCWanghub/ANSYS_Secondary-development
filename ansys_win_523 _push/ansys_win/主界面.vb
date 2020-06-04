Imports Microsoft.Office.Core
Imports word = Microsoft.Office.Interop.Word
Public Class 主界面Form
    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub
    Private Sub 主界面Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        初始化Button.Enabled = False
        后台计算button.Enabled = True
        读取结果Button.Enabled = False
        生成报告Button.Enabled = False

    End Sub



    Private Sub Button5_Click(sender As Object, e As EventArgs)

        If System.IO.File.Exists(Me.工作目录.Text & "\ansys.txt") Then

            Dim input As Integer
            Dim output As Integer
            input = 1
            output = 2

            FileOpen(input, Me.工作目录.Text & "\ansys.txt", OpenMode.Input)
            FileOpen(output, Me.工作目录.Text & "\VB.txt", OpenMode.Output)

            Dim str As String
            str = ""
            Do While Not EOF(1)
                str = LineInput(input)
                PrintLine(output, "PrintLine (input,""" & str & """)")
            Loop

            MsgBox("转换完成，请插入VB代码")
            FileClose(input)

            FileClose(output)

        Else
            MsgBox("没有找到ansys.txt文件！")
        End If

    End Sub

    Private Sub 设置Button_Click(sender As Object, e As EventArgs) Handles 工作设置Button.Click
        后台计算button.Enabled = True


        Me.FolderBrowserDialog1.Description = "请选择工作目录："
        Me.FolderBrowserDialog1.SelectedPath = "c:\"
        If Me.FolderBrowserDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            工作目录.Text = System.IO.Path.GetFullPath(Me.FolderBrowserDialog1.SelectedPath)
        End If

    End Sub

    Private Sub 启动Button_Click(sender As Object, e As EventArgs) Handles 启动Button.Click

        Me.OpenFileDialog1.Title = "请选择ansys exe文件："
        Me.OpenFileDialog1.Filter = "exe files (*.exe)|*.exe"
        Me.OpenFileDialog1.RestoreDirectory = True
        If Me.OpenFileDialog1.ShowDialog = DialogResult.OK Then
            ansys启动程序.Text = Me.OpenFileDialog1.FileName()
        End If
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles 后台计算button.Click
        读取结果Button.Enabled = True
        Dim input As Integer
        input = 1
        FileOpen(input, Me.工作目录.Text & "\input.mac", OpenMode.Output)

        PrintLine(input, "finish")
        PrintLine(input, "/clear")
        PrintLine(input, "/FILNAME," & Me.项目名称.Text)
        PrintLine(input, "/CWD," & Me.工作目录.Text)
        'vb.txt文件从此开始覆盖
        'vb.txt-------begin
        PrintLine(input, "/ CLEAR, START")
        PrintLine(input, "/PREP7  ")
        PrintLine(input, "!*********瀹氫箟鍗曞厓*************")
        PrintLine(input, "ET,1,PLANE230   ")
        PrintLine(input, "")
        PrintLine(input, "!*********瀹氫箟鐢甸樆鐜?************")
        PrintLine(input, "MPTEMP,,,,,,,,  ")
        PrintLine(input, "MPTEMP,1,0  ")
        PrintLine(input, "MPDATA,RSVX,1,," & Resistivity1.Text)
        PrintLine(input, "MPTEMP,,,,,,,,  ")
        PrintLine(input, "MPTEMP,1,0  ")
        PrintLine(input, "MPDATA,RSVX,2,," & Resistivity2.Text)
        PrintLine(input, "MPTEMP,,,,,,,,  ")
        PrintLine(input, "MPTEMP,1,0  ")
        PrintLine(input, "MPDATA,RSVX,3,," & Resistivity3.Text)
        PrintLine(input, "MPTEMP,,,,,,,,  ")
        PrintLine(input, "MPTEMP,1,0  ")
        PrintLine(input, "MPDATA,RSVX,4,," & Resistivity4.Text)
        PrintLine(input, "MPTEMP,,,,,,,,  ")
        PrintLine(input, "MPTEMP,1,0  ")
        PrintLine(input, "MPDATA,RSVX,5,," & Resistivity5.Text)
        PrintLine(input, "MPTEMP,,,,,,,,  ")
        PrintLine(input, "MPTEMP,1,0  ")
        PrintLine(input, "MPDATA,RSVX,6,," & Resistivity6.Text)
        PrintLine(input, "MPTEMP,,,,,,,,  ")
        PrintLine(input, "MPTEMP,1,0  ")
        PrintLine(input, "MPDATA,RSVX,7,," & Resistivity7.Text)
        PrintLine(input, "MPTEMP,,,,,,,,  ")
        PrintLine(input, "MPTEMP,1,0  ")
        PrintLine(input, "MPDATA,RSVX,8,," & Resistivity8.Text)
        PrintLine(input, "")
        PrintLine(input, "!*********鍑犱綍灏哄鍙傛暟**********")
        PrintLine(input, "!妲藉搴k")
        PrintLine(input, "Cll_wd=2020e-3")
        PrintLine(input, "")
        PrintLine(input, "!妲借啗瀹藉害 ok")
        PrintLine(input, "Cv_wd=1940e-3")
        PrintLine(input, "")
        PrintLine(input, "!绗竴灞傚唴琛細纭呴吀閽欐澘 ok")
        PrintLine(input, "Lining1_hg=100e-3")
        PrintLine(input, "")
        PrintLine(input, "!绗簩灞傚唴琛細淇濇俯鐮?鑰愰珮娓╃閰搁挋鏉?ok")
        PrintLine(input, "Lining2_hg=66e-3")
        PrintLine(input, "")
        PrintLine(input, "!绗笁灞傚唴琛細闅旂儹鑰愮伀鐮?ok")
        PrintLine(input, "Lining3_hg=66e-3")
        PrintLine(input, "")
        PrintLine(input, "!绗洓灞傚唴琛細闃叉笚鏂?ok")
        PrintLine(input, "Lining4_hg=185e-3")
        PrintLine(input, "")
        PrintLine(input, "!闃存瀬閽㈡楂樺害ok")
        PrintLine(input, "Cllb_hg=180e-3")
        PrintLine(input, "")
        PrintLine(input, "!闃存瀬閽㈡闀垮害 ok")
        PrintLine(input, "Cllb_wd=2130e-3")
        PrintLine(input, "")
        PrintLine(input, "!闃存瀬閽㈡绯婇珮搴?ok")
        PrintLine(input, "Clpt_hg=20e-3")
        PrintLine(input, "")
        PrintLine(input, "!闃存瀬鐐潡瀹藉害 ok")
        PrintLine(input, "Cth_wd=1680e-3")
        PrintLine(input, "")
        PrintLine(input, "!闃存瀬鐐潡楂樺害 ok")
        PrintLine(input, "Cth_hg=450e-3")
        PrintLine(input, "")
        PrintLine(input, "!渚ч儴鐐潡楂樺害")
        PrintLine(input, "Scb_hg=820e-3")
        PrintLine(input, "")
        PrintLine(input, "!渚ч儴鐐潡瀹藉害 ok")
        PrintLine(input, "Scb_wd=80e-3")
        PrintLine(input, "")
        PrintLine(input, "!鎹ｅ浐绯婇珮搴?ok")
        PrintLine(input, "dgh_hg=550e-3")
        PrintLine(input, "")
        PrintLine(input, "!鎹ｅ浐绯婁笂瀹?ok")
        PrintLine(input, "dgh_wd=50e-3")
        PrintLine(input, "")
        PrintLine(input, "!鎹ｅ浐绯婁笅瀹?ok")
        PrintLine(input, "dgh_wd_dwn=260e-3")
        PrintLine(input, "")
        PrintLine(input, "!闃虫瀬瀹藉害 ok")
        PrintLine(input, "And_wd=1550e-3")
        PrintLine(input, "")
        PrintLine(input, "!闃虫瀬楂樺害 ok")
        PrintLine(input, "And_hg=370e-3 ")
        PrintLine(input, "")
        PrintLine(input, "!闃虫瀬璺濅腑蹇冪嚎 ok")
        PrintLine(input, "Ad_2ad=90e-3")
        PrintLine(input, "")
        PrintLine(input, "!闃虫瀬璺濈渚ч儴鐐潡锛屽ぇ闈㈠姞宸ヨ窛绂?ok")
        PrintLine(input, "Swr_wd=300e-3")
        PrintLine(input, "")
        PrintLine(input, "!闃虫瀬閽㈡鎻掑叆闃虫瀬娣卞害 ok")
        PrintLine(input, "And_in=100e-3")
        PrintLine(input, "")
        PrintLine(input, "!閽㈢埅闂磋窛 ok")
        PrintLine(input, "Rod_2rod=300e-3")
        PrintLine(input, "")
        PrintLine(input, "!閽㈢埅楂樺害 ok")
        PrintLine(input, "Rod_hg=280e-3")
        PrintLine(input, "")
        PrintLine(input, "!閽㈢埅瀹藉害 ok")
        PrintLine(input, "Rod_dia=150e-3")
        PrintLine(input, "")
        PrintLine(input, "!閽㈢埅姊侀珮搴?ok")
        PrintLine(input, "Beam_hg=150e-3")
        PrintLine(input, "")
        PrintLine(input, "!妯瀹藉害")
        PrintLine(input, "Beam_Wd=1050e-3")
        PrintLine(input, "")
        PrintLine(input, "")
        PrintLine(input, "!閾濆鏉嗗 ok")
        PrintLine(input, "Alrod_wd=150e-3")
        PrintLine(input, "")
        PrintLine(input, "!閾濆鏉嗛珮搴?ok")
        PrintLine(input, "Alrod_hg=400e-3")
        PrintLine(input, "")
        PrintLine(input, "!姘у寲閾濊鐩栨枡鍘氬害ok")
        PrintLine(input, "Al2O3_hg=175e-3")
        PrintLine(input, "")
        PrintLine(input, "!閾濇按骞?ok")
        PrintLine(input, "Alu_hg=200e-3            ")
        PrintLine(input, "")
        PrintLine(input, "!鐢佃В璐ㄦ按骞?ok")
        PrintLine(input, "Elu_hg=175e-3   ")
        PrintLine(input, "")
        PrintLine(input, "!鏋佽窛 ok")
        PrintLine(input, "ACD=45e-3")
        PrintLine(input, "                                                          ")
        PrintLine(input, "!鍐呰‖寤烘āok")
        PrintLine(input, "rectang,0,Cll_wd,0,Lining1_hg")
        PrintLine(input, "rectang,0,Cll_wd,0,Lining1_hg+Lining2_hg")
        PrintLine(input, "rectang,0,Cll_wd,0,Lining1_hg+Lining2_hg+Lining3_hg")
        PrintLine(input, "rectang,0,Cll_wd,0,Lining1_hg+Lining2_hg+Lining3_hg+Lining4_hg")
        PrintLine(input, "rectang,0,Cllb_wd,Lining1_hg+Lining2_hg+Lining3_hg+Lining4_hg,Lining1_hg+Lining2_hg+Lining3_hg+Lining4_hg+Cllb_hg")
        PrintLine(input, "rectang,0,Cll_wd,0,Lining1_hg+Lining2_hg+Lining3_hg+Lining4_hg+Cllb_hg+Clpt_hg")
        PrintLine(input, "rectang,0,Cll_wd,0,Lining1_hg+Lining2_hg+Lining3_hg+Lining4_hg+Cth_hg")
        PrintLine(input, "")
        PrintLine(input, "")
        PrintLine(input, "!渚ч儴鐐潡ok")
        PrintLine(input, "rectang,Cll_wd-Scb_wd,Cll_wd,0,Lining1_hg+Lining2_hg+Lining3_hg+Lining4_hg+Cllb_hg+Scb_hg")
        PrintLine(input, "")
        PrintLine(input, "")
        PrintLine(input, "!鎹ｉ紦绯?ok")
        PrintLine(input, "*get,kpnum,kp,0,count")
        PrintLine(input, "k,kpnum+1,Cll_wd-dgh_wd_dwn-Scb_wd,Lining1_hg+Lining2_hg+Lining3_hg+Lining4_hg+Cllb_hg")
        PrintLine(input, "k,kpnum+2,Cll_wd-dgh_wd_dwn-Scb_wd,Lining1_hg+Lining2_hg+Lining3_hg+Lining4_hg+Cth_hg")
        PrintLine(input, "k,kpnum+3,Cll_wd-dgh_wd-Scb_wd,Lining1_hg+Lining2_hg+Lining3_hg+Lining4_hg+Cllb_hg+dgh_hg")
        PrintLine(input, "k,kpnum+4,Cll_wd,Lining1_hg+Lining2_hg+Lining3_hg+Lining4_hg+Cllb_hg+dgh_hg")
        PrintLine(input, "k,kpnum+5,Cll_wd,Lining1_hg+Lining2_hg+Lining3_hg+Lining4_hg+Cllb_hg")
        PrintLine(input, "a,kpnum+1,kpnum+2,kpnum+3,kpnum+4,kpnum+5")
        PrintLine(input, "")
        PrintLine(input, "")
        PrintLine(input, "!妲藉府")
        PrintLine(input, "sledg_dw_wd=20e-3+dgh_wd_dwn+Scb_wd")
        PrintLine(input, "sledg_dw_hg=Lining1_hg+Lining2_hg+Lining3_hg+Lining4_hg+Cth_hg")
        PrintLine(input, "sledg_mid_wd=dgh_wd_dwn+Scb_wd-50e-3")
        PrintLine(input, "sledg_mid_hg=sledg_dw_hg+200e-3")
        PrintLine(input, "sledg_up_wd=Swr_wd+Scb_wd")
        PrintLine(input, "sledg_up_hg=Lining1_hg+Lining2_hg+Lining3_hg+Lining4_hg+Cllb_hg+Scb_hg-Al2O3_hg")
        PrintLine(input, "")
        PrintLine(input, "*get,kpnum,kp,0,count")
        PrintLine(input, "k,kpnum+1,Cll_wd-sledg_dw_wd,sledg_dw_hg")
        PrintLine(input, "k,kpnum+2,Cll_wd-sledg_mid_wd,sledg_mid_hg")
        PrintLine(input, "k,kpnum+3,Cll_wd-sledg_up_wd,sledg_up_hg")
        PrintLine(input, "k,kpnum+4,Cll_wd,sledg_up_hg")
        PrintLine(input, "k,kpnum+5,Cll_wd,sledg_dw_hg")
        PrintLine(input, "a,kpnum+1,kpnum+2,kpnum+3,kpnum+4,kpnum+5")
        PrintLine(input, "")
        PrintLine(input, "")
        PrintLine(input, "!姘у寲閾濊鐩栧眰鍘氬害 ok")
        PrintLine(input, "rectang,0,Cll_wd-Scb_wd,sledg_up_hg,sledg_up_hg+Al2O3_hg")
        PrintLine(input, "")
        PrintLine(input, "!闃虫瀬鐐潡 ok")
        PrintLine(input, "rectang,Ad_2ad,Cll_wd-Swr_wd-Scb_wd,Lining1_hg+Lining2_hg+Lining3_hg+Lining4_hg+Cth_hg+Alu_hg+ACD,Lining1_hg+Lining2_hg+Lining3_hg+Lining4_hg+Cth_hg+Alu_hg+ACD+And_hg")
        PrintLine(input, "")
        PrintLine(input, "")
        PrintLine(input, "!闃虫瀬閽㈢埅 ok")
        PrintLine(input, "Rod_X=Ad_2ad+(And_wd-Beam_Wd)/2")
        PrintLine(input, "Rod_Y=Lining1_hg+Lining2_hg+Lining3_hg+Lining4_hg+Cth_hg+Alu_hg+ACD+And_hg-And_in")
        PrintLine(input, "rectang,Rod_X,Rod_X+Rod_dia,Rod_Y,Rod_Y+Rod_hg+Beam_hg")
        PrintLine(input, "rectang,Rod_X+Rod_2rod,Rod_X+Rod_2rod+Rod_dia,Rod_Y,Rod_Y+Rod_hg+Beam_hg")
        PrintLine(input, "rectang,Rod_X+Rod_2rod*2,Rod_X+Rod_2rod*2+Rod_dia,Rod_Y,Rod_Y+Rod_hg+Beam_hg")
        PrintLine(input, "rectang,Rod_X+Rod_2rod*3,Rod_X+Rod_2rod*3+Rod_dia,Rod_Y,Rod_Y+Rod_hg+Beam_hg")
        PrintLine(input, "rectang,Rod_X,Rod_X+Beam_Wd,Rod_Y+Rod_hg,Rod_Y+Rod_hg+Beam_hg")
        PrintLine(input, "rectang,Rod_X+(Beam_Wd-Alrod_wd)/2,Rod_X+(Beam_Wd-Alrod_wd)/2+Alrod_wd,Rod_Y+Rod_hg+Beam_hg,Rod_Y+Rod_hg+Beam_hg+Alrod_hg")
        PrintLine(input, "")
        PrintLine(input, "")
        PrintLine(input, "alls")
        PrintLine(input, "aovlap,all")
        PrintLine(input, "aglue,all  ")
        PrintLine(input, "nummrg,kp   ")
        PrintLine(input, "numcmp,all  ")
        PrintLine(input, "alls")
        PrintLine(input, "")
        PrintLine(input, "LSTR,      29,      17  ")
        PrintLine(input, "FLST,2,8,4  ")
        PrintLine(input, "FITEM,2,144 ")
        PrintLine(input, "FITEM,2,33  ")
        PrintLine(input, "FITEM,2,38  ")
        PrintLine(input, "FITEM,2,9   ")
        PrintLine(input, "FITEM,2,36  ")
        PrintLine(input, "FITEM,2,7   ")
        PrintLine(input, "FITEM,2,6   ")
        PrintLine(input, "FITEM,2,142 ")
        PrintLine(input, "AL,P51X ")
        PrintLine(input, "FLST,2,52,5,ORDE,2  ")
        PrintLine(input, "FITEM,2,1   ")
        PrintLine(input, "FITEM,2,-52 ")
        PrintLine(input, "AGLUE,P51X  ")
        PrintLine(input, "CM,_Y,AREA  ")
        PrintLine(input, "ASEL, , , ,      52 ")
        PrintLine(input, "CM,_Y1,AREA ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "FLST,5,20,5,ORDE,8  ")
        PrintLine(input, "FITEM,5,8   ")
        PrintLine(input, "FITEM,5,-16 ")
        PrintLine(input, "FITEM,5,34  ")
        PrintLine(input, "FITEM,5,-39 ")
        PrintLine(input, "FITEM,5,41  ")
        PrintLine(input, "FITEM,5,43  ")
        PrintLine(input, "FITEM,5,45  ")
        PrintLine(input, "FITEM,5,-47 ")
        PrintLine(input, "CM,_Y,AREA  ")
        PrintLine(input, "ASEL, , , ,P51X ")
        PrintLine(input, "CM,_Y1,AREA ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "FLST,5,20,5,ORDE,8  ")
        PrintLine(input, "FITEM,5,8   ")
        PrintLine(input, "FITEM,5,-16 ")
        PrintLine(input, "FITEM,5,34  ")
        PrintLine(input, "FITEM,5,-39 ")
        PrintLine(input, "FITEM,5,41  ")
        PrintLine(input, "FITEM,5,43  ")
        PrintLine(input, "FITEM,5,45  ")
        PrintLine(input, "FITEM,5,-47 ")
        PrintLine(input, "CM,_Y,AREA  ")
        PrintLine(input, "ASEL, , , ,P51X ")
        PrintLine(input, "CM,_Y1,AREA ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "")
        PrintLine(input, "!********灏嗗悇闈㈠畾涔変负涓嶅悓鐨勬潗鏂?**********")
        PrintLine(input, "!*  ")
        PrintLine(input, "CMSEL,S,_Y1 ")
        PrintLine(input, "AATT,       1, ,   1,       0,  ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "CMDELE,_Y   ")
        PrintLine(input, "CMDELE,_Y1  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "FLST,5,7,5,ORDE,7   ")
        PrintLine(input, "FITEM,5,7   ")
        PrintLine(input, "FITEM,5,32  ")
        PrintLine(input, "FITEM,5,-33 ")
        PrintLine(input, "FITEM,5,40  ")
        PrintLine(input, "FITEM,5,42  ")
        PrintLine(input, "FITEM,5,44  ")
        PrintLine(input, "FITEM,5,51  ")
        PrintLine(input, "CM,_Y,AREA  ")
        PrintLine(input, "ASEL, , , ,P51X ")
        PrintLine(input, "CM,_Y1,AREA ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "CMSEL,S,_Y1 ")
        PrintLine(input, "AATT,       2, ,   1,       0,  ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "CMDELE,_Y   ")
        PrintLine(input, "CMDELE,_Y1  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "CM,_Y,AREA  ")
        PrintLine(input, "ASEL, , , ,      52 ")
        PrintLine(input, "CM,_Y1,AREA ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "CMSEL,S,_Y1 ")
        PrintLine(input, "AATT,       3, ,   1,       0,  ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "CMDELE,_Y   ")
        PrintLine(input, "CMDELE,_Y1  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "FLST,5,5,5,ORDE,4   ")
        PrintLine(input, "FITEM,5,4   ")
        PrintLine(input, "FITEM,5,25  ")
        PrintLine(input, "FITEM,5,-27 ")
        PrintLine(input, "FITEM,5,31  ")
        PrintLine(input, "CM,_Y,AREA  ")
        PrintLine(input, "ASEL, , , ,P51X ")
        PrintLine(input, "CM,_Y1,AREA ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "CMSEL,S,_Y1 ")
        PrintLine(input, "AATT,       2, ,   1,       0,  ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "CMDELE,_Y   ")
        PrintLine(input, "CMDELE,_Y1  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "FLST,5,4,5,ORDE,4   ")
        PrintLine(input, "FITEM,5,5   ")
        PrintLine(input, "FITEM,5,29  ")
        PrintLine(input, "FITEM,5,-30 ")
        PrintLine(input, "FITEM,5,50  ")
        PrintLine(input, "CM,_Y,AREA  ")
        PrintLine(input, "ASEL, , , ,P51X ")
        PrintLine(input, "CM,_Y1,AREA ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "CMSEL,S,_Y1 ")
        PrintLine(input, "AATT,       4, ,   1,       0,  ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "CMDELE,_Y   ")
        PrintLine(input, "CMDELE,_Y1  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "CM,_Y,AREA  ")
        PrintLine(input, "ASEL, , , ,      49 ")
        PrintLine(input, "CM,_Y1,AREA ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "CMSEL,S,_Y1 ")
        PrintLine(input, "AATT,       5, ,   1,       0,  ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "CMDELE,_Y   ")
        PrintLine(input, "CMDELE,_Y1  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "CM,_Y,AREA  ")
        PrintLine(input, "ASEL, , , ,      24 ")
        PrintLine(input, "CM,_Y1,AREA ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "CMSEL,S,_Y1 ")
        PrintLine(input, "AATT,       6, ,   1,       0,  ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "CMDELE,_Y   ")
        PrintLine(input, "CMDELE,_Y1  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "FLST,5,3,5,ORDE,3   ")
        PrintLine(input, "FITEM,5,3   ")
        PrintLine(input, "FITEM,5,23  ")
        PrintLine(input, "FITEM,5,48  ")
        PrintLine(input, "CM,_Y,AREA  ")
        PrintLine(input, "ASEL, , , ,P51X ")
        PrintLine(input, "CM,_Y1,AREA ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "CMSEL,S,_Y1 ")
        PrintLine(input, "AATT,       7, ,   1,       0,  ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "CMDELE,_Y   ")
        PrintLine(input, "CMDELE,_Y1  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "FLST,5,10,5,ORDE,6  ")
        PrintLine(input, "FITEM,5,1   ")
        PrintLine(input, "FITEM,5,-2  ")
        PrintLine(input, "FITEM,5,6   ")
        PrintLine(input, "FITEM,5,17  ")
        PrintLine(input, "FITEM,5,-22 ")
        PrintLine(input, "FITEM,5,28  ")
        PrintLine(input, "CM,_Y,AREA  ")
        PrintLine(input, "ASEL, , , ,P51X ")
        PrintLine(input, "CM,_Y1,AREA ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "CMSEL,S,_Y1 ")
        PrintLine(input, "AATT,       8, ,   1,       0,  ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "CMDELE,_Y   ")
        PrintLine(input, "CMDELE,_Y1  ")
        PrintLine(input, "")
        PrintLine(input, "!********4.缃戞牸鍒掑垎鍜岃竟鐣屾潯浠?**********")
        PrintLine(input, "ESIZE,0.01,0,   ")
        PrintLine(input, "MSHKEY,0")
        PrintLine(input, "FLST,5,52,5,ORDE,2  ")
        PrintLine(input, "FITEM,5,1   ")
        PrintLine(input, "FITEM,5,-52 ")
        PrintLine(input, "CM,_Y,AREA  ")
        PrintLine(input, "ASEL, , , ,P51X ")
        PrintLine(input, "CM,_Y1,AREA ")
        PrintLine(input, "CHKMSH,'AREA'   ")
        PrintLine(input, "CMSEL,S,_Y  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "AMESH,_Y1   ")
        PrintLine(input, "!*  ")
        PrintLine(input, "CMDELE,_Y   ")
        PrintLine(input, "CMDELE,_Y1  ")
        PrintLine(input, "CMDELE,_Y2  ")
        PrintLine(input, "!*  ")
        PrintLine(input, "FINISH  ")
        PrintLine(input, "/SOL")
        PrintLine(input, "LPLOT   ")
        PrintLine(input, "FLST,2,1,4,ORDE,1   ")
        PrintLine(input, "FITEM,2,18  ")
        PrintLine(input, "/GO ")
        PrintLine(input, "!*  ")
        PrintLine(input, "DL,P51X, ,VOLT,0")
        PrintLine(input, "")
        PrintLine(input, "NPLOT   ")
        PrintLine(input, "FLST,2,37,1,ORDE,3  ")
        PrintLine(input, "FITEM,2,6487")
        PrintLine(input, "FITEM,2,6509")
        PrintLine(input, "FITEM,2,-6544   ")
        PrintLine(input, "/GO ")
        PrintLine(input, "!*  ")
        PrintLine(input, "Current=" & Current1.Text * -1 / 26 / 4)
        PrintLine(input, "F,P51X,AMPS,Current")
        PrintLine(input, "/STATUS,SOLU")
        PrintLine(input, "")
        PrintLine(input, "!***************9.姹傝В**************  ")
        PrintLine(input, "SOLVE   ")
        PrintLine(input, "")
        PrintLine(input, "!***************10.缁撴灉鍚庡鐞?************* ")
        PrintLine(input, "")
        PrintLine(input, "/EFACET,1   ")
        PrintLine(input, "PLNSOL, VOLT,, 0")
        PrintLine(input, "")
        '以下为apdl输出云图图片命令
        PrintLine(input, "/RGB,INDEX,100,100,100,0")
        PrintLine(input, "/RGB,INDEX,0,0,0,15 ")
        PrintLine(input, "/REPLOT ")
        PrintLine(input, "/CMAP,_TEMPCMAP_,CMP")
        PrintLine(input, "/DELETE,_TEMPCMAP_,CMP  ")
        PrintLine(input, "/SHOW,CLOSE ")
        PrintLine(input, "/DEVICE,VECTOR,0")
        PrintLine(input, "")
        PrintLine(input, "!*  ")
        PrintLine(input, "/POST1  ")
        PrintLine(input, "!*  ")
        PrintLine(input, " ")
        PrintLine(input, "/EFACET,1   ")
        PrintLine(input, "PLNSOL, VOLT,, 0")
        PrintLine(input, "")
        PrintLine(input, "/show,png")
        PrintLine(input, "lplot") '输出线图
        PrintLine(input, "aplot") '输出面图
        PrintLine(input, "vplot") '输出体图
        PrintLine(input, "eplot") '输出网格图
        PrintLine(input, "/EFACET,1   ")
        PrintLine(input, "PLNSOL, VOLT,, 0") '输出电压场云图
        PrintLine(input, "")
        PrintLine(input, "/show,close")
        PrintLine(input, "!*  ")
        'vb.txt-------end
        FileClose(input)

        '调用ansys计算
        Dim x As Integer
        x = Shell(Me.ansys启动程序.Text & " -p ansys -np 2 -lch -dir " & Me.工作目录.Text & " -j " & Me.项目名称.Text & " -s read -l en-us -b -i " & Me.工作目录.Text & "\input.mac" & " -o " & Me.工作目录.Text & "\output.mac", 1, False, -1)
        后台计算button.Enabled = False
        MsgBox("完成计算！")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles 读取结果Button.Click
        后台计算button.Enabled = False
        生成报告Button.Enabled = True
        Dim pict0, pict1, pict2, pict3 As String

        pict1 = Me.工作目录.Text & "\" & Me.项目名称.Text & "001.png"
        pict2 = Me.工作目录.Text & "\" & Me.项目名称.Text & "002.png"
        pict3 = Me.工作目录.Text & "\" & Me.项目名称.Text & "003.png"

        Me.PictureBox2.Image = Image.FromFile(pict1)
        Me.PictureBox3.Image = Image.FromFile(pict2)
        Me.PictureBox4.Image = Image.FromFile(pict3)


        Me.Show()
        读取结果Button.Enabled = False
        MsgBox("读取成功！")
    End Sub



    Private Sub 初始化Button_Click(sender As Object, e As EventArgs) Handles 初始化Button.Click
        Dim pict0, pict1, pict2, pict3 As String

        pict1 = Me.工作目录.Text & "\" & Me.项目名称.Text & "001.png"
        pict2 = Me.工作目录.Text & "\" & Me.项目名称.Text & "002.png"
        pict3 = Me.工作目录.Text & "\" & Me.项目名称.Text & "003.png"

        PictureBox2.Image.Dispose()
        PictureBox3.Image.Dispose()
        PictureBox4.Image.Dispose()
        Kill(pict1)
        Kill(pict2)
        Kill(pict3)

        pict0 = Application.StartupPath & "\el.png"
        Me.PictureBox2.Image = Image.FromFile(pict0)
        Me.PictureBox3.Image = Image.FromFile(pict0)
        Me.PictureBox4.Image = Image.FromFile(pict0)

        pict3 = Me.工作目录.Text
        'System.IO.Directory.CreateDirectory("c:\Test")
        System.IO.Directory.Delete(pict3, True)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If System.IO.File.Exists(Me.工作目录.Text & "\ansys_test.txt") Then

            Dim input As Integer
            Dim output As Integer
            input = 1
            output = 2
            '将apdl放进ansys_test.txt，存于工作目录下，点击该“转换”按钮即可将其转换成vb可识别的形式
            FileOpen(input, 工作目录.Text & "\ansys_test.txt", OpenMode.Input)
            FileOpen(output, 工作目录.Text & "\VB.txt", OpenMode.Output)

            Dim str As String
            str = ""
            Do While Not EOF(1)
                str = LineInput(input)
                PrintLine(output, "PrintLine (input,""" & str & """)")
            Loop

            MsgBox("转换完成，请插入VB代码")
            FileClose(input)

            FileClose(output)

        Else
            MsgBox("没有找到ansys.txt文件！")
        End If
    End Sub

    Private Sub 生成报告Button_Click(sender As Object, e As EventArgs) Handles 生成报告Button.Click
        初始化Button.Enabled = True
        Dim wordApp As New word.Application   'word应用程序对象
        Dim wordDocument As word.Document
        '报告模板在\ansys_win\bin\Debug下
        wordDocument = wordApp.Documents.Open(Application.StartupPath & "\报告模板.docx")
        wordApp.Visible = False

        Dim FindObject1 As word.Find = wordApp.Selection.Find            '定义word中需要被替换的量
        Dim FindObject2 As word.Find = wordApp.Selection.Find
        Dim FindObject3 As word.Find = wordApp.Selection.Find
        Dim FindObject4 As word.Find = wordApp.Selection.Find
        Dim FindObject5 As word.Find = wordApp.Selection.Find
        Dim FindObject6 As word.Find = wordApp.Selection.Find
        Dim FindObject7 As word.Find = wordApp.Selection.Find

        With FindObject1
            .ClearFormatting()
            .Text = "阳极导杆value"
            .Replacement.ClearFormatting()
            .Replacement.Text = Resistivity1.Text
            .Execute(Replace:=word.WdReplace.wdReplaceAll)
        End With

        With FindObject1
            .ClearFormatting()
            .Text = "阳极炭块value"
            .Replacement.ClearFormatting()
            .Replacement.Text = Resistivity3.Text
            .Execute(Replace:=word.WdReplace.wdReplaceAll)
        End With



        '插入图片
        Dim FindPicture As word.Find = wordApp.Selection.Find
        Dim FindPFT As Boolean

        With FindPicture
            .ClearFormatting()
            .Text = "Countour Picture"
            .Replacement.ClearFormatting()
            .Replacement.Text = ""
            .Forward = True
            .Format = False
            .MatchCase = False
            .MatchWholeWord = False
            .MatchByte = True
            .MatchWildcards = False
            .MatchSoundsLike = False
            .MatchAllWordForms = False
        End With

        FindPFT = FindPicture.Execute(Replace:=True)
        wordApp.Application.Selection.InlineShapes.AddPicture(工作目录.Text & "\" & 项目名称.Text & "003.png")


        wordDocument.SaveAs2(工作目录.Text & "\" & 项目名称.Text & "计算报告.docx")
        wordDocument.Close()
        生成报告Button.Enabled = False
    End Sub

    Private Sub 帮助Button_Click(sender As Object, e As EventArgs) Handles 帮助Button.Click
        帮助Form.Show()
    End Sub

    Private Sub ansys启动程序_TextChanged(sender As Object, e As EventArgs) Handles ansys启动程序.TextChanged

    End Sub
End Class