using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasNegocio
{
    public class UsuarioController
    {
        private repositorioDatos repositorio;

        public UsuarioController(repositorioDatos repo)
        {
            this.repositorio = repo;
        }

        public bool registrarUsuarioNuevo(Usuario usuario)
        {
            if (usuario.tipoUsuario.Equals("") || usuario.nombre.Equals("") || usuario.apellido.Equals("")
                || usuario.edad.Equals("") || usuario.correo.Equals("") || usuario.clave.Equals("") 
                || usuario.talento.Equals("") || usuario.descripcion.Equals("")) 

                return false;

            else

                return repositorio.registrarUsuarioNuevo(usuario);

        }

    }
}
