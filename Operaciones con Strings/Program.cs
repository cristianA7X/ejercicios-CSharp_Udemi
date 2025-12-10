using System;

internal class EjemploConStrings
 {
    static void Main(string[] args)                                                                
    {
        string saludo = "Avenged Sevenfold";
        
        if(saludo == "Chau")
        {

        }

        foreach(char letra in saludo)
        {
            Console.Write(letra + " ");
        }

        Console.WriteLine();

        for (int i = 0; i < saludo.Length; i++)
        {
            Console.Write(saludo[i] + " ");
        }

        Console.WriteLine();

        Console.WriteLine(saludo.ToUpper());
        Console.WriteLine(saludo.Substring(0,7));
        Console.WriteLine(saludo.Contains("Seven"));
        Console.WriteLine(saludo.IndexOf("Seven"));
        Console.WriteLine(saludo.LastIndexOf("Seven"));
    }
}
