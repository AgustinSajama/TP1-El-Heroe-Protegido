using System;
using System.Collections.Generic;

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
        Console.WriteLine($"el guerrero {Nombre} ataca con su espada usando {fuerza} de poder");
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
        Console.WriteLine($"el mago {Nombre} tira un hechizo");
    }
}

class Program
{
    static void Main(string[] args)
    {     
        Console.WriteLine("creando lista de heroes");
        List<Heroe> listaHeroes = new List<Heroe>();
        
        Guerrero thor = new Guerrero("Thor", 120, 85);
        Mago merlin = new Mago("Merlín", 80);
        
        listaHeroes.Add(thor);
        listaHeroes.Add(merlin);
        
        Console.WriteLine($"se agregaron {listaHeroes.Count} heroes a la lista\n");
        Console.WriteLine("los heroes atacan");
        foreach (Heroe heroe in listaHeroes)
        {
            heroe.Atacar();
        }
    }
}