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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categoria_metodo_pago));
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
            this.groupMetodoPago.BackColor = System.Drawing.Color.Transparent;
            this.groupMetodoPago.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupMetodoPago.BackgroundImage")));
            this.groupMetodoPago.Controls.Add(this.label4);
            this.groupMetodoPago.Controls.Add(this.boxPago);
            this.groupMetodoPago.Controls.Add(this.btnEliminarPago);
            this.groupMetodoPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupMetodoPago.ForeColor = System.Drawing.SystemColors.Control;
            this.groupMetodoPago.Location = new System.Drawing.Point(11, 11);
            this.groupMetodoPago.Margin = new System.Windows.Forms.Padding(2);
            this.groupMetodoPago.Name = "groupMetodoPago";
            this.groupMetodoPago.Padding = new System.Windows.Forms.Padding(2);
            this.groupMetodoPago.Size = new System.Drawing.Size(419, 220);
            this.groupMetodoPago.TabIndex = 0;
            this.groupMetodoPago.TabStop = false;
            this.groupMetodoPago.Text = "   Metodo de pago    ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(4, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Eliminar metodo de pago";
            // 
            // boxPago
            // 
            this.boxPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxPago.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.boxPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPago.FormattingEnabled = true;
            this.boxPago.Location = new System.Drawing.Point(193, 37);
            this.boxPago.Margin = new System.Windows.Forms.Padding(2);
            this.boxPago.Name = "boxPago";
            this.boxPago.Size = new System.Drawing.Size(210, 21);
            this.boxPago.TabIndex = 7;
            // 
            // btnEliminarPago
            // 
            this.btnEliminarPago.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarPago.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarPago.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPago.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarPago.Image")));
            this.btnEliminarPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarPago.Location = new System.Drawing.Point(8, 97);
            this.btnEliminarPago.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarPago.Name = "btnEliminarPago";
            this.btnEliminarPago.Size = new System.Drawing.Size(159, 29);
            this.btnEliminarPago.TabIndex = 6;
            this.btnEliminarPago.Text = "Eliminar Metodo";
            this.btnEliminarPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarPago.UseVisualStyleBackColor = false;
            this.btnEliminarPago.Click += new System.EventHandler(this.btnEliminarPago_Click);
            // 
            // groupCategoria
            // 
            this.groupCategoria.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupCategoria.BackgroundImage")));
            this.groupCategoria.Controls.Add(this.label3);
            this.groupCategoria.Controls.Add(this.boxCategoria);
            this.groupCategoria.Controls.Add(this.btnEliminarCategoria);
            this.groupCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupCategoria.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCategoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupCategoria.Location = new System.Drawing.Point(465, 11);
            this.groupCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.groupCategoria.Name = "groupCategoria";
            this.groupCategoria.Padding = new System.Windows.Forms.Padding(2);
            this.groupCategoria.Size = new System.Drawing.Size(362, 154);
            this.groupCategoria.TabIndex = 1;
            this.groupCategoria.TabStop = false;
            this.groupCategoria.Text = "   Categoria   ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Eliminar categoria";
            // 
            // boxCategoria
            // 
            this.boxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxCategoria.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.boxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCategoria.FormattingEnabled = true;
            this.boxCategoria.Location = new System.Drawing.Point(166, 31);
            this.boxCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.boxCategoria.Name = "boxCategoria";
            this.boxCategoria.Size = new System.Drawing.Size(172, 21);
            this.boxCategoria.TabIndex = 2;
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarCategoria.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCategoria.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCategoria.Image")));
            this.btnEliminarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(8, 112);
            this.btnEliminarCategoria.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(171, 29);
            this.btnEliminarCategoria.TabIndex = 4;
            this.btnEliminarCategoria.Text = "Eliminar categoria";
            this.btnEliminarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarCategoria.UseVisualStyleBackColor = false;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // Unidad
            // 
            this.Unidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Unidad.BackgroundImage")));
            this.Unidad.Controls.Add(this.btnEliminar);
            this.Unidad.Controls.Add(this.label1);
            this.Unidad.Controls.Add(this.boxUnidad);
            this.Unidad.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unidad.ForeColor = System.Drawing.SystemColors.Control;
            this.Unidad.Location = new System.Drawing.Point(483, 183);
            this.Unidad.Margin = new System.Windows.Forms.Padding(2);
            this.Unidad.Name = "Unidad";
            this.Unidad.Padding = new System.Windows.Forms.Padding(2);
            this.Unidad.Size = new System.Drawing.Size(312, 167);
            this.Unidad.TabIndex = 2;
            this.Unidad.TabStop = false;
            this.Unidad.Text = "Unidad";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.LightCoral;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(23, 64);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(157, 29);
            this.btnEliminar.TabIndex = 9;
            this.btnEliminar.Text = "Eliminar Unidad";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Eliminar Unidad";
            // 
            // boxUnidad
            // 
            this.boxUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxUnidad.FormattingEnabled = true;
            this.boxUnidad.Location = new System.Drawing.Point(148, 29);
            this.boxUnidad.Margin = new System.Windows.Forms.Padding(2);
            this.boxUnidad.Name = "boxUnidad";
            this.boxUnidad.Size = new System.Drawing.Size(152, 21);
            this.boxUnidad.TabIndex = 3;
            // 
            // categoria_metodo_pago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(903, 401);
            this.Controls.Add(this.Unidad);
            this.Controls.Add(this.groupCategoria);
            this.Controls.Add(this.groupMetodoPago);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2);
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