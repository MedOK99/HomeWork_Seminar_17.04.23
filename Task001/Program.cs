// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();
int m = ReadNumberFromConsole("Введите требуемое количество строк:");
int n = ReadNumberFromConsole("Введите требуемое количество столбцов:");
int[,] array = new int[m, n]; // объявляю новый массив с пользовательскими данными
FillArrayRandomNumbers(array);
Console.WriteLine("Пользовательский массив из псевдослучайных чисел:\n");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Получаем готовый, отсортированный массив:\n");
SortArray(array);
PrintArray(array);

int ReadNumberFromConsole(string message = "")  // метод для чтения из консоли введённого значения
{
  if (message != "")
    Console.WriteLine(message);
  string input = Console.ReadLine();
  return int.Parse(input);
}

void FillArrayRandomNumbers(int[,] array)   // метод для наполнения двумерного массива случайными числами
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1, 10);
    }
  }
}

void SortArray(int[,] array)  // метод  для сортировки массива
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
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
    Console.Write("]");
    Console.WriteLine();
  }
}




