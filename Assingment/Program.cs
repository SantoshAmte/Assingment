using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment
{
    class Program
    {
        public class CountWords
        {

            // Write a C# Program to Count Number of Words in a String 
            public static void Main()
            {
                String sentence = "Beauty lies in the eyes of beholder";
                int wordCount = 0;

                for (int i = 0; i < sentence.Length - 1; i++)
                {
                    if (sentence[i] == ' ' && Char.IsLetter(sentence[i + 1]) && (i > 0))
                    {
                        wordCount++;
                    }
                }

                wordCount++;

                Console.WriteLine("Total number of words in the given string: " + wordCount);
            }

        }
        class Assignment
        {
            // Write a C# Program to average of 3 numbers and print 
            static void Main(string[] args)
            {
                int number1, number2, number3, avarage;

                Console.Write("Enter 1st number :");
                number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter 2nd number :");
                number2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter 3rd number :");
                number3 = Convert.ToInt32(Console.ReadLine());

                avarage = (number1 + number2 + number3) / 3;

                Console.Write("Avarage of three numbers is {0}", avarage);

                Console.ReadKey();
            }
        }

        public class Example
        {

            //  Write a asp.net Program to Demonstrate DivideByZero Exception using  try..catch. 

            public static void Main()
            {
                int number1 = 3000;
                int number2 = 0;
                try
                {
                    Console.WriteLine(number1 / number2);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Division of {0} by zero.", number1);
                }
            }
        }

        class Timespanex
        {

            // Write a asp.net Program to find the sum of two specified times using  Timespan 

            static void Main()
            {
                TimeSpan time;

                TimeSpan ts1 = new TimeSpan(10, 20, 50);
                TimeSpan ts2 = new TimeSpan(8, 19, 32);

                time = ts1 + ts2;

                Console.WriteLine("Hours:{0}, Minutes:{1}, Seconds:{2}", time.Hours, time.Minutes, time.Seconds);
            }
        }

        class datecompaire
        {
            //Write a asp.net Program to compare two dates and print the earlier date  

            static void Main(string[] args)
            {
                string date = "01/04/2013";
                DateTime myDate = DateTime.ParseExact(date, "dd/MM/yyyy",
                                           System.Globalization.CultureInfo.InvariantCulture);
                if (myDate > DateTime.Today)
                {
                    Console.WriteLine("greater than");
                }
                else
                {
                    Console.WriteLine("Less Than");
                }
            }
        }

        class Geeks
        {

            // Write a C# Program to enter two float input values and Multiply print roundup by 2 digit after decimal 

            public static void Main()
            {
                double[] val = { 4.125, 4.135, 4.165, 4.175 };

                Console.WriteLine("Rounded values are:");
                foreach (double value in val)
                    Console.WriteLine("{0} == {1}", value, Math.Round(value, 2,
                                                     MidpointRounding.ToEven));

            }
        }
    }
}

