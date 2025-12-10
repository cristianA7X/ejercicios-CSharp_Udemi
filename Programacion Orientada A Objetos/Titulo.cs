using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_Orientada_A_Objetos
{
    class Titulo
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Texto
        {
            get
            {
                return field;
            }
            set
            {
                field = value;
            }
        }

        public Titulo(int x, int y, string texto)
        {
            X = x;
            Y = y;
            Texto = texto;
        }
        public virtual void Mostrar()
        {
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(Texto);
        }
    }
}
