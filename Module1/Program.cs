// Module 1: Getting Started
using System;

// Lesson: Your first C# Program
/*
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to C#!");
        Console.WriteLine("Welcome to the Code Playground");
    }
}
*/

// Lesson: Multiple Statements
/*
public class Program
{    public static void Main(string[] args)
    {
        // Multiple Statements
        Console.WriteLine("Name:");
        Console.WriteLine("Surname:");

        // Text vs Numbers
        Console.WriteLine("Points:");
        Console.WriteLine(500);
    }
}
*/

// Coding Practice: Your First C# Program

/*
Let's code for real!
The given program should output the text: "My first C# Code Coach!".

But something is wrong.

Task:
Complete the code to generate the required output.
*/

/*
public class Program
{
    public static void Main(string[] args)
    {
        // Console.("My first C# Code Coach!");
        Console.WriteLine("My first C# Code Coach!"); 
    }
}
*/

// Lesson: Program Structure
/*
public class Program
{
public static void Main(string[] args)
    {
        Console.WriteLine("Hey!");
        Console.WriteLine("You are doing great!");
        Console.WriteLine("Keep it on!");
    }
}
*/

// Coding Practice: Program Structure
/*
The given program should output:
C# is awesome!
Coding is fun

But it seems the namespace is missing.

Task:
Fix the given code to generate the required output.
*/

/*
// using System;
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("C# is awesome!");
        Console.WriteLine("Coding is fun");
    }
}
*/

// Lesson: Basic concepts
/*
public class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hey!");
        //Console.WriteLine("Happy to see you here!");
        Console.Write("Nothing is impossible. ");
        Console.WriteLine("The word itself says 'I'm possible!");
        Console.WriteLine("-Audrey Hepburn");
    }
}
*/

// Lesson: Variables
/*
public class Program
{
    static void Main(string[] args)
    {
        //string name;
        //name = "James";
        //string name = "James";
        //Console.WriteLine(name);
        
        string name = "James";
        name = "Skywalker";
        
        Console.WriteLine(name);
    }
}
*/

// Coding Practice: Alphabet

/*
The given program declares a variable that holds all the letters of the English alphabet.

Task:
Complete the program to output the value of the variable.
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        //your code goes here
        Console.WriteLine(alphabet);
    }
}
*/

// Lesson: Data Types
/*
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("42");
        char label = 'A';
        int age = 42;
        float height = 1.82f;
        decimal weight = 92.8m;
        bool isOpen = true;
    }
}
*/

// Coding Practice: Name and Score

/*
The given program declares name and score variables, and assigns them their values.
Then, it outputs the name and the score values.
However, the code is missing the required types for the variables.

Task:
Add the required types to make the program work as expected.
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        //fix the code
        //name = "Tom";
        //score = 163;
        string name = "Tom";
        int score = 163;

        Console.WriteLine(name);
        Console.WriteLine(score);
    }
}
*/

// Lesson: Doing Math
/*
public class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine(5+4);
        //Console.WriteLine(6-3);
        
        //int x = 5;
        //int y = 4;
        //Console.WriteLine(x+y);

        //int z = x+y;
        //Console.WriteLine(z);

        //int amount = 54000;
        //int price = 1300;
        //int result = amount/price;

        //int x = 10;
        //int y = 3;
        //int result = x/y;
        //Console.WriteLine(result);

        int x = 2;
        int y = 3;
        int z = 4;
        // y*z will be calculated first
        Console.WriteLine(x+y-z);
    }
}
*/

// Coding Practice: Simple Operations

/*
Ever wondered how many seconds are there in a month (30 days) 🕰️?
Let's calculate it! 

Task:
Write a program to calculate and output the answer.

Hint:
Remember, there are 24 hours in a day, 60 minutes in an hour, and 60 seconds in a minute.
*/
public class Program
{
    static void Main(string[] args)
    {
        /* 30 days
        1 day = 24 hours
        1 hour = 60 minutes
        1 minute = 60 seconds */
        
        // your code goes here
        Console.WriteLine(30*24*60*60);
        
    }
}
