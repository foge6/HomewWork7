// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
// double[,] Create2dArray(int rows, int cols, int min, int max)
// {
//     double[,] array = new double[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(min, max + 1)/10.0);
//         }
//     }
//     return array;
// }
// void Show2dArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// double[,] array = Create2dArray(m, n, min, max);
// Show2dArray(array);

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// int[,] Create2dArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// void FindElement(int[,] array, int row, int col)
// {
//     bool flag = false;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (i==row && j == col)
//             flag = true;
//         }
//     }
//     if (flag == true)
//     {
//         System.Console.WriteLine(array[row,col]);
//     }
//     else
//     System.Console.WriteLine("Enter numb not finded");
// }
// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.Write("Write for find row: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of col: ");
// int col = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2dArray(m, n, min, max);
// Show2dArray(array);
// FindElement(array, row, col);

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int[,] Create2dArray(int rows, int cols, int min, int max)
// {
//     int[,] array = new int[rows, cols];
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < cols; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }
// void Show2dArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// void FindAverege(int[,] array)
// {
    
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         double summ=0;
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             summ += array[j,i];
//         }
//         Console.Write(Math.Round(summ / array.GetLength(0),2) + " ");
//     }
// }
// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int[,] array = Create2dArray(m, n, min, max);
// Show2dArray(array);
// System.Console.WriteLine();
// FindAverege(array);
