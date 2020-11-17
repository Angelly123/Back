using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReglasNegocio
{
    public class Usuario
    {
        public int tipoUsuario { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string correo { get; set; }
        public string clave { get; set; }
        public string talento { get; set; }

        public string descripcion { get; set; }
        public int sex { get; set; }
        public string adjuntos { get; set; }
    }
}
