using System;

class Program 
{
  public static void Main (string[] args) 
  {
    int t1 = 0;
    int t2 = 1;
    int t3 = 0;
    int n;

    Console.WriteLine("==========Sequência de Fibonacci==========");
    Console.WriteLine("Digite o numero que deseja saber se pertence a sequêcia: ");
    n = int.Parse(Console.ReadLine());

    Console.Clear();
    
      Console.WriteLine("\n==========================================================");
    
    Console.Write($" {t1} -> {t2} ");

      while(t3 < n)
      {
        t3 = t1 + t2;
        Console.Write($"-> {t3} ");
        t1 = t2;
        t2 = t3;
      }
    
      Console.WriteLine("\n==========================================================");
    
    if(t3 == n)
      {
        Console.WriteLine("Numero pertence a sequencia de fibonacci");
      }
      else
      {
        Console.WriteLine("Nmero não está na sequecia de fibonacci");
      }
    
  }
}
