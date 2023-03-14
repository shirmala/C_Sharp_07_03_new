//Задача 2_0. Функция

int TakeNum (int num)
{
Console.WriteLine (num);
return num%10;
}

int th_num = new Random().Next(100,1000);
              // это как формула генератора 
              // случ чисел
TakeNum(th_num);// th_num отличается от num!!

int result = TakeNum(th_num);
Console.WriteLine (result);

