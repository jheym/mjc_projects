Public Class Form1

    Structure Pizza
        Dim name As String
        Dim phoneNumber As String
        Dim streetAddress As String
        Dim city As String
        Dim state As String
        Dim zip As String
        Dim size As String
        Dim crust As String
        Dim sauce As String
        Dim cheese As String
        Dim quantity As Integer
        Dim meats As String
        Dim veggies As String
        Dim completePizza As String
        Dim PizzaList As List(Of String)
    End Structure

    Dim sizeValidation As Boolean
    Dim sauceValidation As Boolean
    Dim crustValidation As Boolean
    Dim cheeseValidation As Boolean
    Dim strDigits As String = ""
    Dim newPizza As Pizza

    Private Sub rdoDelivery_MouseClick(sender As Object, e As MouseEventArgs) Handles rdoDelivery.MouseClick
        rdoTakeout.Checked = False
        pnlAddress.Visible = True
    End Sub
    Private Sub rdoTakeout_MouseClick(sender As Object, e As MouseEventArgs) Handles rdoTakeout.MouseClick
        rdoDelivery.Checked = False
        pnlAddress.Visible = False
    End Sub
    Private Sub rdoSmall_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSmall.CheckedChanged
        newPizza.size = "Small"
        sizeValidation = True
    End Sub
    Private Sub rdoMedium_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMedium.CheckedChanged
        newPizza.size = "Medium"
        sizeValidation = True
    End Sub
    Private Sub rdoLarge_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLarge.CheckedChanged
        newPizza.size = "Large"
        sizeValidation = True
    End Sub
    Private Sub rdoOriginal_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOriginal.CheckedChanged
        newPizza.crust = "original crust"
        crustValidation = True
    End Sub
    Private Sub rdoPan_CheckedChanged(sender As Object, e As EventArgs) Handles rdoPan.CheckedChanged
        newPizza.crust = "pan crust"
        crustValidation = True
    End Sub
    Private Sub rdoStuffed_CheckedChanged(sender As Object, e As EventArgs) Handles rdoStuffed.CheckedChanged
        newPizza.crust = "stuffed crust"
        crustValidation = True
    End Sub
    Private Sub rdoSauceTomato_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSauceTomato.CheckedChanged
        newPizza.sauce = "tomato sauce"
        sauceValidation = True
    End Sub
    Private Sub rdoSauceAlfredo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSauceAlfredo.CheckedChanged
        newPizza.sauce = "alfredo sauce"
        sauceValidation = True
    End Sub
    Private Sub rdoSauceBarbeque_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSauceBarbeque.CheckedChanged
        newPizza.sauce = "barbeque sauce"
        sauceValidation = True
    End Sub
    Private Sub rdoLightCheese_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLightCheese.CheckedChanged
        newPizza.cheese = "light cheese"
        cheeseValidation = True
    End Sub
    Private Sub rdoNormalCheese_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNormalCheese.CheckedChanged
        newPizza.cheese = "normal cheese"
        cheeseValidation = True
    End Sub
    Private Sub rdoExtraCheese_CheckedChanged(sender As Object, e As EventArgs) Handles rdoExtraCheese.CheckedChanged
        newPizza.cheese = "extra cheese"
        cheeseValidation = True
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MsgBox("Are you sure you want to exit?", vbYesNo) = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSubmit_click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtName.Text = "" Or strDigits.Length = 0 Or sizeValidation = False Or sauceValidation = False Or cheeseValidation = False Or crustValidation = False Or (rdoDelivery.Checked = False And rdoTakeout.Checked = False) Then
            MsgBox("Please enter all order information before continuing.")
            Exit Sub
        End If

        If rdoDelivery.Checked = True And (txtStreetAddress.Text = "" Or txtState.Text = "" Or txtZipCode.Text = "" Or txtCity.Text = "") Then
            MsgBox("Please enter a valid delivery address before continuing.")
            Exit Sub
        End If

        For Each chkbox As CheckBox In grpMeats.Controls
            If chkbox.Checked Then
                newPizza.meats = chkbox.Text + ", " + newPizza.meats
            End If
        Next

        For Each chkbox As CheckBox In grpVeggies.Controls
            If chkbox.Checked Then
                newPizza.veggies = chkbox.Text + ", " + newPizza.veggies
            End If
        Next

        If newPizza.PizzaList Is Nothing Then
            newPizza.PizzaList = New List(Of String)
        End If

        newPizza.quantity = nudQuantity.Value
        newPizza.completePizza = newPizza.quantity.ToString() + " " + newPizza.size + " " + newPizza.crust + " pizza with " + newPizza.sauce + ", " + newPizza.cheese + ", " + newPizza.meats + newPizza.veggies
        newPizza.completePizza = newPizza.completePizza.Substring(0, newPizza.completePizza.Length - 2) & ". "

        If Convert.ToInt32(newPizza.quantity) > 1 Then
            newPizza.completePizza = Replace(newPizza.completePizza, "pizza", "pizzas")
        End If

        newPizza.PizzaList.Add(newPizza.completePizza)

        Dim allPizzas As String = ""

        For Each item As String In newPizza.PizzaList
            allPizzas = allPizzas + vbNewLine + vbNewLine + item
        Next

        MsgBox(allPizzas)

    End Sub

    Private Sub txtPhoneNumber_Leave(sender As Object, e As EventArgs) Handles txtPhoneNumber.Leave
        If txtPhoneNumber.Text = Nothing Then
            Exit Sub
        End If

        For Each c As Char In txtPhoneNumber.Text.ToCharArray()
            If IsNumeric(c) Then
                strDigits &= c
            End If
        Next c
    End Sub
End Class
