/*Задача 2: Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
456 -> 46
782 -> 72
918 -> 98 */

int number = new Random().Next(100,999);
System.Console.Write(number);

int tmp = number / 100;
tmp = tmp * 10;


int res = number % 10;
res = tmp + res;
System.Console.WriteLine($" -> {res}");