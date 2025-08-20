using System;
using System.Collections.Generic;
using System.Linq;

namespace CampaniaVacunacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Crear 500 ciudadanos
            HashSet<string> todosCiudadanos = new HashSet<string>();
            for (int i = 1; i <= 500; i++)
            {
                todosCiudadanos.Add("Ciudadano " + i);
            }

            // 2. Crear 75 vacunados con Pfizer
            HashSet<string> vacunadosPfizer = new HashSet<string>();
            Random rnd = new Random();
            while (vacunadosPfizer.Count < 75)
            {
                int numero = rnd.Next(1, 501); // rango 1 - 500
                vacunadosPfizer.Add("Ciudadano " + numero);
            }

            // 3. Crear 75 vacunados con AstraZeneca
            HashSet<string> vacunadosAstraZeneca = new HashSet<string>();
            while (vacunadosAstraZeneca.Count < 75)
            {
                int numero = rnd.Next(1, 501);
                vacunadosAstraZeneca.Add("Ciudadano " + numero);
            }

            // 4. Operaciones de teoría de conjuntos

            // a) Ciudadanos que NO se han vacunado
            var noVacunados = todosCiudadanos.Except(vacunadosPfizer.Union(vacunadosAstraZeneca));

            // b) Ciudadanos con ambas dosis
            var ambasDosis = vacunadosPfizer.Intersect(vacunadosAstraZeneca);

            // c) Ciudadanos que solo recibieron Pfizer
            var soloPfizer = vacunadosPfizer.Except(vacunadosAstraZeneca);

            // d) Ciudadanos que solo recibieron AstraZeneca
            var soloAstraZeneca = vacunadosAstraZeneca.Except(vacunadosPfizer);

            // 5. Mostrar resultados
            Console.WriteLine("LISTADOS DE VACUNACIÓN COVID-19\n");

            Console.WriteLine("1) No vacunados: " + noVacunados.Count());
            foreach (var c in noVacunados) Console.WriteLine(c);

            Console.WriteLine("\n2) Con ambas dosis: " + ambasDosis.Count());
            foreach (var c in ambasDosis) Console.WriteLine(c);

            Console.WriteLine("\n3) Solo Pfizer: " + soloPfizer.Count());
            foreach (var c in soloPfizer) Console.WriteLine(c);

            Console.WriteLine("\n4) Solo AstraZeneca: " + soloAstraZeneca.Count());
            foreach (var c in soloAstraZeneca) Console.WriteLine(c);

            Console.WriteLine("\nProceso finalizado. Presiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
