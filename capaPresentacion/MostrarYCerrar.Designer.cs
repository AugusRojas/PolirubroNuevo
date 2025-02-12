namespace POLIRUBRO.capaPresentacion
{
    partial class MostrarYCerrar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalFinal = new System.Windows.Forms.TextBox();
            this.txtTotalEsperado = new System.Windows.Forms.TextBox();
            this.txtTransferencia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label_fecha = new System.Windows.Forms.Label();
            this.label_hora_cierre = new System.Windows.Forms.Label();
            this.label_hora_apertura = new System.Windows.Forms.Label();
            this.labelCierre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelApertura = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelHoraCierre = new System.Windows.Forms.Label();
            this.labelHoraApertura = new System.Windows.Forms.Label();
            this.txtEgresos = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCategorias = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHistorial = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.sItxt = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Efectivo";
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Location = new System.Drawing.Point(151, 72);
            this.txtEfectivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(100, 22);
            this.txtEfectivo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Esperado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Final";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Transferencia";
            // 
            // txtTotalFinal
            // 
            this.txtTotalFinal.Location = new System.Drawing.Point(151, 197);
            this.txtTotalFinal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalFinal.Name = "txtTotalFinal";
            this.txtTotalFinal.Size = new System.Drawing.Size(100, 22);
            this.txtTotalFinal.TabIndex = 5;
            // 
            // txtTotalEsperado
            // 
            this.txtTotalEsperado.Location = new System.Drawing.Point(151, 151);
            this.txtTotalEsperado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalEsperado.Name = "txtTotalEsperado";
            this.txtTotalEsperado.Size = new System.Drawing.Size(100, 22);
            this.txtTotalEsperado.TabIndex = 6;
            // 
            // txtTransferencia
            // 
            this.txtTransferencia.Location = new System.Drawing.Point(151, 108);
            this.txtTransferencia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTransferencia.Name = "txtTransferencia";
            this.txtTransferencia.Size = new System.Drawing.Size(100, 22);
            this.txtTransferencia.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.sItxt);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label_fecha);
            this.groupBox1.Controls.Add(this.label_hora_cierre);
            this.groupBox1.Controls.Add(this.label_hora_apertura);
            this.groupBox1.Controls.Add(this.labelCierre);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labelApertura);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelHoraCierre);
            this.groupBox1.Controls.Add(this.labelHoraApertura);
            this.groupBox1.Controls.Add(this.txtEgresos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTransferencia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTotalEsperado);
            this.groupBox1.Controls.Add(this.txtEfectivo);
            this.groupBox1.Controls.Add(this.txtTotalFinal);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(403, 423);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 311);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Hora de cierre";
            // 
            // label_fecha
            // 
            this.label_fecha.AutoSize = true;
            this.label_fecha.Location = new System.Drawing.Point(148, 341);
            this.label_fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_fecha.Name = "label_fecha";
            this.label_fecha.Size = new System.Drawing.Size(0, 16);
            this.label_fecha.TabIndex = 18;
            // 
            // label_hora_cierre
            // 
            this.label_hora_cierre.AutoSize = true;
            this.label_hora_cierre.Location = new System.Drawing.Point(151, 311);
            this.label_hora_cierre.Name = "label_hora_cierre";
            this.label_hora_cierre.Size = new System.Drawing.Size(0, 16);
            this.label_hora_cierre.TabIndex = 16;
            // 
            // label_hora_apertura
            // 
            this.label_hora_apertura.AutoSize = true;
            this.label_hora_apertura.Location = new System.Drawing.Point(151, 278);
            this.label_hora_apertura.Name = "label_hora_apertura";
            this.label_hora_apertura.Size = new System.Drawing.Size(0, 16);
            this.label_hora_apertura.TabIndex = 15;
            // 
            // labelCierre
            // 
            this.labelCierre.AutoSize = true;
            this.labelCierre.Location = new System.Drawing.Point(203, 376);
            this.labelCierre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCierre.Name = "labelCierre";
            this.labelCierre.Size = new System.Drawing.Size(0, 16);
            this.labelCierre.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 341);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fecha";
            // 
            // labelApertura
            // 
            this.labelApertura.AutoSize = true;
            this.labelApertura.Location = new System.Drawing.Point(203, 341);
            this.labelApertura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApertura.Name = "labelApertura";
            this.labelApertura.Size = new System.Drawing.Size(0, 16);
            this.labelApertura.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 278);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Hora de apertura";
            // 
            // labelHoraCierre
            // 
            this.labelHoraCierre.AutoSize = true;
            this.labelHoraCierre.Location = new System.Drawing.Point(195, 376);
            this.labelHoraCierre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHoraCierre.Name = "labelHoraCierre";
            this.labelHoraCierre.Size = new System.Drawing.Size(0, 16);
            this.labelHoraCierre.TabIndex = 11;
            // 
            // labelHoraApertura
            // 
            this.labelHoraApertura.AutoSize = true;
            this.labelHoraApertura.Location = new System.Drawing.Point(195, 341);
            this.labelHoraApertura.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelHoraApertura.Name = "labelHoraApertura";
            this.labelHoraApertura.Size = new System.Drawing.Size(0, 16);
            this.labelHoraApertura.TabIndex = 10;
            // 
            // txtEgresos
            // 
            this.txtEgresos.Location = new System.Drawing.Point(151, 233);
            this.txtEgresos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEgresos.Name = "txtEgresos";
            this.txtEgresos.Size = new System.Drawing.Size(100, 22);
            this.txtEgresos.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Egresos varios";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewCategorias);
            this.groupBox2.Location = new System.Drawing.Point(421, 22);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(288, 114);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categorias mas vendidas";
            // 
            // dataGridViewCategorias
            // 
            this.dataGridViewCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategorias.Location = new System.Drawing.Point(5, 21);
            this.dataGridViewCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewCategorias.Name = "dataGridViewCategorias";
            this.dataGridViewCategorias.RowHeadersWidth = 51;
            this.dataGridViewCategorias.RowTemplate.Height = 24;
            this.dataGridViewCategorias.Size = new System.Drawing.Size(276, 87);
            this.dataGridViewCategorias.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewProductos);
            this.groupBox3.Location = new System.Drawing.Point(421, 181);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(288, 298);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Productos mas vendidos";
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(7, 21);
            this.dataGridViewProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.RowHeadersWidth = 51;
            this.dataGridViewProductos.RowTemplate.Height = 24;
            this.dataGridViewProductos.Size = new System.Drawing.Size(274, 342);
            this.dataGridViewProductos.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewHistorial);
            this.groupBox4.Location = new System.Drawing.Point(716, 36);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(815, 320);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Historial de productos vendidos";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // dataGridViewHistorial
            // 
            this.dataGridViewHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHistorial.Location = new System.Drawing.Point(16, 21);
            this.dataGridViewHistorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewHistorial.Name = "dataGridViewHistorial";
            this.dataGridViewHistorial.RowHeadersWidth = 51;
            this.dataGridViewHistorial.RowTemplate.Height = 24;
            this.dataGridViewHistorial.Size = new System.Drawing.Size(599, 233);
            this.dataGridViewHistorial.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(914, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Cerrar e imprimir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Saldo Inicial";
            // 
            // sItxt
            // 
            this.sItxt.Location = new System.Drawing.Point(151, 35);
            this.sItxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sItxt.Name = "sItxt";
            this.sItxt.Size = new System.Drawing.Size(100, 22);
            this.sItxt.TabIndex = 21;
            // 
            // MostrarYCerrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1924, 583);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MostrarYCerrar";
            this.Text = "MostrarYCerrar";
            this.Load += new System.EventHandler(this.MostrarYCerrar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistorial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalFinal;
        private System.Windows.Forms.TextBox txtTotalEsperado;
        private System.Windows.Forms.TextBox txtTransferencia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEgresos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewCategorias;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.DataGridView dataGridViewHistorial;

        private System.Windows.Forms.Label labelHoraCierre;
        private System.Windows.Forms.Label labelHoraApertura;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelCierre;
        private System.Windows.Forms.Label labelApertura;
        private System.Windows.Forms.Label label_hora_cierre;
        private System.Windows.Forms.Label label_hora_apertura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_fecha;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox sItxt;
    }
}