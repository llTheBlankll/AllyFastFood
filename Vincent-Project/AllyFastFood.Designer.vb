<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AllyFastFood
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Receipt = New System.Windows.Forms.DataGridView()
        Me.col_category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_food = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Btn_Compute = New System.Windows.Forms.Button()
        Me.Lbl_price = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Numud_Quantity = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Btn_Close = New System.Windows.Forms.Button()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.Btn_Save = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Cmb_Food = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Cmb_Category = New System.Windows.Forms.ComboBox()
        CType(Me.Receipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Numud_Quantity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Receipt
        '
        Me.Receipt.BackgroundColor = System.Drawing.Color.White
        Me.Receipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Receipt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_category, Me.col_food, Me.col_quantity, Me.col_price})
        Me.Receipt.Dock = System.Windows.Forms.DockStyle.Right
        Me.Receipt.Location = New System.Drawing.Point(210, 0)
        Me.Receipt.Name = "Receipt"
        Me.Receipt.RowTemplate.Height = 25
        Me.Receipt.Size = New System.Drawing.Size(588, 383)
        Me.Receipt.TabIndex = 12
        '
        'col_category
        '
        Me.col_category.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_category.HeaderText = "Category"
        Me.col_category.Name = "col_category"
        Me.col_category.ReadOnly = True
        Me.col_category.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_food
        '
        Me.col_food.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_food.HeaderText = "Food"
        Me.col_food.Name = "col_food"
        Me.col_food.ReadOnly = True
        '
        'col_quantity
        '
        Me.col_quantity.HeaderText = "Quantity"
        Me.col_quantity.Name = "col_quantity"
        Me.col_quantity.ReadOnly = True
        '
        'col_price
        '
        Me.col_price.HeaderText = "Price"
        Me.col_price.Name = "col_price"
        Me.col_price.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.Btn_Compute)
        Me.Panel1.Controls.Add(Me.Lbl_price)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Numud_Quantity)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Btn_Close)
        Me.Panel1.Controls.Add(Me.Btn_Clear)
        Me.Panel1.Controls.Add(Me.Btn_Save)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Cmb_Food)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Cmb_Category)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(211, 383)
        Me.Panel1.TabIndex = 13
        '
        'Btn_Compute
        '
        Me.Btn_Compute.BackColor = System.Drawing.Color.RoyalBlue
        Me.Btn_Compute.FlatAppearance.BorderSize = 0
        Me.Btn_Compute.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Compute.ForeColor = System.Drawing.Color.White
        Me.Btn_Compute.Location = New System.Drawing.Point(11, 339)
        Me.Btn_Compute.Name = "Btn_Compute"
        Me.Btn_Compute.Size = New System.Drawing.Size(188, 32)
        Me.Btn_Compute.TabIndex = 23
        Me.Btn_Compute.Text = "COMPUTE"
        Me.Btn_Compute.UseVisualStyleBackColor = False
        '
        'Lbl_price
        '
        Me.Lbl_price.AutoSize = True
        Me.Lbl_price.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_price.ForeColor = System.Drawing.Color.Red
        Me.Lbl_price.Location = New System.Drawing.Point(11, 229)
        Me.Lbl_price.Name = "Lbl_price"
        Me.Lbl_price.Size = New System.Drawing.Size(32, 22)
        Me.Lbl_price.TabIndex = 22
        Me.Lbl_price.Text = "$0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 22)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Price"
        '
        'Numud_Quantity
        '
        Me.Numud_Quantity.Location = New System.Drawing.Point(11, 172)
        Me.Numud_Quantity.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Numud_Quantity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Numud_Quantity.Name = "Numud_Quantity"
        Me.Numud_Quantity.Size = New System.Drawing.Size(188, 31)
        Me.Numud_Quantity.TabIndex = 20
        Me.Numud_Quantity.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 22)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Quantity"
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Red
        Me.Btn_Close.FlatAppearance.BorderSize = 0
        Me.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Close.ForeColor = System.Drawing.Color.White
        Me.Btn_Close.Location = New System.Drawing.Point(108, 301)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(91, 32)
        Me.Btn_Close.TabIndex = 18
        Me.Btn_Close.Text = "Close"
        Me.Btn_Close.UseVisualStyleBackColor = False
        '
        'Btn_Clear
        '
        Me.Btn_Clear.BackColor = System.Drawing.Color.Yellow
        Me.Btn_Clear.FlatAppearance.BorderSize = 0
        Me.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Clear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Btn_Clear.Location = New System.Drawing.Point(11, 301)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(91, 32)
        Me.Btn_Clear.TabIndex = 17
        Me.Btn_Clear.Text = "Clear"
        Me.Btn_Clear.UseVisualStyleBackColor = False
        '
        'Btn_Save
        '
        Me.Btn_Save.BackColor = System.Drawing.Color.Lime
        Me.Btn_Save.FlatAppearance.BorderSize = 0
        Me.Btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Save.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Btn_Save.Location = New System.Drawing.Point(11, 263)
        Me.Btn_Save.Name = "Btn_Save"
        Me.Btn_Save.Size = New System.Drawing.Size(188, 32)
        Me.Btn_Save.TabIndex = 16
        Me.Btn_Save.Text = "Save"
        Me.Btn_Save.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 86)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 22)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Food"
        '
        'Cmb_Food
        '
        Me.Cmb_Food.BackColor = System.Drawing.SystemColors.Control
        Me.Cmb_Food.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Food.FormattingEnabled = True
        Me.Cmb_Food.Location = New System.Drawing.Point(11, 112)
        Me.Cmb_Food.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Cmb_Food.Name = "Cmb_Food"
        Me.Cmb_Food.Size = New System.Drawing.Size(188, 30)
        Me.Cmb_Food.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 22)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Category"
        '
        'Cmb_Category
        '
        Me.Cmb_Category.BackColor = System.Drawing.SystemColors.Control
        Me.Cmb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Category.FormattingEnabled = True
        Me.Cmb_Category.Items.AddRange(New Object() {"Burger", "Chicken", "Fries", "Dessert", "Drinks"})
        Me.Cmb_Category.Location = New System.Drawing.Point(11, 39)
        Me.Cmb_Category.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Cmb_Category.Name = "Cmb_Category"
        Me.Cmb_Category.Size = New System.Drawing.Size(188, 30)
        Me.Cmb_Category.TabIndex = 12
        '
        'AllyFastFood
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(798, 383)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Receipt)
        Me.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "AllyFastFood"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ally's Fast Food"
        CType(Me.Receipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Numud_Quantity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Receipt As DataGridView
    Friend WithEvents col_category As DataGridViewTextBoxColumn
    Friend WithEvents col_food As DataGridViewTextBoxColumn
    Friend WithEvents col_quantity As DataGridViewTextBoxColumn
    Friend WithEvents col_price As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Lbl_price As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Numud_Quantity As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Close As Button
    Friend WithEvents Btn_Clear As Button
    Friend WithEvents Btn_Save As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Cmb_Food As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Cmb_Category As ComboBox
    Friend WithEvents Btn_Compute As Button
End Class
