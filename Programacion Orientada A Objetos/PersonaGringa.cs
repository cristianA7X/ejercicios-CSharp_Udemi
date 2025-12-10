using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_Orientada_A_Objetos
{
    class PersonaGringa : Persona
    {
        public PersonaGringa(string nombre, int anioNacimiento) :
            base(nombre, anioNacimiento)
        { }
        public override void Mostrar()
        {
            Console.WriteLine($"Wassup bro, i'm {Nombre} and i was born in {AnioNacimiento}");
        }

        public override string ToString()
        {
            return $"• Name: {Nombre} | Year of birth: {AnioNacimiento}";
        }
    }
}
