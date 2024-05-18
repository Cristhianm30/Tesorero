using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Tesorero.Class
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Puerto;
        private string Usuario;
        private string Clave;
        private static Conexion con = null;

        private Conexion() {
            //Datos de la conexion con la DB
            this.Base = "Tesorero";
            this.Servidor = "localhost";
            this.Puerto = "3306";
            this.Usuario = "root";
            this.Clave = "0452";
        }

        public MySqlConnection CrearConexion()
        {
            MySqlConnection Cadena = new MySqlConnection();
            try
            {
                Cadena.ConnectionString = "datasource=" + this.Servidor + "; port=" + this.Puerto + ";username=" + this.Usuario + ";password=" + this.Clave + ";database=" + this.Base;
            }
            catch (Exception ex) {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }
    }
}
