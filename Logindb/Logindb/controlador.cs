using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logindb
{
    class controlador
    {
        public string ctrlRegistro(usuarios usuario)
        {
            modelo modelo = new modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Contraseña) || string.IsNullOrEmpty(usuario.ConPassword) || string.IsNullOrEmpty(usuario.Nombre))
            {
                respuesta = "Debe llenar todos los campos";
            }

            else
            {
                if (usuario.Contraseña == usuario.ConPassword)
                {
                    if (modelo.existusuario(usuario.Usuario))
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else
                    {
                        usuario.Contraseña = generarSHA1(usuario.Contraseña);
                        modelo.registro(usuario);
                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }
            }
            return respuesta;
        }

        public string ctrlLogin(string usuario, string contraseña)
        {
            modelo modelo = new modelo();
            string respuesta = "";
            usuarios datosusuario = null;
             
            if(string.IsNullOrEmpty (usuario) || string.IsNullOrEmpty (contraseña))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosusuario = modelo.PorUsuario(usuario);
                
                if (datosusuario == null)
                {
                    respuesta = "El usuario no existe";

                    frmRegistro frm1 = new frmRegistro();

                    frm1.Visible = true;

                    
                }

                else
                {
                    if (datosusuario.Contraseña != generarSHA1 (contraseña) )

                    {
                        respuesta = "El usuario y/o contraseña no coinciden";
                    }

                    else
                    {
                        sesion sesion = new sesion();
                        sesion.id = datosusuario.Id;
                        sesion.usuario = usuario;
                        sesion.nombre = datosusuario.Nombre;
                        sesion.id_tipo = datosusuario.Id_tipo;
                    }
                }
            }
            return respuesta;
        }

        private string generarSHA1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }

            return sb.ToString();
        }


    }
}
