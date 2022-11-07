using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Login_MySQL
{
    class controlador
    {
        public string control_registro(Usuarios usuario)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Contraseña) || string.IsNullOrEmpty(usuario.Nombre) || string.IsNullOrEmpty(usuario.Concontraseña))
            {
                respuesta = "Debe Ingresar Todos Los Valores";
            }
            else
            {
                if (usuario.Contraseña == usuario.Concontraseña)
                {
                    if (modelo.usuarioingresado(usuario.Usuario))
                    {
                        respuesta = "Usuario Ya Registrado";
                    }
                    else
                    {
                        usuario.Contraseña = generarSHA1(usuario.Contraseña);
                        usuario.Id_tipo = 2;
                        modelo.registro(usuario);
                    }
                }
                else
                {
                    respuesta = "Las Contraseñas No Coinciden";
                }
            }
            return respuesta;
        }

        public string ControlLogin(string usuario, string contraseña)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuarios datosUsuarios = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty (contraseña))
            {
                respuesta = "Debe Ingresar Todos Los Valores";
            }
            else
            {
                datosUsuarios = modelo.usuarioexistente(usuario);

                if (datosUsuarios == null)
                {
                    respuesta = "Este Usuario NO Existe";
                }
                else
                {
                    if (datosUsuarios.Contraseña != generarSHA1(contraseña))
                    {
                        respuesta = "El Usuario y/o Contraseña no Coinciden";
                    }
                    else
                    {
                        sesion.id = datosUsuarios.Id;
                        sesion.id_Tipo = datosUsuarios.Id_tipo;
                        sesion.nombre = datosUsuarios.Nombre;
                        sesion.usuarios = usuario; 
                    }
                }
            }
            return respuesta;

        }

        public string generarSHA1 (string cadena)
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
