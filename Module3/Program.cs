// Module 3: Decision Making
using System;

// Lesson: Comparison Operators
/*
public class Program
{
    static void Main(string[] args)
    {
        bool isActive = true;
        bool isHoliday = false;

        int score = 85;
        Console.WriteLine(score>99);

        int x = 7;
        Console.WriteLine(x == 7);
        Console.WriteLine(x!=8);
        Console.WriteLine(x > 10);
        Console.WriteLine(x < 2);
        Console.WriteLine(x >= 7);
        Console.WriteLine(x <= 7);

        string password = "Xn5fg";
        string repeat = "Xn5fg";
        Console.WriteLine(password==repeat);
        Console.WriteLine(password!=repeat);
    }
}
*/

// Lesson: The if statement
/*
public class Program
{
    static void Main(string[] args)
    {
        int purchase = 1400;
        
        if (purchase>=1500)
        {
            Console.WriteLine("Discount!");
        }

        Console.WriteLine("Do you enjoy learning?");
        string answer = Console.ReadLine();
        
        if(answer == "Yes")
        {
            Console.WriteLine("You are awesome!");
        }

        int num = 12;
        
        if(num > 5)
        {
            Console.WriteLine("Bigger than 5");
            if(num<47)
            {
                Console.WriteLine("Between 5 and 47");
            }
        }
    }
}
*/

// Coding Practice: Take your kindle!

/*
Airlines are offering a special promotion for teenagers and are offering kindles to use during the flight.
The given program takes the passengers` age as input.

Task:
Write a program to output Take your kindle , if the age is under or equal to 19.

Sample Input:
14

Sample Output:
Take your kindle
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        int age = Convert.ToInt32(Console.ReadLine());

        // your code goes here
        if(age <= 19)
        {
            Console.WriteLine("Take your kindle");
        }
    }
}
*/

// Lesson: The else if statement
/*
public class Program
{
    static void Main(string[] args)
    {
        string stopLight = "green";
        
        if(stopLight == "red")
        {
            Console.WriteLine("Stop!");
        } 
        else if(stopLight == "yellow")
        {
            Console.WriteLine("Slow down.");
        }
        else if(stopLight == "green")
        {
            Console.WriteLine("Go!");
        }
        else
        {
            Console.WriteLine("Unknown.");
        }
    }
}
*/

// Coding Practice: Organized Robot

/*
You are developing a program that will be used in a robot that categorizes items by their color.
Each color corresponds to a box with a specific number.

For simplicity, our program will handle 3 colors:

red goes to box #1
green goes to box #2
black goes to box #3

Your program needs to take color as input and output the corresponding box in the given format.
In the case of an unsupported colors, the program should output unknown.

Input Example: green

Output Example: box #2
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        string color = Console.ReadLine();

        // your code goes here
        if(color == "red")
        {
            Console.WriteLine("box #1");
        }
        else if (color == "green")
        {
            Console.WriteLine("box #2");
        }
        else if (color == "black")
        {
            Console.WriteLine("box #3");
        }
        else
        {
            Console.WriteLine("unknown");
        }
    }
}
*/

// Lesson: Logical Operators
/*
public class Program
{
    static void Main(string[] args)
    {
        int points = 95;
        int keys = 2;

        if(points>=90 && keys >=2)
        {
            Console.WriteLine("Level Completed!");
        }
        else
        {
            Console.WriteLine("Try again!");
        }

        int hour = 18;
        string day = "Sunday";

        if(hour>20 || day=="Sunday")
        {
            Console.WriteLine("Closed");
        }
        else
        {
            Console.WriteLine("Opened");
        }

        day = "Monday";

        if( !(day=="Sunday"))
        {
            Console.WriteLine("Working day");
        }
        else
        {
            Console.WriteLine("Non-working day");
        }

        string country = "US";
        int age = 42;

        if ((country == "US" || country == "GB") &&(age >0 && age <=100))
        {
            Console.WriteLine("Welcome!");
        }
    }
}
*/

// Coding Practice: Age Groups

/*
The given program takes the age of a person as input.

Task:
Write a program to output their age group.
Here are the age groups you need to handle:

Child: 0 to 11
Teen: 12 to 17
Adult: 18 to 64

Input Example: 42
Output Example: Adult
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        int age = Convert.ToInt32(Console.ReadLine());

        // your code goes here
        if(age >= 0 && age <= 11)
        {
            Console.WriteLine("Child");
        }
        else if(age >=12 && age <= 17)
        {
            Console.WriteLine("Teen");
        }
        else if(age >= 18 && age <= 64)
        {
            Console.WriteLine("Adult");
        }
    }
}
*/

// Lesson: The switch statement
/*
public class Program
{
    static void Main(string[] args)
    {
        int choice = 2;
        switch(choice)
        {
            case 1:
            Console.WriteLine("Sports");
            break;
            
        case 2:
            //match!
            Console.WriteLine("Business");
            break;
            
        case 3:
            Console.WriteLine("Technology");
            break;
        }

        string color = "yellow";
        switch(color)
        {
            case "blue": 
                Console.WriteLine("This is blue.");
                break;
            case "red": 
                Console.WriteLine("This is red.");
                break;
            default: 
                Console.WriteLine("Color not found.");
                break;
        }
    }
}
*/

// Coding Practice: Coffee Time!

/*
A coffee vending machine makes 3 types of coffee:

1 - Americano
2 - Espresso
3 - Cappuccino

The given program takes the number from the customer as input.

Task:
Complete the program to serve the corresponding coffee type. It should output Unknown if there is no match.

Input Example: 2
Output Example: Espresso
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        int choice = Convert.ToInt32(Console.ReadLine());

        // your code goes here
        switch(choice)
        {
            case 1:
                Console.WriteLine("Americano");
                break;
            case 2:
                Console.WriteLine("Espresso");
                break;
            case 3:
                Console.WriteLine("Cappuccino");
                break;
            default:
                Console.WriteLine("Unknown");
                break;            
        }
    }
}
*/

// Lesson: The Ternary Operator
/*
public class Program
{
    static void Main(string[] args)
    {
        int age = 42;
        string isAdult = age<18 ? "Too young": "Old enough";

        Console.WriteLine(isAdult);

        double bill = 1800;
        bill = bill>=1500 ? bill * 0.85 : bill;

        Console.WriteLine(bill);
    }
}
*/

// Coding Practice: Noon Or Midnight

/*
Time flies when you’re having fun.
You are given a digital clock that measures time over a 24 hour day, and a program that takes the hour of the day as input.

Task:
Complete the program so that it outputs AM to the console if the time is between 0 and 12 (inclusive), and outputs PM if the time is between 13 and 24 (inclusive).

Input Example: 13
Output Example: PM
*/

/*
public class Program
{
    static void Main(string[] args)
    {
        int hour = Convert.ToInt32(Console.ReadLine());

        // your code goes here
        string time = hour >= 0 && hour <= 12? "AM": "PM";
        Console.WriteLine(time);
    }
}
*/