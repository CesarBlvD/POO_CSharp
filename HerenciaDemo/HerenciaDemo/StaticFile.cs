using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaDemo
{
    class StaticFile : MultimediaFile
    {
        public override string ObtenerTipo()
        {
            return "Archivo Estatico";
        }
    }
}
