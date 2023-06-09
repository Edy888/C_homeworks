// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве./////
// [345, 897, 568, 234] -> 2

/* [] CreatePosRandom  size, min, max)
{
 [] arPositive = new [size] ;
    for  i = 0; i < size; i++)
    {
        arPositive [i] = new Random().Next(min,max) ;        
    }
    return(arPositive) ;
}
 arrayEvenNum  [] arrayCurrent)
{
 count = 0 ;

    for  s = 0; s < arrayCurrent.Length; s++)
    {
        if (arrayCurrent [s] % 2 == 0)
        count ++ ;
    }
    return(count);
}

void arrShow  [] CreateAr)
{
    for  h = 0; h < CreateAr.Length; h++)
    {
        Console.Write(CreateAr [h] + " ");
    }
}
 size = 200 ; min = 100 ; max = 999 ;
 [] ArPosF = CreatePosRandom(size,min,max) ;
arrShow (ArPosF) ;
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Your number of positive values are {arrayEvenNum(ArPosF)}") ;
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. ///////////////////////////////////////
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

/* [] ArrayCreater  size, min, max) 
{
 [] ArrIndex = new [size] ;
    for  i = 0; i < size; i++)
    {
        ArrIndex [i] = new Random().Next(min, max);
    }
    return(ArrIndex);
}

void ShowArrInd  [] ArrInd)
{
    for  s = 0; s < ArrInd.Length; s++)
    {
        Console.Write(ArrInd [s] + " ");
    }
}
 ArrSort  [] ArrCurrent)
{
 sum = 0 ;
    for  j = 1; j < ArrCurrent.Length; j+=2)
    {
        Console.Write(ArrCurrent [j] + " ") ;
        sum += ArrCurrent [j];
    }
    return(sum) ;
   
}

Console.WriteLine("Enter size of your array: ") ; size = Convert.T32(Console.ReadLine()); min = 0 ; max = 999 ;

Console.WriteLine();
 [] Arr = ArrayCreater(size, min, max);
Console.WriteLine("Your generated array is:");
ShowArrInd(Arr);

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Number which has ODD indexes: "); summary = ArrSort(Arr) ; 

Console.WriteLine();
Console.WriteLine();
Console.WriteLine ($"Sum of Numbers which has ODD indexes is equal:   {summary}") ;
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. ////////////////////////////////////////////////////
// [3 7 22 2 78] -> 76

/*
double [] ArrayCreaDouble  size)
{
    double [] ArrIndex = new double [size] ;
    for  i = 0; i < size; i++)
    {
        ArrIndex [i] = new Random().NextDouble();
    }
    return(ArrIndex) ;
}

void ShowArrInd (double [] ArrInd)
{
    for  s = 0; s < ArrInd.Length; s++)
    {
        Console.Write($"{ArrInd [s]:f2}" + " ");
    }
}

void arrFinder (double [] ArrD)
{
    double min = 0 ;
    double max = 0 ;
    for  x = 0; x < ArrD.Length; x++)
    {
        if (ArrD [x] > max)
        {
            max = ArrD [x];
        }
        if (ArrD [x] < max)
        {
            min = ArrD [x] ;
        }
    }
    Console.WriteLine() ;
    Console.WriteLine($"1. min is : {min:f2}") ;
    Console.WriteLine($"2. max is : {max:f2}") ;
    Console.WriteLine() ;
    Console.WriteLine($"Result: max - min = {(max - min):f2}") ;
}

Console.WriteLine("Enter size of your array: ") ; size = Convert.T32(Console.ReadLine());

double [] ArrDouble = ArrayCreaDouble(size);

Console.WriteLine("Your generated double massive: ") ;
ShowArrInd(ArrDouble);

Console.WriteLine() ;
arrFinder(ArrDouble) ;
Console.WriteLine() ;
*/

// Напишите программу, которая перевернет одномерный массив.

/* [] ArCrea  size, min, max)
{
 [] ArrayNew = new [size] ;
    for  i = 0; i < size; i++)
    {
        ArrayNew [i] = new Random().Next(min, max + 1) ;
    }
    return(ArrayNew) ;
}

void ShowArrInd  [] ArrInd)
{
    for  s = 0; s < ArrInd.Length; s++)
    {
        Console.Write(ArrInd [s] + " ");
    }
}
 [] ArChange  [] Ar3)
{
 Length = Ar3.Length ;
    for  i = 0; i < Ar3.Length/2; i++)
    {
     temp = 0 ;
        temp = Ar3 [i] ;
        Ar3[i] = Ar3[Length - 1 - i];
        Ar3[Length - 1 - i] = temp ;
    }

return(Ar3) ;
}


Console.WriteLine("Enter size of your array: ") ; size = Convert.T32(Console.ReadLine()); min = 1 ; max = 99 ;
 [] Array = ArCrea(size, min, max);
ShowArrInd(Array) ;
Console.WriteLine();
Console.WriteLine(); [] MasNew = ArChange(Array);
ShowArrInd(MasNew) ;
*/

// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые 2 числа ФибоначчиЖ а и b (пользователь). 
// 0 1 1 2 3 5 8 13
// a b a+b=c b+c=d c+d=e

// 1. Запросить N, a and b
// 2. 


/* [] ArCreate  count, nA, nB)
{
 [] arFibonachi = new [count];
    arFibonachi [0] = nA ;
    arFibonachi [1] = nB ;
    for  i = 2; i < count; i++)
    {
        arFibonachi [i] = arFibonachi [i-2] + arFibonachi [i-1] ;
    }
    return (arFibonachi);
}

void arShow ( [] ar8)
{
    for  f = 0; f < ar8.Length; f++)
    {
        Console.Write(ar8[f] + " " );
    }
}

Console.WriteLine("Enter your N: "); countN = Convert.T32(Console.ReadLine());

Console.WriteLine("Enter your a: "); numA = Convert.T32(Console.ReadLine());

Console.WriteLine("Enter your b: "); numB = Convert.T32(Console.ReadLine());
 [] ArrC = ArCreate(countN, numA, numB);
Console.WriteLine();
arShow(ArrC);
*/

// Задача про треугольник
/*
string BinarSys (int Num)
{
    string binRes = String.Empty;
    while (Num != 0)
    {
        binRes = Num % 2 + binRes ;
        Console.WriteLine($"двоичное число (остаток от деления) = {binRes}");
        Num /= 2 ;
        Console.WriteLine($"(целочисленное деление) =  {Num}");
    }
    return(binRes);
}

Console.WriteLine("Enter your number:  ");
int num = Convert.ToInt32(Console.ReadLine());

string binresult = BinarSys(num);
Console.WriteLine ($"Your number {num} is equal in binare system {binresult}");
*/

void Calculator (double a1, double b1, double a2, double b2)
{
   
    if (a1 == a2)
    {
        Console.WriteLine("Your Lines are parallel");
    }
    else
    {
        double  x = (b2 - b1)/(a1-a2) ;
        double y = a1 * x + b1;
        Console.WriteLine($"Your coordinates x;y = {x:f3} ; {y:f3}");

    }
    if (a1 == a2 & b1 == b2)
    {
        Console.WriteLine("Your lines are coinside!!!");
    }
}

Console.WriteLine("Enter your a1 (slope1):  ");
double a1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter your b1 (intersept1):  ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter your a2 (slope2):  ");
double a2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter your b2 (intersept2):  ");
double b2 = Convert.ToDouble(Console.ReadLine());

Calculator(a1,b1,a2,b2);