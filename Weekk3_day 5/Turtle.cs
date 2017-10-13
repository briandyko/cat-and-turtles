using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekk3_day_5
{
    class Turtle
    {
        //This static variable belongs to CLASS.
        //It is shared among all instances.
        //This also means we can use the variable without creating instances first.
        static int turtleCount;    // you don't need a property for static field varibles

        public Turtle()
        {
            turtleCount++;
        }

        //This static method belongs to the class.
        //It's shared among all instances.
        //It means we can use the method with creating any instances first.
        //In Program class, that is why all methods are static - we do not want to have to create a new instance of the class Program
        public static void WarCry()
        {
            Console.WriteLine("We are an army of " + turtleCount + " turtles!");
        }
    }
}
