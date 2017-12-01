using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.Create two variables called name and age. Work out what type you need to use for these.
            string name;
            int age;

            //2.Set the value for name and age to something(you don't have to be honest!)    
            name = "lindsay";
            age = 29;

            //3.Print out your name and age using the variables.
            Console.WriteLine(name);
            Console.WriteLine(age);

            //4.Modify your print statements to print out something more informative, such as: "My age is... 21".You should use the string concatenation symbol, +
            Console.WriteLine("My name is " + name + " and I am " + age + " yrs old.");

            //5.Reassign your age to be something different and print it out.
            age = 30;
            Console.WriteLine("My name is {0} and I am {1} yrs old.", name, age);

            /* 6. Write an expression that calculates the equation of a line and prints out each part to the screen.
                The equation is: y = m * x + c
                Where m is 1, x is 0.5 and c is 15
                You need to calculate the value of y(it may not be a whole number, 
                so make sure you get the correct value rather than a rounded one.) */
            int m = 1;
            float x = 0.5F;
            int c = 15;
            float y = m * x + c;
            Console.WriteLine("y is {0}", y);

            //7.Create a boolean value for isRaining and give it a value.
            bool isRaining = true;


            //8.Create another boolean, happy and give it a different value to isRaining
            bool happy = false;

            //9.Combine the two booleans using the logical operators(and, or, not) to print out an appropriate message when:

            //a.it is raining and we're happy
            if (isRaining && happy)
                Console.WriteLine("I'm singing in the rain!");

            //b.it is raining and we're not happy
            if (isRaining && !happy)
                Console.WriteLine("I'm stuck inside!");

            //c.it is not raining and we're happy
            if (!isRaining && happy)
                Console.WriteLine("The sun has got his hat on!");

            //d.it is not raining and we're not happy
            if (!isRaining && !happy)
                Console.WriteLine("Think of the plants!!");

            //Then change the 'and' in the sentences to 'or'.Notice the difference it makes when you use or in a statement. 
            //a.it is raining and we're happy
            if (isRaining || happy)
                Console.WriteLine("Its raining and Im happy or unhappy, or its not raining and Im happy.");

            //b.it is raining and we're not happy
            if (isRaining || !happy)
                Console.WriteLine("Its raining and Im happy or not happy, or its not raining and Im not happy.");

            //c.it is not raining and we're happy
            if (!isRaining || happy)
                Console.WriteLine("Its not raining and Im happy or not happy, or its raining and Im happy.");

            //d.it is not raining and we're not happy
            if (!isRaining || !happy)
                Console.WriteLine("When its not raining I could be happy or not happy, or it's raining and Im not happy!!");

            // This line is just to pause execution so you can read the screen before it exits
            Console.ReadLine();


        }
    }
}
