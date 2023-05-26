// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/*
void NaturalVal (int numA, int numB)
{
    int sumC = 1 ;
    for (int i = 1; i <= numB; i++)
    {
        sumC = numA*sumC ;
    }

Console.WriteLine ($"log {numA} in degree {numB} is equal {sumC}") ;
}

Console.WriteLine ("Enter num A:");
int nA = Convert.ToInt32(Console.ReadLine()) ;

Console.WriteLine ("Enter num B:");
int nB = Convert.ToInt32(Console.ReadLine()) ;

NaturalVal (nA, nB);
*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе////////////////////////////////////////////////////////////////////////////////////////////////
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/*
void NumSum (int valueX)
{
    int remainder = 0 ;
    int sum_X = 0 ;
    while(valueX != 0 )
    {
        remainder = valueX % 10 ;
        sum_X += remainder ;
        valueX /= 10 ;
    }
Console.WriteLine(sum_X);
}

Console.WriteLine ("Enter your number_X : ");
int NumX = Convert.ToInt32(Console.ReadLine());

NumSum(NumX);
*/


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран./////////////////////////////
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] Create_Ar ()
{
    int [] arr_eight = new int [8] ;
    for(int i = 0; i < 8; i++)
        arr_eight[i] = new Random().Next() ;   
    return(arr_eight) ;
}
void Show_arr_eight (int [] arr_eight)
{
    for (int i = 0 ; i < arr_eight.Length ; i ++)
    {
    Console.Write(arr_eight [i] + "_");
    }
}

int [] arrayNew = Create_Ar();
Show_arr_eight(arrayNew);
