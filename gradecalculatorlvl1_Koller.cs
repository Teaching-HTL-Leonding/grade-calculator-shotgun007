Console.Clear();
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Black;

Console.WriteLine("Did you participated the first and/or the second written exam?");
Console.WriteLine("Press, 1 for I have participated both and 2 for I have participated one of them and 3 for I have participated none of them.");
int decision1 = int.Parse(Console.ReadLine()!);

int possiblepoints = 40;

if (decision1 == 3)
{
    possiblepoints -= 40;
    Console.WriteLine("Nothing to calculate!");
}
if (decision1 == 2)
{
    possiblepoints -= 20;
    Console.WriteLine("How many points have you reached at the written exam (0-20 points)?");
    double writtenexampoints = double.Parse(Console.ReadLine()!);
    double totalpoints = writtenexampoints / possiblepoints * 100;
    if (totalpoints >= 89)
    {
        Console.WriteLine("Your grade is 1!");
    }
    else if (totalpoints >= 76)
    {
        Console.WriteLine("Your grade is 2!");
    }
    else if (totalpoints >= 63)
    {
        Console.WriteLine("Your grade is 3!");
    }
    else if (totalpoints >= 50)
    {
        Console.WriteLine("Your grade is 4!");
    }
    else if (totalpoints < 50)
    {
        Console.WriteLine("Your grade is 5!");
    }
    else if (totalpoints > 100)
    {
        Console.WriteLine("You cheated, your grade is 5!");
    }
}
else if (decision1 == 1)
{
    Console.WriteLine("How many points have you reached together at both written exams (0-40 points)?");
    double writtenexampoints = double.Parse(Console.ReadLine()!);
    double totalpoints = writtenexampoints / possiblepoints * 100;
    if (totalpoints >= 89)
    {
        Console.WriteLine("Your grade is 1!");
    }
    else if (totalpoints >= 76)
    {
        Console.WriteLine("Your grade is 2!");
    }
    else if (totalpoints >= 63)
    {
        Console.WriteLine("Your grade is 3!");
    }
    else if (totalpoints >= 50)
    {
        Console.WriteLine("Your grade is 4!");
    }
    else if (totalpoints < 50)
    {
        Console.WriteLine("Your grade is 5!");
    }
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.Clear();

