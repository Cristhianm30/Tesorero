using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tesorero.Class
{
    internal class Informe_Financiero
    {
        public int ID_Informe { get; set; }
        public string Periodo_Tiempo { get; set; }
        public decimal Ingresos_Totales { get; set; }
        public decimal Gastos_Totales { get; set; }
        public decimal Ganancia_Neta { get; set; }
    }
}
