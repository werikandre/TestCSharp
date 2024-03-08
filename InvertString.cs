using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite uma string: ");
        string texto = Console.ReadLine();

        string textoInvertido = InverterString(texto);
        Console.WriteLine("String invertida: " + textoInvertido);
    }

    static string InverterString(string texto)
    {
        char[] caracteres = texto.ToCharArray();
        Array.Reverse(caracteres);
        return new string(caracteres);
    }
}
