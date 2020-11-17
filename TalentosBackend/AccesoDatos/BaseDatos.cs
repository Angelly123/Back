using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReglasNegocio;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace AccesoDatos
{
    public class BaseDatos : repositorioDatos
    {
        public bool registrarUsuarioNuevo(Usuario usuario)
        {
            try
            {
                bool existe = false;
                string respuesta = "";
                SqlConnection cn = new SqlConnection(@"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TALENTOS;Data Source=LAPTOP-0O44VAVH\SQLEXPRESS");

                SqlCommand cmd = new SqlCommand("USP_registrarUsuarioNuevo", cn);


                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tipoUsuario", usuario.tipoUsuario);
                cmd.Parameters.Add("@nombre", usuario.nombre);
                cmd.Parameters.Add("@apellido ", usuario.apellido);
                cmd.Parameters.Add("@edad", usuario.edad);
                cmd.Parameters.Add("@correo", usuario.correo);
                cmd.Parameters.Add("@clave", usuario.clave);
                cmd.Parameters.Add("@talento", usuario.talento);
                cmd.Parameters.Add("@descripcion", usuario.descripcion);
                cmd.Parameters.Add("@sex", usuario.sex);
                cmd.Parameters.Add("@adjuntos", usuario.adjuntos);


                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                
                if (dr.Read() == true)
                {
                    respuesta = dr["respuesta"].ToString();
                    cn.Close();
                }


                if (respuesta.Equals("true"))
                {
                    existe = true;
                }
                cn.Close();

                return existe;
            


            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }


       
    }
}
