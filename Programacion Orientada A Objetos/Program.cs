using Programacion_Orientada_A_Objetos;
using System;
Console.OutputEncoding = System.Text.Encoding.UTF8;

var t = new Titulo(45,1 , "El diablo loko");
t.Mostrar();

var t2 = new TituloSubrayado(45, 5, "Mierda loco. Cebolla");
t2.Mostrar();

var pipol = new Persona("Juancho", 1945);
pipol.Mostrar();

var pipol2 = new PersonaGringa("John", 1938);
pipol2.Mostrar();

Persona[] gente = new Persona[5];

gente[0] = new Persona("Juancho Tacortta", 1976);
gente[1] = new Persona("Mónica galindo", 1978);
gente[2] = new Persona("Rosa Meltrozo", 1998);
gente[3] = new Persona("Débora Meltrozo", 2001);
gente[4] = new PersonaGringa("Elvio Lao", 2003);

foreach (var item in gente)
{
    Console.Write("• ");
    item.Mostrar();
}

Perro[] pichichos = new Perro[3];
Console.WriteLine("*****************************************");
pichichos[0] = new Perro("Firulais", "Rubio", "Golden", 2010);
pichichos[1] = new Perro("Angueto", "Marrón clarito", "Labrador chaqueño", 1999);
pichichos[2] = new Perro("Pity", "Negro", "Pastor correntino", 2018);
foreach (var pichicho in pichichos)
{
    Console.WriteLine(pichicho.MostrarInfo());
    pichicho.Ladrar();
}

