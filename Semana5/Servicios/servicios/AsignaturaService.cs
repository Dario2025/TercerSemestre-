using System;
using System.Collections.Generic;

namespace ListaEjercicios.Servicios
{
    public class AsignaturaService
    {
        public void MostrarAsignaturas()
        {
            List<string> asignaturas = new List<string>
            {
                "Matemáticas", "Física", "Química", "Historia", "Lengua"
            };

            foreach (string asignatura in asignaturas)
            {
                Console.WriteLine($"Yo estudio {asignatura}");
            }
        }
    }
}
