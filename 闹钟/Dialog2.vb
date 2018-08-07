Imports System.ComponentModel

Public Class Dialog2
    Public ring As String

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Dim i As Long
        For i = 1 To 100000
            If i Mod 1000 = 0 Then
                WMP1.settings.volume = WMP1.settings.volume - 1
            End If
        Next
        Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Beep()
    End Sub

    Private Sub Dialog2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ring = "默认铃声" Then
            Timer1.Enabled = True
        Else
            Timer2.Enabled = True
            With WMP1
                .URL = ring
                .settings.volume = 100
                .Ctlcontrols.play()
            End With
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If WMP1.playState = WMPLib.WMPPlayState.wmppsStopped Then WMP1.Ctlcontrols.play()
    End Sub

End Class
