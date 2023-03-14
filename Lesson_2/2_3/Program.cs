//Задача 2_3. Напишите программу , которая на вход принимает число
// и проверяет,кратно ли оно одновременно 7 и 23
//Первый вариант
int KratNum (int a)
{
if ( a%7==0||a%23 == 0)
 Console.WriteLine ($"Число {a} кратно 7 и 23");
 else Console.WriteLine ($"Число {a} некратно 7 и 23");
return a;
}
 int ostatok = KratNum(161);// Вводим число здесьб

// Второй вариант
 
 int b = int.Parse(Console.ReadLine()!);// Вводим число в терминале
 if ( b%7== 0 || b%23 == 0)
Console.WriteLine ($"Число {b} кратно 7 и 23");
else Console.WriteLine ($"Число {b} некратно 7 и 23");
