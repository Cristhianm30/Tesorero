using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesorero.Class
{
    internal class Factura
    {
        public int ID_Factura { get; set; }
        public int ID_Pedido { get; set; }
        public int ID_Cliente { get; set; }
        public string Fecha_Factura { get; set; }
        public decimal Total_Factura { get; set; }
        public string Metodo_Pago { get; set; }
    }
}
