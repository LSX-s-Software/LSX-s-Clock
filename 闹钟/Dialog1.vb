Public Class Dialog1

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim a As Integer
        With Form1.ListView1
            DialogResult = DialogResult.OK
            .Items.Add(DateTimePicker1.Value.ToString("yyyy/MM/dd HH:mm:ss"))
            a = .Items.Count
            .Items(a - 1).SubItems.Add(CStr(ComboBox1.SelectedItem))
            Form1.activeclock = Form1.activeclock + 1
            .Items(a - 1).Checked = True
            Close()
        End With
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim a As String
        a = DateDiff("n", Now, DateTimePicker1.Value)
        If a < 0 Then
            Label1.Text = "将不会响铃"
            Exit Sub
        End If
        If a >= 1 Then
            Label1.Text = "将在" & a & "分钟后响铃"
        Else
            Label1.Text = "将在一分钟内响铃"
        End If
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DateTimePicker1.Value = Now
        DateTimePicker1.CustomFormat = "yyyy/MM/dd HH:mm:ss"
        ComboBox1.SelectedItem = "默认铃声"
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem.ToString = "浏览..." Then
            OpenFileDialog1.ShowDialog()
            If OpenFileDialog1.FileName <> "" Then
                ComboBox1.Items.Add(OpenFileDialog1.FileName)
            End If
            ComboBox1.SelectedItem = ComboBox1.Items(ComboBox1.Items.Count - 1)
        End If
    End Sub
End Class
