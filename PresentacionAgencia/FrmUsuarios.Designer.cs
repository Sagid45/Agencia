namespace PresentacionAgencia
{
    partial class FrmUsuarios
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
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.BackColor = System.Drawing.Color.Silver;
            this.btnAgregarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarUsuario.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarUsuario.Location = new System.Drawing.Point(796, 84);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(38, 39);
            this.btnAgregarUsuario.TabIndex = 17;
            this.btnAgregarUsuario.Text = "+";
            this.btnAgregarUsuario.UseVisualStyleBackColor = false;
            // 
            // txtProducto
            // 
            this.txtProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProducto.Location = new System.Drawing.Point(250, 88);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(540, 34);
            this.txtProducto.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 29);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre del Usuario:";
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Location = new System.Drawing.Point(20, 128);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.RowHeadersWidth = 51;
            this.dtgUsuarios.RowTemplate.Height = 24;
            this.dtgUsuarios.Size = new System.Drawing.Size(824, 334);
            this.dtgUsuarios.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 74);
            this.panel1.TabIndex = 18;
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
            this.label1.Location = new System.Drawing.Point(296, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Permisos de los Usuarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Usuarios";
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 471);
            this.Controls.Add(this.btnAgregarUsuario);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgUsuarios);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUsuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dtgUsuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}