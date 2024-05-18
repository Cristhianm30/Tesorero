using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesorero.Class
{
    internal class Proveedor
    {
        public int ID_Proveedor { get; set; }
        public string Nombre_Proveedor { get; set; }
        public string Direccion { get; set; }
        public string Numero_Telefono { get; set; }
        public string Correo_Electronico { get; set; }
        public string Productos_Suministra { get; set;}
    }
}
