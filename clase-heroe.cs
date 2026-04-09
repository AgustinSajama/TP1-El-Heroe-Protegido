using System;

public class Heroe
{
    private int puntosVida;

    public int PuntosVida
    {
        get { return puntosVida; }
        set
        {
            if (value < 0)
                puntosVida = 0;
            else
                puntosVida = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Heroe miHeroe = new Heroe();
        
        // Probamos la propiedad
        miHeroe.PuntosVida = 100;
        Console.WriteLine($"Puntos de vida: {miHeroe.PuntosVida}");
        
        // Intentamos poner un valor negativo
        miHeroe.PuntosVida = -500;
        Console.WriteLine($"Puntos de vida después de intentar poner -500: {miHeroe.PuntosVida}");
        Console.ReadKey();
    }
}