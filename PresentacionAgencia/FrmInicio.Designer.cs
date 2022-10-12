namespace PresentacionAgencia
{
    partial class FrmInicio
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEscritorio = new System.Windows.Forms.Button();
            this.btnHerramientas = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.AdministrarUsuarios = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(442, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 87);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Modulos Disponibles";
            // 
            // btnEscritorio
            // 
            this.btnEscritorio.BackColor = System.Drawing.Color.Maroon;
            this.btnEscritorio.ForeColor = System.Drawing.Color.White;
            this.btnEscritorio.Location = new System.Drawing.Point(428, 286);
            this.btnEscritorio.Name = "btnEscritorio";
            this.btnEscritorio.Size = new System.Drawing.Size(154, 66);
            this.btnEscritorio.TabIndex = 3;
            this.btnEscritorio.Text = "Salir al escritorio";
            this.btnEscritorio.UseVisualStyleBackColor = false;
            this.btnEscritorio.Click += new System.EventHandler(this.btnEscritorio_Click);
            // 
            // btnHerramientas
            // 
            this.btnHerramientas.BackColor = System.Drawing.Color.Silver;
            this.btnHerramientas.Location = new System.Drawing.Point(88, 145);
            this.btnHerramientas.Name = "btnHerramientas";
            this.btnHerramientas.Size = new System.Drawing.Size(267, 50);
            this.btnHerramientas.TabIndex = 0;
            this.btnHerramientas.Text = "Taller (Herramientas)";
            this.btnHerramientas.UseVisualStyleBackColor = false;
            this.btnHerramientas.Click += new System.EventHandler(this.btnHerramientas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Silver;
            this.btnProductos.Location = new System.Drawing.Point(88, 264);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(267, 50);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Refacciones (Productos)";
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // AdministrarUsuarios
            // 
            this.AdministrarUsuarios.BackColor = System.Drawing.Color.LightGreen;
            this.AdministrarUsuarios.Location = new System.Drawing.Point(434, 163);
            this.AdministrarUsuarios.Name = "AdministrarUsuarios";
            this.AdministrarUsuarios.Size = new System.Drawing.Size(148, 72);
            this.AdministrarUsuarios.TabIndex = 4;
            this.AdministrarUsuarios.Text = "Administrar Usuarios";
            this.AdministrarUsuarios.UseVisualStyleBackColor = false;
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 383);
            this.Controls.Add(this.AdministrarUsuarios);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnHerramientas);
            this.Controls.Add(this.btnEscritorio);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInicio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnHerramientas;
        private System.Windows.Forms.Button btnEscritorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AdministrarUsuarios;
    }
}