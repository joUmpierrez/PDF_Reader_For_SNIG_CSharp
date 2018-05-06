using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.Text.RegularExpressions;
using System.IO;

namespace BLL
{
    public static class PdfExtractor
    {
        public static string PdfText(string path)
        {
            PdfReader reader = new PdfReader(path);
            string text = string.Empty;
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, page);
            }
            reader.Close();
            return text;
        }

        public static void SaveInformation(string cons)
        {
            Regex fechaAutor = new Regex(@"");  // Fecha Autorizacion
            Regex numGuiaPro = new Regex(@"");  // Guia de Propiedad y Transito
            Regex numAutoriz = new Regex(@"");  // Numero de Autorizacion
            Regex numDicoseA = new Regex(@"(?<=DICOSE\sA:\s)[0-9]+");   // Numero Propietario Vendedor
            Regex numDicoseB = new Regex(@"(?<=DICOSE\sB:\s)[0-9]+");   // Numero Propietario Comprador
            Regex numDicoseC = new Regex(@"(?<=DICOSE\sC:\s)[0-9]+");   // Numero Sitio Salida
            Regex numDicoseD = new Regex(@"(?<=DICOSE\sD:\s)[0-9]+");   // Numero Sitio Llegada
            Regex nomDicoseA = new Regex(@"(?<=" + numDicoseA.Match(cons) + " ).+$", RegexOptions.Multiline);   // Nombre Propietario Vendedor
            Regex nomDicoseB = new Regex(@"(?<=" + numDicoseB.Match(cons) + " ).+$", RegexOptions.Multiline);   // Nombre Propietario Comprador
            Regex nomDicoseC = new Regex(@"(?<=" + numDicoseC.Match(cons) + " ).+$", RegexOptions.Multiline);   // Nombre Sitio Salida
            Regex nomDicoseD = new Regex(@"(?<=" + numDicoseD.Match(cons) + " ).+$", RegexOptions.Multiline);   // Nombre Sitio Llegada
            Regex numCaravan = new Regex(@"[\d]{15}");  // Numeros de caravana
        }

        // Metodo para extraer todos los archivos de una Carpeta Determinada (TODA LA INFORMACION DEL ARCHIVO)
        public static FileInfo[] GetPdfPath(string folderPath)
        {
            DirectoryInfo directory = new DirectoryInfo(folderPath);
            FileInfo[] files = directory.GetFiles("*.pdf");
            return files;
        }
    }
}
