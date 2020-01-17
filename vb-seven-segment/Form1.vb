Imports System.Text.RegularExpressions

Public Class MainActivity
    Dim count As Integer

    ' Handling Numbers only for StartInput Text box
    Private Sub number_Handling(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles StartInput.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
    Private Sub number_TextHandler(ByVal sender As Object, ByVal e As System.EventArgs) Handles StartInput.TextChanged
        Dim digitsOnly As Regex = New Regex("[^\d]")
        StartInput.Text = digitsOnly.Replace(StartInput.Text, "")
    End Sub

    ' Start Seven Segment Counting on the number specified. (Loops to 0 -> 1 after 9)
    Private Sub StartInput_TextChanged(sender As Object, e As EventArgs) Handles StartInput.TextChanged
        If StartInput.Text = "0" Then
            segmentA.BackColor = Color.Red
            segmentB.BackColor = Color.Red
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.Red
            segmentE.BackColor = Color.Red
            segmentF.BackColor = Color.Red
            segmentG.BackColor = Color.White
        ElseIf StartInput.Text = "1" Then
            segmentA.BackColor = Color.White
            segmentB.BackColor = Color.Red
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.White
            segmentE.BackColor = Color.White
            segmentF.BackColor = Color.White
            segmentG.BackColor = Color.White
        ElseIf StartInput.Text = "2" Then
            segmentA.BackColor = Color.Red
            segmentB.BackColor = Color.Red
            segmentC.BackColor = Color.White
            segmentD.BackColor = Color.Red
            segmentE.BackColor = Color.Red
            segmentF.BackColor = Color.White
            segmentG.BackColor = Color.Red
        ElseIf StartInput.Text = "3" Then
            segmentA.BackColor = Color.Red
            segmentB.BackColor = Color.Red
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.Red
            segmentE.BackColor = Color.White
            segmentF.BackColor = Color.White
            segmentG.BackColor = Color.Red
        ElseIf StartInput.Text = "4" Then
            segmentA.BackColor = Color.White
            segmentB.BackColor = Color.Red
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.White
            segmentE.BackColor = Color.White
            segmentF.BackColor = Color.Red
            segmentG.BackColor = Color.Red
        ElseIf StartInput.Text = "5" Then
            segmentA.BackColor = Color.Red
            segmentB.BackColor = Color.White
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.Red
            segmentE.BackColor = Color.White
            segmentF.BackColor = Color.Red
            segmentG.BackColor = Color.Red
        ElseIf StartInput.Text = "6" Then
            segmentA.BackColor = Color.Red
            segmentB.BackColor = Color.White
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.Red
            segmentE.BackColor = Color.Red
            segmentF.BackColor = Color.Red
            segmentG.BackColor = Color.Red
        ElseIf StartInput.Text = "7" Then
            segmentA.BackColor = Color.Red
            segmentB.BackColor = Color.Red
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.White
            segmentE.BackColor = Color.White
            segmentF.BackColor = Color.White
            segmentG.BackColor = Color.White
        ElseIf StartInput.Text = "8" Then
            segmentA.BackColor = Color.Red
            segmentB.BackColor = Color.Red
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.Red
            segmentE.BackColor = Color.Red
            segmentF.BackColor = Color.Red
            segmentG.BackColor = Color.Red
        ElseIf StartInput.Text = "9" Then
            segmentA.BackColor = Color.Red
            segmentB.BackColor = Color.Red
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.Red
            segmentE.BackColor = Color.White
            segmentF.BackColor = Color.Red
            segmentG.BackColor = Color.Red
        ElseIf StartInput.Text = "" Then
            segmentA.BackColor = Color.White
            segmentB.BackColor = Color.White
            segmentC.BackColor = Color.White
            segmentD.BackColor = Color.White
            segmentE.BackColor = Color.White
            segmentF.BackColor = Color.White
            segmentG.BackColor = Color.White
        End If
    End Sub

    ' Start Click Handler
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Timer1.Interval = 1000
        Timer1.Start()
        If StartInput.Text IsNot "" Then
            count = CInt(StartInput.Text)
        End If
        StartInput.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        count = count + 1
        If count Mod 10 = 0 Then
            segmentA.BackColor = Color.Red
            segmentB.BackColor = Color.Red
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.Red
            segmentE.BackColor = Color.Red
            segmentF.BackColor = Color.Red
            segmentG.BackColor = Color.White
        ElseIf count Mod 10 = 1 Then
            segmentA.BackColor = Color.White
            segmentB.BackColor = Color.Red
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.White
            segmentE.BackColor = Color.White
            segmentF.BackColor = Color.White
            segmentG.BackColor = Color.White
        ElseIf count Mod 10 = 2 Then
            segmentA.BackColor = Color.Red
            segmentB.BackColor = Color.Red
            segmentC.BackColor = Color.White
            segmentD.BackColor = Color.Red
            segmentE.BackColor = Color.Red
            segmentF.BackColor = Color.White
            segmentG.BackColor = Color.Red
        ElseIf count Mod 10 = 3 Then
            segmentA.BackColor = Color.Red
            segmentB.BackColor = Color.Red
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.Red
            segmentE.BackColor = Color.White
            segmentF.BackColor = Color.White
            segmentG.BackColor = Color.Red
        ElseIf count Mod 10 = 4 Then
            segmentA.BackColor = Color.White
            segmentB.BackColor = Color.Red
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.White
            segmentE.BackColor = Color.White
            segmentF.BackColor = Color.Red
            segmentG.BackColor = Color.Red
        ElseIf count Mod 10 = 5 Then
            segmentA.BackColor = Color.Red
            segmentB.BackColor = Color.White
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.Red
            segmentE.BackColor = Color.White
            segmentF.BackColor = Color.Red
            segmentG.BackColor = Color.Red
        ElseIf count Mod 10 = 6 Then
            segmentA.BackColor = Color.Red
            segmentB.BackColor = Color.White
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.Red
            segmentE.BackColor = Color.Red
            segmentF.BackColor = Color.Red
            segmentG.BackColor = Color.Red
        ElseIf count Mod 10 = 7 Then
            segmentA.BackColor = Color.Red
            segmentB.BackColor = Color.Red
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.White
            segmentE.BackColor = Color.White
            segmentF.BackColor = Color.White
            segmentG.BackColor = Color.White
        ElseIf count Mod 10 = 8 Then
            segmentA.BackColor = Color.Red
            segmentB.BackColor = Color.Red
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.Red
            segmentE.BackColor = Color.Red
            segmentF.BackColor = Color.Red
            segmentG.BackColor = Color.Red
        ElseIf count Mod 10 = 9 Then
            segmentA.BackColor = Color.Red
            segmentB.BackColor = Color.Red
            segmentC.BackColor = Color.Red
            segmentD.BackColor = Color.Red
            segmentE.BackColor = Color.White
            segmentF.BackColor = Color.Red
            segmentG.BackColor = Color.Red
        ElseIf StartInput.Text = "" Then
            segmentA.BackColor = Color.White
            segmentB.BackColor = Color.White
            segmentC.BackColor = Color.White
            segmentD.BackColor = Color.White
            segmentE.BackColor = Color.White
            segmentF.BackColor = Color.White
            segmentG.BackColor = Color.White
        End If
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Timer1.Stop()
        StartInput.Enabled = True
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        count = 0
        segmentA.BackColor = Color.White
        segmentB.BackColor = Color.White
        segmentC.BackColor = Color.White
        segmentD.BackColor = Color.White
        segmentE.BackColor = Color.White
        segmentF.BackColor = Color.White
        segmentG.BackColor = Color.White
    End Sub
End Class
