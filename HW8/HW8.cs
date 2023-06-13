// ЗАДАЧА 54: Задайте двумерный массив и напишите программу, которая упорядочет по убыванию элементы каждой строки двумерного массива._____________________________

/*
Console.WriteLine("Enter count of Rows:  ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter count of Columns:  ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter MIN value:  ");
int minV = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter MAX value:  ");
int maxV = Convert.ToInt32(Console.ReadLine());


int [,] CreateDataFrame (int rows, int columns, int MIN, int MAX)
{
    int [,] createdDF = new int [rows,columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdDF [i,j] = new Random().Next(minV,maxV);
        }
    }
    return createdDF;
}

void ShowDF (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,]  ChangeDF (int [,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns - 1; j++)
        {
            if (array[i,j] < array[i,j+1])
            {
                    int temp = array[i,j];
                    array[i,j] = array[i, j + 1];
                    array[i, j + 1] = temp;
            }
            
        }
    }
    return array;
}


int [,] createDF = CreateDataFrame(rows,columns,minV, maxV);
Console.WriteLine();
Console.WriteLine("CreatedDF:");
ShowDF(createDF);

int [,] changeDF = ChangeDF(createDF);
Console.WriteLine();
Console.WriteLine("new chagedDF:");
ShowDF(changeDF);
*/
//_____________________________________________________________________________________________________________________________________________________________

// Задача 56: Создайте прямоугольный массив, и напишите программу, которая будет находить строку с наименьшей суммой элементов.

/*
Console.WriteLine("Enter count of Rows (количество строк должно быть равно количеству столбцов!!!):  ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter count of Columns (количество столбцов должно быть равно количеству строк!!!):  ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter MIN value:  ");
int minV = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter MAX value:  ");
int maxV = Convert.ToInt32(Console.ReadLine());


int [,] CreateDataFrame (int rows, int columns, int MIN, int MAX)
{
    int [,] createdDF = new int [rows,columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            createdDF [i,j] = new Random().Next(minV,maxV);
        }
    }
    return createdDF;
}

void ShowDF (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void CalcMinSumRow (int [,] arrayDF)
{
    int rows = arrayDF.GetLength(0);
    int columns = arrayDF.GetLength(1);
   

    int [] sumRows = new int [arrayDF.GetLength(0)];

    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += arrayDF[i,j];          
        }
         sumRows[i] = sum;
        
        Console.Write(sumRows[i] + " ");       
    }
    Console.WriteLine();

    
    int minSum = sumRows[0];
    int minInd = 0;
    for (int k = 1; k < sumRows.Length; k ++)
    {
        if( sumRows[k] < minSum )
        {
            minSum = sumRows[k];
            minInd = k;
        }    
    }
    Console.WriteLine($"Minimal sum equal {minSum} and it's row with index i = {minInd}");
}

if (rows == columns)
{
int [,] createDF = CreateDataFrame(rows,columns,minV, maxV);
Console.WriteLine();
Console.WriteLine("CreatedDF:");
ShowDF(createDF);

CalcMinSumRow(createDF);
}
else
{
  Console.WriteLine ("Your count of rows and columns arn't equal, enter valid data please!");
}
*/
//______________________________________________________________________________________________________________________________________________________________

// Задача 58. Задайте 2-е матрицы. Напишите программу, которая будет находить произведения 2-х матриц.
/*
int [,] matrix1 = {{2,3,5}, {3,3,5}, {3,4,23}};
int [,] matrix2 = {{3,6,8}, {11,2,22},{13,4,88}};

int [,] CreateMatrixResult (int [,] matrix1, int [,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int cols2 = matrix2.GetLength(1);

    int [,] result = new int[rows1, cols2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < cols2; j++)
        {
            int sum =  0;

            for (int k = 0; k < cols1; k++)
            {
                sum += matrix1[i,k]*matrix2[k,j];
            }
            result[i,j] = sum;
        }
    }
    return result;
}

void ShowDF (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] resultMatrix3 = CreateMatrixResult(matrix1, matrix2);
Console.WriteLine("Matrix1 is below: ");
ShowDF(matrix1);
Console.WriteLine("Matrix2 is below: ");
ShowDF(matrix2);
Console.WriteLine("Result (Matrix3) is below: ");
ShowDF(resultMatrix3);

_______________________________________________________________________________________________________________________________________________________________________________

*/
// Задача 60. Сформируйте трехмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выодить массив, добавляя индексы каждого элемента.

/*
int [,,] Createarray3D ()
{
    Random random = new Random();
    int [,,] created3DDF = new int[2,2,2];
    List<int> usedNumbers = new List<int>();

    for (int i = 0; i < created3DDF.GetLength(0); i++)
    {
        for (int j = 0; j < created3DDF.GetLength(1); j++)
        {
            for (int k = 0; k < created3DDF.GetLength(2); k++)
            {
                int number;
                do
                {
                    number =  random.Next (10, 100);
                } while(usedNumbers.Contains(number));
                created3DDF[i, j, k] = number;
                usedNumbers.Add(number);
            }
        }
    }
    return created3DDF;
}


void Print3DDF (int [,,] dataFrame3D)
{
    for (int i = 0; i < dataFrame3D.GetLength(0); i++)
    {
        for (int j = 0; j < dataFrame3D.GetLength(1); j++)
        {
            for (int k = 0; k < dataFrame3D.GetLength(2); k++)
            {
                Console.Write($"{dataFrame3D[i,j,k]}({i},{j},{k})  ");
            }
        }
    }
}


    int [,,] array3D = Createarray3D();
    Print3DDF(array3D);
    ____________________________________________________________________________________________________________________________________________________
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4*4.


/*
void FillSpiralArray ()
{
    int [,] createdDF = new int[4,4];

    int value = 1;

    int rowStart = 0 ;
    int rowEnd = 3 ;
    int colStart = 0 ;
    int colEnd = 3 ;

   
    while(rowStart <= rowEnd && colStart <= colEnd)
    {

        for (int col = colStart ; col <= colEnd ; col++) //первая строка (вправо)
        {
            createdDF[rowStart, col] = value++;
        }
        rowStart++;

        for (int row = rowStart; row <= rowEnd ; row++) // правый столбец (вниз)
        {
            createdDF[row, colEnd] = value++;
        }
        colEnd--;

        for(int col =  colEnd; col >= colStart ; col--) // нижняя строка (влево)
        {
            createdDF[rowEnd, col] = value++;
        }
        rowEnd--;

        for (int row = rowEnd; row >= rowStart; row--) // первый столбец (вверх)
        {
            createdDF[row,colStart] = value++;
        }
        colStart++;
    }
        for (int row = 0; row <4; row++)
        {
            for(int col = 0; col<4; col++)
            {
                Console.Write(createdDF[row,col] + " "); 
            }
            Console.WriteLine();
        }

    
}

FillSpiralArray();
*/