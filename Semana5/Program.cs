using System;
using System.Collections.Generic;
using System.Linq;

namespace ListaEjercicios.Servicios
{
    public class PrecioService
    {
        public int ObtenerMenor(List<int> precios)
        {
            return precios.Min();
        }

        public int ObtenerMayor(List<int> precios)
        {
            return precios.Max();
        }
    }
}
