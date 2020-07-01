using System;
using System.IO;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common 
            // DONE


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class
            // DONE

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class
            // DONE

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            //DONE - SEE BELOW
            var blueJay = new Bird("Blue Jay", false, "tweet!", true);
            Console.WriteLine(blueJay.Sing());
            Console.WriteLine(blueJay.Fly());
            Console.WriteLine(blueJay.Consume("seeds"));
            Console.WriteLine(blueJay.Reproduce());
            var rattlesnake = new Reptile("Rattlesnake", true, "hisss!", 0, false);
            Console.WriteLine(rattlesnake.Slither());
            Console.WriteLine(rattlesnake.Sunbathe());
            Console.WriteLine(rattlesnake.Noise);
            var turtle = new Reptile("Turtle", false, "gulp", 4, true);
            Console.WriteLine("Turtle trying to eat meat...");
            Console.WriteLine(turtle.Consume("meat"));
            Console.WriteLine("Turtle trying to slither...");
            Console.WriteLine(turtle.Slither());
            Console.WriteLine($"The Turtle can swim: {turtle.Swimming}");
            var squirrel = new Animal("Squirrel");
            Console.WriteLine(squirrel.Reproduce());
            
        }
    }
}
