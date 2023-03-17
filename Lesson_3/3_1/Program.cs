//Задача 3_1.
//Напишите программу, которая принимает на вход координаты
//точки (X и Y), причем X!=0,Y!=0, и выдает номер четверти ,
//в  которой находится эта точка


void Quarters (int x,int y)
{
if (x==0 || y==0) Console.WriteLine ("Четверть не определена");
else if(x>0 && y>0) Console.WriteLine ("1_ая четверть");
else if(x<0 && y>0) Console.WriteLine ("2_ая четверть");
else if(x<0 && y<0) Console.WriteLine ("3_ая четверть");
else if(x>0 && y<0) Console.WriteLine ("4_ая четверть");
}
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);
Quarters(a,b);