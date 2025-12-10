using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_Orientada_A_Objetos
{
    class Persona
    {
        public string Nombre
        {
            get;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("El campo no debe estar vacío.");
                else
                    field = value;
            }
        }
        public int AnioNacimiento
        {
            get;
            set
            {
                if (value < 0)
                    throw new ArgumentException("El año de nacimiento no debe ser negativo");
                else
                    field = value;
            }
        }

        public Persona(string nombre, int anioNacimiento)
        {
            Nombre = nombre;
            AnioNacimiento = anioNacimiento;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine($"Mi nombre es {Nombre} y nací en el año {AnioNacimiento}");
        }

        public override string ToString()
        {
            return $"• Nombre: {Nombre} | Año de nacimiento: {AnioNacimiento}";
        }
    }
}
