
namespace POLIRUBRO.capaPresentacion
{
    partial class Ventana_emergente_buscar__producto
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dvg_filtrado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_buscar_filtro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_filtrado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Buscar por";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Categoria",
            "Nombre"});
            this.comboBox1.Location = new System.Drawing.Point(89, 42);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(136, 26);
            this.comboBox1.TabIndex = 1;
            // 
            // dvg_filtrado
            // 
            this.dvg_filtrado.AllowUserToDeleteRows = false;
            this.dvg_filtrado.AllowUserToOrderColumns = true;
            this.dvg_filtrado.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dvg_filtrado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_filtrado.Location = new System.Drawing.Point(13, 130);
            this.dvg_filtrado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dvg_filtrado.Name = "dvg_filtrado";
            this.dvg_filtrado.ReadOnly = true;
            this.dvg_filtrado.RowHeadersWidth = 51;
            this.dvg_filtrado.Size = new System.Drawing.Size(927, 243);
            this.dvg_filtrado.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_buscar_filtro);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(397, 96);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de Producto";
            // 
            // textBox_buscar_filtro
            // 
            this.textBox_buscar_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_buscar_filtro.Location = new System.Drawing.Point(238, 42);
            this.textBox_buscar_filtro.Name = "textBox_buscar_filtro";
            this.textBox_buscar_filtro.Size = new System.Drawing.Size(136, 26);
            this.textBox_buscar_filtro.TabIndex = 3;
            this.textBox_buscar_filtro.TextChanged += new System.EventHandler(this.textBox_buscar_filtro_TextChanged);
            // 
            // Ventana_emergente_buscar__producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 387);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dvg_filtrado);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ventana_emergente_buscar__producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana_emergente_buscar__producto";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_filtrado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dvg_filtrado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_buscar_filtro;
    }
}