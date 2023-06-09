int Prompt (string message)
{
    System.Console.Write(message);
    string value = Console.ReadLine();
    int results = Convert.ToInt32(Console.ReadLine());
    return results;
}

int number = Prompt("Input 3 dig value: ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("error");
    return;
}

Console.WriteLine($" Enter value {number}");
int secondRank = number / 10 % 10;