
namespace POLIRUBRO.capaPresentacion
{
    partial class Facturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_hora = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_fecha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_Id = new System.Windows.Forms.TextBox();
            this.label_fraccionable = new System.Windows.Forms.Label();
            this.textBox_cantidad_vender = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_unidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_precio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_stock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_buscar_producto = new System.Windows.Forms.Button();
            this.textBox_codigo_ean = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_ventas = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_barra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_a_vender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.X = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_total = new System.Windows.Forms.TextBox();
            this.comboBox_metodo_pago = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_descuento = new System.Windows.Forms.TextBox();
            this.button_vender = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metodoDePagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalDiario = new System.Windows.Forms.TextBox();
            this.timer_hora = new System.Windows.Forms.Timer(this.components);
            this.btnCierreCaja = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Facturacion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_hora);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.textBox_fecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(16, 114);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(211, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Datos del dia  ";
            // 
            // textBox_hora
            // 
            this.textBox_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_hora.Location = new System.Drawing.Point(81, 71);
            this.textBox_hora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_hora.Name = "textBox_hora";
            this.textBox_hora.ReadOnly = true;
            this.textBox_hora.Size = new System.Drawing.Size(99, 26);
            this.textBox_hora.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 75);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 20);
            this.label15.TabIndex = 2;
            this.label15.Text = "Hora:";
            // 
            // textBox_fecha
            // 
            this.textBox_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_fecha.Location = new System.Drawing.Point(81, 37);
            this.textBox_fecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_fecha.Name = "textBox_fecha";
            this.textBox_fecha.ReadOnly = true;
            this.textBox_fecha.Size = new System.Drawing.Size(99, 26);
            this.textBox_fecha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.textBox_Id);
            this.groupBox2.Controls.Add(this.label_fraccionable);
            this.groupBox2.Controls.Add(this.textBox_cantidad_vender);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_unidad);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBox_precio);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_stock);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_Nombre);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button_buscar_producto);
            this.groupBox2.Controls.Add(this.textBox_codigo_ean);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(260, 52);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1049, 219);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "  Informacion del Producto  ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(899, 135);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "Id Producto";
            // 
            // textBox_Id
            // 
            this.textBox_Id.Location = new System.Drawing.Point(903, 159);
            this.textBox_Id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Id.Name = "textBox_Id";
            this.textBox_Id.ReadOnly = true;
            this.textBox_Id.Size = new System.Drawing.Size(109, 29);
            this.textBox_Id.TabIndex = 16;
            // 
            // label_fraccionable
            // 
            this.label_fraccionable.AutoSize = true;
            this.label_fraccionable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_fraccionable.Location = new System.Drawing.Point(211, 166);
            this.label_fraccionable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_fraccionable.Name = "label_fraccionable";
            this.label_fraccionable.Size = new System.Drawing.Size(16, 24);
            this.label_fraccionable.TabIndex = 15;
            this.label_fraccionable.Text = "-";
            // 
            // textBox_cantidad_vender
            // 
            this.textBox_cantidad_vender.Location = new System.Drawing.Point(348, 162);
            this.textBox_cantidad_vender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_cantidad_vender.Name = "textBox_cantidad_vender";
            this.textBox_cantidad_vender.Size = new System.Drawing.Size(179, 29);
            this.textBox_cantidad_vender.TabIndex = 14;
            this.textBox_cantidad_vender.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_cantidad_vender_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(344, 140);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "Cantidad  a vender";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 166);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 24);
            this.label9.TabIndex = 12;
            this.label9.Text = "Es Fraccionable: ";
            // 
            // textBox_unidad
            // 
            this.textBox_unidad.Location = new System.Drawing.Point(868, 71);
            this.textBox_unidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_unidad.Name = "textBox_unidad";
            this.textBox_unidad.ReadOnly = true;
            this.textBox_unidad.Size = new System.Drawing.Size(144, 29);
            this.textBox_unidad.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(864, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tipo de unidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(839, 74);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "X";
            // 
            // textBox_precio
            // 
            this.textBox_precio.Location = new System.Drawing.Point(732, 71);
            this.textBox_precio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_precio.Name = "textBox_precio";
            this.textBox_precio.ReadOnly = true;
            this.textBox_precio.Size = new System.Drawing.Size(97, 29);
            this.textBox_precio.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(745, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Precio";
            // 
            // textBox_stock
            // 
            this.textBox_stock.Location = new System.Drawing.Point(587, 71);
            this.textBox_stock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_stock.Name = "textBox_stock";
            this.textBox_stock.ReadOnly = true;
            this.textBox_stock.Size = new System.Drawing.Size(100, 29);
            this.textBox_stock.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(603, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Stock";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(348, 73);
            this.textBox_Nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.ReadOnly = true;
            this.textBox_Nombre.Size = new System.Drawing.Size(180, 29);
            this.textBox_Nombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(367, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Producto";
            // 
            // button_buscar_producto
            // 
            this.button_buscar_producto.BackColor = System.Drawing.Color.Black;
            this.button_buscar_producto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_buscar_producto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_buscar_producto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.button_buscar_producto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button_buscar_producto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_buscar_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_buscar_producto.ForeColor = System.Drawing.SystemColors.Info;
            this.button_buscar_producto.Location = new System.Drawing.Point(229, 73);
            this.button_buscar_producto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_buscar_producto.Name = "button_buscar_producto";
            this.button_buscar_producto.Size = new System.Drawing.Size(95, 31);
            this.button_buscar_producto.TabIndex = 2;
            this.button_buscar_producto.Text = "Buscar";
            this.button_buscar_producto.UseVisualStyleBackColor = false;
            this.button_buscar_producto.Click += new System.EventHandler(this.button_buscar_producto_Click);
            // 
            // textBox_codigo_ean
            // 
            this.textBox_codigo_ean.Location = new System.Drawing.Point(27, 73);
            this.textBox_codigo_ean.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_codigo_ean.Name = "textBox_codigo_ean";
            this.textBox_codigo_ean.Size = new System.Drawing.Size(176, 29);
            this.textBox_codigo_ean.TabIndex = 1;
            this.textBox_codigo_ean.TextChanged += new System.EventHandler(this.textBox_codigo_ean_TextChanged);
            this.textBox_codigo_ean.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_codigo_ean_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 47);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Codigo del Producto:";
            // 
            // dgv_ventas
            // 
            this.dgv_ventas.AllowUserToAddRows = false;
            this.dgv_ventas.BackgroundColor = System.Drawing.Color.LavenderBlush;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ventas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ventas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Codigo_barra,
            this.Producto,
            this.Precio,
            this.Cantidad_a_vender,
            this.Unidad,
            this.SubTotal,
            this.Descuento,
            this.X});
            this.dgv_ventas.GridColor = System.Drawing.Color.DarkSlateGray;
            this.dgv_ventas.Location = new System.Drawing.Point(260, 306);
            this.dgv_ventas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_ventas.Name = "dgv_ventas";
            this.dgv_ventas.ReadOnly = true;
            this.dgv_ventas.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            this.dgv_ventas.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ventas.Size = new System.Drawing.Size(1049, 343);
            this.dgv_ventas.TabIndex = 3;
            this.dgv_ventas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ventas_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // Codigo_barra
            // 
            this.Codigo_barra.HeaderText = "Codigo de Barra";
            this.Codigo_barra.MinimumWidth = 6;
            this.Codigo_barra.Name = "Codigo_barra";
            this.Codigo_barra.ReadOnly = true;
            this.Codigo_barra.Width = 125;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            this.Producto.Width = 80;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 80;
            // 
            // Cantidad_a_vender
            // 
            this.Cantidad_a_vender.HeaderText = "Cantidad a Vender";
            this.Cantidad_a_vender.MinimumWidth = 6;
            this.Cantidad_a_vender.Name = "Cantidad_a_vender";
            this.Cantidad_a_vender.ReadOnly = true;
            this.Cantidad_a_vender.Width = 120;
            // 
            // Unidad
            // 
            this.Unidad.HeaderText = "Unidad";
            this.Unidad.MinimumWidth = 6;
            this.Unidad.Name = "Unidad";
            this.Unidad.ReadOnly = true;
            this.Unidad.Width = 85;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.MinimumWidth = 6;
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 90;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.MinimumWidth = 6;
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 70;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.X.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.X.Text = "";
            this.X.Width = 35;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 44;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(1356, 114);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 91);
            this.button1.TabIndex = 4;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1351, 306);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "Total a Pagar";
            // 
            // textBox_total
            // 
            this.textBox_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_total.Location = new System.Drawing.Point(1349, 336);
            this.textBox_total.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_total.Name = "textBox_total";
            this.textBox_total.ReadOnly = true;
            this.textBox_total.Size = new System.Drawing.Size(164, 34);
            this.textBox_total.TabIndex = 6;
            this.textBox_total.Text = "0";
            // 
            // comboBox_metodo_pago
            // 
            this.comboBox_metodo_pago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_metodo_pago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_metodo_pago.FormattingEnabled = true;
            this.comboBox_metodo_pago.Location = new System.Drawing.Point(1333, 414);
            this.comboBox_metodo_pago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_metodo_pago.Name = "comboBox_metodo_pago";
            this.comboBox_metodo_pago.Size = new System.Drawing.Size(208, 28);
            this.comboBox_metodo_pago.TabIndex = 7;
            this.comboBox_metodo_pago.SelectedIndexChanged += new System.EventHandler(this.comboBox_metodo_pago_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1331, 391);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 18);
            this.label12.TabIndex = 8;
            this.label12.Text = "Elija el metodo de pago";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_descuento);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(24, 358);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(192, 79);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "  Aplicar Descuento  ";
            // 
            // textBox_descuento
            // 
            this.textBox_descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_descuento.Location = new System.Drawing.Point(24, 34);
            this.textBox_descuento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_descuento.Name = "textBox_descuento";
            this.textBox_descuento.Size = new System.Drawing.Size(132, 29);
            this.textBox_descuento.TabIndex = 0;
            // 
            // button_vender
            // 
            this.button_vender.BackColor = System.Drawing.Color.LightCoral;
            this.button_vender.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_vender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_vender.ForeColor = System.Drawing.Color.Black;
            this.button_vender.Location = new System.Drawing.Point(1356, 556);
            this.button_vender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_vender.Name = "button_vender";
            this.button_vender.Size = new System.Drawing.Size(145, 94);
            this.button_vender.TabIndex = 17;
            this.button_vender.Text = "Vender";
            this.button_vender.UseVisualStyleBackColor = false;
            this.button_vender.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Thistle;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.metodoDePagoToolStripMenuItem,
            this.generarReporteToolStripMenuItem,
            this.historialToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(1924, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productosToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.productosToolStripMenuItem.Text = "Productos ";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proveedoresToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click);
            // 
            // metodoDePagoToolStripMenuItem
            // 
            this.metodoDePagoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metodoDePagoToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.metodoDePagoToolStripMenuItem.Name = "metodoDePagoToolStripMenuItem";
            this.metodoDePagoToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.metodoDePagoToolStripMenuItem.Text = "Metodo de Pago";
            this.metodoDePagoToolStripMenuItem.Click += new System.EventHandler(this.metodoDePagoToolStripMenuItem_Click);
            // 
            // generarReporteToolStripMenuItem
            // 
            this.generarReporteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generarReporteToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.generarReporteToolStripMenuItem.Name = "generarReporteToolStripMenuItem";
            this.generarReporteToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.generarReporteToolStripMenuItem.Text = "Generar Reporte";
            this.generarReporteToolStripMenuItem.Click += new System.EventHandler(this.generarReporteToolStripMenuItem_Click);
            // 
            // historialToolStripMenuItem
            // 
            this.historialToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.historialToolStripMenuItem.Name = "historialToolStripMenuItem";
            this.historialToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.historialToolStripMenuItem.Text = "Historial";
            this.historialToolStripMenuItem.Click += new System.EventHandler(this.historialToolStripMenuItem_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1361, 446);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 25);
            this.label14.TabIndex = 19;
            this.label14.Text = "Total Diario";
            // 
            // txtTotalDiario
            // 
            this.txtTotalDiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalDiario.Location = new System.Drawing.Point(1349, 490);
            this.txtTotalDiario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotalDiario.Name = "txtTotalDiario";
            this.txtTotalDiario.ReadOnly = true;
            this.txtTotalDiario.Size = new System.Drawing.Size(164, 34);
            this.txtTotalDiario.TabIndex = 20;
            this.txtTotalDiario.Text = "0";
            // 
            // timer_hora
            // 
            this.timer_hora.Tick += new System.EventHandler(this.timer_hora_Tick);
            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.BackColor = System.Drawing.Color.LightCoral;
            this.btnCierreCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCierreCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierreCaja.ForeColor = System.Drawing.Color.Black;
            this.btnCierreCaja.Location = new System.Drawing.Point(21, 603);
            this.btnCierreCaja.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Size = new System.Drawing.Size(193, 116);
            this.btnCierreCaja.TabIndex = 21;
            this.btnCierreCaja.Text = "Cerrar Caja";
            this.btnCierreCaja.UseVisualStyleBackColor = false;
            this.btnCierreCaja.Click += new System.EventHandler(this.btnCierreCaja_Click);
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1924, 923);
            this.Controls.Add(this.btnCierreCaja);
            this.Controls.Add(this.txtTotalDiario);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button_vender);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox_metodo_pago);
            this.Controls.Add(this.textBox_total);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_ventas);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Facturacion_FormClosing);
            this.Load += new System.EventHandler(this.Facturacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ventas)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_fecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_codigo_ean;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_stock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_cantidad_vender;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_unidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_precio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_ventas;
        private System.Windows.Forms.Label label_fraccionable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_total;
        private System.Windows.Forms.ComboBox comboBox_metodo_pago;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_descuento;
        private System.Windows.Forms.Button button_vender;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_Id;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem metodoDePagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReporteToolStripMenuItem;
        public System.Windows.Forms.Button button_buscar_producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_barra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_a_vender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewButtonColumn X;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotalDiario;
        private System.Windows.Forms.ToolStripMenuItem historialToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_hora;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Timer timer_hora;
        private System.Windows.Forms.Button btnCierreCaja;
    }
}