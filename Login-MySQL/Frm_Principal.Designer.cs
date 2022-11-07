
namespace Login_MySQL
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Lbl_Bienvenido = new System.Windows.Forms.Label();
            this.Panel_Menu = new System.Windows.Forms.Panel();
            this.Btn_RegistrarUsuariosA = new System.Windows.Forms.Button();
            this.Btn_Consultas = new System.Windows.Forms.Button();
            this.Pic_Logo = new System.Windows.Forms.PictureBox();
            this.Pic_Cerrar = new System.Windows.Forms.PictureBox();
            this.Btn_Configuracion = new System.Windows.Forms.Button();
            this.Panel_RegistroA = new System.Windows.Forms.Panel();
            this.chk_MostrarConfirma = new System.Windows.Forms.CheckBox();
            this.Txt_Confirmacion = new System.Windows.Forms.TextBox();
            this.Lbl_Confirmar = new System.Windows.Forms.Label();
            this.Txt_UsuarioR = new System.Windows.Forms.TextBox();
            this.Lbl_UsuarioR = new System.Windows.Forms.Label();
            this.Btn_Registrar = new System.Windows.Forms.Button();
            this.Lbl_Registro = new System.Windows.Forms.Label();
            this.Lbl_ContraseñaR = new System.Windows.Forms.Label();
            this.Txt_NombreU = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre = new System.Windows.Forms.Label();
            this.Txt_ContraseñaR = new System.Windows.Forms.TextBox();
            this.chk_Contraseña = new System.Windows.Forms.CheckBox();
            this.Panel_Consultas = new System.Windows.Forms.Panel();
            this.Panel_Configuracion = new System.Windows.Forms.Panel();
            this.Btn_CerrarSesion = new System.Windows.Forms.Button();
            this.Panel_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cerrar)).BeginInit();
            this.Panel_RegistroA.SuspendLayout();
            this.Panel_Consultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Bienvenido
            // 
            this.Lbl_Bienvenido.AutoSize = true;
            this.Lbl_Bienvenido.Font = new System.Drawing.Font("Mongolian Baiti", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bienvenido.Location = new System.Drawing.Point(346, 32);
            this.Lbl_Bienvenido.Name = "Lbl_Bienvenido";
            this.Lbl_Bienvenido.Size = new System.Drawing.Size(265, 50);
            this.Lbl_Bienvenido.TabIndex = 0;
            this.Lbl_Bienvenido.Text = "Bienvenido ";
            // 
            // Panel_Menu
            // 
            this.Panel_Menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Panel_Menu.Controls.Add(this.Btn_CerrarSesion);
            this.Panel_Menu.Controls.Add(this.Btn_Configuracion);
            this.Panel_Menu.Controls.Add(this.Pic_Logo);
            this.Panel_Menu.Controls.Add(this.Btn_Consultas);
            this.Panel_Menu.Controls.Add(this.Btn_RegistrarUsuariosA);
            this.Panel_Menu.Location = new System.Drawing.Point(-1, 0);
            this.Panel_Menu.Name = "Panel_Menu";
            this.Panel_Menu.Size = new System.Drawing.Size(324, 650);
            this.Panel_Menu.TabIndex = 8;
            // 
            // Btn_RegistrarUsuariosA
            // 
            this.Btn_RegistrarUsuariosA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_RegistrarUsuariosA.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_RegistrarUsuariosA.Location = new System.Drawing.Point(3, 190);
            this.Btn_RegistrarUsuariosA.Name = "Btn_RegistrarUsuariosA";
            this.Btn_RegistrarUsuariosA.Size = new System.Drawing.Size(318, 42);
            this.Btn_RegistrarUsuariosA.TabIndex = 9;
            this.Btn_RegistrarUsuariosA.Text = "Registrar Usuarios";
            this.Btn_RegistrarUsuariosA.UseVisualStyleBackColor = true;
            this.Btn_RegistrarUsuariosA.Click += new System.EventHandler(this.Btn_RegistrarUsuarios_Click);
            // 
            // Btn_Consultas
            // 
            this.Btn_Consultas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Consultas.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Consultas.Location = new System.Drawing.Point(3, 239);
            this.Btn_Consultas.Name = "Btn_Consultas";
            this.Btn_Consultas.Size = new System.Drawing.Size(318, 42);
            this.Btn_Consultas.TabIndex = 10;
            this.Btn_Consultas.Text = "Consultar Usuarios";
            this.Btn_Consultas.UseVisualStyleBackColor = true;
            this.Btn_Consultas.Click += new System.EventHandler(this.Btn_Consultas_Click);
            // 
            // Pic_Logo
            // 
            this.Pic_Logo.Image = global::Login_MySQL.Properties.Resources._17_cart_cat_icon_icons_com_76693;
            this.Pic_Logo.Location = new System.Drawing.Point(99, 12);
            this.Pic_Logo.Name = "Pic_Logo";
            this.Pic_Logo.Size = new System.Drawing.Size(128, 128);
            this.Pic_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Pic_Logo.TabIndex = 11;
            this.Pic_Logo.TabStop = false;
            // 
            // Pic_Cerrar
            // 
            this.Pic_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pic_Cerrar.Image = global::Login_MySQL.Properties.Resources.boton;
            this.Pic_Cerrar.Location = new System.Drawing.Point(961, 12);
            this.Pic_Cerrar.Name = "Pic_Cerrar";
            this.Pic_Cerrar.Size = new System.Drawing.Size(27, 26);
            this.Pic_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Pic_Cerrar.TabIndex = 7;
            this.Pic_Cerrar.TabStop = false;
            this.Pic_Cerrar.Click += new System.EventHandler(this.Pic_Cerrar_Click);
            // 
            // Btn_Configuracion
            // 
            this.Btn_Configuracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Configuracion.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Configuracion.Location = new System.Drawing.Point(3, 293);
            this.Btn_Configuracion.Name = "Btn_Configuracion";
            this.Btn_Configuracion.Size = new System.Drawing.Size(318, 42);
            this.Btn_Configuracion.TabIndex = 12;
            this.Btn_Configuracion.Text = "Configuracion Usuarios";
            this.Btn_Configuracion.UseVisualStyleBackColor = true;
            this.Btn_Configuracion.Click += new System.EventHandler(this.Btn_Configuracion_Click);
            // 
            // Panel_RegistroA
            // 
            this.Panel_RegistroA.BackColor = System.Drawing.Color.White;
            this.Panel_RegistroA.Controls.Add(this.Panel_Consultas);
            this.Panel_RegistroA.Controls.Add(this.chk_MostrarConfirma);
            this.Panel_RegistroA.Controls.Add(this.Txt_Confirmacion);
            this.Panel_RegistroA.Controls.Add(this.Lbl_Confirmar);
            this.Panel_RegistroA.Controls.Add(this.Txt_UsuarioR);
            this.Panel_RegistroA.Controls.Add(this.Lbl_UsuarioR);
            this.Panel_RegistroA.Controls.Add(this.Btn_Registrar);
            this.Panel_RegistroA.Controls.Add(this.Lbl_Registro);
            this.Panel_RegistroA.Controls.Add(this.Lbl_ContraseñaR);
            this.Panel_RegistroA.Controls.Add(this.Txt_NombreU);
            this.Panel_RegistroA.Controls.Add(this.Lbl_Nombre);
            this.Panel_RegistroA.Controls.Add(this.Txt_ContraseñaR);
            this.Panel_RegistroA.Controls.Add(this.chk_Contraseña);
            this.Panel_RegistroA.Location = new System.Drawing.Point(354, 89);
            this.Panel_RegistroA.Name = "Panel_RegistroA";
            this.Panel_RegistroA.Size = new System.Drawing.Size(619, 533);
            this.Panel_RegistroA.TabIndex = 13;
            this.Panel_RegistroA.Visible = false;
            // 
            // chk_MostrarConfirma
            // 
            this.chk_MostrarConfirma.AutoSize = true;
            this.chk_MostrarConfirma.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_MostrarConfirma.Location = new System.Drawing.Point(458, 344);
            this.chk_MostrarConfirma.Name = "chk_MostrarConfirma";
            this.chk_MostrarConfirma.Size = new System.Drawing.Size(76, 20);
            this.chk_MostrarConfirma.TabIndex = 13;
            this.chk_MostrarConfirma.Text = "Mostrar";
            this.chk_MostrarConfirma.UseVisualStyleBackColor = true;
            this.chk_MostrarConfirma.CheckedChanged += new System.EventHandler(this.chk_MostrarConfirma_CheckedChanged);
            // 
            // Txt_Confirmacion
            // 
            this.Txt_Confirmacion.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Confirmacion.Location = new System.Drawing.Point(28, 312);
            this.Txt_Confirmacion.Name = "Txt_Confirmacion";
            this.Txt_Confirmacion.PasswordChar = '*';
            this.Txt_Confirmacion.Size = new System.Drawing.Size(506, 26);
            this.Txt_Confirmacion.TabIndex = 12;
            // 
            // Lbl_Confirmar
            // 
            this.Lbl_Confirmar.AutoSize = true;
            this.Lbl_Confirmar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Confirmar.Location = new System.Drawing.Point(25, 284);
            this.Lbl_Confirmar.Name = "Lbl_Confirmar";
            this.Lbl_Confirmar.Size = new System.Drawing.Size(190, 20);
            this.Lbl_Confirmar.TabIndex = 18;
            this.Lbl_Confirmar.Text = "Confirme la Contraseña";
            // 
            // Txt_UsuarioR
            // 
            this.Txt_UsuarioR.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_UsuarioR.Location = new System.Drawing.Point(28, 167);
            this.Txt_UsuarioR.Name = "Txt_UsuarioR";
            this.Txt_UsuarioR.Size = new System.Drawing.Size(506, 26);
            this.Txt_UsuarioR.TabIndex = 9;
            // 
            // Lbl_UsuarioR
            // 
            this.Lbl_UsuarioR.AutoSize = true;
            this.Lbl_UsuarioR.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_UsuarioR.Location = new System.Drawing.Point(24, 144);
            this.Lbl_UsuarioR.Name = "Lbl_UsuarioR";
            this.Lbl_UsuarioR.Size = new System.Drawing.Size(69, 20);
            this.Lbl_UsuarioR.TabIndex = 16;
            this.Lbl_UsuarioR.Text = "Usuario";
            // 
            // Btn_Registrar
            // 
            this.Btn_Registrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Registrar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Registrar.Location = new System.Drawing.Point(28, 407);
            this.Btn_Registrar.Name = "Btn_Registrar";
            this.Btn_Registrar.Size = new System.Drawing.Size(121, 31);
            this.Btn_Registrar.TabIndex = 14;
            this.Btn_Registrar.Text = "Registrate";
            this.Btn_Registrar.UseVisualStyleBackColor = true;
            this.Btn_Registrar.Click += new System.EventHandler(this.Btn_Registrar_Click);
            // 
            // Lbl_Registro
            // 
            this.Lbl_Registro.AutoSize = true;
            this.Lbl_Registro.Font = new System.Drawing.Font("Mongolian Baiti", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Registro.Location = new System.Drawing.Point(17, 21);
            this.Lbl_Registro.Name = "Lbl_Registro";
            this.Lbl_Registro.Size = new System.Drawing.Size(304, 45);
            this.Lbl_Registro.TabIndex = 8;
            this.Lbl_Registro.Text = "Create Account";
            // 
            // Lbl_ContraseñaR
            // 
            this.Lbl_ContraseñaR.AutoSize = true;
            this.Lbl_ContraseñaR.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ContraseñaR.Location = new System.Drawing.Point(24, 213);
            this.Lbl_ContraseñaR.Name = "Lbl_ContraseñaR";
            this.Lbl_ContraseñaR.Size = new System.Drawing.Size(94, 20);
            this.Lbl_ContraseñaR.TabIndex = 12;
            this.Lbl_ContraseñaR.Text = "Contraseña";
            // 
            // Txt_NombreU
            // 
            this.Txt_NombreU.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NombreU.Location = new System.Drawing.Point(25, 101);
            this.Txt_NombreU.Name = "Txt_NombreU";
            this.Txt_NombreU.Size = new System.Drawing.Size(509, 26);
            this.Txt_NombreU.TabIndex = 8;
            // 
            // Lbl_Nombre
            // 
            this.Lbl_Nombre.AutoSize = true;
            this.Lbl_Nombre.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nombre.Location = new System.Drawing.Point(21, 78);
            this.Lbl_Nombre.Name = "Lbl_Nombre";
            this.Lbl_Nombre.Size = new System.Drawing.Size(72, 20);
            this.Lbl_Nombre.TabIndex = 11;
            this.Lbl_Nombre.Text = "Nombre";
            // 
            // Txt_ContraseñaR
            // 
            this.Txt_ContraseñaR.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_ContraseñaR.Location = new System.Drawing.Point(25, 236);
            this.Txt_ContraseñaR.Name = "Txt_ContraseñaR";
            this.Txt_ContraseñaR.PasswordChar = '*';
            this.Txt_ContraseñaR.Size = new System.Drawing.Size(509, 26);
            this.Txt_ContraseñaR.TabIndex = 10;
            // 
            // chk_Contraseña
            // 
            this.chk_Contraseña.AutoSize = true;
            this.chk_Contraseña.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_Contraseña.Location = new System.Drawing.Point(458, 268);
            this.chk_Contraseña.Name = "chk_Contraseña";
            this.chk_Contraseña.Size = new System.Drawing.Size(76, 20);
            this.chk_Contraseña.TabIndex = 11;
            this.chk_Contraseña.Text = "Mostrar";
            this.chk_Contraseña.UseVisualStyleBackColor = true;
            this.chk_Contraseña.CheckedChanged += new System.EventHandler(this.chk_Contraseña_CheckedChanged);
            // 
            // Panel_Consultas
            // 
            this.Panel_Consultas.Controls.Add(this.Panel_Configuracion);
            this.Panel_Consultas.Location = new System.Drawing.Point(0, 0);
            this.Panel_Consultas.Name = "Panel_Consultas";
            this.Panel_Consultas.Size = new System.Drawing.Size(619, 533);
            this.Panel_Consultas.TabIndex = 14;
            this.Panel_Consultas.Visible = false;
            // 
            // Panel_Configuracion
            // 
            this.Panel_Configuracion.Location = new System.Drawing.Point(1, 1);
            this.Panel_Configuracion.Name = "Panel_Configuracion";
            this.Panel_Configuracion.Size = new System.Drawing.Size(619, 533);
            this.Panel_Configuracion.TabIndex = 15;
            this.Panel_Configuracion.Visible = false;
            // 
            // Btn_CerrarSesion
            // 
            this.Btn_CerrarSesion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CerrarSesion.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CerrarSesion.Location = new System.Drawing.Point(3, 577);
            this.Btn_CerrarSesion.Name = "Btn_CerrarSesion";
            this.Btn_CerrarSesion.Size = new System.Drawing.Size(318, 42);
            this.Btn_CerrarSesion.TabIndex = 13;
            this.Btn_CerrarSesion.Text = "Cerrar Sesion";
            this.Btn_CerrarSesion.UseVisualStyleBackColor = true;
            this.Btn_CerrarSesion.Click += new System.EventHandler(this.Btn_CerrarSesion_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.Panel_RegistroA);
            this.Controls.Add(this.Panel_Menu);
            this.Controls.Add(this.Pic_Cerrar);
            this.Controls.Add(this.Lbl_Bienvenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Panel_Menu.ResumeLayout(false);
            this.Panel_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Cerrar)).EndInit();
            this.Panel_RegistroA.ResumeLayout(false);
            this.Panel_RegistroA.PerformLayout();
            this.Panel_Consultas.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Bienvenido;
        private System.Windows.Forms.PictureBox Pic_Cerrar;
        private System.Windows.Forms.Panel Panel_Menu;
        private System.Windows.Forms.Button Btn_RegistrarUsuariosA;
        private System.Windows.Forms.PictureBox Pic_Logo;
        private System.Windows.Forms.Button Btn_Consultas;
        private System.Windows.Forms.Button Btn_Configuracion;
        private System.Windows.Forms.Panel Panel_RegistroA;
        private System.Windows.Forms.CheckBox chk_MostrarConfirma;
        private System.Windows.Forms.TextBox Txt_Confirmacion;
        private System.Windows.Forms.Label Lbl_Confirmar;
        private System.Windows.Forms.TextBox Txt_UsuarioR;
        private System.Windows.Forms.Label Lbl_UsuarioR;
        private System.Windows.Forms.Button Btn_Registrar;
        private System.Windows.Forms.Label Lbl_Registro;
        private System.Windows.Forms.Label Lbl_ContraseñaR;
        private System.Windows.Forms.TextBox Txt_NombreU;
        private System.Windows.Forms.Label Lbl_Nombre;
        private System.Windows.Forms.TextBox Txt_ContraseñaR;
        private System.Windows.Forms.CheckBox chk_Contraseña;
        private System.Windows.Forms.Panel Panel_Consultas;
        private System.Windows.Forms.Panel Panel_Configuracion;
        private System.Windows.Forms.Button Btn_CerrarSesion;
    }
}