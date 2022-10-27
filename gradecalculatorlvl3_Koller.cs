﻿Console.Clear();
Console.BackgroundColor = ConsoleColor.Red;
Console.ForegroundColor = ConsoleColor.Black;

Console.WriteLine("Did you participated the first and/or the second written exam?");
Console.WriteLine("Press, 1 for I have participated both and 2 for I have participated one of them and 3 for I have participated none of them.");
int decision1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Did you have an oral exam?");
Console.WriteLine("Press 1 for yes and 2 for no");
int decision2 = int.Parse(Console.ReadLine()!);

int possiblepoints = (80);

if (decision1 == 3 & decision2 == 2)
{
    possiblepoints -= 60;

    Console.WriteLine("How many points have you reached at your homework (0-20 points)?");
    double homeworkpoints = double.Parse(Console.ReadLine()!);
    
    double totalpoints = homeworkpoints / possiblepoints * 100;

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
if (decision1 == 2 & decision2 == 2)
{
    possiblepoints -= 40;

    Console.WriteLine("How many points have you reached at the written exam (0-20 points)?");
    double writtenexampoints = double.Parse(Console.ReadLine()!);

    Console.WriteLine("How many points have you reached at your homework (0-20 points)?");
    double homeworkpoints = double.Parse(Console.ReadLine()!);

    double totalpoints = writtenexampoints + homeworkpoints / possiblepoints * 100;

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
if (decision1 == 1 & decision2 == 2)
{
    possiblepoints -= 20;
    Console.WriteLine("How many points have you reached together at both written exams (0-40 points)?");
    double writtenexampoints = double.Parse(Console.ReadLine()!);

    Console.WriteLine("How many points have you reached at your homework (0-20 points)?");
    double homeworkpoints = double.Parse(Console.ReadLine()!);

    double totalpoints = writtenexampoints + homeworkpoints / possiblepoints * 100;

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
if (decision1 == 3 & decision2 == 1)
{
    possiblepoints -= 40;
    Console.WriteLine("How many points have you reached at your oral exam (0-20 points)?");
    double oralexampoints = double.Parse(Console.ReadLine()!);

    Console.WriteLine("How many points have you reached at your homework (0-20 points)?");
    double homeworkpoints = double.Parse(Console.ReadLine()!);

    double totalpoints = oralexampoints + homeworkpoints / possiblepoints * 100;

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
if (decision1 == 2 & decision2 == 1)
{
    possiblepoints -= 20;
    Console.WriteLine("How many points have you reached at your written exam (0-20 points)?");
    double writtenexampoints = double.Parse(Console.ReadLine()!);

    Console.WriteLine("How many points have you reached at your oral exam (0-20 points)?");
    double oralexampoints = double.Parse(Console.ReadLine()!);

    Console.WriteLine("How many points have you reached at your homework (0-20 points)?");
    double homeworkpoints = double.Parse(Console.ReadLine()!);

    double totalpoints = writtenexampoints + homeworkpoints + oralexampoints / possiblepoints * 100;

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
if (decision1 == 1 & decision2 == 1)
{
    Console.WriteLine("How many points have you reached together at both written exams (0-40 points)?");
    double writtenexampoints = double.Parse(Console.ReadLine()!);

    Console.WriteLine("How many points have you reached at your homework (0-20 points)?");
    double homeworkpoints = double.Parse(Console.ReadLine()!);

    Console.WriteLine("How many points have you reached at your oral exam (0-20 points)?");
    double oralexampoints = double.Parse(Console.ReadLine()!);

    double totalpoints = writtenexampoints + homeworkpoints + oralexampoints / possiblepoints * 100;

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





