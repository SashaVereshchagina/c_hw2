//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());

int secondDigit = ((n%100)-(n%10))/10;

Console.WriteLine("Вторая цифра: " + secondDigit);