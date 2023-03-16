// Задача 3_0.
//Напишите программу, которая нра вход принимает координаты
//точки (X и Y), причем X!= 0 и Y!= 0, и выдает номер четверти
// плоскости, в которой находится  эта точка

void Quarters(int X, int Y)
{
      if (X == 0 || Y == 0)
            Console.WriteLine("Четверть не определена");
      else if (X > 0 && Y > 0) Console.WriteLine("1-ая четверть");
      else if (X < 0 && Y > 0) Console.WriteLine("2-ая четверть");
      else if (X < 0 && Y < 0) Console.WriteLine("3-ая четверть");
      else if (X > 0 && Y < 0) Console.WriteLine("4-ая четверть");
}
int num_1 = int.Parse(Console.ReadLine()!);
int num_2 = int.Parse(Console.ReadLine()!);
Quarters(num_1, num_2);
