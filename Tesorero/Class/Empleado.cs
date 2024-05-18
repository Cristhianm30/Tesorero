using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tesorero.Class
{
    internal class Empleado
    {
        public int ID_Empleado {  get; set; }
        public string Nombre { get; set; }
        public string Posicion { get; set; }
        public decimal Salario { get; set; }
        public string Fecha_Contratacion { get; set; }
    }
}
