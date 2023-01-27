// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
string numberStr1 = Console.ReadLine(); 
int number1 = Convert.ToInt32(numberStr1); 

Console.WriteLine("Введите второе число, отличное от первого:"); //По условию задачи числа разные, поэтому пишу это в запросе, проверку на то, что они равны не делаю
string numberStr2 = Console.ReadLine(); 
int number2 = Convert.ToInt32(numberStr2); 

if(number1 > number2)
{
  Console.WriteLine($"Большее число: {number1}, меньшее число: {number2}");  
}
else
{
    Console.WriteLine($"Большее число: {number2}, меньшее число: {number1}"); 
}

