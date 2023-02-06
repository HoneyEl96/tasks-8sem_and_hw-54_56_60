// Урок 8. Двумерные массивы. Продолжение

// Задача 53: Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

// void FillArrayWithRandom(int[,] matrix)
// {
// for(int i = 0; i < matrix.GetLength(0); i++) //GetLength(0) - отвечает за строки
// {
// for(int j = 0; j < matrix.GetLength(1); j++) //GetLength(1) - отвечает за столбцы
// {
// matrix[i,j] = new Random().Next(0, 10);
// }
// }
// }

// void PrintArrayWithRandom(int[,] matrix)
// {
// for(int i = 0; i < matrix.GetLength(0); i++)
// {
// for(int j = 0; j < matrix.GetLength(1); j++)
// {
// Console.Write(matrix[i,j] + "\t");
// }
// Console.WriteLine();
// }
// Console.WriteLine();
// }

// Console.WriteLine("Введите число m:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n:");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[m,n];
// FillArrayWithRandom(matrix);
// PrintArrayWithRandom(matrix);

// int temp = 0;

// for(int i = 0; i < matrix.GetLength(1); i++)
// {
// temp = matrix[0,i]; // [0,i] - записали нулевую строку в темп
// matrix[0, i] = matrix[matrix.GetLength(0) - 1, i]; // перезаписали нелувую строку в последнюю 
// // 5 на 4 матрица, 5-1 = 4 -индекс последней строки
// matrix[matrix.GetLength(0) - 1, i] = temp; // перезаписали последнюю строку в темп (поменяли первую и последнюю строку местами)
// }
// Console.WriteLine();
// PrintArrayWithRandom(matrix);

// // Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.

// void FillArrayWithRandom(int[,] matrix)
// {
// for(int i = 0; i < matrix.GetLength(0); i++)
// {
// for(int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i,j] = new Random().Next(0, 10);
// }
// }
// }

// void PrintArrayWithRandom(int[,] matrix)
// {
// for(int i = 0; i < matrix.GetLength(0); i++)
// {
// for(int j = 0; j < matrix.GetLength(1); j++)
// {
// Console.Write(matrix[i,j] + "\t");
// }
// Console.WriteLine();
// }
// Console.WriteLine();
// }

// Console.WriteLine("Введите число m:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n:");
// int n = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int[m,n];
// FillArrayWithRandom(matrix);
// PrintArrayWithRandom(matrix);
// int[,] ResultMatrix = new int[n,m];

// for(int i = 0; i < ResultMatrix.GetLength(0); i++)
// {
// for(int j = 0; j < ResultMatrix.GetLength(1); j++)
// {
// ResultMatrix[i,j] = matrix[j, i];
// }
// }
// Console.WriteLine();
// PrintArrayWithRandom(ResultMatrix);

// // Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// // 1, 2, 3
// // 4, 6, 1
// // 2, 1, 6
// // 1 встречается 3 раза
// // 2 встречается 2 раз
// // 3 встречается 1 раз
// // 4 встречается 1 раз
// // 6 встречается 2 раза

// void FillArrayWithRandom(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i, j] = new Random().Next(0, 10);
// }

// }
// }

// void PrintArrayWithRandom(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// Console.Write(matrix[i, j] + "\t");
// }
// Console.WriteLine();
// }
// Console.WriteLine();
// }

// Console.WriteLine("Введите число m:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[m, n];
// FillArrayWithRandom(matrix);
// PrintArrayWithRandom(matrix);

// int count = 0;
// for (int k = 0; k < 10; k++)
// {
// count = 0;
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// if(matrix[i,j] == k)
// {
// count++;
// }
// }
// }
// if(count > 0)
// {
// Console.WriteLine($"Кол-во повторений для {k} = {count}");
// }
// }

// // Вариант2

// void FillArrayWithRandom(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// matrix[i, j] = new Random().Next(0, 10);
// }
// }
// }

// void PrintArrayWithRandom(int[,] matrix)
// {
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// Console.Write(matrix[i, j] + "\t");
// }
// Console.WriteLine();
// }
// Console.WriteLine();
// }

// Console.WriteLine("Введите число m:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число n:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[m, n];
// FillArrayWithRandom(matrix);
// PrintArrayWithRandom(matrix);

// int[] CountArray = new int[10];
// for (int i = 0; i < matrix.GetLength(0); i++)
// {
// for (int j = 0; j < matrix.GetLength(1); j++)
// {
// int numbers = matrix[i,j];
// CountArray[numbers]= CountArray[numbers] + 1;
// }
// }
// for(int i = 0; i < CountArray.Length; i++)
// {
// if(CountArray[i]!=0)
// {
// Console.WriteLine($"Кол-во повторений для {i} = {CountArray[i]}");
// }
// }

// Домашка:

// Обязательные задачи:

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой 
// строки двумерного массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillMatrixRandom(int[,] matrix, int rows, int columns) 
{
for(int i = 0; i < rows; i++)
{
for(int j = 0; j < columns; j++)
{
matrix[i,j] = new Random().Next(0,10);
Console.Write(matrix[i,j] + "\t"); 
}
Console.WriteLine();
}
}

// // метод пузырьков, через одномерный массив
void SortMaxToMinWithBubble(int[] stroki) // метод пузырьков
{
for (int i = 0; i < stroki.Length; i++)
for (int j = 0; j < stroki.Length - i - 1; j++)
{
if (stroki[j] < stroki[j + 1])
{
int temp = stroki[j];
stroki[j] = stroki[j + 1];
stroki[j + 1] = temp;    
}
}
Console.WriteLine(string.Join(", ", stroki));
}

// int[,] SortMaxToMinWithBubble(int [,] matrix) 
// { 
// for (int i = 0; i <matrix.GetLength(0); i++) 
// { 
//     for (int j = 0; j <matrix.GetLength(1)-1; j++) 
//     { 
//         for (int k = 1;k<matrix.GetLength(1);k++) 
//         { 
//             if (matrix[i,k] < matrix[i,k]) 
//             { 
//             int tmp = matrix [i,k]; 
//             matrix [i,k] = matrix [i,k]; 
//             matrix [i,k] = tmp;
//             }
//         }
//     }
// }
// return(matrix);
// }

Console.WriteLine("Введите число строк:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов:");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int[rows,columns];
Console.WriteLine("Исходный сгенерированный массив:");
FillMatrixRandom(matrix, rows, columns);
// первая часть программы, с сгенерированным выводом массива

// для первого варианта
Console.WriteLine("Сортировка по строкам: ");
int[] row = new int[columns];
for (int i = 0; i < rows; i++)
{
for (int j = 0; j < columns; j++)
row[j] = matrix[i, j];
SortMaxToMinWithBubble(row);
}

// // для второго варианта
// Console.WriteLine("Сортировка по строкам: ");
// for (int i = 0; i < rows; i++)
// {
// for (int j = 0; j < columns; j++)
// {
//     SortMaxToMinWithBubble(matrix);
//     Console.Write(matrix[i,j] + "\t");
// }
// }

// ??? я не понял как вывеси, вроде пузырьки должны работать во втором варианте, а как вывод сделать?? подскажите?

// Задача 56: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: одна строка

// void FillMatrixRandom(int[,] matrix, int rows, int columns)
// {
// Console.WriteLine("Диапазон рандомных значений от 1 до..:");
// // Random().Next(range) вводится с клавиатуры, начиная с 1
// int range = Convert.ToInt32(Console.ReadLine());
// for (int i = 0; i < rows; i++)
// {
// for (int j = 0; j < columns; j++)
// {
// matrix[i, j] = new Random().Next(range + 1);
// Console.Write(matrix[i, j] + "\t");
// }
// Console.WriteLine();
// }
// }

// void SumRowAndIndex(int[,] matrix)
// {
//     int ind = 0;
//     int minSum = 0;
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     // пройти i-ым счетчиком по столбцам для минсуммы
//     {
//         minSum += matrix[0, i]; // сказать, что сумма 0 строки, это теперь минимальная сумма
//     }
//     for (int i = 1; i < matrix.GetLength(0); i++)
//     // назначить новый i-ый счетчик и начать его с первого индекса строки
//     {
//         int sum = 0;
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         // запустив счетчик в счетчике проходим по столбцам 
//         {
//             sum += matrix[i, j];
//         }
//         if (minSum > sum) // условие, где если полученная выше minsum больше sum, переназначить
//         {
//             minSum = sum;
//             ind = i; // напечатать номер строки
//         }
//     }
//     Console.WriteLine("Минимальная сумма: " + minSum + $", это {ind+1} строка");
// }

// Console.WriteLine("Введите число строк:");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число столбцов:");
// int columns = Convert.ToInt32(Console.ReadLine());
// int[,] matrix = new int[rows, columns];
// FillMatrixRandom(matrix, rows, columns);
// SumRowAndIndex(matrix);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Дополнительные задачи(не обязательные):

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07