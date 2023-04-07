//Задача 9_0.
// Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в 
// промежутке от 1 до N при помощи рекурсии:.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

//Вариант_1:input data
Console.Write("Enter the number: ");
int n = int.Parse(Console.ReadLine()!);
//functions
string PrintNums(int begin, int n)
{
      if (begin == n)
      {
            return begin.ToString();
      }
      return (begin + "  " + PrintNums(begin + 1, n));
}
//result
Console.Write("Result: ");
Console.WriteLine(PrintNums(1, n));
/*
https://www.youtube.com/watch?v=F4HNO4rCQ2c&ab_channel=KhanAcademyRussian
https://youtu.be/rh1mP02NFoM?t=229
https://skillbox.ru/media/code/rekursiya-vokrug-nas/
*/

//Вариант_2:
Console.Write("Enter the first number: ");
int N = int.Parse(Console.ReadLine()!);

//functions
void PrintNumsa(int n)
{
      if (n == 0) return;// в void используется return для
                         // завершения работы
      PrintNumsa(n - 1);
      Console.Write($"{n} ");
}
Console.Write("Result: ");
PrintNumsa(N);


