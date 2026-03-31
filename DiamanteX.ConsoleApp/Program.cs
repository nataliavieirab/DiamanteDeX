namespace DiamanteX.ConsoleApp;

class Program
{
  static void Main(string[] args)
  {
    ShowHeader();

    int number = ReadNumber();

    if (!IsOdd(number))
    {
      Console.WriteLine("Você digitou um número par. Tente novamente! ");
      return;
    }

    int upperLines = (number - 1) / 2;

    PrintUpperPart(upperLines);
    PrintLowerPart(upperLines);

    Console.ReadLine();
  }

  static void ShowHeader()
  {
    Console.WriteLine("================================");
    Console.WriteLine("-------- Diamante de X ---------");
    Console.WriteLine("================================");
    Console.WriteLine();
  }

  static int ReadNumber()
  {
    Console.Write(">> Digite um número: ");
    int number = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();

    return number;
  }

  static void PrintUpperPart(int upperLines)
  {
    int spaces = upperLines;
    int xCount = 1;

    for (int line = 1; line <= upperLines; line++)
    {
      PrintLine(spaces, xCount);

      spaces--;
      xCount += 2;
    }
  }

  static void PrintLowerPart(int upperLines)
  {
    int spaces = 0;
    int xCount = upperLines * 2 + 1;

    for (int line = 0; line <= upperLines; line++)
    {
      PrintLine(spaces, xCount);

      spaces++;
      xCount -= 2;
    }
  }

  static void PrintLine(int spaces, int xCount)
  {
    for (int i = 0; i <= spaces; i++)
      Console.Write(" ");

    for (int j = 1; j <= xCount; j++)
      Console.Write("X");

    Console.WriteLine();
  }

  static bool IsOdd(int number)
  {
    return number % 2 != 0;
  }
}