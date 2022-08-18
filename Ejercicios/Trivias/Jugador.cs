using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoTrivias
{
    class Jugador
    {
        public string Nombre { get; set; }
        public int Puntaje { get; set; }

        public Jugador(string nombre)
        {
            Nombre = nombre;
            Puntaje = 0;

        }
    }

}
