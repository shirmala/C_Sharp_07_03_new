//Задача DZ_4.
//Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

//Вариант от преподавателя. Красивое решение:
void Weekend(int num)
{
      string text = "not quit a week";// сваеобразный флаг!
      if (num == 7 || num == 6) text = "Weekend";
      else if (num < 6 && num > 0) text = "Workday";
      Console.WriteLine($"{num}         {text}");
}
int val = int.Parse(Console.ReadLine()!);
Weekend(val);
