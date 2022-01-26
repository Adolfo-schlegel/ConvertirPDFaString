using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirPDFaString
{
    internal class ConversionConStreamReader
    {
        public static string pf_ConvertirPdfAString(string path, string path2)
        {
            string result = "OK";
            try
            {
                Encoding objEncoding = Encoding.Latin1;
                string lstr_ValorEnBd = "";

                // 1, convierto archivo => StreamReader           
                StreamReader objSR = new StreamReader(path, objEncoding);

                // 2, Guardar en BD
                // 2.1, convierto Encoding => String
                // 2.2, Guardo String en BD

                lstr_ValorEnBd = objSR.ReadToEnd();
           
                Console.WriteLine(lstr_ValorEnBd.ToString());
                // 3, Leo BD
                // 3.1, Guardo en String         
                // 3.2, convierto String  => StreamReader

                               

                //lstr_ValorEnBd = objEncoding.GetString

                // 4, convierto Encoding => archivo
                StreamWriter objSW = new StreamWriter(path2, false, objEncoding);

                objSW.WriteLine(lstr_ValorEnBd);

                objSW.Write(objSR.ReadToEnd());

                objSW.Close();

                objSR.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
            }
            return result;
        }

        public static string pf_ConvertirStringAPdf(string pdf_string, string nuevoArchivo)
        {
            string result = "OK";

            

            return result;
        }
    }
}
//archivo1 = System.Text.Encoding.UTF8.GetString(vs);//tomo el string de los bytes

//archivo4 = System.Text.Encoding.Unicode.GetBytes(archivo1);//tomo los bytes de el string 