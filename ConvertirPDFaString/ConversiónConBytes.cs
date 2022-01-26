using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConvertirPDFaString
{
    internal class ConversiónConBytes
    {
        public byte [] ConvertirPdfAString(string path)
        {            
            byte[] CollectionBytes = File.ReadAllBytes(path); //leo los bytes del archivo 
         
            return CollectionBytes;
        }

        public string ConvertirBytesAPdf(byte[] collection, string name)
        {
            string resultado = "OK";
            try
            {
                
                File.WriteAllBytes(CrearPDF(name, collection), collection); //escribo los bytes a traves de la clase file en un nuevo archivo
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return resultado;
        }

        public static string CrearPDF(string name, byte[] objdata)
        {
            string filename = @"C:\Users\adolf\OneDrive\Escritorio\pdf\generados\" + name;

            /*
             ---Necesarias para generar PDF---

               *iTextSharp.text;
                 * iTextSharp.text.pdf;
            */

           // Document doc = new Document(PageSize.A4.Rotate(), 10, 10, 10, 10); //genero estructura de documento 

            FileStream file = new FileStream(filename, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);// genero archivo
            file.Write(objdata, 0, objdata.Length);
            //PdfWriter.GetInstance(doc, file); //escribo el documento con las propiedades de un archivo 

            file.Close();
            return filename;
        }
    }
}
