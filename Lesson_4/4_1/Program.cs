//Задача 4_1.Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.

//Мой варианты решения:
int  CountDig(int N)
{
N=Math.Abs(N);// Чтобы можно было вводить отриц числа
int i=0;
if (N==0) i=1;// Для рассмотрения спецслучая, когда N=0
while (N>0)
{
N=N/10;
i++;
}
return i;
}
int N=int.Parse( Console.ReadLine()!);
Console.WriteLine(CountDig(N));
/*
int val = int.Parse(Console.ReadLine()!);
CountDig(val);
Console.WriteLine(CountDig(val));
*/





















/*
num = GetUserNumber();
int цифры = CountNumbers(num);
Console.WriteLine(цифры);

int GetUserNumber()
{
 int число = 0;
 while(число == 0)
 {
 Console.Write("Пожалуйста, введите номер: ");
 число = int. Parse(Console.ReadLine()!);
 }
 номер возврата;
}

int CountNumbers(int n)
{
 количество int = 0;
 в то время как (n > 0)
 {
 n = n/10; 
 счёт++;
 }
 счетчик возвратов;
}*/