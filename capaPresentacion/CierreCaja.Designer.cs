namespace POLIRUBRO.capaPresentacion
{
    partial class CierreCaja
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
            this.btnCaja = new System.Windows.Forms.Button();
            this.txtEfectivoInicial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrasnferenciaTotal = new System.Windows.Forms.TextBox();
            this.txtEfectivoTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEgresos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCaja
            // 
            this.btnCaja.Location = new System.Drawing.Point(561, 286);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(227, 23);
            this.btnCaja.TabIndex = 0;
            this.btnCaja.Text = "Mostrar y cerrar caja";
            this.btnCaja.UseVisualStyleBackColor = true;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // txtEfectivoInicial
            // 
            this.txtEfectivoInicial.Location = new System.Drawing.Point(219, 70);
            this.txtEfectivoInicial.Name = "txtEfectivoInicial";
            this.txtEfectivoInicial.Size = new System.Drawing.Size(100, 22);
            this.txtEfectivoInicial.TabIndex = 1;
            this.txtEfectivoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEfectivoInicial_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Efectivo inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total transferencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total efectivo";
            // 
            // txtTrasnferenciaTotal
            // 
            this.txtTrasnferenciaTotal.Location = new System.Drawing.Point(219, 106);
            this.txtTrasnferenciaTotal.Name = "txtTrasnferenciaTotal";
            this.txtTrasnferenciaTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTrasnferenciaTotal.TabIndex = 5;
            this.txtTrasnferenciaTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrasnferenciaTotal_KeyPress);
            // 
            // txtEfectivoTotal
            // 
            this.txtEfectivoTotal.Location = new System.Drawing.Point(219, 171);
            this.txtEfectivoTotal.Name = "txtEfectivoTotal";
            this.txtEfectivoTotal.Size = new System.Drawing.Size(100, 22);
            this.txtEfectivoTotal.TabIndex = 6;
            this.txtEfectivoTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEfectivoTotal_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Egresos";
            // 
            // txtEgresos
            // 
            this.txtEgresos.Location = new System.Drawing.Point(219, 140);
            this.txtEgresos.Name = "txtEgresos";
            this.txtEgresos.Size = new System.Drawing.Size(100, 22);
            this.txtEgresos.TabIndex = 8;
            this.txtEgresos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEgresos_KeyPress);
            // 
            // CierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtEgresos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEfectivoTotal);
            this.Controls.Add(this.txtTrasnferenciaTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEfectivoInicial);
            this.Controls.Add(this.btnCaja);
            this.Name = "CierreCaja";
            this.Text = "CierreCaja";
            this.Load += new System.EventHandler(this.CierreCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.TextBox txtEfectivoInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrasnferenciaTotal;
        private System.Windows.Forms.TextBox txtEfectivoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEgresos;
    }
}