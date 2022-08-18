using System;

public class Participante
{

    public string Nombre{ get; set; }


    public void EnviarNotificacion()
    {
        Console.WriteLine("Ganador: " + Nombre);
    }
}
