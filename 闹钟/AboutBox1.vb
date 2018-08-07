Public NotInheritable Class AboutBox1
    Public c As Byte = 0
    Public Const updatelog As String = "版本更新内容：" & Chr(13) &
                                       "1、增加更新日志；" & Chr(13) &
                                       "2、增加彩蛋；" & Chr(13) &
                                       "3、修复动画时钟显示错误的bug；" & Chr(13) &
                                       "4、修复导出文件后再导入时乱码的bug；" & Chr(13) &
                                       "5、增加反馈功能"
    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' 设置此窗体的标题。
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("关于 {0}", ApplicationTitle)
        ' 初始化“关于”对话框显示的所有文字。
        ' TODO: 在项目的“应用程序”窗格中自定义此应用程序的程序集信息 
        '    属性对话框(在“项目”菜单下)。
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = LabelVersion.Text & My.Application.Info.Version.ToString
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub LabelVersion_DoubleClick(sender As Object, e As EventArgs) Handles LabelVersion.DoubleClick
        MsgBox(updatelog, vbInformation)
    End Sub

    Private Sub LabelProductName_Click(sender As Object, e As EventArgs) Handles LabelProductName.Click
        c = c + 1
        If c = 6 Then
            MsgBox("哈哈，彩蛋被你发现了！" & Chr(13) & "奖励：你可以带着这个字符串在QQ上问我一个问题（可以是除了个人信息之外的任何内容）：EhVMA8Y~rp")
            c = 0
        End If
    End Sub
End Class
