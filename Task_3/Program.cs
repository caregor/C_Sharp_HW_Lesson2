/* Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int Promt (string message)
{
    System.Console.Write(message);
    int ret = int.Parse(Console.ReadLine());
    return ret;
}

int Pow (int a, int b)
{
    int res = a;
    for (int i=1; i < b; i++)
    {
        res = res * a;
    }
return res;
}

int number = Promt("Enter a number: ");

if (number < 100)
{
    System.Console.WriteLine(" the third digit doesn't exisit!");
}
else
{
    for (int i=9; i > 1; i--)
    {
        if(number / Pow(10, i) != 0 )
        {
            
            int digit = number % Pow(10, i - 1);
            if (i > 2)
                digit = digit / Pow(10, i - 2);
            System.Console.WriteLine($"the 3`d digit is {digit}");
            break;
        }
    }
}