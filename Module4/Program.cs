// Module 4: Loops
using System;

// Lesson: The for loop
/*
public class Program
{
    static void Main(string[] args)
    {
       for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Value of i: {i}");
        }

        for(int j=5; j>=0; j--)
        {
            Console.WriteLine($"Bullets: {j}");
        }
    }
}
*/

// Coding Practice: Factorial

/*
The factorial of a number N is equal to 1 * 2 * 3 * ... * N
For example, the factorial of 5 is 1 * 2 * 3 * 4 * 5 = 120.
The given program takes a number from the input.

Task:
Create a program to calculate and output the factorial of that input number.
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        // your code goes here
        int factorial = 1;

        for(int i = 1; i <= num; i++)
        {   
            factorial *= i;   
        }
        Console.WriteLine(factorial);
    }
}*/

// Lesson: The while loop
/*
public class Program
{
    static void Main(string[] args)
    {
        int x = 5;

        while(x>0)
        {
            Console.WriteLine(x);
            x--;
        }

        int sum = 0;
        int num = 100;

        while(num>=0)
        {
            sum+=num;
            num--;
        }

        Console.WriteLine(sum);

        int i = 5;

        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 5);
    }
}
*/

// Coding Practice: Sum

/*
Your math teacher asked you to calculate the sum of the numbers 1 to N, where N is a given number.
The given program takes a number as input.

Task:
Write code to output the sum of the numbers from 1 to that number, inclusive.

Input Example: 10
Output Example: 55
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        int num = Convert.ToInt32(Console.ReadLine());

        // your code goes here
        int sum = 0;
        while(num > 0)
        {
            sum += num;
            num--;
        }
        Console.WriteLine(sum);
    }
}*/

// Lesson: break and continue
/*
public class Program
{
    static void Main(string[] args)
    {
        int num = 1;

        while(num<=10)
        {
            if(num == 3)
            {
                break;
            }
            Console.WriteLine(num);
            num++;
        }

        for(int i = 0; i<=10; i++)
        {
            if(i==5)
            {
            continue;
            }
            Console.WriteLine(i);
        }
    }
}
*/

// Coding Practice: Break The Loop

/*
The given code declares a loop and calculates the multiplication of all numbers from 1 to 10000.

Task:
Make the necessary changes to break the loop when the result is larger than 10000 and output the result.

Hint:
Use an if statement inside the loop and break the loop based on the given condition.
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        int num = 1;

        for(int i = 1; i<=100; i++)
        {
            //your code goes here
            if(num > 10000)
            {
                break;
            }

            num*=i;
        }
        Console.WriteLine(num);
    }
}
*/