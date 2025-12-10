using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_Orientada_A_Objetos
{
    class TituloSubrayado : Titulo
    {
        public TituloSubrayado(int x, int y, string texto) : base(x, y, texto)
        {

        }

        public override void Mostrar()
        {
            base.Mostrar();

            Console.SetCursorPosition(X, Y + 1);
            Console.WriteLine(new string('-', Texto.Length));
        }
    }
}
