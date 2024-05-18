using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesorero.Class
{
    internal class Detalle_Pedido
    {
        public int ID_Detalle_Pedido { get; set; }
        public int ID_Pedido { get; set; }
        public int ID_Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Total { get; set; }
    }
}
