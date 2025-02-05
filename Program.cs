using System;

namespace Calculator {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Selecione o tipo de operação: ");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisao");
      Console.WriteLine("4 - Multiplicacao");

      int opcao = int.Parse(Console.ReadLine());
      if (opcao == 1) {
        Soma();
      } else if (opcao == 2) {
        Subtracao();
      } else if (opcao == 3) {
        Divisao();
      } else if (opcao == 4) {
        Multiplicacao();
      }else {
        Console.WriteLine("Opção inválida");
      }
    }
    static void Soma(){
       Console.Clear();
      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      float resultado = v1 + v2;
      Console.WriteLine($"A soma dos numeros é: {resultado}");
    }
    static void Subtracao() {
      Console.Clear();
      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      float resultado = v1 - v2;
      Console.WriteLine($"A subtração dos numeros é: {resultado}");
    }
    static void Divisao(){
      Console.Clear();
      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      float resultado = v1 / v2;
      Console.WriteLine();
      Console.WriteLine("O resultado da divisão é: " +resultado);
      Console.ReadKey();
    }
    static void Multiplicacao() { 
      Console.Clear();
      Console.WriteLine("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());
      
      float resultado = v1 * v2;
      Console.WriteLine("");
      Console.WriteLine("O resultado da multiplicação é: " + resultado);
      Console.ReadKey();
    }
  }
}