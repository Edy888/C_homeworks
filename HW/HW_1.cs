////////////////////////////////// Семинар1_HW ///////////////////////////////////////////////////////

// Задача 2:
// Напишите программу, которая на вход принимает 2 числа и выдает, какое число большее, а какое меньшее


Console.WriteLine("Input num_a: ");
int num_a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input num_b: ");
int num_b = Convert.ToInt32(Console.ReadLine());

if (num_a > num_b)
{
    int max = num_a;
    int min = num_b;
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"min = {min}");
}
else
{
    int max = num_b;
    int min = num_a;
    Console.WriteLine($"max = {max}");
    Console.WriteLine($"min = {min}");
}


// Задача 4:
// Напишите программу, которая принимает на вход 3 числа и выдает макс из этих чисел

/*
Console.Write("Enter num_1: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter num_2: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter num_3: ");
int num_3 = Convert.ToInt32(Console.ReadLine());

if (num_1>num_2 && num_1>num_3)
{
    int max = num_1;
    Console.WriteLine($"Maximum digit: {max}");
}
else
{
    if (num_2 > num_3)
    {
        int max = num_2;
        Console.WriteLine($"Maximum digit: {max}");
    }
    else
    {
        int max = num_3;
        Console.WriteLine($"Maximum digit: {max}");
    }
}
*/



// Задача 6:
// Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на 2 без остатка)

/*
Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine()) % 2;

if (number == 0)
{
    Console.WriteLine($"Your remainder of a number {number}, your number is EVEN (четное)");
}
else
{
    Console.WriteLine($"Your remainder of a number {number}, your number is ODD (нечетное)");
}
*/


// Задача 8:
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все четные числа от 1 до N.

/*
Console.Write("Enter your number: ");
int num_N = Convert.ToInt32(Console.ReadLine());

int current_i = 1;

while (current_i <= num_N)
{
    if (current_i % 2 == 0)
    {
        Console.Write(current_i + " ");        
    }
current_i ++;
}
*/
