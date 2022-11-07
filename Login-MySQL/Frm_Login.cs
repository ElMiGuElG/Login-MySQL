using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Login_MySQL
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string usuario = Txt_UsuarioL.Text;
            string contraseña = Txt_ContraseñaL.Text;

            try
            {
                controlador control = new controlador();
                string respuesta = control.ControlLogin(usuario,contraseña);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Frm_Principal frmprinci = new Frm_Principal();
                    frmprinci.Visible = true;
                    this.Visible = false;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message,"Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void Btn_Registro_Click(object sender, EventArgs e)
        {
            Panel_Registro.Visible = true;
            Pic_Tienda.Image = Login_MySQL.Properties.Resources._4_review_cat_icon_icons_com_76680;
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

        private void Btn_Volver_Click(object sender, EventArgs e)
        {
            Txt_NombreU.Text = "";
            Txt_UsuarioR.Text = "";
            Txt_ContraseñaR.Text = "";
            Txt_Confirmacion.Text = "";

            Txt_UsuarioL.Text = "";
            Txt_ContraseñaL.Text = "";

            Pic_Tienda.Image = Login_MySQL.Properties.Resources._16_client_cat_icon_icons_com_76692;

            Panel_Login.Visible = true;
            Panel_Registro.Visible = false;
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

        private void chk_Mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Mostrar.Checked == true)
            {
                if (Txt_ContraseñaL.PasswordChar == '*')
                {
                    Txt_ContraseñaL.PasswordChar = '\0';
                }
            }
            else
            {
                Txt_ContraseñaL.PasswordChar = '*';
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
