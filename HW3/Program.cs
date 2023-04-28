//_______________________________________________________________________________________________________
/* Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.Write("Enter your 5-digits number: ");
int numPoly = Convert.ToInt32(Console.Read());















//___________________________________________________________________________________________________________________
/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

/*
double CubeLength (double x1, double x2, double y1, double y2, double z1, double z2)
{
    double resultCalc = Math.Sqrt((x1-x2)*(x1-x2) + (y1 - y2)*(y1 - y2) + (z1 - z2)*(z1 - z2));
    return resultCalc;
}

Console.WriteLine ("Input your x of A: ");
double xValA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input your y of A: ");
double yValA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input your z of A: ");
double zValA = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input your x of B: ");
double xValB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input your y of B: ");
double yValB = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Input your z of B: ");
double zValB = Convert.ToInt32 (Console.ReadLine());

double lengthRes = CubeLength(xValA, xValB, yValA, yValB, zValA, zValB);
Console.WriteLine($"Distanse between dot A and dot B is equal: {lengthRes:f2}");
*/

//______________________________________________________________________________________________
/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/*
void nPlusMinus()
{
    Console.Write("Enter your N: ");
    int userN = Convert.ToInt32(Console.ReadLine());
    
    if (userN > 0)
    {   
       int current_N = 1;
        
        while (current_N <= userN)
        {
            double nPlus = Math.Pow(current_N,3);
            Console.Write($"{nPlus:f0}, ");
            current_N++;
        }
         
        Console.WriteLine("\b\b. ");
    }
    else
    {
        int current_N = 1;
        while (current_N >= userN)
        {
            double nMinus = Math.Pow (current_N, 3);
            Console.Write($"{nMinus:f0}, ");
            current_N--;
        }
        Console.WriteLine("\b\b. ");
    }
}
nPlusMinus();
*/


/*
void nPlus (double yourN)
{
    double current_n = 1;

    while(current_n <= yourN)
    {
        double res = Math.Pow(current_n,3);
        Console.Write ($"{res:f0}, "); 
        current_n++;
    }
    Console.WriteLine("\b\b. ");
}

void nMinus (double yourN)
{
    double current_n = 1;

    while(current_n >= yourN)
    {
        double res = Math.Pow(current_n,3);
        Console.Write ($"{res:f0}, "); 
        current_n--;
    }
    Console.WriteLine("\b\b. ");
}

Console.Write("Enter your N: ");
double yourN = Convert.ToInt32(Console.ReadLine());

if (yourN > 0)
{
    nPlus(yourN);
}
else
{
    nMinus(yourN);
}
*/