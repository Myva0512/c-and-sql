using System;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = txbUsuario.Text;
            string Contraseña = txbContraseña.Text;


            try
            {
                controlador ctrl = new controlador();
                string respuesta = ctrl.ctrlLogin(usuario,Contraseña);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    frmPrincipal frm = new frmPrincipal();

                    frm.Visible = true;
                    this.Visible=false;
                }


            }catch(Exception ex)
            {

                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
    }
}
