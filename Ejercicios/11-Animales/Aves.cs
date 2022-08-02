using System;
public abstract class Aves: Reino
{
    public string Plumaje {get;set;}
    

    public void funcionesaves()
    {
      cosasdeaves();
    }
    private void cosasdeaves()
    {
        Console.WriteLine("Volando");

    }

}