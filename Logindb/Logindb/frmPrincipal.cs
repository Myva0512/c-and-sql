﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logindb
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();

            txtNombre.Text = sesion.nombre;
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
