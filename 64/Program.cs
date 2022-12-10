// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

try
{


Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <0 )
    {
        throw new Exception($"меньше нуля");
    }

void NaturalNumbers (int num)
{ 
    if (num == 0) return;
    NaturalNumbers (num - 1);
    Console.Write($"{num}");
}
NaturalNumbers(number);


}

catch (FormatException) { Console.WriteLine($"Это не число"); }
catch (Exception ex)
{
    Console.WriteLine($"Число не может быть {ex.Message}");
}

