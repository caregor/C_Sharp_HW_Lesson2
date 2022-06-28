/*Задача 4: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да 
7 -> да 
1 -> нет */

int Promt (string message)
{
    System.Console.Write(message);
    int ret = int.Parse(Console.ReadLine());
    return ret;
}

int day = Promt("Enter a day (by number): ");

switch(day)
{
    case < 8 when day > 5: 
    System.Console.WriteLine("Yes");
    break;

    case > 0 when day < 6:
    System.Console.WriteLine("No");
    break;

    default:
    System.Console.WriteLine("This number is not acceptable");
    break;
}
