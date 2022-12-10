// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
try
{

    Console.Clear();
    Console.WriteLine("Введите число M: ");
    int numberM = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());


    if (numberM < 0 || numberN < 0)
    {
        throw new Exception($"меньше нуля");
    }
     if (numberM ==numberN )
    {
        throw new Exception ($"равны");
    }

    if (numberM < numberN)
    {
        NaturalMinMax(numberM, numberN, 0);
    }
    else
    {
        NaturalMaxMin(numberM, numberN, 0);
    }



    void NaturalMinMax(int numMin, int numMax, int sum)
    {
        if (numMax == numMin)
        {
            Console.Write($"{sum} ");
            return;
        }
        sum = ((numberM + numberN) * ((numberN + 1) - numberM)) / 2;
        NaturalMinMax(numMin + 1, numMax, sum);
    }



    void NaturalMaxMin(int numMax, int numMin, int sum)
    {
        if (numMax == numMin)
        {
            Console.Write($"{sum} ");
            return;
        }
        sum = ((numberM + numberN) * ((numberM + 1) - numberN)) / 2;
        NaturalMaxMin(numMax - 1, numMin, sum);
    }


}
catch (FormatException) { Console.WriteLine($"Это не число"); }

catch (Exception ex)
{
    Console.WriteLine($"Числа не могут быть {ex.Message}");
}


