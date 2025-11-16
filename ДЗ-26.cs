using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Console.WriteLine("Исходный массив:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();

        Console.Write("Введите количество позиций для сдвига влево: ");
        int shiftPositions = int.Parse(Console.ReadLine());

        ShiftArrayLeft(numbers, shiftPositions);

        Console.WriteLine($"Массив после сдвига на {shiftPositions} позиций влево:");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }

    static void ShiftArrayLeft(int[] array, int shiftCount)
    {
        int arrayLength = array.Length;

        if (arrayLength == 0 || shiftCount % arrayLength == 0)
        {
            return;
        }

        shiftCount = shiftCount % arrayLength;

        for (int i = 0; i < shiftCount; i++)
        {
            ShiftOnePositionLeft(array);
        }
    }

    static void ShiftOnePositionLeft(int[] array)
    {
        int arrayLength = array.Length;

        int firstElement = array[0];

        for (int i = 0; i < arrayLength - 1; i++)
        {
            array[i] = array[i + 1];
        }

        array[arrayLength - 1] = firstElement;
    }
}
