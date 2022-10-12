namespace PresentacionAgencia
{
    partial class FrmAddTaller
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtCodigoBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Location = new System.Drawing.Point(-8, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 78);
            this.panel1.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(199, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(431, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "CAPTURAR PRODUCTOS";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Location = new System.Drawing.Point(732, 13);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(48, 50);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "X";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(498, 234);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(223, 30);
            this.txtMarca.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 197);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 25);
            this.label7.TabIndex = 63;
            this.label7.Text = "Marca";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(20, 234);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(424, 178);
            this.txtDescripcion.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 197);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 25);
            this.label6.TabIndex = 62;
            this.label6.Text = "Descripcion";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(377, 133);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(376, 30);
            this.txtNombre.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 94);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 61;
            this.label5.Text = "Nombre";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardar.Location = new System.Drawing.Point(547, 318);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(174, 55);
            this.btnGuardar.TabIndex = 58;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtCodigoBar
            // 
            this.txtCodigoBar.Location = new System.Drawing.Point(20, 133);
            this.txtCodigoBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCodigoBar.Name = "txtCodigoBar";
            this.txtCodigoBar.Size = new System.Drawing.Size(290, 30);
            this.txtCodigoBar.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 60;
            this.label1.Text = "Codigo de Barras";
            // 
            // FrmAddTaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCodigoBar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAddTaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddTaller";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtCodigoBar;
        private System.Windows.Forms.Label label1;
    }
}