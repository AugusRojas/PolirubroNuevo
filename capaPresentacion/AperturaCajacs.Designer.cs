namespace POLIRUBRO.capaPresentacion
{
    partial class AperturaCajacs
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
            this.btnAperturaCaja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEncargadoNombre = new System.Windows.Forms.TextBox();
            this.txtNumeroCaja = new System.Windows.Forms.TextBox();
            this.txtEncargadoApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_hora_apertura = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAperturaCaja
            // 
            this.btnAperturaCaja.Location = new System.Drawing.Point(379, 132);
            this.btnAperturaCaja.Margin = new System.Windows.Forms.Padding(2);
            this.btnAperturaCaja.Name = "btnAperturaCaja";
            this.btnAperturaCaja.Size = new System.Drawing.Size(100, 42);
            this.btnAperturaCaja.TabIndex = 0;
            this.btnAperturaCaja.Text = "Apertura de caja";
            this.btnAperturaCaja.UseVisualStyleBackColor = true;
            this.btnAperturaCaja.Click += new System.EventHandler(this.btnAperturaCaja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saldo Inicial";
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Location = new System.Drawing.Point(229, 77);
            this.txtSaldoInicial.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Size = new System.Drawing.Size(76, 20);
            this.txtSaldoInicial.TabIndex = 2;
            this.txtSaldoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldoInicial_KeyPress);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de caja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // txtEncargadoNombre
            // 
            this.txtEncargadoNombre.Location = new System.Drawing.Point(229, 109);
            this.txtEncargadoNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtEncargadoNombre.Name = "txtEncargadoNombre";
            this.txtEncargadoNombre.Size = new System.Drawing.Size(76, 20);
            this.txtEncargadoNombre.TabIndex = 5;
            this.txtEncargadoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEncargado_KeyPress);
            // 
            // txtNumeroCaja
            // 
            this.txtNumeroCaja.Location = new System.Drawing.Point(229, 157);
            this.txtNumeroCaja.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroCaja.Name = "txtNumeroCaja";
            this.txtNumeroCaja.Size = new System.Drawing.Size(76, 20);
            this.txtNumeroCaja.TabIndex = 6;
            this.txtNumeroCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCaja_KeyPress);
            // 
            // txtEncargadoApellido
            // 
            this.txtEncargadoApellido.Location = new System.Drawing.Point(229, 134);
            this.txtEncargadoApellido.Margin = new System.Windows.Forms.Padding(2);
            this.txtEncargadoApellido.Name = "txtEncargadoApellido";
            this.txtEncargadoApellido.Size = new System.Drawing.Size(76, 20);
            this.txtEncargadoApellido.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 140);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Apellido";
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(379, 95);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(100, 32);
            this.btnAgregarUsuario.TabIndex = 9;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hora: ";
            // 
            // textBox_hora_apertura
            // 
            this.textBox_hora_apertura.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox_hora_apertura.Location = new System.Drawing.Point(84, 20);
            this.textBox_hora_apertura.Multiline = true;
            this.textBox_hora_apertura.Name = "textBox_hora_apertura";
            this.textBox_hora_apertura.Size = new System.Drawing.Size(79, 20);
            this.textBox_hora_apertura.TabIndex = 11;
            // 
            // AperturaCajacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 277);
            this.Controls.Add(this.textBox_hora_apertura);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.txtEncargadoApellido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumeroCaja);
            this.Controls.Add(this.txtEncargadoNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaldoInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAperturaCaja);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AperturaCajacs";
            this.Text = "AperturaCajacs";
            this.Load += new System.EventHandler(this.AperturaCajacs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAperturaCaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSaldoInicial;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEncargadoNombre;
        private System.Windows.Forms.TextBox txtNumeroCaja;
        private System.Windows.Forms.TextBox txtEncargadoApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_hora_apertura;
    }
}