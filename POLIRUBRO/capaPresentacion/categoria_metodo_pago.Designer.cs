namespace POLIRUBRO.capaPresentacion
{
    partial class categoria_metodo_pago
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
            this.groupMetodoPago = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.boxPago = new System.Windows.Forms.ComboBox();
            this.btnEliminarPago = new System.Windows.Forms.Button();
            this.btnAgregarPago = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupCategoria = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxCategoria = new System.Windows.Forms.ComboBox();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupMetodoPago.SuspendLayout();
            this.groupCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMetodoPago
            // 
            this.groupMetodoPago.Controls.Add(this.label4);
            this.groupMetodoPago.Controls.Add(this.boxPago);
            this.groupMetodoPago.Controls.Add(this.btnEliminarPago);
            this.groupMetodoPago.Controls.Add(this.btnAgregarPago);
            this.groupMetodoPago.Controls.Add(this.label2);
            this.groupMetodoPago.Controls.Add(this.textBox2);
            this.groupMetodoPago.Location = new System.Drawing.Point(422, 52);
            this.groupMetodoPago.Name = "groupMetodoPago";
            this.groupMetodoPago.Size = new System.Drawing.Size(374, 394);
            this.groupMetodoPago.TabIndex = 0;
            this.groupMetodoPago.TabStop = false;
            this.groupMetodoPago.Text = "Metodo de pago ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-3, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Eliminar metodo de pago";
            // 
            // boxPago
            // 
            this.boxPago.FormattingEnabled = true;
            this.boxPago.Location = new System.Drawing.Point(140, 216);
            this.boxPago.Name = "boxPago";
            this.boxPago.Size = new System.Drawing.Size(243, 24);
            this.boxPago.TabIndex = 7;
            this.boxPago.Text = "Seleccione un metodo de pago...";
            // 
            // btnEliminarPago
            // 
            this.btnEliminarPago.Location = new System.Drawing.Point(0, 268);
            this.btnEliminarPago.Name = "btnEliminarPago";
            this.btnEliminarPago.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarPago.TabIndex = 6;
            this.btnEliminarPago.Text = "Eliminar";
            this.btnEliminarPago.UseVisualStyleBackColor = true;
            this.btnEliminarPago.Click += new System.EventHandler(this.btnEliminarPago_Click);
            // 
            // btnAgregarPago
            // 
            this.btnAgregarPago.Location = new System.Drawing.Point(0, 91);
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPago.TabIndex = 5;
            this.btnAgregarPago.Text = "Agregar";
            this.btnAgregarPago.UseVisualStyleBackColor = true;
            this.btnAgregarPago.Click += new System.EventHandler(this.btnAgregarPago_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nuevo metodo de pago";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(177, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 22);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // groupCategoria
            // 
            this.groupCategoria.Controls.Add(this.label3);
            this.groupCategoria.Controls.Add(this.boxCategoria);
            this.groupCategoria.Controls.Add(this.btnAgregarCategoria);
            this.groupCategoria.Controls.Add(this.textBox1);
            this.groupCategoria.Controls.Add(this.label1);
            this.groupCategoria.Controls.Add(this.btnEliminarCategoria);
            this.groupCategoria.Location = new System.Drawing.Point(12, 52);
            this.groupCategoria.Name = "groupCategoria";
            this.groupCategoria.Size = new System.Drawing.Size(332, 394);
            this.groupCategoria.TabIndex = 1;
            this.groupCategoria.TabStop = false;
            this.groupCategoria.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-3, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Eliminar caategoria";
            // 
            // boxCategoria
            // 
            this.boxCategoria.FormattingEnabled = true;
            this.boxCategoria.Location = new System.Drawing.Point(142, 216);
            this.boxCategoria.Name = "boxCategoria";
            this.boxCategoria.Size = new System.Drawing.Size(190, 24);
            this.boxCategoria.TabIndex = 2;
            this.boxCategoria.Text = "Seleccione una categoria...";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(257, 91);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCategoria.TabIndex = 6;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(190, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nueva categoria";
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(257, 268);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCategoria.TabIndex = 4;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // categoria_metodo_pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupCategoria);
            this.Controls.Add(this.groupMetodoPago);
            this.Name = "categoria_metodo_pago";
            this.Text = "categoria_metodo_pago";
            this.Load += new System.EventHandler(this.categoria_metodo_pago_Load);
            this.groupMetodoPago.ResumeLayout(false);
            this.groupMetodoPago.PerformLayout();
            this.groupCategoria.ResumeLayout(false);
            this.groupCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMetodoPago;
        private System.Windows.Forms.GroupBox groupCategoria;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminarPago;
        private System.Windows.Forms.Button btnAgregarPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boxPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox boxCategoria;
    }
}