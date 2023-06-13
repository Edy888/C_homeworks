// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
void ShowNum (int numbers)
{
    Console.Write(numbers + " ");
    if(numbers > 1) ShowNum(numbers - 1);
}

ShowNum(8) ;
*/



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int NumSum (int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    else
    {
        return m + NumSum(m+1,n);
    }
}
int res = NumSum(10,400);
Console.Write(res);
*/


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

/*
static int AkkerFun (int m, int n)
{
    if(m == 0)
    {
        return n+1;
    }
    else if( n == 0)
    {
        return AkkerFun(m-1, 1);
    }
    else
    {
        return AkkerFun(m-1, AkkerFun(m, n-1));
    }
}

Console.WriteLine("Enter your M value: ");
int mVal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter your N value: ");
int nVal = Convert.ToInt32(Console.ReadLine());

int result = AkkerFun(mVal,nVal);
Console.Write(result);
*/