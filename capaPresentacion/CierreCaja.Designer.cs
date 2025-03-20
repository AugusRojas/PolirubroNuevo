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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CierreCaja));
            this.btnCaja = new System.Windows.Forms.Button();
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
            this.btnCaja.BackColor = System.Drawing.Color.Transparent;
            this.btnCaja.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCaja.BackgroundImage")));
            this.btnCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCaja.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaja.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCaja.Image = ((System.Drawing.Image)(resources.GetObject("btnCaja.Image")));
            this.btnCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaja.Location = new System.Drawing.Point(337, 46);
            this.btnCaja.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCaja.Name = "btnCaja";
            this.btnCaja.Size = new System.Drawing.Size(229, 78);
            this.btnCaja.TabIndex = 0;
            this.btnCaja.Text = "Mostrar y cerrar caja";
            this.btnCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCaja.UseVisualStyleBackColor = false;
            this.btnCaja.Click += new System.EventHandler(this.btnCaja_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(27, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total transferencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(27, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total efectivo";
            // 
            // txtTrasnferenciaTotal
            // 
            this.txtTrasnferenciaTotal.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrasnferenciaTotal.Location = new System.Drawing.Point(192, 28);
            this.txtTrasnferenciaTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTrasnferenciaTotal.Name = "txtTrasnferenciaTotal";
            this.txtTrasnferenciaTotal.Size = new System.Drawing.Size(95, 26);
            this.txtTrasnferenciaTotal.TabIndex = 5;
            this.txtTrasnferenciaTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTrasnferenciaTotal_KeyPress);
            // 
            // txtEfectivoTotal
            // 
            this.txtEfectivoTotal.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivoTotal.Location = new System.Drawing.Point(192, 112);
            this.txtEfectivoTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEfectivoTotal.Name = "txtEfectivoTotal";
            this.txtEfectivoTotal.Size = new System.Drawing.Size(95, 26);
            this.txtEfectivoTotal.TabIndex = 6;
            this.txtEfectivoTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEfectivoTotal_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(27, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Egresos";
            // 
            // txtEgresos
            // 
            this.txtEgresos.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEgresos.Location = new System.Drawing.Point(192, 70);
            this.txtEgresos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEgresos.Name = "txtEgresos";
            this.txtEgresos.Size = new System.Drawing.Size(95, 26);
            this.txtEgresos.TabIndex = 8;
            this.txtEgresos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEgresos_KeyPress);
            // 
            // CierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(602, 171);
            this.Controls.Add(this.txtEgresos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEfectivoTotal);
            this.Controls.Add(this.txtTrasnferenciaTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCaja);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CierreCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CierreCaja";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CierreCaja_FormClosing);
            this.Load += new System.EventHandler(this.CierreCaja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCaja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTrasnferenciaTotal;
        private System.Windows.Forms.TextBox txtEfectivoTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEgresos;
    }
}