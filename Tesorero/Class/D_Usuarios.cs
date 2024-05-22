using MySql.Data.MySqlClient;
using Mysqlx.Prepare;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesorero.Class
{
    internal class D_Usuarios
    {
        public DataTable login(string username,string pass)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                //Procedimiento de almacenado
                sqlcon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("usp_login",sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                //Parametros
                Comando.Parameters.Add("username",MySqlDbType.VarChar).Value = username;
                Comando.Parameters.Add("pass", MySqlDbType.VarChar).Value = pass;
                // Carga de datos
                sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        public DataTable Listado_Usuario(string cTexto)
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                //Procedimiento de almacenado
                sqlcon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("usp_Listado_Usuario", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                //Parametros
                Comando.Parameters.Add("cTexto", MySqlDbType.VarChar).Value = cTexto;
                // Carga de datos
                sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        public DataTable Listado_Rol()
        {
            MySqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            MySqlConnection sqlcon = new MySqlConnection();
            try
            {
                //Procedimiento de almacenado
                sqlcon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("usp_Listado_Rol", sqlcon);
                Comando.CommandType = CommandType.StoredProcedure;
                //Parametros
                // Carga de datos
                sqlcon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sqlcon.State == ConnectionState.Open) sqlcon.Close();
            }
        }

        public string Guardar_Usuario(int Opcion,Usuario Pro)
        {
            string Respuesta = "";
            MySqlConnection SqlCon = new MySqlConnection();
            try
            {
                SqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand Comando = new MySqlCommand("usp_Guardar_Usuario",SqlCon);
                Comando .CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("Opcion",MySqlDbType.Int32).Value=Opcion;
                Comando.Parameters.Add("cID_Usuario", MySqlDbType.Int32).Value = Pro.ID_Usuario;
                Comando.Parameters.Add("cNombre_Usuario", MySqlDbType.VarChar).Value = Pro.Nombre_Usuario;
                Comando.Parameters.Add("cContrasena", MySqlDbType.VarChar).Value = Pro.Contrasena;
                Comando.Parameters.Add("cID_Rol", MySqlDbType.Int32).Value = Pro.ID_Rol;
                
                MySqlParameter p_Codigo = new MySqlParameter();
                p_Codigo.ParameterName = "Codigo_Salida";
                p_Codigo.MySqlDbType = MySqlDbType.Int32;
                p_Codigo.Direction= ParameterDirection.Output;
                Comando.Parameters.Add(p_Codigo);
                SqlCon.Open();
                Comando.ExecuteNonQuery();
                Respuesta = Convert.ToString(p_Codigo.Value);


            }
            catch (Exception ex)
            {
                Respuesta = ex.Message;
            }
            finally { 
                if(SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return Respuesta;
        }



        public static implicit operator D_Usuarios(Usuario v)
        {
            throw new NotImplementedException();
        }
    }
}
