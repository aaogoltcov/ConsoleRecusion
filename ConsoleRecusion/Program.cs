// Напишите программу , которая выведет все натуральные числа в
// промежутке от M до N. Используйте рекурсию и не используйте циклы.

void PrintRange(int min, int max)
{
    void PrintInterimRangeNumber(int min, int max)
    {
        if (min > max)
        {
            return;
        }

        Console.Write(min);
        
        if (min == max)
        {
            Console.WriteLine(".");
        }

        if (min < max)
        {
            Console.Write(", ");
            PrintInterimRangeNumber(min + 1, max);
        }
    }

    Console.Write("Числа в промежутке: ");
    PrintInterimRangeNumber(min, max);
}

PrintRange(1, 5);

// Напишите программу для вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.

int Ackermann(int m, int n)
{
    int GetAckermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else if (m > 0 && n > 0)
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }

        return 0;
    }

    return GetAckermann(m, n);
}

int m = 2;
int n = 3;
int result = Ackermann(m, n);
Console.WriteLine($"A({m}, {n}) = {result}.");

// Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.

void PrintArrayReverse(int[] array, int? index)
{
    int innerIndex = array.Length - 1;
    
    if (index.HasValue)
    {
        innerIndex = index.Value;
    }

    if (innerIndex < 0)
    {
        return;
    }

    Console.Write(array[innerIndex]);

    if (innerIndex > 0)
    {
        Console.Write(", ");
    }
    
    PrintArrayReverse(array, innerIndex - 1);
}

int[] array = [1, 2, 3, 4, 5];

Console.Write("Массив в обратном порядке: ");
PrintArrayReverse(array, null);