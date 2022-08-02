using System;
public abstract class Animal: Reino 
{
   
    public string Pelaje {get;set;}
    public string Parto {get; set;}
    
    public void funcionesmamiferos()
    {
      cosasdemamiferos();
    }
   
    private void cosasdemamiferos()
    {
      
        
    }

    public void defensasdealpaca()
    {
      cosasdealpacas();
    }
   
    private void cosasdealpacas()
    {
        Console.WriteLine("Pastar llanuras todo el dia sin parar");
    }
}