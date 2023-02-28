' Project name: Comic registration
' Author: Zachary Conley
' Date: February 28, 2023
' Description: This application is used to register for a comic event and allows the user
' to insert a number of guests while seeing how much the regsitration will cost.
Public Class Form1
    Private Sub Btncalculate_Click(sender As Object, e As EventArgs) Handles Btncalculate.Click
        ' This event handler is activated when the user clicks the calculate button and shows the cost
        ' for the registration as it correlates with the input of guests above.

        Dim intgroup As Integer = 0
        Dim decRegistration As Decimal
        Dim decTotalCost As Decimal
        Dim decSuperHero As Decimal = 380D
        Dim decAutographs As Decimal = 275D
        Dim decConvention As Decimal = 209D

        ' added this for fun, when the calculation is complete, the registration total label appears with the total, visibility turned to false when clear is hit
        Lblreg.Visible = True

        If IsNumeric(TxtGroup.Text) Then
            intgroup = Convert.ToInt32(TxtGroup.Text)
            If intgroup > 0 And intgroup < 20 Then
                If RadCSE.Checked Then
                    decRegistration = decSuperHero
                ElseIf RadCA.Checked Then
                    decRegistration = decAutographs
                ElseIf RadC.Checked Then
                    decRegistration = decConvention
                End If

                decTotalCost = (intgroup * decRegistration)
                Lblcostreg.Text = decTotalCost.ToString("C")
            Else
                MsgBox("Enter a positive number between 1 and 20", , "invalid number error")
            End If

        Else
            MsgBox("Enter a reasonable number between 1 and 20", , "Invalid entry error")
        End If
    End Sub

    Private Sub Btnclear_Click(sender As Object, e As EventArgs) Handles Btnclear.Click
        ' This event handler is activated when the clear button is clicked and clears the whole form allowing the user
        ' to restart his/her form submission

        TxtGroup.Clear()
        Lblcostreg.Text = ""
        RadCSE.Checked = False
        RadCA.Checked = False
        RadC.Checked = True
        TxtGroup.Focus()
        Lblreg.Visible = False
    End Sub
End Class
