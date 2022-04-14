<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog_Receipt
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Txt_Burger = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Txt_Chicken = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Txt_Dessert_and_Drinks = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Txt_Fries = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Txt_Total = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(170, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RECEIPT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Txt_Burger)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 65)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(230, 100)
        Me.Panel1.TabIndex = 1
        '
        'Txt_Burger
        '
        Me.Txt_Burger.BackColor = System.Drawing.SystemColors.Info
        Me.Txt_Burger.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Burger.Enabled = False
        Me.Txt_Burger.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txt_Burger.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Txt_Burger.Location = New System.Drawing.Point(7, 24)
        Me.Txt_Burger.Name = "Txt_Burger"
        Me.Txt_Burger.ReadOnly = True
        Me.Txt_Burger.Size = New System.Drawing.Size(218, 30)
        Me.Txt_Burger.TabIndex = 6
        Me.Txt_Burger.Text = "$0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 21)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Burger"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Txt_Chicken)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(248, 65)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(230, 100)
        Me.Panel2.TabIndex = 2
        '
        'Txt_Chicken
        '
        Me.Txt_Chicken.BackColor = System.Drawing.SystemColors.Info
        Me.Txt_Chicken.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Chicken.Enabled = False
        Me.Txt_Chicken.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txt_Chicken.ForeColor = System.Drawing.Color.Brown
        Me.Txt_Chicken.Location = New System.Drawing.Point(7, 24)
        Me.Txt_Chicken.Name = "Txt_Chicken"
        Me.Txt_Chicken.ReadOnly = True
        Me.Txt_Chicken.Size = New System.Drawing.Size(218, 30)
        Me.Txt_Chicken.TabIndex = 6
        Me.Txt_Chicken.Text = "$0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Chicken"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Txt_Dessert_and_Drinks)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(248, 171)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(230, 100)
        Me.Panel3.TabIndex = 4
        '
        'Txt_Dessert_and_Drinks
        '
        Me.Txt_Dessert_and_Drinks.BackColor = System.Drawing.SystemColors.Info
        Me.Txt_Dessert_and_Drinks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Dessert_and_Drinks.Enabled = False
        Me.Txt_Dessert_and_Drinks.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txt_Dessert_and_Drinks.ForeColor = System.Drawing.Color.Orange
        Me.Txt_Dessert_and_Drinks.Location = New System.Drawing.Point(7, 24)
        Me.Txt_Dessert_and_Drinks.Name = "Txt_Dessert_and_Drinks"
        Me.Txt_Dessert_and_Drinks.ReadOnly = True
        Me.Txt_Dessert_and_Drinks.Size = New System.Drawing.Size(218, 30)
        Me.Txt_Dessert_and_Drinks.TabIndex = 6
        Me.Txt_Dessert_and_Drinks.Text = "$0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 21)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Dessert and Drinks"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Txt_Fries)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(12, 171)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(230, 100)
        Me.Panel4.TabIndex = 3
        '
        'Txt_Fries
        '
        Me.Txt_Fries.BackColor = System.Drawing.SystemColors.Info
        Me.Txt_Fries.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Fries.Enabled = False
        Me.Txt_Fries.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txt_Fries.ForeColor = System.Drawing.Color.Fuchsia
        Me.Txt_Fries.Location = New System.Drawing.Point(7, 24)
        Me.Txt_Fries.Name = "Txt_Fries"
        Me.Txt_Fries.ReadOnly = True
        Me.Txt_Fries.Size = New System.Drawing.Size(218, 30)
        Me.Txt_Fries.TabIndex = 5
        Me.Txt_Fries.Text = "$0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 21)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fries"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.Button1)
        Me.Panel5.Controls.Add(Me.Txt_Total)
        Me.Panel5.Controls.Add(Me.Label6)
        Me.Panel5.Location = New System.Drawing.Point(12, 277)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(466, 118)
        Me.Panel5.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(289, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 30)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(378, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 30)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Txt_Total
        '
        Me.Txt_Total.BackColor = System.Drawing.SystemColors.Info
        Me.Txt_Total.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txt_Total.Enabled = False
        Me.Txt_Total.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Txt_Total.ForeColor = System.Drawing.Color.Green
        Me.Txt_Total.Location = New System.Drawing.Point(3, 34)
        Me.Txt_Total.Name = "Txt_Total"
        Me.Txt_Total.ReadOnly = True
        Me.Txt_Total.Size = New System.Drawing.Size(458, 30)
        Me.Txt_Total.TabIndex = 2
        Me.Txt_Total.Text = "$0"
        Me.Txt_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(204, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 21)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "TOTAL"
        '
        'Dialog_Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(488, 407)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Dialog_Receipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receipt"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Public WithEvents Txt_Burger As TextBox
    Public WithEvents Txt_Chicken As TextBox
    Public WithEvents Txt_Dessert_and_Drinks As TextBox
    Public WithEvents Txt_Fries As TextBox
    Public WithEvents Txt_Total As TextBox
End Class
