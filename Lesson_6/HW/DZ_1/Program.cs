//Задача DZ_1.
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

// Вариант_1:
int Prompt(string message)//Считать число с консоли
{
      System.Console.Write(message);//Вывести сообщение
      string value = Console.ReadLine()!;//Считывает с консоли строку
      int result = Convert.ToInt32(value);// преобразует строку в целое число
      return result;// Возвращает результат
}
int[] InputArray(int length)
{
      int[] array = new int[length];
      for (int i = 0; i < array.Length; i++)
      {
            array[i] = Prompt($"Введите {i + 1} - й элемент  ");
      }
      return array;
}
void PrintArray(int[] array)
{
      for (int i = 0; i < array.Length; i++)
      {
            Console.WriteLine($"a[{i}] = {array[i]}");
      }
}
int CountPositiveNumbers(int[] array)
{
      int count = 0;
      for (int i = 0; i < array.Length; i++)
      {
            if (array[i] > 0)
                  count++;
      }
      return count;
}
int lenght = Prompt("Введите количество элементов>   ");
int[] array;
array = InputArray(lenght);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 равняется:  {CountPositiveNumbers(array)}");

//Вариант_2: 
int CountNum()
{
      int count = 0;
      string word;

      while (true)
      {
            Console.Write("Output any number: ");
            word = Console.ReadLine()!;
            if (word == "") return count;
            else if (int.Parse(word) > 0) count += 1;
      }
}
int count = CountNum();
Console.WriteLine($"Numbers greater than zero: {count}");

//Вариант_3:
int Check(int num)
{
      int count = 0;

      for (int i = 1; i <= num; i++)
      {
            Console.Write($"Число {i}: ");
            int a = int.Parse(Console.ReadLine()!);
            if (a > 0) count++;
      }
      return count;
}
Console.Write("Сколько чисел хотели бы ввести?: ");
int a = int.Parse(Console.ReadLine()!);
int result = Check(a);
Console.WriteLine($"Количество чисел больше 0: {result}");


