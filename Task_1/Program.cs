 /*Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int Promt (string message)
{
    System.Console.Write(message);
    int ret = int.Parse(Console.ReadLine());
    return ret;
}

int number = Promt("Ennter the first number: ");


if (number < 100 || number > 1000)
{
    System.Console.WriteLine("Wrong number! Please Enter a numbers grather then 100 and less then 1000");
}
else
{
    int result = number % 100;
    result = result / 10;
    System.Console.WriteLine(result);
}