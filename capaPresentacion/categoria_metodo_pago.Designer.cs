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
            this.groupCategoria = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.boxCategoria = new System.Windows.Forms.ComboBox();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Unidad = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boxUnidad = new System.Windows.Forms.ComboBox();
            this.groupMetodoPago.SuspendLayout();
            this.groupCategoria.SuspendLayout();
            this.Unidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupMetodoPago
            // 
            this.groupMetodoPago.Controls.Add(this.label4);
            this.groupMetodoPago.Controls.Add(this.boxPago);
            this.groupMetodoPago.Controls.Add(this.btnEliminarPago);
            this.groupMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMetodoPago.Location = new System.Drawing.Point(412, 14);
            this.groupMetodoPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupMetodoPago.Name = "groupMetodoPago";
            this.groupMetodoPago.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupMetodoPago.Size = new System.Drawing.Size(493, 394);
            this.groupMetodoPago.TabIndex = 0;
            this.groupMetodoPago.TabStop = false;
            this.groupMetodoPago.Text = "   Metodo de pago    ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Eliminar metodo de pago";
            // 
            // boxPago
            // 
            this.boxPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPago.FormattingEnabled = true;
            this.boxPago.Location = new System.Drawing.Point(235, 36);
            this.boxPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxPago.Name = "boxPago";
            this.boxPago.Size = new System.Drawing.Size(243, 25);
            this.boxPago.TabIndex = 7;
            this.boxPago.Text = "Seleccione un metodo de pago...";
            // 
            // btnEliminarPago
            // 
            this.btnEliminarPago.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPago.Location = new System.Drawing.Point(9, 91);
            this.btnEliminarPago.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarPago.Name = "btnEliminarPago";
            this.btnEliminarPago.Size = new System.Drawing.Size(107, 36);
            this.btnEliminarPago.TabIndex = 6;
            this.btnEliminarPago.Text = "Eliminar";
            this.btnEliminarPago.UseVisualStyleBackColor = false;
            this.btnEliminarPago.Click += new System.EventHandler(this.btnEliminarPago_Click);
            // 
            // groupCategoria
            // 
            this.groupCategoria.Controls.Add(this.label3);
            this.groupCategoria.Controls.Add(this.boxCategoria);
            this.groupCategoria.Controls.Add(this.btnEliminarCategoria);
            this.groupCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCategoria.Location = new System.Drawing.Point(15, 14);
            this.groupCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupCategoria.Name = "groupCategoria";
            this.groupCategoria.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupCategoria.Size = new System.Drawing.Size(392, 185);
            this.groupCategoria.TabIndex = 1;
            this.groupCategoria.TabStop = false;
            this.groupCategoria.Text = "   Categoria   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Eliminar caategoria";
            // 
            // boxCategoria
            // 
            this.boxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCategoria.FormattingEnabled = true;
            this.boxCategoria.Location = new System.Drawing.Point(195, 36);
            this.boxCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxCategoria.Name = "boxCategoria";
            this.boxCategoria.Size = new System.Drawing.Size(191, 25);
            this.boxCategoria.TabIndex = 2;
            this.boxCategoria.Text = "Seleccione una categoria...";
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.Location = new System.Drawing.Point(253, 91);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(105, 36);
            this.btnEliminarCategoria.TabIndex = 4;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // Unidad
            // 
            this.Unidad.Controls.Add(this.btnEliminar);
            this.Unidad.Controls.Add(this.label1);
            this.Unidad.Controls.Add(this.boxUnidad);
            this.Unidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unidad.Location = new System.Drawing.Point(12, 203);
            this.Unidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Unidad.Name = "Unidad";
            this.Unidad.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Unidad.Size = new System.Drawing.Size(395, 206);
            this.Unidad.TabIndex = 2;
            this.Unidad.TabStop = false;
            this.Unidad.Text = "Unidad";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(256, 79);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(105, 36);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Eliminar Unidad";
            // 
            // boxUnidad
            // 
            this.boxUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUnidad.FormattingEnabled = true;
            this.boxUnidad.Location = new System.Drawing.Point(197, 26);
            this.boxUnidad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.boxUnidad.Name = "boxUnidad";
            this.boxUnidad.Size = new System.Drawing.Size(191, 25);
            this.boxUnidad.TabIndex = 3;
            this.boxUnidad.Text = "Seleccione una unidad...";
            // 
            // categoria_metodo_pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(920, 450);
            this.Controls.Add(this.Unidad);
            this.Controls.Add(this.groupCategoria);
            this.Controls.Add(this.groupMetodoPago);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "categoria_metodo_pago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "categoria_metodo_pago";
            this.Load += new System.EventHandler(this.categoria_metodo_pago_Load);
            this.groupMetodoPago.ResumeLayout(false);
            this.groupMetodoPago.PerformLayout();
            this.groupCategoria.ResumeLayout(false);
            this.groupCategoria.PerformLayout();
            this.Unidad.ResumeLayout(false);
            this.Unidad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMetodoPago;
        private System.Windows.Forms.GroupBox groupCategoria;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnEliminarPago;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox boxPago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox boxCategoria;
        private System.Windows.Forms.GroupBox Unidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxUnidad;
        private System.Windows.Forms.Button btnEliminar;
    }
}