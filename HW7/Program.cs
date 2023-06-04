// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами. //////////////////////////////////////////////////////////////////
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
Console.WriteLine("Enter count of rows: ");
int rowsM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter count of columns: ");
int columnsN = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Enter your MIN: ");
 int minNum = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine("Enter your MAX: ");
int maxNum = Convert.ToInt32(Console.ReadLine());

double [,] CreateDataFrame (int rows, int columns)
{
   double [,] createdDataFrame = new double [rows,columns] ;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdDataFrame [i,j] = Math.Round ((new Random().Next(minNum,maxNum) + new Random().NextDouble()), 1);
        }
    }
    return (createdDataFrame) ;
}

void ShowDataFrame (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine() ;
    }
    Console.WriteLine() ;
}

double [,] readyArray = CreateDataFrame(rowsM, columnsN);
ShowDataFrame(readyArray) ;
*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.////////////////////
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


/*
Console.WriteLine("Enter count of rows: ");
int rowsM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter count of columns: ");
int columnsN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your MIN: ");
int minNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your MAX: ");
int maxNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter value of necessary row: ");
int rowsForFind = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter value of necessary column: ");
int columnForFind = Convert.ToInt32(Console.ReadLine());



double [,] CreateDataFrame (int rowsM, int columnsN)
{
   double [,] createdDataFrame = new double [rowsM,columnsN] ;
    for (int i = 0; i < rowsM; i++)
    {
        for (int j = 0; j < columnsN; j++)
        {
            createdDataFrame [i,j] = Math.Round ((new Random().Next(minNum,maxNum) + new Random().NextDouble()), 1);
        }
    }
    return (createdDataFrame) ;
}


void ShowDataFrame (double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine() ;
    }
    Console.WriteLine() ;
}


void FinderIndexDataFrame (double [,] arrayDF, int row, int column)
{
    int numRows = arrayDF.GetLength(0);
    int numColumns = arrayDF.GetLength(1);

    if (rowsForFind < 0 || rowsForFind >= numRows || columnForFind < 0 || columnForFind >= numColumns)
    {
        Console.WriteLine ("Некоректная позиция элемента !!!");
    }
    else
    {
        Console.WriteLine (arrayDF[rowsForFind,columnForFind]);
    }
}


double [,] createdDF = CreateDataFrame (rowsM, columnsN) ;
ShowDataFrame(createdDF);
FinderIndexDataFrame (createdDF, rowsForFind, columnForFind);
*/

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. //////////////////////////////////////////////////////////

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Enter count of rows: ");
int rowsM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter count of columns: ");
int columnsN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your MIN: ");
int minNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your MAX: ");
int maxNum = Convert.ToInt32(Console.ReadLine());


int [,] CreateDataFrame (int rowsM, int columnsN)
{
   int [,] createdDataFrame = new int [rowsM,columnsN] ;
    for (int i = 0; i < rowsM; i++)
    {
        for (int j = 0; j < columnsN; j++)
        {
            createdDataFrame [i,j] = new Random().Next(minNum,maxNum) ;
        }
    }
    return (createdDataFrame) ;
}

void ShowDataFrame (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine() ;
    }
    Console.WriteLine() ;
}

void MeanCalc (int [,] array)
{
    int sum = 0 ;
    int count = 0 ;
    int sizeCol = array.GetLength(1);
    int sizeRow = array.GetLength(0);

    double [] columnAverage = new double [sizeCol];

    for (int j = 0; j < sizeCol; j++)
    {
        for (int i = 0; i < sizeRow; i++)
        {
            sum  = sum + array[i,j];
            count ++;
        }

        columnAverage [j] = Math.Round((double) sum / count, 2 );
    }
    Console.WriteLine ("Mean ");

    for (int j = 0; j < sizeCol; j ++)
    {
        Console.Write(columnAverage[j] + "_") ;
    }
}

int [,] arrayDF = CreateDataFrame(rowsM, columnsN) ;
ShowDataFrame(arrayDF) ;
MeanCalc(arrayDF) ;
