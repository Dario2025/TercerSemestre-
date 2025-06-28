using System;
using System.Collections.Generic;

namespace ListaEjercicios.Servicios
{
    public class VocalService
    {
        public void ContarVocales(string palabra)
        {
            Dictionary<char, int> conteo = new Dictionary<char, int>()
            {
                { 'a', 0 }, { 'e', 0 }, { 'i', 0 }, { 'o', 0 }, { 'u', 0 }
            };

            foreach (char letra in palabra.ToLower())
            {
                if (conteo.ContainsKey(letra))
                {
                    conteo[letra]++;
                }
            }

            Console.WriteLine("Conteo de vocales:");
            foreach (var par in conteo)
            {
                Console.WriteLine($"{par.Key}: {par.Value}");
            }
        }
    }
}
