using System;

class Program
{
    static void Main(string[] args)
    {
        int magic_number; 
        int guess = -1;

        Console.WriteLine("What is the magic number?");
        magic_number = int.Parse(Console.ReadLine());

        while (guess != magic_number)
        {
            Console.WriteLine("What is your guess?");
            guess = int.Parse(Console.ReadLine());
            
            if (magic_number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic_number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
        
    }
}