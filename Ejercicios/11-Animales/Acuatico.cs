using System;
public abstract class Acuaticos: Reino 
{
   public int Aleta {get;set;} 
   
   public void funcionesacuaticos()
    {
      cosasdeacuaticos();
    }
   
   private void cosasdeacuaticos()
    {
        Console.WriteLine("Vivir todo el tiempo o gran parte dentro del agua");
        
    }
}  