//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Ведите цифру соотвтствующую дню недели:"); 
int digit = Convert.ToInt32(Console.ReadLine());
if (digit == 6|| digit ==7 )
Console.WriteLine ("Это выходной день");
else
{
  Console.WriteLine ("Это будний день");  
}