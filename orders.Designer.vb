<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class orders
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.OrdersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmumaDataSet2 = New EMUMA.emumaDataSet2()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MinDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QTYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmumaDataSet1 = New EMUMA.emumaDataSet1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.OrdersTableAdapter = New EMUMA.emumaDataSet1TableAdapters.ordersTableAdapter()
        Me.OrdersTableAdapter1 = New EMUMA.emumaDataSet2TableAdapters.ordersTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.OrdersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmumaDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmumaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ListBox1)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Location = New System.Drawing.Point(12, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1454, 576)
        Me.Panel1.TabIndex = 0
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.OrdersBindingSource1
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(1040, 229)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(141, 134)
        Me.ListBox1.TabIndex = 5
        '
        'OrdersBindingSource1
        '
        Me.OrdersBindingSource1.DataMember = "orders"
        Me.OrdersBindingSource1.DataSource = Me.EmumaDataSet2
        '
        'EmumaDataSet2
        '
        Me.EmumaDataSet2.DataSetName = "emumaDataSet2"
        Me.EmumaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(1160, 144)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(125, 21)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "view all items"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.MinDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.QTYDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OrdersBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(894, 455)
        Me.DataGridView1.TabIndex = 3
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Width = 150
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Width = 200
        '
        'MinDataGridViewTextBoxColumn
        '
        Me.MinDataGridViewTextBoxColumn.DataPropertyName = "Min"
        Me.MinDataGridViewTextBoxColumn.HeaderText = "Min"
        Me.MinDataGridViewTextBoxColumn.Name = "MinDataGridViewTextBoxColumn"
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "Stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'QTYDataGridViewTextBoxColumn
        '
        Me.QTYDataGridViewTextBoxColumn.DataPropertyName = "QTY"
        Me.QTYDataGridViewTextBoxColumn.HeaderText = "QTY"
        Me.QTYDataGridViewTextBoxColumn.Name = "QTYDataGridViewTextBoxColumn"
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        '
        'OrdersBindingSource
        '
        Me.OrdersBindingSource.DataMember = "orders"
        Me.OrdersBindingSource.DataSource = Me.EmumaDataSet1
        '
        'EmumaDataSet1
        '
        Me.EmumaDataSet1.DataSetName = "emumaDataSet1"
        Me.EmumaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1157, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "click grid after supplier selection"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1113, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "supplier"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(1116, 57)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(306, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'OrdersTableAdapter
        '
        Me.OrdersTableAdapter.ClearBeforeFill = True
        '
        'OrdersTableAdapter1
        '
        Me.OrdersTableAdapter1.ClearBeforeFill = True
        '
        'orders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1493, 611)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "orders"
        Me.Text = "orders"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.OrdersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmumaDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmumaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents EmumaDataSet1 As emumaDataSet1
    Friend WithEvents OrdersBindingSource As BindingSource
    Friend WithEvents OrdersTableAdapter As emumaDataSet1TableAdapters.ordersTableAdapter
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QTYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents EmumaDataSet2 As emumaDataSet2
    Friend WithEvents OrdersBindingSource1 As BindingSource
    Friend WithEvents OrdersTableAdapter1 As emumaDataSet2TableAdapters.ordersTableAdapter
End Class
