﻿namespace POLIRUBRO.capaPresentacion
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
            this.groupMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMetodoPago.Location = new System.Drawing.Point(309, 11);
            this.groupMetodoPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupMetodoPago.Name = "groupMetodoPago";
            this.groupMetodoPago.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupMetodoPago.Size = new System.Drawing.Size(370, 320);
            this.groupMetodoPago.TabIndex = 0;
            this.groupMetodoPago.TabStop = false;
            this.groupMetodoPago.Text = "   Metodo de pago    ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Eliminar metodo de pago";
            // 
            // boxPago
            // 
            this.boxPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPago.FormattingEnabled = true;
            this.boxPago.Location = new System.Drawing.Point(181, 178);
            this.boxPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxPago.Name = "boxPago";
            this.boxPago.Size = new System.Drawing.Size(183, 21);
            this.boxPago.TabIndex = 7;
            this.boxPago.Text = "Seleccione un metodo de pago...";
            // 
            // btnEliminarPago
            // 
            this.btnEliminarPago.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPago.Location = new System.Drawing.Point(11, 231);
            this.btnEliminarPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarPago.Name = "btnEliminarPago";
            this.btnEliminarPago.Size = new System.Drawing.Size(80, 29);
            this.btnEliminarPago.TabIndex = 6;
            this.btnEliminarPago.Text = "Eliminar";
            this.btnEliminarPago.UseVisualStyleBackColor = false;
            this.btnEliminarPago.Click += new System.EventHandler(this.btnEliminarPago_Click);
            // 
            // btnAgregarPago
            // 
            this.btnAgregarPago.BackColor = System.Drawing.Color.LightCoral;
            this.btnAgregarPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPago.Location = new System.Drawing.Point(11, 74);
            this.btnAgregarPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.Size = new System.Drawing.Size(80, 28);
            this.btnAgregarPago.TabIndex = 5;
            this.btnAgregarPago.Text = "Agregar";
            this.btnAgregarPago.UseVisualStyleBackColor = false;
            this.btnAgregarPago.Click += new System.EventHandler(this.btnAgregarPago_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nuevo metodo de pago";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(173, 35);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 24);
            this.textBox2.TabIndex = 3;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // groupCategoria
            // 
            this.groupCategoria.Controls.Add(this.label3);
            this.groupCategoria.Controls.Add(this.boxCategoria);
            this.groupCategoria.Controls.Add(this.btnEliminarCategoria);
            this.groupCategoria.Controls.Add(this.btnAgregarCategoria);
            this.groupCategoria.Controls.Add(this.textBox1);
            this.groupCategoria.Controls.Add(this.label1);
            this.groupCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCategoria.Location = new System.Drawing.Point(11, 11);
            this.groupCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupCategoria.Name = "groupCategoria";
            this.groupCategoria.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupCategoria.Size = new System.Drawing.Size(294, 320);
            this.groupCategoria.TabIndex = 1;
            this.groupCategoria.TabStop = false;
            this.groupCategoria.Text = "   Categoria   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Eliminar caategoria";
            // 
            // boxCategoria
            // 
            this.boxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCategoria.FormattingEnabled = true;
            this.boxCategoria.Location = new System.Drawing.Point(141, 177);
            this.boxCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxCategoria.Name = "boxCategoria";
            this.boxCategoria.Size = new System.Drawing.Size(144, 21);
            this.boxCategoria.TabIndex = 2;
            this.boxCategoria.Text = "Seleccione una categoria...";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.BackColor = System.Drawing.Color.LightCoral;
            this.btnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(171, 74);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(79, 28);
            this.btnAgregarCategoria.TabIndex = 6;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = false;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 24);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nueva categoria";
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.Location = new System.Drawing.Point(171, 231);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(79, 29);
            this.btnEliminarCategoria.TabIndex = 4;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // categoria_metodo_pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(690, 366);
            this.Controls.Add(this.groupCategoria);
            this.Controls.Add(this.groupMetodoPago);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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