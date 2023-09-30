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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            usuarios usuario = new usuarios();
            usuario.Usuario = txtUsuario.Text;
            usuario.Contraseña = txbContraseña.Text;
            usuario.ConPassword = txbConfirmarContraseña.Text;
            usuario.Nombre = txbNombre.Text;

            try
            {
                controlador controlador = new controlador();
                string respuesta = controlador.ctrlRegistro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(respuesta, "Usuario Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
