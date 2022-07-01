// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
int usernumber=Convert.ToInt32(Console.ReadLine());

if( usernumber >= 100 && usernumber < 1000 )
{
    System.Console.WriteLine(usernumber/10%10);
}
else
{
    System.Console.WriteLine("error");
}

