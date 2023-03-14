//Задача DZ_1 
//Напишите программу, которая принимает на вход трёхзначное число и на выходе
// показывает вторую цифру этого числа.

//Вариант от преподавателя:

string NumSec(int num)
{
      if ((-1000 < num && num > -100) || (num < 1000 && num > 100))
            return $"{num / 10 % 10}";
      return "The numder is not three-dirit !";
}
Console.WriteLine(NumSec(int.Parse(Console.ReadLine())));

/*

//ВАриант мой:

int n=int.Parse(Console.ReadLine());
if (n<100)Console.WriteLine("NO");
else Console.WriteLine(n/10%10);
*/
