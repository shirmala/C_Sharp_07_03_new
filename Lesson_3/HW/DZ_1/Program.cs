//Задача DZ_1
//Напишите программу, которая принимает на вход пятизначное число 
//и проверяет является ли оно палиндромом

//Вариант 1:
void Palindr(int a)
{
int t1=a%10;
int t2=((a-t1)/10)%10;
int t3=(a-10*t2-t1)/100%10;
int b=(t1*10000+t2*1000+t3*100+t2*10+t1);
{
   if (a==b) 
   Console.WriteLine ("Введенное число палиндром");
   else
   Console.WriteLine ("Введенное число не палиндром");
}
}
Console.WriteLine("Введите пятизнпчное число");
int k = int.Parse(Console.ReadLine()!);
Palindr(k);


// Вариант 2 от преподавателя:
void Pali(int num)
{
int num_1_2 = num/1000;
int num_5 = num%10;
int num_4 = num/10%10;

if (num_1_2 ==num_5* 10+ num_4)
Console.WriteLine ($"Yes,{num} is a palindrom");
else 
Console.WriteLine ($"No, {num} is not a palindrome");
}

Console.WriteLine("Enter a five-digit number");
int val = int.Parse(Console.ReadLine()!);
Pali (val);