using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using actividad_asincrona.entidades;

namespace actividad_asincrona.negocio
{
    public class cls_datos
    {
        public int Conteo(datos datos)
        {
            datos.total = datos.palabra.Length;
            return datos.total;

        }

    }
}