using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesorero.Class
{
    internal class Pedido
    {
        public int ID_Pedido { get; set; }
        public int ID_Cliente { get; set; }
        public int ID_Empleado { get; set; }
        public string Fecha_Pedido { get; set; }
        public string Estado_Pedido { get; set; }
        public decimal Total_Pedido { get; set; }

    }
}
