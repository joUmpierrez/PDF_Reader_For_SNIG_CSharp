using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using BLL;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Text.RegularExpressions;
using System.IO;

namespace UIL
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileInfo[] ext = PdfExtractor.GetPdfPath("C:\\Users\\Joaquin Razer\\Desktop\\Programacion\\Personal\\PDF_Reader_For_SNIG\\PDFs_De_Prueba");
            Regex numDicoseA = new Regex(@"(?<=DICOSE\sA:\s)[0-9]+");   // Numero Propietario Vendedor

            foreach (var item in ext)
            {
                Console.WriteLine(numDicoseA.IsMatch(PdfExtractor.PdfText(item.FullName)));
            }
            Console.ReadKey();
        }
    }
}
