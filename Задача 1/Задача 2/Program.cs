/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Random rnd = new Random();
int number = rnd.Next (10, 1000);
Console.WriteLine($"число равно {number}");

if (number > 99)
{
    number = number % 10;
    Console.WriteLine(number);
}

else 
{
    Console.WriteLine("Третьей цифры нет ");
}
 