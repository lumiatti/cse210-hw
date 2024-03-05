using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        List<int> my_list;
        my_list = new List<int>();
        int total = 0;
        int largest = 0;
        int average = 0;

        while (number != 0)
        {
            Console.Write("Enter a list of numbers, type 0 when finished.");
            number = int.Parse(Console.ReadLine());

            if (number !=0)
            {
                my_list.Add(number);    
            }
        }

        total = my_list.Sum();
        average = total/my_list.Count();
        largest = my_list.Max();

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}