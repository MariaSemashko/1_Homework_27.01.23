// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число");
string numberStr1 = Console.ReadLine(); 
int number1 = Convert.ToInt32(numberStr1); 

Console.WriteLine("Введите второе число");
string numberStr2 = Console.ReadLine(); 
int number2 = Convert.ToInt32(numberStr2); 

Console.WriteLine("Введите третье число");
string numberStr3 = Console.ReadLine(); 
int number3 = Convert.ToInt32(numberStr3); 

int max = number1;

if (number2 > max)
{
    max = number2;
}
else if (number3 > max)
{
  max = number3;  
}
    
Console.WriteLine($"Максимальное число: {max}");

