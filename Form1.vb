Option Strict On
Option Explicit On
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        radGC.Checked = True
        radPrePay.Checked = True
        lblPayMessage.Text = ""
        txtPoints.Clear()
        txtPoints.Focus()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decPlatterCost As Decimal

        Dim strPoints As String = ""
        Dim decPoints As Decimal
        Dim intPoints As Integer

        Dim cdecDiscount As Decimal = 5D
        Dim decFinalCost As Decimal

        Dim strOrder As String = ""
        Dim strPayMessage As String = ""

        If IsNumeric(txtPoints.Text) Then
            intPoints = Convert.ToInt32(txtPoints.Text)
            strPoints = " after discount of " & intPoints.ToString() & " loyalty points."

            If radGC.Checked Then
                decPlatterCost = 49.99D
                strOrder = "Gourmet Cheese"
            ElseIf radPW.Checked Then
                decPlatterCost = 59.99D
                strOrder = "Pinwheel Wraps"
            ElseIf radV.Checked Then
                decPlatterCost = 29.99D
                strOrder = "Veggie"
            ElseIf radSC.Checked Then
                decPlatterCost = 49.99D
                strOrder = "Sausage and Cheese"
            ElseIf radF.Checked Then
                decPlatterCost = 29.99D
                strOrder = "Fruit"
            End If

            If radPrePay.Checked Then
                strPayMessage = " using Pre-Pay"
            ElseIf radPickup.Checked Then
                strPayMessage = " with Pay-on-Pickup"
            End If

            intPoints = Convert.ToInt32(intPoints / 10I)

            decPoints = (intPoints * cdecDiscount) / 100

            If decPoints > 1 Then
                decPoints = 1
            End If

            decFinalCost = decPlatterCost * (1 - decPoints)

            lblPayMessage.Text = "Your order " & strOrder & " platter costs " & decFinalCost.ToString("C") & strPayMessage & strPoints

        Else
            MsgBox("Please enter a valid number of points.", , "Input Error")
            Me.btnClear.PerformClick()
        End If

    End Sub
End Class
