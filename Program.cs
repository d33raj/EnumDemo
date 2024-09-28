using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    internal class Program
    {
        public enum Days // Enum is a value type that represent a collection of named constants and  also user defined type
                         // It stores integer value by default.
                         // We use Enum when we define a property or method which need to access specific values but not outside value,
                         // We define Enum for the specific values and user need to take inputs from it only.
        {
            Sunday, Monday, Tuesday, Wednesday,Thursday, Friday,Saturday  // We can also assign our own values to the constants instead of system generated values.
                                                                 // If we assign first value Sunday=2 then others follow sequence like Monday=3,Tuesday=4... and so on
        }
        static void Main(string[] args)
        {
            //Days d = 0;
            //Console.WriteLine(d); // Output will be Sunday because in Enum every constant is assigned a value by default and it starts with 0 followed by the sequence.

            // Days d1 = 1;   -----> This is not possible because we can access only first value of the enum by default value.
            // For any other values we need to explicitly typecast the Days to get the value from it.

            //Days d1 = (Days)1;
            //Console.WriteLine(d1); // It will give as Monday as we have done explicit casting to the integer value.

            //Days d2 = Days.Saturday; // We can also print the values by accessing them directly from enum instaed of giving value to it.
           //Console.WriteLine(d2);
            //Console.WriteLine((int)d2); // We can get the integer value stored in it by type casting it with int in the output.


            // For accessing every value theough loop we use predefined method called GetValues() which takes Type of enum as input so we used typeof() in out loop
            foreach (int i in Enum.GetValues(typeof(Days)))
            Console.WriteLine(i+ ": "+ (Days)i);
            
            // For Accessing the Names of the values we have GetNames() method
            //foreach(string s in Enum.GetNames(typeof(Days)))
            //    Console.WriteLine(s);


            // Code to demonstrate an example for Enum Usage 

            Days today = Days.Sunday;

            Console.WriteLine($"\nToday is: {today}");
            switch (today)
            {
                case Days.Sunday:
                    Console.WriteLine("It's the weekend! Time to relax.");
                    break;
                case Days.Monday:
                    Console.WriteLine("Back to work! It's Monday.");
                    break;
                case Days.Tuesday:
                    Console.WriteLine("It's Tuesday. Let's be productive.");
                    break;
                case Days.Wednesday:
                    Console.WriteLine("Midweek, it's Wednesday!");
                    break;
                case Days.Thursday:
                    Console.WriteLine("Thursday is here, almost the weekend.");
                    break;
                case Days.Friday:
                    Console.WriteLine("It's Friday! Weekend is near.");
                    break;
                case Days.Saturday:
                    Console.WriteLine("Saturday is here! Enjoy your day off.");
                    break;
                default:
                    Console.WriteLine("Invalid day.");
                    break;
            }

        }
    }
}
