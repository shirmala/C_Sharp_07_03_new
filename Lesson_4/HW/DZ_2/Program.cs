// Задача DZ_2.
//Напишите программу, которая принимет на вход число и
//ивыдает сумму цифр в числе


// Вариант_1: рекурсия:
/*
Console.WriteLine("Введите число ");
Console.WriteLine();

int SumDigits(int a)
{
      if (a < 10) return a;
      else return SumDigits(a / 10) + a % 10;
}
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine(SumDigits(b));
*/
Console.WriteLine("Введите число");
int SumDig(int b)
{
 int sum=0;
 while (b>0)
{
  int t=b/10;
sum = t+b%10;
}
return (sum);
}

int val = int.Parse(Console.ReadLine()!);
SumDig(val);


