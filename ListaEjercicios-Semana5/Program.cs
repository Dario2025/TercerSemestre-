using ListaEjercicios.Servicios;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // =======================
        // EJERCICIO 10: Precios
        // =======================
        Console.WriteLine("Ejercicio 10: Mayor y menor precio");
        List<int> precios = new List<int> { 50, 75, 46, 22, 80, 65, 8 };
        var precioService = new PrecioService();
        Console.WriteLine($"Precio menor: {precioService.ObtenerMenor(precios)}");
        Console.WriteLine($"Precio mayor: {precioService.ObtenerMayor(precios)}");

        // =======================
        // EJERCICIO 9: Contar vocales
        // =======================
        Console.WriteLine("\nEjercicio 9: Contar vocales");
        Console.Write("Ingrese una palabra: ");
        string palabraUsuario = Console.ReadLine();
        var vocalService = new VocalService();
        vocalService.ContarVocales(palabraUsuario);

        // =======================
        // EJERCICIO 8: Palíndromo
        // =======================
        Console.WriteLine("\nEjercicio 8: Palíndromo");
        Console.Write("Ingrese una palabra: ");
        string palabraPalindromo = Console.ReadLine();
        var palindromoService = new PalindromoService();
        bool esPalindromo = palindromoService.EsPalindromo(palabraPalindromo);
        Console.WriteLine(esPalindromo ? "Es un palíndromo" : "No es un palíndromo");

        // =======================
        // EJERCICIO 7: Abecedario
        // =======================
        Console.WriteLine("\nEjercicio 7: Letras en posiciones no múltiplos de 3");
        var abecedarioService = new AbecedarioService();
        abecedarioService.MostrarAbecedarioFiltrado();

        // =======================
        // EJERCICIO 2: Asignaturas
        // =======================
        Console.WriteLine("\nEjercicio: Asignaturas");
        var asignaturaService = new AsignaturaService();
        asignaturaService.MostrarAsignaturas();
    }
}
