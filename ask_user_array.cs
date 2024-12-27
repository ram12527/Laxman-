using System;

class Program
{
    static void Main()
    {
        int total = 0;
        int size;

        Console.Write("Enter the size of the array: ");
        size = Convert.ToInt32(Console.ReadLine());


        int[] array = new int[size];


        for (int i = 0; i < size; i++)
        {
            Console.Write($"Enter value for element [{i + 1}]: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }


        Console.WriteLine("The values in the array are:");
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(array[i]);
            total += array[i];
        }
        Console.WriteLine("The total is: " + total);
    }
}
