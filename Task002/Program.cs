// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

Console.Clear();
int m = ReadNumberFromConsole("Введите требуемое количество строк:");
int n = ReadNumberFromConsole("Введите требуемое количество столбцов:");
int[,] array = new int[m, n];                            // объявляю новый массив
FillArrayRandomNumbers(array);                           // наполняю массив псевдослучайными числами методом FillArrayRandomNumbers
Console.WriteLine("Мы получили массив:\n");
PrintArray(array);                                       // вывожу на печать полученный массив

int minSumElements = 0;                                  // переменная "строка (номер) с минимальной суммой элементов"
int sumInLine = SumOfElements(array, 0);                 // переменная "сумма элементов в строке" присваиваю ей значение суммы элементов 0 строки массива
for (int i = 1; i < array.GetLength(0); i++)             // завожу цикл для построчного прохождения массива
{
  int tempSumLine = SumOfElements(array, i);             // переменная которой присваиваем значения для сравнения (сумма элементов первой строки (для первой итерации))
  if (sumInLine > tempSumLine)                           // оператор для выявления меньшей суммы в строке
  {
    sumInLine = tempSumLine;
    minSumElements = i;
  }
}
Console.WriteLine($"\nв котором {minSumElements + 1}я строкa является наименьшей по сумме всех её элементов, равных {sumInLine}\n");  // +1 т.к. minSumElements определяет строку по индексу (а индекс начинается с 0)

int ReadNumberFromConsole(string message = "")          // метод для чтения из консоли введённого значения
{
  if (message != "")
    Console.WriteLine(message);
  string input = Console.ReadLine();
  return int.Parse(input);
}

int SumOfElements(int[,] array, int i)                  // метод для получения суммы элементов
{
  int sumLine = array[i, 0];                             // переменная в которую записываем сумму элементов
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i, j];
  }
  return sumLine;
}

void FillArrayRandomNumbers(int[,] array)               // метод для наполнения двумерного массива псевдослучайными числами
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void PrintArray(int[,] array)   // метод для вывода массива на печать (с табуляцией)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write("[      ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write($"{array[i, j]}\t");  // табуляция
    }
    Console.Write("]\n");       // добавил "\n" чтобы убрать строку: Console.WriteLine();
  }
}

