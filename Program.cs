// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double [rows, columns];

for (int i =0; i<matrix.GetLength(0); i++)
{
    for (int j =0; j<matrix.GetLength(1); j++)
    {
        matrix[i,j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
}

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
 
 Console.WriteLine("Введите координаты");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>rows && b>columns)
 Console.WriteLine("Такого числа нет");
 else
 {
 object? num = array.GetValue(a,b);
 Console.WriteLine(num);
 }


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int rows = Convert.ToInt32(Console.ReadLine());
int columns = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double [rows, columns];
double b = 0;

for (int i =0; i<matrix.GetLength(0); i++)
{
    for (int j =0; j<matrix.GetLength(1); j++)
    {
        matrix[i,j] = Convert.ToDouble(new Random().Next(0, 100));
        Console.Write(matrix[i,j]+"\t");
    }
    Console.WriteLine();
}    

for (int i=1,k=0;i<matrix.GetLength(0);i++) 
{
   double summa=0;
    for (int j=0;j<matrix.GetLength(1);j++) 
        {
            summa+=matrix[i,j];
        }
    b=summa/columns;
    Console.WriteLine("Среднее арифметическое столбца "+(i)+" равно: "+b);
    k++;
}           