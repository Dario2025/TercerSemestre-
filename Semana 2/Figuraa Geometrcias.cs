using System;

// Clase que representa un Círculo
public class Circulo
{
    private double radio; // Atributo privado que guarda el radio del círculo

    // Constructor que recibe el valor del radio
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // Calcula el área del círculo usando la fórmula: π * radio^2
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // Calcula el perímetro del círculo usando la fórmula: 2 * π * radio
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase que representa un Cuadrado
public class Cuadrado
{
    private double lado; // Atributo privado que guarda el lado del cuadrado

    // Constructor que recibe el valor del lado
    public Cuadrado(double lado)
    {
        this.lado = lado;
    }

    // Calcula el área del cuadrado: lado * lado
    public double CalcularArea()
    {
        return lado * lado;
    }

    // Calcula el perímetro del cuadrado: 4 * lado
    public double CalcularPerimetro()
    {
        return 4 * lado;
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Crear un círculo con radio 3
        Circulo miCirculo = new Circulo(3);
        Console.WriteLine("Área del círculo: " + miCirculo.CalcularArea());
        Console.WriteLine("Perímetro del círculo: " + miCirculo.CalcularPerimetro());

        // Crear un cuadrado con lado 4
        Cuadrado miCuadrado = new Cuadrado(4);
        Console.WriteLine("Área del cuadrado: " + miCuadrado.CalcularArea());
        Console.WriteLine("Perímetro del cuadrado: " + miCuadrado.CalcularPerimetro());
    }
}
