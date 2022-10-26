// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).


Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
if(number != 0)
{
    int remainder = number % 2;
    if(remainder != 0)
    {
        Console.WriteLine("Это число нечетное");
    }
    else
    {
        Console.WriteLine("Это число четное");
    }
}
else
{
    Console.WriteLine("Вы ввели 0");
}