// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве./////
// [345, 897, 568, 234] -> 2

/*
int [] CreatePosRandom (int size, int min, int max)
{
    int [] arPositive = new int [size] ;
    for (int i = 0; i < size; i++)
    {
        arPositive [i] = new Random().Next(min,max) ;        
    }
    return(arPositive) ;
}

int arrayEvenNum (int [] arrayCurrent)
{
    int count = 0 ;

    for (int s = 0; s < arrayCurrent.Length; s++)
    {
        if (arrayCurrent [s] % 2 == 0)
        count ++ ;
    }
    return(count);
}

void arrShow (int [] CreateAr)
{
    for (int h = 0; h < CreateAr.Length; h++)
    {
        Console.Write(CreateAr [h] + " ");
    }
}

int size = 200 ;
int min = 100 ;
int max = 999 ;

int [] ArPosF = CreatePosRandom(size,min,max) ;
arrShow (ArPosF) ;
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Your number of positive values are {arrayEvenNum(ArPosF)}") ;
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. ///////////////////////////////////////
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/*
int [] ArrayCreater (int size, int min, int max) 
{
    int [] ArrIndex = new int [size] ;
    for (int i = 0; i < size; i++)
    {
        ArrIndex [i] = new Random().Next(min, max);
    }
    return(ArrIndex);
}

void ShowArrInd (int [] ArrInd)
{
    for (int s = 0; s < ArrInd.Length; s++)
    {
        Console.Write(ArrInd [s] + " ");
    }
}

int ArrSort (int [] ArrCurrent)
{
    int sum = 0 ;
    for (int j = 1; j < ArrCurrent.Length; j+=2)
    {
        Console.Write(ArrCurrent [j] + " ") ;
        sum += ArrCurrent [j];
    }
    return(sum) ;
   
}

Console.WriteLine("Enter size of your array: ") ;
int size = Convert.ToInt32(Console.ReadLine());
int min = 0 ;
int max = 999 ;

Console.WriteLine();

int [] Arr = ArrayCreater(size, min, max);
Console.WriteLine("Your generated array is:");
ShowArrInd(Arr);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Number which has ODD indexes: ");
int summary = ArrSort(Arr) ; 

Console.WriteLine();
Console.WriteLine();
Console.WriteLine ($"Sum of Numbers which has ODD indexes is equal:   {summary}") ;
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. ////////////////////////////////////////////////////
// [3 7 22 2 78] -> 76

/*
double [] ArrayCreaDouble (int size)
{
    double [] ArrIndex = new double [size] ;
    for (int i = 0; i < size; i++)
    {
        ArrIndex [i] = new Random().NextDouble();
    }
    return(ArrIndex) ;
}

void ShowArrInd (double [] ArrInd)
{
    for (int s = 0; s < ArrInd.Length; s++)
    {
        Console.Write($"{ArrInd [s]:f2}" + " ");
    }
}

void arrFinder (double [] ArrD)
{
    double min = 0 ;
    double max = 0 ;
    for (int x = 0; x < ArrD.Length; x++)
    {
        if (ArrD [x] > max)
        {
            max = ArrD [x];
        }
        else min = ArrD [x] ;
    }
    Console.WriteLine() ;
    Console.WriteLine($"1. min is : {min:f2}") ;
    Console.WriteLine($"2. max is : {max:f2}") ;
    Console.WriteLine() ;
    Console.WriteLine($"Result: max - min = {(max - min):f2}") ;
}

Console.WriteLine("Enter size of your array: ") ;
int size = Convert.ToInt32(Console.ReadLine());

double [] ArrDouble = ArrayCreaDouble(size);

Console.WriteLine("Your generated double massive: ") ;
ShowArrInd(ArrDouble);

Console.WriteLine() ;
arrFinder(ArrDouble) ;
Console.WriteLine() ;
*/