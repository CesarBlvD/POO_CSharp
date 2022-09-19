using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class DynamicFile : MultimediaFile
    {
        public override string ObtenerTipo()
        {
            CalcularTamanio();
            string tArchivo = tipoArchivo;
            return "Archivo Dinamico";
        }
    }
}
