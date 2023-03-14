// Задача DZ_2. 
//Напишите программу, которая выводит случайное трехзначное число
//и удаляет вторую цифрув этого числа

// Вариант от преподавател:

void NumRendom()
{
      int num = new Random().Next(100, 1000);
      Console.WriteLine($"{num}   {num / 100}{num % 10}");
}
NumRendom();


//Вариант от преподавателя:

string SecondNum(int num)
{
      if ((-1000 < num && num < 99) || (num < 1000 && num > 99))
            return $"{num}      {num / 100 * 10 + num % 10}";
      return "Tne number is not three-digit!";
}
int val = int.Parse(Console.ReadLine()!);
string result = SecondNum(val);
Console.WriteLine(result);

// Вариант мой^

int a = int.Parse(Console.ReadLine());
int b = a / 100 * 10 + a % 10;
Console.WriteLine(b);


