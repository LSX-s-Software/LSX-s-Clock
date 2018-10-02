Imports System.ComponentModel
Imports System.Math
Imports System.Net
Imports System.Net.Mail

Public Class Form1
    Public activeclock As Integer
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = Now
        draw()
        draw1()
    End Sub
    Private Sub draw()
        '创建Graphics对象
        Dim clockGraphics As Graphics = PictureBox1.CreateGraphics
        clockGraphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        Dim banjing As Double = PictureBox1.Height / 2
        '定义时，分，秒指针的始末点的坐标数组
        Dim HourPoint(1), MinutePoint(1), SecondPoint(1), OriginPoint As PointF
        OriginPoint.X = PictureBox1.Width / 2
        OriginPoint.Y = PictureBox1.Height / 2
        '更新画面
        PictureBox1.Refresh()
        Dim Angle As Double
        '时针转过的角度
        Angle = -PI / 2 + (Hour(Now) + Minute(Now) / 60) * (PI / 6) '时针每刻度相差pi/6
        '计算时针始末坐标的数值
        HourPoint(0).X = OriginPoint.X
        HourPoint(0).Y = OriginPoint.Y
        HourPoint(1).X = OriginPoint.X + 0.4 * banjing * Cos(Angle)
        HourPoint(1).Y = OriginPoint.Y + 0.4 * banjing * Sin(Angle)
        '定义画笔
        Dim FmPen As Pen
        FmPen = New Pen(Color.Black, 3)
        '画时针
        clockGraphics.DrawLine(FmPen, HourPoint(0), HourPoint(1))
        '分针转过角度
        Angle = -PI / 2 + (Minute(Now) + Second(Now) / 60) * (PI / 30)  '分针每刻度相差pi/30
        '计算分针始末坐标的数值
        MinutePoint(0).X = OriginPoint.X
        MinutePoint(0).Y = OriginPoint.Y
        MinutePoint(1).X = OriginPoint.X + 0.6 * banjing * Cos(Angle)
        MinutePoint(1).Y = banjing + 5 + 0.6 * banjing * Sin(Angle)
        FmPen = New Pen(Color.Black, 2)
        '画分针
        clockGraphics.DrawLine(FmPen, MinutePoint(0), MinutePoint(1))
        '秒针转过的角度
        Angle = -PI / 2 + Second(Now) * (PI / 30) '秒针每刻度相差pi/30
        '计算秒针始末坐标的数值
        SecondPoint(0).X = OriginPoint.X
        SecondPoint(0).Y = OriginPoint.Y
        SecondPoint(1).X = OriginPoint.X + 0.8 * banjing * Cos(Angle)
        SecondPoint(1).Y = OriginPoint.Y + 0.8 * banjing * Sin(Angle)
        FmPen = New Pen(Color.Black, 1)
        '画秒针
        clockGraphics.DrawLine(FmPen, SecondPoint(0), SecondPoint(1))
        '释放Graphics对象，以节省内存资源
        clockGraphics.Dispose()
    End Sub

    Private Sub 退出ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem1.Click
        On Error Resume Next
        End
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        Hide()
    End Sub

    Private Sub 关于本软件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 关于本软件ToolStripMenuItem.Click
        AboutBox1.ShowDialog()
    End Sub

    Private Sub 新闹钟ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 新闹钟ToolStripMenuItem.Click
        Dialog1.ShowDialog()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        activeclock = 0
        For i As Integer = 0 To ListView1.Items.Count - 1
            If ListView1.Items(i).Checked = True Then
                activeclock = activeclock + 1
            End If
        Next
        ToolStripStatusLabel1.Text = "开启的闹钟：" & activeclock & "个"
        For a = 1 To ListView1.Items.Count
            If (ListView1.Items(a - 1).Checked = True) And
                (Date.Now.ToString("yyyy/MM/dd HH:mm:ss") = ListView1.Items(a - 1).Text) Then
                Dialog2.Label1.Text = "现在已经是" & ListView1.Items(a - 1).Text & "了"
                Dialog2.ring = ListView1.Items(a - 1).SubItems(1).Text
                Dialog2.Show()
                ListView1.Items(a - 1).Checked = False
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error GoTo 1
        Dim clocks, c() As String
        Dim i As Integer
        activeclock = 0
        ListView1.Columns.Add("时间", 250)
        ListView1.Columns.Add("铃声", ListView1.Width - 245)
        Show()
        If (Command() <> "") And (Microsoft.VisualBasic.Right(Command, 6) = ".clock") Then
            If MsgBox("导入闹钟配置文件？", vbYesNo) = vbYes Then
                clocks = FileIO.FileSystem.ReadAllText(Command)
                c = clocks.Split(";")
                i = 0
                With ListView1.Items
                    Do While c(i) <> ""
                        .Add(c(i))
                        ListView1.Items(.Count - 1).SubItems.Add(c(i + 1))
                        ListView1.Items(.Count - 1).Checked = CBool(c(i + 2))
                        i = i + 3
                    Loop
                End With
            End If
        End If
        '--------------------------------------------------------
        clocks = FileIO.FileSystem.ReadAllText(Application.StartupPath & "\default.clock")
        c = clocks.Split(";")
        i = 0
        With ListView1.Items
            Do While c(i) <> ""
                .Add(c(i))
                ListView1.Items(.Count - 1).SubItems.Add(c(i + 1))
                ListView1.Items(.Count - 1).Checked = CBool(c(i + 2))
                i = i + 3
            Loop
        End With
        '--------------------------------------------------------
1:
        Exit Sub
    End Sub

    Private Sub 选中的闹钟ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 选中的闹钟ToolStripMenuItem.Click
        For i = 1 To ListView1.SelectedItems.Count
            ListView1.SelectedItems(i - 1).Checked = True
        Next
    End Sub

    Private Sub 选中的闹钟ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 选中的闹钟ToolStripMenuItem1.Click
        For i = 1 To ListView1.SelectedItems.Count
            ListView1.SelectedItems(i - 1).Checked = False
        Next
    End Sub

    Private Sub 选中的闹钟ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles 选中的闹钟ToolStripMenuItem2.Click
        For i = ListView1.SelectedItems.Count - 1 To 0 Step -1
            ListView1.SelectedItems(i).Remove()
        Next
    End Sub

    Private Sub 所有闹钟ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 所有闹钟ToolStripMenuItem.Click
        For i = 1 To ListView1.Items.Count
            ListView1.Items(i - 1).Checked = True
        Next
    End Sub

    Private Sub 所有闹钟ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 所有闹钟ToolStripMenuItem1.Click
        For i = 1 To ListView1.Items.Count
            ListView1.Items(i - 1).Checked = False
        Next
    End Sub

    Private Sub 所有闹钟ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles 所有闹钟ToolStripMenuItem2.Click
        ListView1.Items.Clear()
    End Sub

    Private Sub 启用此闹钟ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 启用此闹钟ToolStripMenuItem.Click
        Dim i As Integer
        For i = 0 To ListView1.SelectedItems.Count - 1
            ListView1.SelectedItems(i).Checked = True
        Next
    End Sub

    Private Sub 停用此闹钟ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 停用此闹钟ToolStripMenuItem.Click
        Dim i As Integer
        For i = 0 To ListView1.SelectedItems.Count - 1
            ListView1.SelectedItems(i).Checked = False
        Next
    End Sub

    Private Sub 删除此闹钟ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 删除此闹钟ToolStripMenuItem.Click
        Dim i As Integer
        For i = ListView1.SelectedItems.Count - 1 To 0 Step -1
            ListView1.SelectedItems(i).Remove()
        Next
    End Sub

    Private Sub 显示主程序ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 显示主程序ToolStripMenuItem.Click
        Show()
    End Sub

    Private Sub 退出ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem2.Click
        On Error Resume Next
        End
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim 内容 As String
        Timer2.Enabled = False
        ToolStripStatusLabel1.Text = "正在保存闹钟..."
        内容 = ""
        For i = 0 To ListView1.Items.Count - 1
            内容 = 内容 & ListView1.Items(i).Text & ";" &
                ListView1.Items(i).SubItems(1).Text & ";" &
                ListView1.Items(i).Checked & ";"
        Next
        If Not (FileIO.FileSystem.FileExists(Application.StartupPath & "\default.clock")) Then
            FileIO.FileSystem.WriteAllText(Application.StartupPath & "\default.clock", 内容, False, System.Text.Encoding.Default)
        Else
            FileIO.FileSystem.WriteAllText(Application.StartupPath & "\default.clock", 内容, False)
        End If
    End Sub

    Private Sub draw1()
        '创建Graphics对象用于绘图
        Dim FrmGraphics As Graphics = PictureBox1.CreateGraphics
        '设置画面质量(消除锯齿)
        FrmGraphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        '创建Pen1对象,颜色为black，粗细为2像素
        Dim Pen1 As New Pen(Color.Black, 2)
        '创建Pen2对象，颜色为黑色，粗细为1像素
        Dim Pen2 As New Pen(Color.Black, 1)
        '定义表示刻度的起点和终点数组，坐标原点
        Dim StartPoint(59), EndPoint(59), OriginPoint As PointF
        '设置坐标原点
        OriginPoint.X = PictureBox1.Width / 2
        OriginPoint.Y = PictureBox1.Height / 2
        Dim banjing As Double = PictureBox1.Width / 2
        '刻度之间的角度
        Dim Angle As Double
        For i1 = 0 To 59
            Angle = i1 * 2 * Atan(1) / 15 '算出每刻度的角度，实际上是(pi/30)*i1,为了精确用了Atan(1)，因为Atan(1)=PI/4
            '使用Atan数学函数，必须在程序的开头引入System.Math空间
            If i1 Mod 5 = 0 Then '画长且粗的刻度线
                '设置刻度起点和终点的坐标
                StartPoint(i1).X = 0.7 * banjing * Cos(Angle) + OriginPoint.X
                StartPoint(i1).Y = 0.7 * banjing * Sin(Angle) + OriginPoint.Y
                EndPoint(i1).X = banjing * Cos(Angle) + OriginPoint.X
                EndPoint(i1).Y = banjing * Sin(Angle) + OriginPoint.Y
                '绘制刻度
                FrmGraphics.DrawLine(Pen1, StartPoint(i1), EndPoint(i1))
            Else
                '设置刻度起点和终点的坐标
                StartPoint(i1).X = 0.9 * banjing * Cos(Angle) + OriginPoint.X
                StartPoint(i1).Y = 0.9 * banjing * Sin(Angle) + OriginPoint.Y
                EndPoint(i1).X = banjing * Cos(Angle) + OriginPoint.X
                EndPoint(i1).Y = banjing * Sin(Angle) + OriginPoint.Y
                '绘制刻度
                FrmGraphics.DrawLine(Pen2, StartPoint(i1), EndPoint(i1))
            End If
        Next
    End Sub

    Private Sub 打开闹钟配置文件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 打开闹钟配置文件ToolStripMenuItem.Click
        On Error Resume Next
        If MsgBox("导入闹钟配置文件？", vbYesNo) = vbYes Then
            Dim path, clocks As String
            Dim c() As String, i As Integer
            OpenFileDialog1.ShowDialog()
            path = OpenFileDialog1.FileName
            clocks = FileIO.FileSystem.ReadAllText(path)
            c = clocks.Split(";")
            i = 0
            With ListView1.Items
                Do While c(i) <> ""
                    .Add(c(i))
                    ListView1.Items(.Count - 1).SubItems.Add(c(i + 1))
                    ListView1.Items(.Count - 1).Checked = CBool(c(i + 2))
                    i = i + 3
                Loop
            End With
        End If
    End Sub

    Private Sub 保存闹钟配置文件ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 保存闹钟配置文件ToolStripMenuItem.Click
        If MsgBox("内容会自动保存在软件目录，您确定要将其导出到其他地方吗？", vbYesNo) = vbYes Then
            Dim 内容, path As String
            Timer2.Enabled = False
            ToolStripStatusLabel1.Text = "正在保存闹钟..."
            内容 = ""
            SaveFileDialog1.FileName = "闹钟配置文件1"
            For i = 0 To ListView1.Items.Count - 1
                内容 = 内容 & ListView1.Items(i).Text & ";" &
                    ListView1.Items(i).SubItems(1).Text & ";" &
                    ListView1.Items(i).Checked & ";"
            Next
            SaveFileDialog1.ShowDialog()
            path = SaveFileDialog1.FileName
            If Not (FileIO.FileSystem.FileExists(path)) Then
                FileIO.FileSystem.WriteAllText(path, 内容, False)
            Else
                FileIO.FileSystem.WriteAllText(path, 内容, False)
            End If
            Timer2.Enabled = True
            MsgBox("保存成功！")
        End If
    End Sub

    Private Sub 帮助ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 帮助ToolStripMenuItem1.Click
        Help.ShowHelp(Me, Application.StartupPath & "\Resources\闹钟-帮助.chm")
    End Sub

    Private Sub 音乐播放器ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 音乐播放器ToolStripMenuItem.Click
        Process.Start("http://adf.ly/1WdmDC")
    End Sub

    Private Sub 计时器ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 计时器ToolStripMenuItem.Click
        Process.Start("http://adf.ly/1WdmIn")
    End Sub

    Private Sub 反馈ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 反馈ToolStripMenuItem.Click
        Dim neirong, systemver As String
        Dim mg As MailMessage = New MailMessage()
        mg.From = New MailAddress("linsixing2001@sina.com")       '发件人邮箱
        mg.To.Add("2682191498@qq.com")                              '收件人邮箱
        mg.Subject = "反馈"                                                   '邮件主题
        neirong = InputBox("请输入你要反馈的内容", "反馈")
        If neirong = "" Then Exit Sub
        systemver = InputBox("请输入系统版本，示例：Windows 10", "反馈")
        mg.Body = neirong & "            系统版本：" & systemver  '邮件内容
        Timer1.Enabled = False
        ToolStripStatusLabel1.Text = "正在发送反馈内容，请稍后..."
        mg.BodyEncoding = System.Text.Encoding.UTF8                '内容编码
        mg.IsBodyHtml = False                                                       '是否支持HTML格式
        mg.Priority = MailPriority.Normal                                             '优先级别
        Dim smtp As SmtpClient = New SmtpClient()
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network             '邮件发送方式.这里通过网络
        smtp.Host = "smtp.sina.com"                                                  '邮件发送服务器
        smtp.Credentials = New NetworkCredential("linsixing2001", "****")    '用户名跟密码
        Try
            smtp.Send(mg)
            MsgBox("发送成功！")
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            mg.Dispose()
            Timer1.Enabled = True
        End Try
    End Sub
End Class