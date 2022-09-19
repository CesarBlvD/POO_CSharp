using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class MultimediaFile : System.Object
    {
        protected string tipoArchivo;
        public virtual string ObtenerTipo()
        {
            return "Archivo Multimedia";
        }
        protected void CalcularTamanio()
        {

        }
    }
}
