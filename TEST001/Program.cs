// string test = "12345\r6789";
// Console.WriteLine(test);
 

// string test = "12345\n6789";
// Console.WriteLine(test);

// string test = "\r12345\n6789";
// Console.WriteLine(test);

// Console.WriteLine();
// Console.WriteLine($"NewLine: {Environment.NewLine}  first line{Environment.NewLine}  second line"); // {Environment.NewLine} - Возвращает строку, обозначающую в данной среде начало новой строки.


// void MAtrixMultipl(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)  // метод перемножения матриц
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i, k] * secomdMartrix[k, j];
//       }
//       resultMatrix[i, j] = sum;
//     }
//   }
// }

// void MatrixMultipl(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix) // метод перемножения матриц
// {
//   int rowsInA = firstMartrix.GetLength(0);                
//   int columnsInA = firstMartrix.GetLength(1); 
//   int columnsInB = secondMartrix.GetLength(1); 
//   for (int i = 0; i < rowsInA; i++)
//   {
//     for (int j = 0; j < columnsInB; j++)
//     {
//       int multiplication = 0;                                        
//       for (int k = 0; k < columnsInA; k++)
//       {
//         multiplication += firstMartrix[i, k] * secondMartrix[k, j];
//       }
//       resultMatrix[i, j] = multiplication;
//     }
//   }
// }
