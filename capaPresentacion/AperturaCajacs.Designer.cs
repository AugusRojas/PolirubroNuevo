﻿namespace POLIRUBRO.capaPresentacion
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
            this.btnAperturaCaja = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSaldoInicial = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEncargadoNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.boxCaja = new System.Windows.Forms.ComboBox();
            this.textBox_hora_apertura = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAperturaCaja
            // 
            this.btnAperturaCaja.Location = new System.Drawing.Point(565, 70);
            this.btnAperturaCaja.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAperturaCaja.Name = "btnAperturaCaja";
            this.btnAperturaCaja.Size = new System.Drawing.Size(133, 52);
            this.btnAperturaCaja.TabIndex = 0;
            this.btnAperturaCaja.Text = "Apertura de caja";
            this.btnAperturaCaja.UseVisualStyleBackColor = true;
            this.btnAperturaCaja.Click += new System.EventHandler(this.btnAperturaCaja_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saldo Inicial";
            // 
            // txtSaldoInicial
            // 
            this.txtSaldoInicial.Location = new System.Drawing.Point(299, 57);
            this.txtSaldoInicial.Margin = new System.Windows.Forms.Padding(4);
            this.txtSaldoInicial.Name = "txtSaldoInicial";
            this.txtSaldoInicial.Size = new System.Drawing.Size(160, 22);
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
            this.label2.Location = new System.Drawing.Point(35, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero de caja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // txtEncargadoNombre
            // 
            this.txtEncargadoNombre.Location = new System.Drawing.Point(299, 103);
            this.txtEncargadoNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtEncargadoNombre.Name = "txtEncargadoNombre";
            this.txtEncargadoNombre.Size = new System.Drawing.Size(160, 22);
            this.txtEncargadoNombre.TabIndex = 5;
            this.txtEncargadoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEncargado_KeyPress);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(565, 15);
            this.btnAgregarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(133, 39);
            this.btnAgregarUsuario.TabIndex = 9;
            this.btnAgregarUsuario.Text = "Agregar Usuario";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // boxCaja
            // 
            this.boxCaja.FormattingEnabled = true;
            this.boxCaja.Location = new System.Drawing.Point(299, 4);
            this.boxCaja.Margin = new System.Windows.Forms.Padding(4);
            this.boxCaja.Name = "boxCaja";
            this.boxCaja.Size = new System.Drawing.Size(160, 24);
            this.boxCaja.TabIndex = 10;
            // 
            // textBox_hora_apertura
            // 
            this.textBox_hora_apertura.Location = new System.Drawing.Point(299, 135);
            this.textBox_hora_apertura.Name = "textBox_hora_apertura";
            this.textBox_hora_apertura.Size = new System.Drawing.Size(160, 22);
            this.textBox_hora_apertura.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Hora de apertura";
            // 
            // AperturaCajacs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(745, 169);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_hora_apertura);
            this.Controls.Add(this.boxCaja);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.txtEncargadoNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSaldoInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAperturaCaja);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.ComboBox boxCaja;
        private System.Windows.Forms.TextBox textBox_hora_apertura;
        private System.Windows.Forms.Label label4;
    }
}