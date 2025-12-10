using System;
using System.Collections.Generic;
using System.Text;

namespace Programacion_Orientada_A_Objetos
{
    class Perro
    {
        public string Nombre { get; set; }
        public string ColorPelaje { get; set; }
        public string Raza { get; set; }
        public int AnioNacimiento { get; set; }
        public string Duenio { get; set; }

        public Perro(string nombre, string colorPelaje, string raza, int anioDeNacimiento)
        {
            Nombre = nombre;
            ColorPelaje = colorPelaje;
            Raza = raza;
            AnioNacimiento = anioDeNacimiento;
        }

        public void Ladrar()
        {
            Console.WriteLine("Wof Wof conchetumare");
        }

        public override string ToString()
        {
            return $"• Nombre: {Nombre} | Raza: {Raza} | Color pelaje: {ColorPelaje}";
        }
    }
}
