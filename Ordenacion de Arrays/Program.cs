Console.OutputEncoding = System.Text.Encoding.UTF8;

//Algoritmo de intercambio directo
string[] cambioDirecto = new string[8];
cambioDirecto[0] = "Sounding The Seventh Trumpet";
cambioDirecto[1] = "Waking The Fallen";
cambioDirecto[2] = "City Of Evil";
cambioDirecto[3] = "Avenged Sevenfold";
cambioDirecto[4] = "Nightmare";
cambioDirecto[5] = "Hail To The King";
cambioDirecto[6] = "The Stage";
cambioDirecto[7] = "Life Is But A Dream";

for (int i = 0; i < cambioDirecto.Length - 1; i++)
{
    for (int j = i + 1; j < cambioDirecto.Length; j++)
    {
        if (cambioDirecto[i].CompareTo(cambioDirecto[j]) > 0)
        {
            string aux = cambioDirecto[j];
            cambioDirecto[j] = cambioDirecto[i];
            cambioDirecto[i] = aux;
        }
    }
}

Console.WriteLine("ORDENAMIENTO MEDIANTE INTERCAMBIO DIRECTO:");
foreach (var item in cambioDirecto)
{
    Console.WriteLine($"• {item}");
}

//Algoritmo Bubule Sort
int[] burbuja = new int[10];
Console.WriteLine($"Ingrese {burbuja.Length} números:");

for (int i = 0; i < burbuja.Length; i++)
{
    burbuja[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < burbuja.Length - 1; i++)
{
    for (int j = 0; j < burbuja.Length - i - 1; j++)
    {
        if (burbuja[j]  > burbuja[j+1])
        {
            int aux = burbuja[j];
            burbuja[j] = burbuja[j+1];
            burbuja[j + 1] = aux;
        }
    }
}

Console.WriteLine("ORDENAMIENTO MEDIANTE METODO BURBUJA :");
foreach (var item in burbuja)
{
    Console.WriteLine("• " + item);
}

Console.WriteLine();
