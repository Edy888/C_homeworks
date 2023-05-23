// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

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

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

void NumSum (int value_X) ;
{
    int save_n = 0 ;
    

}