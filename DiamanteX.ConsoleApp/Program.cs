namespace DiamanteX.ConsoleApp;

class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("================================");
    Console.WriteLine("-------- Diamante de X ---------");
    Console.WriteLine("================================");
    Console.WriteLine();

    Console.Write(">> Digite um número: ");
    int numero = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();

    if (!isImpar(numero))
    {
      Console.WriteLine("Você digitou um número par. Tente novamente! ");
      return;
    }

    int qtdDeLinhasSuperior = (numero - 1) / 2;
    int qtdDeEspaco = (numero - 1) / 2;
    int qtdX = 1;

    for (int linha = 1; linha <= qtdDeLinhasSuperior; linha++)
    {
      for (int i = 0; i <= qtdDeEspaco; i++)
        Console.Write(" ");

      for (int j = 1; j <= qtdX; j++)
        Console.Write("X");

      Console.WriteLine();

      qtdDeEspaco -= 1;
      qtdX += 2;
    }


    for (int linha = 0; linha <= qtdDeLinhasSuperior; linha++)
    {

      for (int i = 0; i <= qtdDeEspaco; i++)
        Console.Write(" ");

      for (int j = 1; j <= qtdX; j++)
        Console.Write("X");

      Console.WriteLine();

      qtdDeEspaco += 1;
      qtdX -= 2;

    }

    Console.ReadLine();

  }
  static bool isImpar(int num)
  {
    if (num % 2 == 0)
      return false;

    return true;
  }
}