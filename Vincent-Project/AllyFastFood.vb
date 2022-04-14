Public Class AllyFastFood

    Dim food_price As Double
    Dim total_saved_price As Double

    Private Sub Cmb_Category_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cmb_Category.SelectedIndexChanged
        Cmb_Food.Text = ""
        Numud_Quantity.Value = 1
        If Cmb_Category.Text = "Burger" Then
            Cmb_Food.Items.Clear()
            Cmb_Food.Items.AddRange(New String() {"Ally's Burger", "Cheese Burger", "Aloha Burger", "Pepper Mushroom"})
        ElseIf Cmb_Category.Text = "Chicken" Then
            Cmb_Food.Items.Clear()
            Cmb_Food.Items.AddRange(New String() {"Ally's Chicken", "Garlic Parmesan", "Buffalo Wings", "Sweet Honey Chicken"})
        ElseIf Cmb_Category.Text = "Fries" Then
            Cmb_Food.Items.Clear()
            Cmb_Food.Items.AddRange(New String() {"Regular Fries", "Cheezy Fries", "BBQ Fries", "Sweet Sour Fries"})
        ElseIf Cmb_Category.Text = "Dessert" Then
            Cmb_Food.Items.Clear()
            Cmb_Food.Items.AddRange(New String() {"Sundae", "Halo-Halo", "Apple Pie", "Choco Pie"})
        ElseIf Cmb_Category.Text = "Drinks" Then
            Cmb_Food.Items.Clear()
            Cmb_Food.Items.AddRange(New String() {"Soda", "Ice Tea", "Ice Coffee", "Slushie"})
        End If
    End Sub

    Private Sub Cmb_Food_TextChanged(sender As Object, e As EventArgs) Handles Cmb_Food.TextChanged
        If Cmb_Food.Text = "Ally's Burger" Then
            food_price = 2
        ElseIf Cmb_Food.Text = "Cheese Burger" Then
            food_price = 1.5
        ElseIf Cmb_Food.Text = "Aloha Burger" Then
            food_price = 3
        ElseIf Cmb_Food.Text = "Pepper Mushroom" Then
            food_price = 2.5
        ElseIf Cmb_Food.Text = "Regular Fries" Then
            food_price = 1
        ElseIf Cmb_Food.Text = "Cheezy Fries" Then
            food_price = 1.25
        ElseIf Cmb_Food.Text = "BBQ Fries" Then
            food_price = 2
        ElseIf Cmb_Food.Text = "Sweet Sour Fries" Then
            food_price = 2.25
        ElseIf Cmb_Category.Text = "Chicken" Then
            food_price = 15
        ElseIf Cmb_Category.Text = "Dessert" Then
            food_price = 5
        ElseIf Cmb_Category.Text = "Drinks" Then
            food_price = 3
        End If

        total_saved_price = (food_price * Numud_Quantity.Value)
        Lbl_price.Text = "$" + (food_price * Numud_Quantity.Value).ToString
    End Sub

    Public Sub resetAllForm(exclude_receipt As Boolean)
        Cmb_Category.ResetText()
        Cmb_Food.ResetText()
        Numud_Quantity.Value = 1
        Lbl_price.Text = "$" + (food_price * Numud_Quantity.Value).ToString

        If exclude_receipt = False Then
            Receipt.Rows.Clear()
        End If
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Numud_Quantity_ValueChanged(sender As Object, e As EventArgs) Handles Numud_Quantity.ValueChanged
        total_saved_price = (food_price * Numud_Quantity.Value)
        Lbl_price.Text = "$" + (food_price * Numud_Quantity.Value).ToString
    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click
        resetAllForm(False)
    End Sub

    Private Sub Btn_Save_Click(sender As Object, e As EventArgs) Handles Btn_Save.Click
        Dim category As String = Cmb_Category.Text
        Dim quantity As Integer = Numud_Quantity.Value
        Dim food_name As String = Cmb_Food.Text

        If Cmb_Food.Text = "" Then
            MsgBox("Enter Food", MsgBoxStyle.Information)
            resetAllForm(True)
        Else
            Receipt.Rows.Add(New String() {category, food_name, quantity, "$" + total_saved_price.ToString})
            resetAllForm(True)
        End If
        resetAllForm(True)
    End Sub

    Private Sub Btn_Compute_Click(sender As Object, e As EventArgs) Handles Btn_Compute.Click
        If Receipt.Rows.Count = 0 Then
            MsgBox("Please enter a product.", MsgBoxStyle.Information)
        Else
            Dim burger_total_price As Double
            Dim chicken_total_price As Double
            Dim fries_total_price As Double
            Dim dessert_and_drinks_total_price As Double
            Dim all_total_price As Double

            For Each row As DataGridViewRow In Receipt.Rows
                If row.Cells(0).Value = "Burger" Then
                    burger_total_price += Double.Parse(Replace(row.Cells(3).Value, "$", ""))
                ElseIf row.Cells(0).Value = "Chicken" Then
                    chicken_total_price += Double.Parse(Replace(row.Cells(3).Value, "$", ""))
                ElseIf row.Cells(0).Value = "Fries" Then
                    fries_total_price += Double.Parse(Replace(row.Cells(3).Value, "$", ""))
                ElseIf row.Cells(0).Value = "Dessert" Then
                    dessert_and_drinks_total_price += Double.Parse(Replace(row.Cells(3).Value, "$", ""))
                ElseIf row.Cells(0).Value = "Drinks" Then
                    dessert_and_drinks_total_price += Double.Parse(Replace(row.Cells(3).Value, "$", ""))
                End If
            Next

            all_total_price = burger_total_price + chicken_total_price + fries_total_price + dessert_and_drinks_total_price

            ' Show Receipt
            Dialog_Receipt.Txt_Burger.Text = "$" + burger_total_price.ToString
            Dialog_Receipt.Txt_Chicken.Text = "$" + chicken_total_price.ToString
            Dialog_Receipt.Txt_Fries.Text = "$" + fries_total_price.ToString
            Dialog_Receipt.Txt_Dessert_and_Drinks.Text = "$" + dessert_and_drinks_total_price.ToString
            Dialog_Receipt.Txt_Total.Text = "$" + all_total_price.ToString
            Dialog_Receipt.Show()
        End If
    End Sub

    Private Sub AllyFastFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Receipt.Rows.Clear()
    End Sub
End Class
