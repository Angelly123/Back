using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ReglasNegocio;
using AccesoDatos;
namespace PresentacionAPI.Controllers
{
    public class UsuariosController : ApiController
    {
        private UsuarioController user = new UsuarioController(new BaseDatos());

        [Route("api/usuario/registrarnuevousuario")]
        public bool registrarUsuarioNuevo(int tipoUsuario, string nombre, string apellido, int edad, string correo, 
            string clave, string talento, string descripcion, int sex, string adjuntos)
        {
            Usuario usuario = new Usuario();
            usuario.tipoUsuario = tipoUsuario;
            usuario.nombre = nombre;
            usuario.apellido = apellido;
            usuario.edad = edad;
            usuario.correo = correo;
            usuario.clave = clave;
            usuario.talento = talento;
            usuario.descripcion = descripcion;
            usuario.sex = sex;
            usuario.adjuntos = adjuntos;

            return user.registrarUsuarioNuevo(usuario);
        }
    }
}
