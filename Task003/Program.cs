// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
string numberStr = Console.ReadLine(); 
int number = Convert.ToInt32(numberStr); 

if(number % 2 == 0)
{
  Console.WriteLine($"Число {number} является четным");  
}
else
{
    Console.WriteLine($"Число {number} является нечетным"); 
}

