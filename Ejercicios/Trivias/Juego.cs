using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoTrivias
{
    class Juego
    {
        private string TituloJuegoArt = @"
___________      .__      .__         ________                          __   
\__    ___/______|__|__  _|__|____    \_____  \  __ __   ____   _______/  |_ 
  |    |  \_  __ \  \  \/ /  \__  \    /  / \  \|  |  \_/ __ \ /  ___/\   __\
  |    |   |  | \/  |\   /|  |/ __ \_ /   \_/.  \  |  /\  ___/ \___ \  |  |  
  |____|   |__|  |__| \_/ |__(____  / \_____\ \_/____/  \___  >____  > |__|  
                                  \/         \__>           \/     \/        
";
        private string TituloJuego = "Trivia Quest";
        private string Descripcion = "Juega y obten el puntaje mas alto";
        private Jugador jugador;
        private Cuestionario PrimerPregunta;
        private Cuestionario SegundaPregunta;
        private Cuestionario TercerPregunta;
        private Cuestionario CuartaPregunta;
        private Cuestionario QuintaPregunta;
        
        public Juego()
        {
            PrimerPregunta = new Cuestionario("La Independencia de Honduras se celebra el 15 de septiembre - true or false?","true");
            SegundaPregunta = new Cuestionario("Francisco Morazan aparece en el billete de 20 Lempiras - true or false?","false");
            TercerPregunta = new Cuestionario("La bandera de Honduras tiene 2 franjas blancas - true or false?","true");
            CuartaPregunta = new Cuestionario("San Pedro Sula es la capital de Honduras - true or false?","false");
            QuintaPregunta = new Cuestionario("Las 5 estrellas en la bandera representan los 5 estados centroamericanos - true or false?","true");

        }

        public void Jugar()
        {
            TituloJuego = TituloJuego;

            Console.WriteLine(TituloJuegoArt);
            Console.WriteLine("Bienvenido al Juego de Preguntas!");
            Console.WriteLine(Descripcion);
            Console.WriteLine("");

            Console.Write("Ingresa el nombre: ");
            string nombre = Console.ReadLine();
            jugador = new Jugador(nombre);
            Console.WriteLine($"Bienvenido a {TituloJuego}, {jugador.Nombre}! ");
            Console.WriteLine($"Tu puntaje inicial es {jugador.Puntaje}.");

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("");
            PrimerPregunta.Preguntar();
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("");
            SegundaPregunta.Preguntar();
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("");
            TercerPregunta.Preguntar();
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("");
            CuartaPregunta.Preguntar();
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("");
            QuintaPregunta.Preguntar();
            Console.WriteLine("****************************************************************************************");
            

            Console.WriteLine("Presione enter para iniciar.");
            Console.ReadKey();

        }
    }
}
