namespace PresentacionAgencia
{
    partial class FrmRefacciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgProductos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 74);
            this.panel1.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.White;
            this.btnCerrar.Location = new System.Drawing.Point(806, 14);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(38, 41);
            this.btnCerrar.TabIndex = 3;
            this.btnCerrar.Text = "X";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Productos Existentes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Refacciones";
            // 
            // dtgProductos
            // 
            this.dtgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductos.Location = new System.Drawing.Point(17, 129);
            this.dtgProductos.Name = "dtgProductos";
            this.dtgProductos.RowHeadersWidth = 51;
            this.dtgProductos.RowTemplate.Height = 24;
            this.dtgProductos.Size = new System.Drawing.Size(824, 334);
            this.dtgProductos.TabIndex = 9;
            this.dtgProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductos_CellClick);
            this.dtgProductos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductos_CellEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre del Producto:";
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(268, 89);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(519, 34);
            this.txtProducto.TabIndex = 0;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Silver;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarProducto.Location = new System.Drawing.Point(793, 85);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(38, 39);
            this.btnAgregarProducto.TabIndex = 1;
            this.btnAgregarProducto.Text = "+";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // FrmRefacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 475);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgProductos);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRefacciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRefacciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
    }
}