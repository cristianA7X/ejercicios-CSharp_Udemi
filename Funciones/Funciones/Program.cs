//Formato de salida para la consola
Console.OutputEncoding = System.Text.Encoding.UTF8;

//Ejecucion del programa
int[] array = { 1986, 2022, 1978, 1990, 2014 };
int minimo, maximo;
MaxMinArray(array, out minimo, out maximo);
for (int i = 0; i < 6; i++)
{
    Console.Write(SucesionFibonacci(i) + " ");
}
Console.WriteLine();
Console.WriteLine($"Minimo: {minimo} | Maximo: {maximo}");
bool esValido = false;
int n = 0;
int cuadrado = 0;
do
{
    Console.Write("Ingrese un numero que quiera elevar al cuadrado y saber si es primo: ");
    try
    {
        string? input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new FormatException();
        }
        n = int.Parse(input);
        cuadrado = ElevarAlCuadrado(n);
        esValido = true;
    }
    catch (FormatException)
    {
        Console.WriteLine("❌ Error: Entrada no válida (debe ser un número entero).");
        esValido = false;
    }
}
while (!esValido);
Console.WriteLine($"{n} elevado al cuadrado es {cuadrado}");
MostarMenuPrincipal();
EscribirTextoCentrado("El diablo loko");
EscribirTextoSubrayado("El diablaso", '-');
Console.WriteLine(CalcularPotencia(3,3));
Console.WriteLine($"{n} es primo: {EsPrimo(n)}");

//Funciones
static void MostarMenuPrincipal()
{
    Console.WriteLine("MENÚ PRINCIPAL!!");
    Console.WriteLine();
    Console.WriteLine("1. Añadir datos");
    Console.WriteLine("2. Buscar");
    Console.WriteLine("3. ...");
    Console.WriteLine("0. Salir");
}

static void EscribirTextoCentrado(string texto)
{
    Console.Write( new string(' ',40-texto.Length/2));
    Console.WriteLine( texto );
}

static void EscribirTextoSubrayado( string texto, char c)
{
    Console.WriteLine( texto );

    for (int i = 0; i < texto.Length; i++)
    {
        Console.Write(c);
    }
    Console.WriteLine();
}

static int ElevarAlCuadrado(int n)
{
    return n * n;
}

static int CalcularPotencia(int baseNum, int exponente)
{
    int resultado = 1;

    for (int i = 0; i < exponente; i++)
    {
        resultado *= baseNum;
    }

    return resultado;
}

static bool EsPrimo(int n)
{
    bool esPrimo = false;
    int cantDivisores = 0;

    for (int i = 0; i < n; i++)
    {
        if (n % 2 == 0)
            cantDivisores++;
    }

    if (cantDivisores >= 2)
        esPrimo = true;

    return esPrimo;
}

//Funciones por paso de referencia 'ref/out'
static void MaxMinArray(int[] numeros, out int min, out int max)
{
    min = max = numeros[0];
    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] < min)
        {
            min = numeros[i];
        }
        if (numeros[i] > max)
        {
            max = numeros[i];
        }
    }
}

//Funciones recursivas
static int MultiplicacionRecursiva(int x, int y)
{
    if (y == 0) //caso base
        return 0;
    else if (y == 1) //segundo caso base
        return x;
    else //caso recursivo
        return x + MultiplicacionRecursiva(x, y - 1);
}

static bool EsPalindromo(string t)
{

    if (t.Length <= 1) //caso base
        return true;
    if (t[0] != t[t.Length - 1]) //los extremos no coinciden
        return false;

    return EsPalindromo(t.Substring(1, t.Length - 2));
}


static int SucesionFibonacci(int n)
{
    if (n <= 1)
        return 1;
    else
        return SucesionFibonacci(n - 2) + SucesionFibonacci(n - 1);
}




