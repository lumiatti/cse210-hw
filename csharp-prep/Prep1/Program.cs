using System;

class Program
{
    static void Main(string[] args)
    {
        string first_name, last_name;
        
        Console.WriteLine("What is your FIRST name?");
        first_name = Console.ReadLine();

        Console.WriteLine("What is your LAST name?");
        
        last_name = Console.ReadLine();
        
        Console.WriteLine($"My name is {last_name}, {first_name} {last_name}");
    }
}