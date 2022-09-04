//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Ведите число: ");
string? number = (Console.ReadLine());
int count = number.Length; 
if (count < 3)
Console.WriteLine ("В этом числе нет третьей цифры");
else
Console.WriteLine($"Третья цифра числа {number} это: {number[2]}");