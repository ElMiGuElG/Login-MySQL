using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_MySQL
{
    public partial class Frm_Principal : Form
    {
        int tipo_usuario;
        public Frm_Principal()
        {
            InitializeComponent();

            Btn_RegistrarUsuariosA.Enabled = false;
            Btn_Configuracion.Enabled = false;
            Btn_Consultas.Enabled = false;

            Lbl_Bienvenido.Text = "Bienvenido " + sesion.nombre;

            tipo_usuario = sesion.id_Tipo;

            if (tipo_usuario == 1)
            {
                Btn_RegistrarUsuariosA.Enabled = true;
                Btn_Consultas.Enabled = true;
                
            }
            else
            {
                Btn_RegistrarUsuariosA.Enabled = false;
                Btn_Consultas.Enabled = false;

                Btn_Configuracion.Enabled = true;
            }
        }

        private void Pic_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_RegistrarUsuarios_Click(object sender, EventArgs e)
        {
            Panel_Consultas.Visible = false;
            Panel_Configuracion.Visible = false;
            Panel_RegistroA.Visible = true;
        }

        private void chk_Contraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Contraseña.Checked == true)
            {
                if (Txt_ContraseñaR.PasswordChar == '*')
                {
                    Txt_ContraseñaR.PasswordChar = '\0';
                }
            }
            else
            {
                Txt_ContraseñaR.PasswordChar = '*';
            }
        }

        private void chk_MostrarConfirma_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_MostrarConfirma.Checked == true)
            {
                if (Txt_Confirmacion.PasswordChar == '*')
                {
                    Txt_Confirmacion.PasswordChar = '\0';
                }
            }
            else
            {
                Txt_Confirmacion.PasswordChar = '*';
            }
        }

        private void Btn_Registrar_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();
            usuario.Nombre = Txt_NombreU.Text;
            usuario.Usuario = Txt_UsuarioR.Text;
            usuario.Contraseña = Txt_ContraseñaR.Text;
            usuario.Concontraseña = Txt_Confirmacion.Text;

            try
            {
                controlador control = new controlador();
                string respuesta = control.control_registro(usuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bienvenido Nuevo Usuario", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Txt_NombreU.Text = "";
                    Txt_UsuarioR.Text = "";
                    Txt_ContraseñaR.Text = "";
                    Txt_Confirmacion.Text = "";
                }

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void Btn_Consultas_Click(object sender, EventArgs e)
        {
            Panel_Configuracion.Visible = false;
            Panel_RegistroA.Visible = false;
            Panel_Consultas.Visible = true;
        }

        private void Btn_Configuracion_Click(object sender, EventArgs e)
        {
            Panel_Consultas.Visible = false;
            Panel_RegistroA.Visible = false;
            Panel_Configuracion.Visible = true;
        }

        private void Btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Login login = new Frm_Login();
            login.Visible = true;

            sesion sesion = new sesion();
        }
    }
}
