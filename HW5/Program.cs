// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
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


