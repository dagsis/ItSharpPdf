using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace ItSharpPdf.Models
{
    [Table("Productos")]
    public class Producto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal Precio { get; set; }
        public int Vistas { get; set; }
        public int Ventas { get; set; }
        public decimal PrecioOferta { get; set; }
        public decimal DescuentoOferta { get; set; }
    }
}
