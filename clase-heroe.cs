using System;

public abstract class Heroe
{
    private string nombre;
    private int puntosVida;
    
    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }
    
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
    
    public Heroe(string nombre, int puntosVida)
    {
        this.nombre = nombre;
        this.puntosVida = puntosVida;
    }
    
    // Método virtual/abstracto para polimorfismo
    public abstract void Atacar();
}

public class Guerrero : Heroe
{
    private int fuerza;
    
    public int Fuerza
    {
        get { return fuerza; }
        set
        {
            if (value < 0)
                fuerza = 0;
            else
                fuerza = value;
        }
    }
    
    public Guerrero(string nombre, int puntosVida, int fuerza) 
        : base(nombre, puntosVida)
    {
        this.fuerza = fuerza;
    }
    
    public override void Atacar()
    {
        Console.WriteLine($"El guerrero {Nombre} ataca con su espada usando {fuerza} de poder");
    }
}

public class Mago : Heroe
{
    public Mago(string nombre, int puntosVida) 
        : base(nombre, puntosVida)
    {
    }
    
    public override void Atacar()
    {
        Console.WriteLine($"El mago {Nombre} lanza un hechizo");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== PRUEBA DE HERENCIA Y POLIMORFISMO ===\n");
        
        Guerrero thor = new Guerrero("Thor", 120, 85);
        Mago merlin = new Mago("Merlín", 80);
        
        Console.WriteLine("=== PRUEBA DE ATAQUES ===\n");
        thor.Atacar();
        merlin.Atacar();
    }
}