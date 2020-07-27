using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ItSharpPdf.Models;
using iTextSharp.text;
using System.Drawing;
using iTextSharp.text.pdf;
using System.IO;
using Rectangle = iTextSharp.text.Rectangle;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace ItSharpPdf.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IWebHostEnvironment _env;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _env = env;
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Document doc = new Document(PageSize.A4);

            // Tamaño creado por el usuario
            //doc.SetPageSize(new Rectangle(202.1f,1000f));

            //doc.SetMargins(85f,28.34f,85f,28.34f); // Igual a un cm

            //Document doc = new Document(PageSize.A4.Rotate());


            //FileStream file = new FileStream("Hola mundo.pdf",FileMode.Create);

            //MemoryStream ms = new MemoryStream();
            //PdfWriter writer = PdfWriter.GetInstance(doc,ms);

            //doc.AddAuthor("Carlos D Agostino");
            //doc.AddTitle("Hola Mundo");
            //doc.Open();

            // Crear una linea personalizada
            // https://www.youtube.com/watch?v=aaOBYzqnXO0&list=PLYAyQauAPx8mJa0p6dvfdPcsUBoGqI5Ds&index=7
            //  PdfContentByte cb = writer.DirectContent;
            //cb.MoveTo(0, 0);
            //cb.LineTo(200, 200);
            //cb.ClosePathStroke();


            //BaseFont fuente = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
            //iTextSharp.text.Font titulo = new iTextSharp.text.Font(fuente, 18f, iTextSharp.text.Font.BOLD,BaseColor.Black);



            //iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(Path.Combine(_env.WebRootPath, "img", "LogoDagsis.jpg"));

            // Porcentaje de la imagen

            //logo.ScalePercent(35);

            // Calcular la proporcion
            //float ancho = logo.Width;
            //float alto = logo.Height;
            //float proporcion = alto / ancho;

            //logo.ScaleAbsoluteWidth(200);
            //logo.ScaleAbsoluteHeight(200 * proporcion);

            //logo.SetAbsolutePosition(0,750);

            //doc.Add(logo);

            // Lineas
            Chunk linea = new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(1f, 100f,BaseColor.Black,Element.ALIGN_CENTER,0f));
            //doc.Add(linea);

            //doc.Add(new Paragraph(" "));

            //doc.Add(new Phrase("REPORTES DE VENTAS",titulo));

            //doc.Add(new Paragraph(" "));

            //doc.Add(new Paragraph($"The standard chunk of Lorem Ipsum used since the 1500s is reproduced below for those interested.\n Sections 1.10.32 and 1.10.33 from de Finibus Bonorum et Malorum by Cicero are also reproduced in their exact original form, accompanied by English versions from the 1914 translation by H. Rackham.") {Alignment = Element.ALIGN_JUSTIFIED });
            //doc.Add(Chunk.Newline);

            //var tbl = new PdfPTable(new float[] { 50f, 50f }) { WidthPercentage = 100f };
            //tbl.AddCell(new Phrase("Nombre"));
            //tbl.AddCell(new Phrase("Apellido"));
            //doc.Add(tbl);


            //writer.Close();
            //doc.Close();

          //  ms.Seek(0, SeekOrigin.Begin);

            //file.Dispose();

            //return File(new FileStream("hola mundo.pdf",FileMode.Open,FileAccess.Read),"application/pdf");

          //  return File(ms.ToArray(), "application/pdf");

            return View();


        }

        public IActionResult Privacy()
        {
            Document doc = new Document(PageSize.A4);
            doc.SetMargins(40f, 40f, 40f, 40f);

            MemoryStream ms = new MemoryStream();
            PdfWriter writer = PdfWriter.GetInstance(doc, ms);

            doc.AddAuthor("Carlos D Agostino");
            doc.AddTitle("Reportes de Ventas");
            doc.Open();

            BaseFont _titulo = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1250, true);
            iTextSharp.text.Font titulo = new iTextSharp.text.Font(_titulo, 18f, iTextSharp.text.Font.BOLD, new BaseColor(0,0,0));

            BaseFont _subtitulo = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
            iTextSharp.text.Font subtitulo = new iTextSharp.text.Font(_subtitulo, 12f, iTextSharp.text.Font.BOLD, new BaseColor(0, 0, 0));

            BaseFont _parrafo = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
            iTextSharp.text.Font parrafo = new iTextSharp.text.Font(_parrafo, 10f, iTextSharp.text.Font.NORMAL, new BaseColor(0, 0, 0));

            BaseFont _negrita = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
            iTextSharp.text.Font negrita = new iTextSharp.text.Font(_negrita, 10f, iTextSharp.text.Font.BOLD, new BaseColor(0, 0, 0));

            BaseFont _textoblanco = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
            iTextSharp.text.Font textoblanco = new iTextSharp.text.Font(_textoblanco, 10f, iTextSharp.text.Font.BOLD, new BaseColor(255,255,255));


            BaseFont _toinvoice = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, true);
            iTextSharp.text.Font toinvoice = new iTextSharp.text.Font(_toinvoice, 20f, iTextSharp.text.Font.BOLD, new BaseColor(255,255,255));

            doc.Add(Chunk.Newline);

            Chunk barra = new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(5f, 30f, new BaseColor(0, 69, 161), Element.ALIGN_RIGHT, -1));
            doc.Add(barra);

            doc.Add(new Paragraph(" "));

            var tbl = new PdfPTable(new float[] { 40f, 60f }) { WidthPercentage = 100f };
            tbl.AddCell(new PdfPCell(new Phrase("DAgostino Sistemas", titulo)) { Border = 0,Rowspan = 3, VerticalAlignment = Element.ALIGN_MIDDLE });
            tbl.AddCell(new PdfPCell(new Phrase("B.Mitre 120, Cap.Sarmiento, Argentina",parrafo)) { Border = 0, HorizontalAlignment = Element.ALIGN_RIGHT });
            tbl.AddCell(new PdfPCell(new Phrase("+(54) 92478-475660 dagsis@dagsis.com.ar",parrafo)) { Border = 0, HorizontalAlignment = Element.ALIGN_RIGHT });
            tbl.AddCell(new PdfPCell(new Phrase(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"), parrafo)) { Border = 0, HorizontalAlignment = Element.ALIGN_RIGHT });
            doc.Add(tbl);

            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));

            tbl = new PdfPTable(new float[] { 20f,50f,30f }) { WidthPercentage = 100f };
            tbl.AddCell(new PdfPCell(new Phrase("TO:", toinvoice)) {BorderColor = new BaseColor(0,69,161),BackgroundColor = new BaseColor(0,69,161), HorizontalAlignment = Element.ALIGN_CENTER,VerticalAlignment = Element.ALIGN_MIDDLE, Rowspan = 3 });

            tbl.AddCell(new PdfPCell(new Phrase("Australian Gift Network", parrafo)) { BorderColor = new BaseColor(0, 69, 161), BorderWidthBottom = 0, Padding = 5f });
            tbl.AddCell(new PdfPCell(new Phrase("INVOICE", toinvoice)) { BorderColor = new BaseColor(0, 69, 161), BackgroundColor = new BaseColor(0, 69, 161), HorizontalAlignment = Element.ALIGN_CENTER, VerticalAlignment = Element.ALIGN_MIDDLE, Rowspan = 3 });
            tbl.AddCell(new PdfPCell(new Phrase("31 Calle Ponienta, Colonia Miraflore", parrafo)) { BorderColor = new BaseColor(0, 69, 161), BorderWidthBottom = 0, BorderWidthTop = 0, Padding = 5f });
            tbl.AddCell(new PdfPCell(new Phrase("Colonia San Miguel, Pasaje los Olivos 45", parrafo)) { BorderColor = new BaseColor(0, 69, 161),BorderWidthTop = 0, Padding = 5f });
            doc.Add(tbl);

            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));

            tbl = new PdfPTable(new float[] { 50f, 50f }) { WidthPercentage = 100f };
            var col1 = new PdfPCell(new Phrase("Att. Tony Calh", negrita)) { Border=0, Padding = 5f };
            var col2 = new PdfPCell(new Phrase("INVOICE #4817824-4", parrafo)) {Border=0, HorizontalAlignment = Element.ALIGN_RIGHT };
            tbl.AddCell(col1);
            tbl.AddCell(col2);

            col1.Phrase = new Phrase("Reportes de Ventas: 1601",parrafo);
            col2.Phrase = new Phrase("# de Cuenta",parrafo);
            tbl.AddCell(col1);
            tbl.AddCell(col2);

            col1.Phrase = new Phrase("Limite de Entrega: 30 dias", parrafo);
            col2.Phrase = new Phrase("Fecha: 18 de nomviembre de 2019" , parrafo);
            tbl.AddCell(col1);
            tbl.AddCell(col2);

            doc.Add(tbl);

            doc.Add(new Paragraph(" "));
            doc.Add(new Paragraph(" "));

            tbl = new PdfPTable(new float[] { 15f, 40f, 15f,15f,15f }) { WidthPercentage = 100f };
            var c1 = new PdfPCell(new Phrase("Código", negrita)) { Border = 0,BorderWidthBottom = 2f,BorderColor = new BaseColor(0,69,161), Padding = 5f};
            var c2 = new PdfPCell(new Phrase("Producto", negrita)) { Border = 0, BorderWidthBottom = 2f, BorderColor = new BaseColor(0, 69, 161), Padding = 5f };
            var c3 = new PdfPCell(new Phrase("Cantidad", negrita)) { Border = 0, BorderWidthBottom = 2f, BorderColor = new BaseColor(0, 69, 161), Padding = 5f, HorizontalAlignment = Element.ALIGN_CENTER };
            var c4 = new PdfPCell(new Phrase("P.Unitario", negrita)) { Border = 0, BorderWidthBottom = 2f, BorderColor = new BaseColor(0, 69, 161), Padding = 5f, HorizontalAlignment = Element.ALIGN_CENTER };
            var c5 = new PdfPCell(new Phrase("Total", negrita)) { Border = 0, BorderWidthBottom = 2f, BorderColor = new BaseColor(0, 69, 161), Padding = 5f, HorizontalAlignment = Element.ALIGN_CENTER };

            tbl.AddCell(c1);
            tbl.AddCell(c2);
            tbl.AddCell(c3);
            tbl.AddCell(c4);
            tbl.AddCell(c5);

            List<Venta> ventas = new List<Venta>();
            ventas.Add(new Venta { Id = 1, Name = "Impresora Epson lx 200", Cantidad = 2, Unitario = 200, Total = 400 });
            ventas.Add(new Venta { Id = 2, Name = "Monitor Samsung", Cantidad = 1, Unitario = 300, Total = 300 });
            ventas.Add(new Venta { Id = 3, Name = "Memoria 8gb", Cantidad = 2, Unitario = 250, Total = 500 });
            ventas.Add(new Venta { Id = 4, Name = "Kit", Cantidad = 1, Unitario = 200, Total = 200 });
            ventas.Add(new Venta { Id = 5, Name = "Matherboar Asus a452", Cantidad =1 ,Unitario = 150.00m, Total = 150.00m });

            c1.Border = 0;
            c2.Border = 0;
            c3.Border = 0;
            c3.HorizontalAlignment = Element.ALIGN_RIGHT;
            c4.Border = 0;
            c4.HorizontalAlignment = Element.ALIGN_RIGHT;
            c5.Border = 0;
            c5.HorizontalAlignment = Element.ALIGN_RIGHT;

            foreach (var order in ventas)
            {
                c1.Phrase = new Phrase(order.Id.ToString());
                c2.Phrase = new Phrase(order.Name);
                c3.Phrase = new Phrase(order.Cantidad.ToString("N"));
                c4.Phrase = new Phrase(order.Unitario.ToString("N2"));
                c5.Phrase = new Phrase(order.Total.ToString("N2"));
                tbl.AddCell(c1);
                tbl.AddCell(c2);
                tbl.AddCell(c3);
                tbl.AddCell(c4);
                tbl.AddCell(c5);
            }
            c1.Colspan = 5;
            c1.Phrase = new Phrase(ventas.Select(x=> new { Total  = x.Total }).Sum(x => x.Total).ToString("N2"));
            c1.HorizontalAlignment = Element.ALIGN_RIGHT;

            tbl.AddCell(c1);

            doc.Add(tbl);

            tbl = new PdfPTable(new float[] { 50f, 50f }) { WidthPercentage = 90f };
            var tbl1 = new PdfPTable(new float[] { 33f, 33f, 34f }) { WidthPercentage = 100f };
            var tbl2 = new PdfPTable(new float[] { 100f }) { WidthPercentage = 100f };

            tbl.DefaultCell.Border = 0;
            tbl.DefaultCell.Padding = 10f;

            c1.Colspan = 3;
            c1.HorizontalAlignment = Element.ALIGN_CENTER;
            c1.VerticalAlignment = Element.ALIGN_MIDDLE;
            c1.BackgroundColor = new BaseColor(0, 69, 161);
            c1.Phrase = new Phrase("HISTORIAL DE PAGOS", textoblanco);
            tbl1.AddCell(c1);

            c2.Phrase = new Phrase("Fecha",negrita);
            c3.Phrase = new Phrase("# Cheque",negrita);
            c4.Phrase = new Phrase("Importe",negrita);
            tbl1.AddCell(c2);
            tbl1.AddCell(c3);
            tbl1.AddCell(c4);

            c2.Phrase = new Phrase("12/11/2019", parrafo);
            c3.Phrase = new Phrase("12356", parrafo);
            c4.Phrase = new Phrase("$1,245.00", parrafo);
            tbl1.AddCell(c2);
            tbl1.AddCell(c3);
            tbl1.AddCell(c4);

            c2.Phrase = new Phrase("19/11/2019", parrafo);
            c3.Phrase = new Phrase("58466", parrafo);
            c4.Phrase = new Phrase("$1,500.00", parrafo);
            tbl1.AddCell(c2);
            tbl1.AddCell(c3);
            tbl1.AddCell(c4);

            tbl.AddCell(tbl1);
            tbl.AddCell(tbl2);

            doc.Add(tbl);

            writer.Close();
            doc.Close();

            ms.Seek(0, SeekOrigin.Begin);

            return File(ms, "application/pdf");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
