// Задача DZ_1.Напишите программу, которая на вход принимает два
// числа (А и В) и возводит число А в натуральную степенрь В^

//Вариант от преподавателя:
double PowNum(int a, int b)
{
      double n_pow = 1;
      int b_abs = Math.Abs(b);

      for (int i = 1; i <= b_abs; i++)
      {
            if (b > 0)
                  n_pow *= a;
            else n_pow /= a;
      }
      return n_pow;
}
Console.WriteLine("Enter a number:  ");
int num_1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter degree of number:  ");
int num_2 = int.Parse(Console.ReadLine()!);

Console.WriteLine(PowNum(num_1, num_2));

//Вариант_1: со счетчиком для  целого положительного h:
int StepNum(int a, int b)
{
      int res = 1;
      for (int i = 1; i <= b; i++) res *= a;
      return res;
}
Console.WriteLine(StepNum(2, 2));
Console.WriteLine(StepNum(2, 0));
Console.WriteLine();

//Вариант_2 с целым положительным b и рекурсией в одну сточку:
int StepeNum(int a, int b)
{
      return b == 0 ? 1 : StepeNum(a, b - 1) * a;
}
Console.WriteLine(StepeNum(2, 2));
Console.WriteLine(StepeNum(2, 0));
Console.WriteLine();

//Вариант_3 с положительной и отрицательной степенью: 
double StepenjNum(int A, int B)
{
      if (B > 0) return StepenjNum(A, B - 1) * A;
      else if (B < 0) return StepenjNum(B, B + 1) * 1 / A;
      else return 1;
}
Console.WriteLine(StepenjNum(2, -2));
Console.WriteLine(StepenjNum(2, 2));
Console.WriteLine(StepenjNum(2, 0));
Console.WriteLine();


