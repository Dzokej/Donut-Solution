' Name:         Donut Shoppe Project
' Purpose:      Display the subtotal, sales tax, and total due.
' Programmer:   Mr. Koric - 4.5.2023

Option Explicit On
Option Strict On
Option Infer Off

'another change
Public Class frmMain
    Private Sub CalcSubtotal(ByRef decSubtotalCost As Decimal)
        ' Calculates the cost before sales tax.

        Select Case True
            Case radGlazed.Checked, radSugar.Checked
                decSubtotalCost = 1.05D
            Case radChocolate.Checked
                decSubtotalCost = 1.25D
            Case Else
                decSubtotalCost = 1.5D
        End Select

        Select Case True
            Case radRegular.Checked
                decSubtotalCost += 1.5D
            Case radCappuccino.Checked
                decSubtotalCost += 2.75D
        End Select
    End Sub

    Private Function GetSalesTax(ByVal decPurchase As Decimal) As Decimal
        ' Calculates and returns the sales tax.

        Return decPurchase * 0.06D
    End Function

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' Displays the subtotal, sales tax, and total due.

        Dim decSubtotal As Decimal
        Dim decSalesTax As Decimal
        Dim decTotal As Decimal

        ' Calculate subtotal.
        CalcSubtotal(decSubtotal)
        ' Calculate sales tax.
        decSalesTax = GetSalesTax(decSubtotal)
        decSalesTax = Math.Round(decSalesTax, 2)
        ' Calculate total due.
        decTotal = decSubtotal + decSalesTax

        ' Display subtotal, sales tax, and total due.
        lblSubtotal.Text = decSubtotal.ToString("N2")
        lblTax.Text = decSalesTax.ToString("N2")
        lblTotal.Text = decTotal.ToString("N2")
    End Sub

    Private Sub ClearOutput(sender As Object, e As EventArgs) Handles radCappuccino.CheckedChanged,
         radChocolate.CheckedChanged, radFilled.CheckedChanged, radGlazed.CheckedChanged,
         radNoCoffee.CheckedChanged, radRegular.CheckedChanged, radSugar.CheckedChanged

        lblSubtotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim dlgButton As DialogResult
        dlgButton = MessageBox.Show("Do you want to exit?", "Donut Shoppe",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButton = DialogResult.No Then
            e.Cancel = True
        Else
            MsgBox("Thank you for using our app!")
        End If

    End Sub
End Class
