using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //MultimediaFile multimedia;
            //DynamicFile dFile = new DynamicFile();
            //StaticFile sFile = new StaticFile();
            //OtherFile oFile = new OtherFile();

            //multimedia = dFile;
            //Console.WriteLine(multimedia.ObtenerTipo());
            //multimedia = sFile;
            //Console.WriteLine(multimedia.ObtenerTipo());
            //multimedia = oFile;
            //Console.WriteLine(multimedia.ObtenerTipo());

            string prueba = "Esta es una demo de los metodos de extension";
            //var cantidad1 = MetodosExtension.ContarPalabras(prueba); // fomra incorrecta
            
            var cantidad2 = prueba.ContarPalabras();

            //Console.WriteLine(cantidad1);
            Console.WriteLine(cantidad2);

            Console.ReadLine();
        }
    }
}
