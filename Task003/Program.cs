// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
int m = ReadNumberFromConsole("Введите требуемое количество строк первой матрицы:");
int n = ReadNumberFromConsole("Введите требуемое количество столбцов первой матрицы (являющееся количеством строк второй матрицы):");
int p = ReadNumberFromConsole("Введите требуемое количество столбцов второй матрицы:");

int[,] firstMartrix = new int[m, n];                    // объявляю новый массив первой матрицы
FillArrayRandomNumbers(firstMartrix);                   // заполняю первый массив псевдослучайными числами методом FillArrayRandomNumbers
Console.WriteLine($"Первая матрица:\n");
PrintArray(firstMartrix);                               // вывод на печать первой матрицы

int[,] secondMartrix = new int[n, p];                   // объявляю новый массив второй матрицы
FillArrayRandomNumbers(secondMartrix);                  // заполняю второй массив псевдослучайными числами методом FillArrayRandomNumbers
Console.WriteLine($"\nВторая матрица:\n");
PrintArray(secondMartrix);                              // вывод на печать второй матрицы

int[,] resultMatrix = new int[m, p];                     // объявляю новый массив, который будет результатом произведения двух предыдущих

MatrixMultipl(firstMartrix, secondMartrix, resultMatrix);// запускаю метод перемножения матриц
Console.WriteLine($"\nПроизведение первой и второй матриц:\n");
PrintArray(resultMatrix);                                // вывод на печать матрицы произведений

void MatrixMultipl(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix) // метод перемножения матриц
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)    // цикл пока i меньше длины строки первой матрицы
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)  // цикл пока j меньше длины столбцов первой матрицы
    {
      {
        int multipl = 0;                                 // переменная в которую складываем значения перемножения чисел матрицы
        for (int k = 0; k < firstMartrix.GetLength(1); k++) // цикл для перемножения
        {
          multipl += firstMartrix[i, k] * secondMartrix[k, j]; // переменная "k" одновременно выполняет роль столбцов (первой) и строк (второй) матрицы.
        }
        resultMatrix[i, j] = multipl;                   
      }
    }
  }
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

int ReadNumberFromConsole(string message = "")          // метод для чтения из консоли введённого значения
{
  if (message != "")
    Console.WriteLine(message);
  string input = Console.ReadLine();
  return int.Parse(input);
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

