using MySql.Data.MySqlClient;
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

    }
}
