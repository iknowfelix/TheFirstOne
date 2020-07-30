using System;

namespace Conditionals
{
    class Program
    {
        // Comparisson operators: <, >, <=, >=
        // == equal to; && AND; || OR; ! Not

        static void Main(string[] args)
        {
            // setting up my boolean variables
            bool isitRaining = true;
            bool isitWinter = false;

            // is it presently raining?
            if (isitRaining == true)
            {
                Console.WriteLine("Close the bloody window");
            }

            // are we in winter? YES
            else if (isitWinter == true)
            {
                Console.WriteLine("Close the bloody window and turn the pissing heater on!");
            }

            // are we in winter? No
            else
            {
                Console.WriteLine("Open the window and let some bloody air in!");
            }

            // using other operators for is it not winter
            if (isitWinter != true)
            {
                Console.WriteLine("The bastard has gone and used an exclamation mark! And open that fucking window.");
            }

            // More complex questions
            // Is it raining and its winter
            if ((isitRaining == true) && (isitWinter == true))
            {
                Console.WriteLine("Bugger me, its raining and its winter");
            }

            //Is it raining or is it winter. Result if one is correct
            if ((isitRaining == true) || (isitWinter ==  true))
            {
                Console.WriteLine("Well, its either winter or its raining");
            }

            //Using negation. Is it raining but not winter
            if ((isitRaining == true) && !(isitWinter == true))
            {
                Console.WriteLine("Its raining but not winter.");
            }

        }
    }
}
