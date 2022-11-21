// Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5 -> да 
// a = 2, b = 10 -> нет 
// a = 9, b = -3 -> да 
// a = -3 b = 9 -> нет

Console.Clear();
Console.WriteLine("Введите число 1: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int numberB = int.Parse(Console.ReadLine());

int square = numberA * numberA;

if(numberB == square);
{
   Console.WriteLine("Да, второе число это квадрат первого");
}
else
{
Console.WriteLine("Нет, второе число это не квадрат первого");
    
}
// Console.Clear(); 
// Console.Write("Введите число: "); 
// int numberA = int.Parse(Console.ReadLine()); 
// int numberB = int.Parse(Console.ReadLine()); 
// int squareA = numberA*numberA; 
// if(numberB==squareA); 
// { 
//     Console.WriteLine("Yes"); 
// }