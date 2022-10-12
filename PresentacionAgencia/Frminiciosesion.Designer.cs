namespace PresentacionAgencia
{
    partial class Frminiciosesion
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
            this.IniciarSesion = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.Cancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IniciarSesion
            // 
            this.IniciarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.IniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.IniciarSesion.Location = new System.Drawing.Point(289, 261);
            this.IniciarSesion.Margin = new System.Windows.Forms.Padding(6);
            this.IniciarSesion.Name = "IniciarSesion";
            this.IniciarSesion.Size = new System.Drawing.Size(150, 45);
            this.IniciarSesion.TabIndex = 2;
            this.IniciarSesion.Text = "Entrar";
            this.IniciarSesion.UseVisualStyleBackColor = false;
            this.IniciarSesion.Click += new System.EventHandler(this.IniciarSesion_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(227, 120);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 38);
            this.txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(83, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(227, 174);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(192, 38);
            this.txtContra.TabIndex = 1;
            // 
            // Cancelar
            // 
            this.Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cancelar.ForeColor = System.Drawing.Color.White;
            this.Cancelar.Location = new System.Drawing.Point(108, 261);
            this.Cancelar.Margin = new System.Windows.Forms.Padding(6);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(150, 45);
            this.Cancelar.TabIndex = 3;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = false;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(76, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Agencia Automotriz";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 83);
            this.panel1.TabIndex = 7;
            // 
            // Frminiciosesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 348);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.IniciarSesion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frminiciosesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frminiciosesion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IniciarSesion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}