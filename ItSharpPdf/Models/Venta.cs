using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItSharpPdf.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cantidad { get; set; }
        public decimal Unitario { get; set; }
        public decimal Total { get; set; }
    }
}
