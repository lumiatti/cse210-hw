using System;

class Program
{
    static void Main(string[] args)
    {
        int my_grade;
        string grade = "";

        //grade = "";

        Console.WriteLine("What is you grade percentage?");
        my_grade = int.Parse(Console.ReadLine());

        if (my_grade >= 90)
        {
            grade = "A";
        }        
        else if (my_grade >= 80 && my_grade < 90)
        {
            grade = "B";
        }           
        else if (my_grade >= 70 && my_grade <80)
        {
            grade = "C";
        }
        else if (my_grade >= 60 && my_grade <70)
        {
            grade = "D";
        }
        else if (my_grade < 60)
        {
            grade = "F";
        }        
        
        
        Console.WriteLine($"Your grade is {grade}");
    }
}