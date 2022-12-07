/*Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.WriteLine("Введите цифру от 1 до 7");
string number = Console.ReadLine();
if (number == "1")
 Console.WriteLine ("Понедельник (Нет)");
else if (number == "2")
 Console.WriteLine ("Вторник (Нет)");
else if (number == "3")
 Console.WriteLine ("Среда (Нет)");
 else if (number == "4")
 Console.WriteLine ("Четверг(Нет)");
else if (number == "5")
 Console.WriteLine ("Пятница (Нет)");
else if (number == "6")
 Console.WriteLine ("Суббота (Да)");
else if (number == "7")
 Console.WriteLine ("Воскресенье (Да)");