using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome(); 
        string name = EnterYourName();
        int f_number = FavoriteNumber();
        int square = SquareNumber(f_number);
        DisplayMessage(name, square.ToString());
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string EnterYourName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int FavoriteNumber()
    {
        Console.Write("Please enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayMessage(string name, string square)
    {
        Console.Write($"Brother {name}, the square of your favorite number is {square}");
    }
}