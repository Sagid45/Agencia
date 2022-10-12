﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionAgencia
{
    public partial class Frminiciosesion : Form
    {
        public Frminiciosesion()
        {
            InitializeComponent();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IniciarSesion_Click(object sender, EventArgs e)
        {
            FrmInicio inicio = new FrmInicio();
            inicio.ShowDialog();
        }
    }
}
