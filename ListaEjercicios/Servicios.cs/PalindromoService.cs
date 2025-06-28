using System;

namespace ListaEjercicios.Servicios
{
    public class PalindromoService
    {
        public bool EsPalindromo(string palabra)
        {
            string texto = palabra.ToLower().Replace(" ", "");
            char[] invertido = texto.ToCharArray();
            Array.Reverse(invertido);
            return texto == new string(invertido);
        }
    }
}
