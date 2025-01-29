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
            this.btnCaja.Location = new System.Drawing.Point(421, 232);
            this.btnCaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(170, 19);
            this.btnCaja.TabIndex = 0;
            this.btnCaja.Text = "Mostrar y cerrar caja";
            this.btnCaja.UseVisualStyleBackColor = true;
           
            // 
            // txtEfectivoInicial
            // 
            this.txtEfectivoInicial.Location = new System.Drawing.Point(164, 57);
            this.txtEfectivoInicial.Margin = new System.Windows.Forms.Padding(2);
            this.txtEfectivoInicial.Name = "txtEfectivoInicial";
            this.txtEfectivoInicial.Size = new System.Drawing.Size(76, 20);
            this.txtEfectivoInicial.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Efectivo inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total transferencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total efectivo";
            // 
            // txtTrasnferenciaTotal
            // 
            this.txtTrasnferenciaTotal.Location = new System.Drawing.Point(164, 86);
            this.txtTrasnferenciaTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrasnferenciaTotal.Name = "txtTrasnferenciaTotal";
            this.txtTrasnferenciaTotal.Size = new System.Drawing.Size(76, 20);
            this.txtTrasnferenciaTotal.TabIndex = 5;
            // 
            // txtEfectivoTotal
            // 
            this.txtEfectivoTotal.Location = new System.Drawing.Point(164, 139);
            this.txtEfectivoTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtEfectivoTotal.Name = "txtEfectivoTotal";
            this.txtEfectivoTotal.Size = new System.Drawing.Size(76, 20);
            this.txtEfectivoTotal.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Egresos";
            // 
            // txtEgresos
            // 
            this.txtEgresos.Location = new System.Drawing.Point(164, 114);
            this.txtEgresos.Margin = new System.Windows.Forms.Padding(2);
            this.txtEgresos.Name = "txtEgresos";
            this.txtEgresos.Size = new System.Drawing.Size(76, 20);
            this.txtEgresos.TabIndex = 8;
            // 
            // CierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txtEgresos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEfectivoTotal);
            this.Controls.Add(this.txtTrasnferenciaTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEfectivoInicial);
            this.Controls.Add(this.btnCaja);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CierreCaja";
            this.Text = "CierreCaja";
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