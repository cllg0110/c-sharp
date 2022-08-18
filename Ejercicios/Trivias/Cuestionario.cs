using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoTrivias
{
    class Cuestionario

    {
        private string Pregunta { get; set; }
        private string Respuesta { get; set; }

        public Cuestionario(string pregunta, string respuesta)
        {
            Pregunta = pregunta;
            Respuesta = respuesta;

        }

        public void Preguntar()
        {
            Console.WriteLine(Pregunta);
            Console.WriteLine("La respuesta es ");
            string jugadorPregunta = Console.ReadLine();
            Console.WriteLine($"Tu respuesta {jugadorPregunta}'.");
            Console.WriteLine($"La respuesta correcta era :{Respuesta}");

        }

    }
}


