using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekk3_day_5
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Cat> catArmy = new List<Cat>();
            List<Turtle> turtleArmy = new List<Turtle>();

            Random rand = new Random();

            //Let's create our armies!!
            for (int i = 0; i < 100; i++)
            {
                if (rand.NextDouble() >= 0.5)    //returns a double 0.0 and 1.0.
                {
                    catArmy.Add(new Cat());
                }
                else
                {
                    turtleArmy.Add(new Turtle());
                }
                    
                    }
                }
            }
        }
    }
}
