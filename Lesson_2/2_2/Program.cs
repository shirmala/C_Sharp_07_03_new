﻿
//Задача 2_2. Напишите программу, которая будет принимать на 
// вход два числа  и выводить, является ли второе число кратно первому.  
// Если число 2 не кратно числу 1 , то программа выодит остаток от деления


int KratNum(int a1, int a2)
{
      if (a2%a1==0) Console.WriteLine($"число {a2} кратно {a1}");
      else Console.WriteLine($"число {a2} не кратно {a1}");
      return (a2%a1);                    
}
int Ostatok=KratNum(5,17);// Вводим числа в терминале
Console.WriteLine (Ostatok);
