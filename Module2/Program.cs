﻿// Module 2: Operators and Strings
using System;

// Lesson: Arithmetic Operators
/*
public class Program
{
    static void Main(string[] args)
    {
        int x = 8;
        int y = 3;

        Console.WriteLine(x+y); // addition
        Console.WriteLine(x-y); // subtraction
        Console.WriteLine(x*y); // multiplication
        Console.WriteLine(x/y); // division   

        int balls = 100;
        int ballsInBox = 3;
        int result = balls%ballsInBox;

        Console.WriteLine(result);

        int points = 10;
        Console.Write("Your score: ");
        Console.WriteLine(points);
        
        //good shot!
        points++;

        Console.Write("Your score: ");
        Console.WriteLine(points);

        Console.Write("Your score: ");
        Console.WriteLine(points);
        
        //hit an ally
        points--;

        Console.Write("Your score: ");
        Console.WriteLine(points);

        Console.WriteLine(x++);
        Console.WriteLine(x);
        Console.WriteLine(++x);
    }
}
*/

// Coding Practice: Gift Boxes

/*
You are making gift boxes 🎁. Each box contains 9 items.

Task:
Given 200 items in total, you need to calculate and output how many items will be left over if you create gift boxes from all of the items.
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        int items = 200;
        int itemInBox = 9;

        //your code goes here
        int remainder = items % 9;
        Console.WriteLine(remainder);
    }
}
*/

// Lesson: Assignment Operators
/*
public class Program
{
    static void Main(string[] args)
    {
        double weight = 75.5;
        int x = 6, y = 7, z = 8;
        int score = 100;
        //score = score +10;
        score+=10;

        int x = 15;
        x+=5; // x = x+5;
        x-=5; // x = x-5;
        x*=5; // x = x*5;
        x/=5; // x = x/5;
        x%=5; // x = x%5;

        double price = 50;
        double rate = 1.2;
        price*=rate;// price = price*rate;
    }
}
*/

// Coding Practice: Bank Account Balance

/*
You want to withdraw some money from your bank account.
The given program declares balance and withdraw variables and assigns them values.

Task:
Calculate and output the remaining balance after the withdrawal.
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        int balance = 416500;
        int withdraw = 160000;

        // your code goes here
        Console.WriteLine(balance-=withdraw);
    }
}
*/

// Lesson: User Input

/*
public class Program
{
    static void Main(string[] args)
    {
        string nickname;
        nickname = Console.ReadLine();

        Console.Write("Welcome, ");
        Console.WriteLine(nickname);

        string text = "5";
        int number = Convert.ToInt32(text);
        text = Convert.ToString(number);

        //string text = "hello";
        //int number = Convert.ToInt32(text);// error

        // taking inputs
        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();

        // converting to int
        int number1 = Convert.ToInt32(input1);
        int number2 = Convert.ToInt32(input2);

        // calculating the sum
        int result = number1 + number2;

        // taking inputs and
        // converting them to int
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        // calculating the sum
        int result = x + y;
    }
}
*/

// Coding Practice: Chess Tournament

/*
You are making a program for a chess tournament that needs to calculate the points earned by a player.
A win is worth 1 point, while a tie is worth 0.5 points.
The given program declares two variables: wins and ties.

Task:
Create a program to take the values for wins and ties as input, then calculate and output the points earned by the player.

Hint:
Multiply the ties value by 0.5, to get the points earned for ties.
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        int wins;
        int ties;

        //your code goes here
        string i1 = Console.ReadLine();
        string i2 = Console.ReadLine();

        wins = Convert.ToInt32(i1);
        ties = Convert.ToInt32(i2);

        Console.WriteLine(wins + (ties*0.5));
        
    }
}
*/

// Lesson: More on Strings
/*
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("He said \"I am back!\"");
        Console.WriteLine("One \nTwo \nThree");
        Console.WriteLine("\t hey \t there");
        Console.WriteLine(@"Hey!
        I'm a verbatim string.");
    }
}
*/

// Coding Practice: Strings

/*
The given code declares a text variable with a value of "ABCD".

Task:
Write a program to output each letter on a separate line, like this 👇:

A

B

C

D
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        string text = "ABCD";
        Console.WriteLine(text[0] + "\n" + text[1] + "\n" + text[2] + "\n" + text[3]);
        
        
    }
}
*/

// Lesson: Concatenation and Interpolation
/*
public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Solo" +"learn");
        Console.WriteLine("2" + "2");

        string text1 = "C";
        string text2 = "#";
        string result = text1 + text2;

        Console.WriteLine("Hakuna" + " " + "Matata!");

        string name = Console.ReadLine();
        Console.WriteLine(name + " is an awesome Sololearner!");
        Console.WriteLine(name + " learns!");
        Console.WriteLine(name + " practises!");
        Console.WriteLine("Be like " + name + "!");

        string city = "London";
        Console.WriteLine($"{city} is the capital of the United Kingdom.");
    }
}
*/

// Coding Practice: Country Cards

/*
You need to make country cards for a school project 📇.
The given program takes the country and the name of its capital name as input.

Task:
Complete the code to output a string in the format you are given in the sample output 👇.

Sample Input:
Portugal
Lisbon

Sample Output:
Country: Portugal, Capital: Lisbon
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        string country = Console.ReadLine();
        string capital = Console.ReadLine();

        // your code goes here
        Console.WriteLine($"Country: {country}, Capital: {capital}");
    }
}
*/
