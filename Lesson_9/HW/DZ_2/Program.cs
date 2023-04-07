//Задача DZ_2.
/* Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N с помощью рекурсии.

M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/
// Вариант с рекурсией
int Sum(int m, int n)
{
      if (n == m) return m;
      else return n + Sum(m, n - 1);
}
Console.WriteLine(Sum(10, 13));

//Вариант без рекурсии:
int SumA(int m, int n)
{
      int rez = 0;
      for (int i = m; i <= n; i++) rez += i;
      return rez;
}
Console.WriteLine(SumA(2, 4));

