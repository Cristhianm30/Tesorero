using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesorero.Class
{
    internal class Venta
    {
        public int ID_Venta { get; set; }
        public int ID_Producto { get; set; }
        public int cantidad_Vendida { get; set; }
        public decimal Precio_Total { get; set; }
        public string Fecha_Hora_Venta { get; set; }
        public int ID_Empleado { get; set; }

    }
}
