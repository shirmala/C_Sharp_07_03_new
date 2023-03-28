//Задача DZ_2.
//Напишите программу, которая найдёт точку пересечения 
//двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//https://studok.net/obrazovanie-i-kommunikacii/vopros-kak-vychislit-tochku-peresechenija-dvuh-prjamyh/

//Вариант_1:
const int COEFFICIENT = 0;
const int CONSTANT = 1;
const int X_COORD = 0;
const int Y_COORD = 1;
const int LINE1 = 1;
const int LINE2 = 2;

double[] lineData1 = InputLineData(LINE1);
double[] lineData2 = InputLineData(LINE2);

if (ValidateLines(lineData1, lineData2))
{
      double[] coord = FindCoords(lineData1, lineData2);
      Console.Write($"Точка пересечений уравнений y ={lineData1[COEFFICIENT]}*X+{lineData1[CONSTANT]} И Y = {lineData2[COEFFICIENT]}*x+{lineData2[CONSTANT]}  ");
      Console.WriteLine($"имеет координаты ({coord[X_COORD]}, {coord[Y_COORD]})");
}
//Ввод числа
double Prompt(string message)
{
      System.Console.Write(message);// Вывести сообщение
      string value = Console.ReadLine();//Считывает с консоли строку
      double result = Convert.ToDouble(value); // Прпеобразует строку в целое число
      return result; // Взвращает результат
}
// Ввод дпнных по прямой
double[] InputLineData(int numberOfLine)
{
      double[] lineData = new double[2];
      lineData[COEFFICIENT] = Prompt($"Введите коэффициент для {numberOfLine} прямой > ");
      lineData[CONSTANT] = Prompt($"Введите константу для {numberOfLine} прямой >");
      return lineData;
}
// Поиск координат
double[] FindCoords(double[] lineData1, double[] lineData2)
{
      double[] coord = new double[2];
      coord[X_COORD] = (lineData1[CONSTANT] - (lineData2[CONSTANT]) / lineData2[COEFFICIENT] - lineData1[COEFFICIENT]);
      coord[Y_COORD] = (lineData1[CONSTANT] * coord[X_COORD] + lineData1[CONSTANT]);
      return coord;
}
bool ValidateLines(double[] lineData1, double[] lineData2)
{

      if (lineData1[COEFFICIENT] == lineData2[COEFFICIENT])
      {
            if (lineData1[CONSTANT] == lineData1[CONSTANT])
            {
                  Console.WriteLine($"Прямые совпадают");
                  return false;
            }
            else
            {
                  Console.WriteLine("Прямые параллельны");
                  return false;
            }
      }
      return true;
}

//Вариант_2:
void Intersection(double k1, double b1, double k2, double b2)
{
      double k_sub = k1 - k2;
      if (k_sub != 0)
      {
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;
            Console.WriteLine($"Intersection point: ({x}; {y})");
      }
      else if (k1 == k2 && b1 == b2)
            Console.WriteLine("There are an infinite number of intersection points.");
      else
            Console.WriteLine("There is no intersection point");
}
//  1, 4, 2, 3
// -1, -2, -1, 2
double k_1 = double.Parse(Console.ReadLine()!);
double b_1 = double.Parse(Console.ReadLine()!);
double k_2 = double.Parse(Console.ReadLine()!);
double b_2 = double.Parse(Console.ReadLine()!);
Intersection(k_1, b_1, k_2, b_2);



