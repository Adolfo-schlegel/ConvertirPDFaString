using System.IO;
using System.Reflection.Metadata;
using System.Text;

public class Program
{

    static void Main(string[] args)
    {       
        Console.WriteLine("Inicio");
        ConvertirPDFaString.ConversiónConBytes conversiónConBytes = new();
        //pdf
        byte[] archivo1;
        byte[] archivo2;
        byte[] archivo3;

        //rutas
        string path1 = @"C:\Users\adolf\OneDrive\Escritorio\pdf\arduino.pdf";
        string path2 = @"C:\Users\adolf\OneDrive\Escritorio\pdf\Matematica.pdf";
        string path3 = @"C:\Users\adolf\OneDrive\Escritorio\pdf\backup_cvm_gpa_cnt_04.zip";

        //collecciones de bytes
        archivo1 = conversiónConBytes.ConvertirPdfAString(path1);
        archivo2 = conversiónConBytes.ConvertirPdfAString(path2);

        // convierto archivo => Byte()
        archivo3 = conversiónConBytes.ConvertirPdfAString(path3);

        // convierto Byte() => String
        string contenido = System.Text.Encoding.Latin1.GetString(archivo3, 0, archivo3.Length);
     
        //---------------------------------------


        //"Contenido" ya es un string, por lo tanto lo puedes guardar en una base de datos y develverlo para la reconversion a archivo y almacenamiento 


        //--------------------------------------------------------------------------------------------------------
        //  despues de esta linea de codigo el archivo se convierte a byte y se guarda solo en una ruta especifica

        // convierto String  => Byte()
        archivo3 = System.Text.Encoding.Latin1.GetBytes(contenido);
        
        // convierto Byte() => archivo
        string result = conversiónConBytes.ConvertirBytesAPdf(archivo3, System.IO.Path.GetFileName(path3));

        //result
        if (result == "OK")      
            Console.WriteLine("Copiado con exito :) ");
        
        Console.ReadKey();
    }
   
}
