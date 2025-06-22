<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DiscountForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtNumberOfYearsEmployed = New System.Windows.Forms.TextBox()
        Me.txtYearToDatePreviousPurchases = New System.Windows.Forms.TextBox()
        Me.txtTotalOfTodaysPurchase = New System.Windows.Forms.TextBox()
        Me.radManager = New System.Windows.Forms.RadioButton()
        Me.radHourly = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblEmployeeDiscountPercentage = New System.Windows.Forms.Label()
        Me.lblYearToDateDiscount = New System.Windows.Forms.Label()
        Me.lblTotalPurchaseBeforeDiscount = New System.Windows.Forms.Label()
        Me.lblEmployeeDiscount = New System.Windows.Forms.Label()
        Me.lblTotalWithDiscount = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnNextEmployee = New System.Windows.Forms.Button()
        Me.btnDiscountSummary = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Number of Years Employed:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Year to Date Previous Purchases:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Employee Status:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Total of Today's Purchase:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(285, 28)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 22)
        Me.txtName.TabIndex = 5
        '
        'txtNumberOfYearsEmployed
        '
        Me.txtNumberOfYearsEmployed.Location = New System.Drawing.Point(285, 68)
        Me.txtNumberOfYearsEmployed.Name = "txtNumberOfYearsEmployed"
        Me.txtNumberOfYearsEmployed.Size = New System.Drawing.Size(100, 22)
        Me.txtNumberOfYearsEmployed.TabIndex = 6
        '
        'txtYearToDatePreviousPurchases
        '
        Me.txtYearToDatePreviousPurchases.Location = New System.Drawing.Point(285, 112)
        Me.txtYearToDatePreviousPurchases.Name = "txtYearToDatePreviousPurchases"
        Me.txtYearToDatePreviousPurchases.Size = New System.Drawing.Size(100, 22)
        Me.txtYearToDatePreviousPurchases.TabIndex = 7
        '
        'txtTotalOfTodaysPurchase
        '
        Me.txtTotalOfTodaysPurchase.Location = New System.Drawing.Point(285, 162)
        Me.txtTotalOfTodaysPurchase.Name = "txtTotalOfTodaysPurchase"
        Me.txtTotalOfTodaysPurchase.Size = New System.Drawing.Size(100, 22)
        Me.txtTotalOfTodaysPurchase.TabIndex = 8
        '
        'radManager
        '
        Me.radManager.AutoSize = True
        Me.radManager.Location = New System.Drawing.Point(261, 228)
        Me.radManager.Name = "radManager"
        Me.radManager.Size = New System.Drawing.Size(85, 21)
        Me.radManager.TabIndex = 10
        Me.radManager.TabStop = True
        Me.radManager.Text = "Manager"
        Me.radManager.UseVisualStyleBackColor = True
        '
        'radHourly
        '
        Me.radHourly.AutoSize = True
        Me.radHourly.Checked = True
        Me.radHourly.Location = New System.Drawing.Point(162, 228)
        Me.radHourly.Name = "radHourly"
        Me.radHourly.Size = New System.Drawing.Size(70, 21)
        Me.radHourly.TabIndex = 11
        Me.radHourly.TabStop = True
        Me.radHourly.Text = "Hourly"
        Me.radHourly.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.radHourly)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.radManager)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTotalOfTodaysPurchase)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtYearToDatePreviousPurchases)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNumberOfYearsEmployed)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 277)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Data"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(210, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Employee Discount Percentage:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Year to Date Discount:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(212, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Total Purchase before Discount:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Employee Discount:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 218)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(135, 17)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Total With Discount:"
        '
        'lblEmployeeDiscountPercentage
        '
        Me.lblEmployeeDiscountPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeDiscountPercentage.Location = New System.Drawing.Point(287, 23)
        Me.lblEmployeeDiscountPercentage.Name = "lblEmployeeDiscountPercentage"
        Me.lblEmployeeDiscountPercentage.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployeeDiscountPercentage.TabIndex = 18
        '
        'lblYearToDateDiscount
        '
        Me.lblYearToDateDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblYearToDateDiscount.Location = New System.Drawing.Point(287, 66)
        Me.lblYearToDateDiscount.Name = "lblYearToDateDiscount"
        Me.lblYearToDateDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblYearToDateDiscount.TabIndex = 19
        '
        'lblTotalPurchaseBeforeDiscount
        '
        Me.lblTotalPurchaseBeforeDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalPurchaseBeforeDiscount.Location = New System.Drawing.Point(287, 112)
        Me.lblTotalPurchaseBeforeDiscount.Name = "lblTotalPurchaseBeforeDiscount"
        Me.lblTotalPurchaseBeforeDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalPurchaseBeforeDiscount.TabIndex = 20
        '
        'lblEmployeeDiscount
        '
        Me.lblEmployeeDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployeeDiscount.Location = New System.Drawing.Point(287, 162)
        Me.lblEmployeeDiscount.Name = "lblEmployeeDiscount"
        Me.lblEmployeeDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblEmployeeDiscount.TabIndex = 21
        '
        'lblTotalWithDiscount
        '
        Me.lblTotalWithDiscount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotalWithDiscount.Location = New System.Drawing.Point(287, 212)
        Me.lblTotalWithDiscount.Name = "lblTotalWithDiscount"
        Me.lblTotalWithDiscount.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalWithDiscount.TabIndex = 22
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblTotalWithDiscount)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblEmployeeDiscount)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblTotalPurchaseBeforeDiscount)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblYearToDateDiscount)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblEmployeeDiscountPercentage)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 334)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(413, 288)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totals:"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(21, 662)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(90, 43)
        Me.btnCalculate.TabIndex = 24
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnNextEmployee
        '
        Me.btnNextEmployee.Location = New System.Drawing.Point(133, 662)
        Me.btnNextEmployee.Name = "btnNextEmployee"
        Me.btnNextEmployee.Size = New System.Drawing.Size(90, 43)
        Me.btnNextEmployee.TabIndex = 25
        Me.btnNextEmployee.Text = "Next Employee"
        Me.btnNextEmployee.UseVisualStyleBackColor = True
        '
        'btnDiscountSummary
        '
        Me.btnDiscountSummary.Location = New System.Drawing.Point(248, 662)
        Me.btnDiscountSummary.Name = "btnDiscountSummary"
        Me.btnDiscountSummary.Size = New System.Drawing.Size(90, 43)
        Me.btnDiscountSummary.TabIndex = 26
        Me.btnDiscountSummary.Text = "Discount Summary"
        Me.btnDiscountSummary.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(358, 662)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 43)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 734)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDiscountSummary)
        Me.Controls.Add(Me.btnNextEmployee)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Employee Discounts"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNumberOfYearsEmployed As TextBox
    Friend WithEvents txtYearToDatePreviousPurchases As TextBox
    Friend WithEvents txtTotalOfTodaysPurchase As TextBox
    Friend WithEvents radManager As RadioButton
    Friend WithEvents radHourly As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblEmployeeDiscountPercentage As Label
    Friend WithEvents lblYearToDateDiscount As Label
    Friend WithEvents lblTotalPurchaseBeforeDiscount As Label
    Friend WithEvents lblEmployeeDiscount As Label
    Friend WithEvents lblTotalWithDiscount As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnNextEmployee As Button
    Friend WithEvents btnDiscountSummary As Button
    Friend WithEvents btnExit As Button
End Class
