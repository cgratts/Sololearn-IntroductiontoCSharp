// Module 5: Methods
using System;

// Lesson: Methods
/*
static void Welcome() 
{
    Console.WriteLine("Welcome");
    Console.WriteLine("I am a method");
    Console.WriteLine("End of method");
}

static void Main(string[] args)
{
    Welcome();
}
*/

// Coding Practice: Welcome, Sololearner!

/*
We have a method that outputs Welcome, user! as it is called.

Task:
We want to make it more personalized, so redesign the given method so that it will take the given input as the name of the user and output the welcome message with it.

Input Example: Tommy
Output Example: Welcome, Tommy!
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        // your code here: call the method
        Welcome();
    }

    static void Welcome()
    {
        // your code here: redesign the method
        string input = Console.ReadLine();
        Console.WriteLine($"Welcome, {input}!");
        
        //Console.WriteLine("Welcome, user!");
    }
}
*/

// Lesson: Parameters and Arguments

/*
static void Main(string[] args)
{
    Welcome("John", 25);
    Welcome("Tom", 36);
}
static void Welcome(string name, int age) 
{
    Console.WriteLine("Welcome " + name);
    Console.WriteLine("You age: " + age);
}

static void Perc(double num, int percentage)
{
    double res = num*percentage/100;
    Console.WriteLine(res);
}
*/

/*
static void Main(string[] args)
{
    Discount("Tom", 1700);
    Discount("Bob", 1300);
}
static void Discount(string name, double purchase)
{
    if(purchase>=1500)
    {
        purchase*=0.85;
    }

    Console.WriteLine($"Customer: {name}");
    Console.WriteLine($"Total: {purchase}");
}
*/

// Coding Practice: Feet to Inches Converter

/*
You need to make a function that converts a foot value to inches.
1 foot has 12 inches.
The given code takes the foot value as input and passes it to the Converter method.

Task:
Define a Converter method that takes the foot value as an argument and outputs the inches value.

Input Example: 8
Output Example: 96
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        double foot = Convert.ToDouble(Console.ReadLine());
        Converter(foot);
    }

    // your code goes here
    static void Converter(double feet)
    {
        int inches = Convert.ToInt32(feet*12);
        Console.WriteLine(inches);
    }
    
}
*/

// Lesson: Returning from Methods
/*
public class Program
{
    static double Perc(double num, int percentage)
    {
        double res = num*percentage/100;
        return res;
    }

    static void Main(string[] args)
    {
        double result = Perc(640,24);
        Console.WriteLine($"Result is: {result}");
    }
}
*/

// Coding Practice: Area Of a Rectangle

/*
We need to calculate the area of a given rectangle.
The given program takes the width and length as input.

Task:
Fix and complete the Area method, which takes the length and width as arguments, to calculate and return the area.
Then call the method for the given inputs.

Example Input:
7
4

Example Output:
28
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        int width = Convert.ToInt32(Console.ReadLine());
        int length = Convert.ToInt32(Console.ReadLine());

        // your code here: output the result
        Console.WriteLine(Area(width,length));
    }


    //static void Area()
    // your code here: fix the method
    static int Area(int w, int h)
    {
        return w*h;
    }
}
*/




