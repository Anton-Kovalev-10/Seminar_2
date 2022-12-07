/*Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Random rnd = new Random();
int number = rnd.Next (100, 1000);
Console.WriteLine($"число равно {number}");

int second = number % 100 / 10;
 
Console.WriteLine($" резулитат равен {second}");