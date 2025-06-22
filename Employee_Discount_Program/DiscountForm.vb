Public Class DiscountForm
    Dim dblTotalBeforeDiscountForTheDay As Double
    Dim dblTotalAfterDiscountsApplied As Double
    Dim dblTotalOfTodaysPurchase As Double
    Dim dblEmployeeDiscountForThisPurchase As Double
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Declare Variables
        Dim intNumberOfYearsEmployed As Integer
        Dim dblYearToDateAmountOfPreviousPurchasesBeforeDiscount As Double

        Dim dblEmployeeDiscountPercentage As Double
        Dim dblYearToDateAmountOfDiscountInDollars As Double
        Dim dblTotalPurchaseTodayBeforeDiscount As Double
        Dim dblTotalWithDiscount As Double

        'Get and Validate Inputs

        If txtName.Text = String.Empty Then
            MessageBox.Show("Name is Required")
            txtName.Focus()
            Exit Sub
        End If

        If IsNumeric(txtNumberOfYearsEmployed.Text) Then
            intNumberOfYearsEmployed = txtNumberOfYearsEmployed.Text
            If intNumberOfYearsEmployed < 1 Then
                MessageBox.Show("Number of Years Employed Should be Greater Than 0")
                txtNumberOfYearsEmployed.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Number of Years Employed is Required and Must be Numeric")
            txtNumberOfYearsEmployed.Focus()
            Exit Sub
        End If



        If IsNumeric(txtYearToDatePreviousPurchases.Text) Then
            dblYearToDateAmountOfPreviousPurchasesBeforeDiscount = txtYearToDatePreviousPurchases.Text
            If dblYearToDateAmountOfPreviousPurchasesBeforeDiscount < 0 Then
                MessageBox.Show("Year to Date Amount of Previous Purchases Must be Greater Than or Equal to 0")
                txtYearToDatePreviousPurchases.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Year to Date Previous Purchases Must Exist and be Numeric")
            txtYearToDatePreviousPurchases.Focus()
            Exit Sub
        End If

        If IsNumeric(txtTotalOfTodaysPurchase.Text) Then
            dblTotalOfTodaysPurchase = txtTotalOfTodaysPurchase.Text
            If dblTotalOfTodaysPurchase < 0 Then
                MessageBox.Show("Total Purchase Must be Greater Than or Equal to 0")
                txtTotalOfTodaysPurchase.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Total of Todays Purchase Is Required and Must be Numeric")
            txtTotalOfTodaysPurchase.Focus()
            Exit Sub
        End If

        'Do Calculations

        If radHourly.Checked And intNumberOfYearsEmployed > 15 Then
            dblEmployeeDiscountPercentage = 0.3
        Else
            If radManager.Checked And intNumberOfYearsEmployed > 15 Then
                dblEmployeeDiscountPercentage = 0.4
            End If
        End If

        If radHourly.Checked And (intNumberOfYearsEmployed < 16) And (intNumberOfYearsEmployed > 10) Then
            dblEmployeeDiscountPercentage = 0.25
        Else
            If radManager.Checked And (intNumberOfYearsEmployed < 16) And (intNumberOfYearsEmployed > 10) Then
                dblEmployeeDiscountPercentage = 0.35
            End If
        End If

        If radHourly.Checked And (intNumberOfYearsEmployed < 11) And (intNumberOfYearsEmployed > 6) Then
            dblEmployeeDiscountPercentage = 0.2
        Else
            If radManager.Checked And (intNumberOfYearsEmployed < 11) And (intNumberOfYearsEmployed > 6) Then
                dblEmployeeDiscountPercentage = 0.3
            End If
        End If

        If radHourly.Checked And (intNumberOfYearsEmployed < 7) And (intNumberOfYearsEmployed > 3) Then
            dblEmployeeDiscountPercentage = 0.14
        Else
            If radManager.Checked And (intNumberOfYearsEmployed < 7) And (intNumberOfYearsEmployed > 3) Then
                dblEmployeeDiscountPercentage = 0.24
            End If
        End If

        If radHourly.Checked And (intNumberOfYearsEmployed < 4) And (intNumberOfYearsEmployed > 0) Then
            dblEmployeeDiscountPercentage = 0.1
        Else
            If radManager.Checked And (intNumberOfYearsEmployed < 4) And (intNumberOfYearsEmployed > 0) Then
                dblEmployeeDiscountPercentage = 0.2
            End If
        End If

        dblYearToDateAmountOfDiscountInDollars = dblYearToDateAmountOfPreviousPurchasesBeforeDiscount * dblEmployeeDiscountPercentage
        dblTotalPurchaseTodayBeforeDiscount = dblTotalOfTodaysPurchase

        If dblYearToDateAmountOfDiscountInDollars > 200 Then
            dblEmployeeDiscountForThisPurchase = 0
        Else
            If dblYearToDateAmountOfDiscountInDollars + (dblTotalOfTodaysPurchase * dblEmployeeDiscountPercentage) < 200 Then
                dblEmployeeDiscountForThisPurchase = dblTotalOfTodaysPurchase * dblEmployeeDiscountPercentage
            Else
                If dblYearToDateAmountOfDiscountInDollars + (dblTotalOfTodaysPurchase * dblEmployeeDiscountPercentage) > 200 Then
                    dblEmployeeDiscountForThisPurchase = 200 - dblYearToDateAmountOfDiscountInDollars
                End If
            End If
        End If

        dblTotalWithDiscount = dblTotalOfTodaysPurchase - dblEmployeeDiscountForThisPurchase

        'Display Local Outputs in currency

        lblEmployeeDiscountPercentage.Text = FormatPercent(dblEmployeeDiscountPercentage)
        lblYearToDateDiscount.Text = FormatCurrency(dblYearToDateAmountOfDiscountInDollars)
        lblTotalPurchaseBeforeDiscount.Text = FormatCurrency(dblTotalPurchaseTodayBeforeDiscount)
        lblEmployeeDiscount.Text = FormatCurrency(dblEmployeeDiscountForThisPurchase)
        lblTotalWithDiscount.Text = FormatCurrency(dblTotalWithDiscount)

    End Sub

    Private Sub btnNextEmployee_Click(sender As Object, e As EventArgs) Handles btnNextEmployee.Click

        'Reset the inputs for the next employee
        txtName.Clear()
        txtNumberOfYearsEmployed.Clear()
        txtYearToDatePreviousPurchases.Clear()
        txtTotalOfTodaysPurchase.Clear()

        radHourly.Checked = True
        radManager.Checked = False

        lblEmployeeDiscountPercentage.ResetText()
        lblYearToDateDiscount.ResetText()
        lblTotalPurchaseBeforeDiscount.ResetText()
        lblEmployeeDiscount.ResetText()
        lblTotalWithDiscount.ResetText()

        txtName.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnDiscountSummary_Click(sender As Object, e As EventArgs) Handles btnDiscountSummary.Click
        'Do calculations
        dblTotalBeforeDiscountForTheDay += dblTotalOfTodaysPurchase
        dblTotalAfterDiscountsApplied = dblTotalAfterDiscountsApplied + (dblTotalOfTodaysPurchase - dblEmployeeDiscountForThisPurchase)

        'Place outputs in messagebox

        MessageBox.Show("Total Before Discounts for the day is " & FormatCurrency(dblTotalBeforeDiscountForTheDay) & vbCr & "Total After Discounts Applied is " & FormatCurrency(dblTotalAfterDiscountsApplied))



    End Sub
End Class
