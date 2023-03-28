//Задача 6_2
// Напишите программу, которая будет
// преобразовывать десятичное число в двоичное.

int GetUserNumber(string name)
{
      int number = 0;
      Console.Write($"Please enter {name}: ");
      number = int.Parse(Console.ReadLine()!);
      return number;
}
string MakeBinary(int number)
{
      string binary = "";
      while (number > 0)
      {
            binary = number % 2 + binary;
            number /= 2;
      }
      return binary;
}
int num = GetUserNumber("number");
Console.WriteLine(MakeBinary(num));

