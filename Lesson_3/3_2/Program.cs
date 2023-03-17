// Задача 3_2.
//Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.

//Решение на семинаре с использованием функции:
Console.Write("x1=   ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("y1=   ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("x2=   ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("y2=   ");
int y2 = int.Parse(Console.ReadLine()!);

double Length(int x1, int y1, int x2, int y2)
{
      return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), 1);
}
Console.Write(Length(x1, y1, x2, y2));
/*
//Мое решение бес использования функции:
double x11,y11,x12,y12,dist;
x11=int.Parse(Console.ReadLine()!);
y11=int.Parse(Console.ReadLine()!);
x12=int.Parse(Console.ReadLine()!);
y12=int.Parse(Console.ReadLine()!);
dist = Math.Round(Math.Sqrt(Math.Pow(x12 - x11, 2) + Math.Pow(y12 - y11, 2)), 1);
Console.WriteLine(dist);
*/