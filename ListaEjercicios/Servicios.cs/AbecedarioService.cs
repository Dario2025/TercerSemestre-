using System;
using System.Collections.Generic;

namespace ListaEjercicios.Servicios
{
    public class AbecedarioService
    {
        public void MostrarAbecedarioFiltrado()
        {
            List<char> abecedario = new List<char>();
            for (char c = 'a'; c <= 'z'; c++)
            {
                abecedario.Add(c);
            }

            List<char> resultado = new List<char>();
            for (int i = 0; i < abecedario.Count; i++)
            {
                // Se omiten posiciones múltiplos de 3 (empezando desde 1)
                if ((i + 1) % 3 != 0)
                {
                    resultado.Add(abecedario[i]);
                }
            }

            Console.WriteLine("Abecedario sin letras en posiciones múltiplos de 3:");
            Console.WriteLine(string.Join(", ", resultado));
        }
    }
}
