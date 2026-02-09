namespace Topic_2___Numbers_and_Math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Topic 2 - Math and Numbers";

            // Prints a statement
            Console.WriteLine("I will now count my chickens:");

            /* 
               plus is + 
               minus is -
               times is *
               divided is /
               power is ^
               square root is Math.Sqrt() but for ths you need to use the module System
               % is the modulus operator. It gives you the remainder of a division.
            */

            // Prints the number of hens and roosters
            Console.WriteLine(" ");
            Console.WriteLine("Hens " + (10 + 5 * 2)); 
            Console.WriteLine("Roosters " + (25 + 30 / 6));

            Console.WriteLine(" ");
            Console.WriteLine("six" + 6);
            // Prediction: six6 (string + number)

            Console.WriteLine("6 + 6");
            // Prediction: 6 + 6 (string)

            Console.WriteLine("6" + 6);
            // Prediction: 66 (String + number)

            Console.WriteLine(6 + 6);
            // Prediction: 12 (number + number)

            Console.WriteLine(" ");
            Console.WriteLine("Now I will count the eggs");
            Console.WriteLine(11 / 2);
            /* Output: 5 (integer) 
             However, it should be a decimal because a odd # is divided by 2.
            */

            // A float is a decimal number. 
            // A integer is a whole number.

            Console.WriteLine(11.0 / 2);
            // Changes the "11" to a float by adding ".0" so the output will be 5.5

            Console.WriteLine(" ");
            Console.WriteLine("Is it true that 3 + 2 < 5 - 7?");
            Console.WriteLine(3 + 2 < 5 - 7);
            // Output: False

            Console.WriteLine(" ");
            Console.WriteLine("What is 3 +2? " + (3 + 2));
            Console.WriteLine("What is 5 -7? " + (5 - 7));
            Console.WriteLine("Oh, that's why it's " + (3 + 2 < 5 - 7));

            // Putting numbers inside quotes makes them strings

            // A Boolean is either true or false. (<, >, <=, >=, ==, !=)

            // Programming Tasks 

            Console.WriteLine(" ");
            Console.WriteLine("I worked for 8 hours today. I earn $21 per hour.");
            Console.WriteLine("I made " + (8 * 21).ToString("C") + " today!");
            /*
             The "C" in ToString() stands for currency.
             It formats the number as currency. 
             In this case, it will display $168.00.
            */

            Console.WriteLine(" ");
            Console.WriteLine("I have 5.5 eggs. How much does each egg cost if a dozen of eggs costs $6");
            Console.WriteLine("Each individual egg would cost " + (6.0/ 12).ToString("C") + ".");

            Console.WriteLine(" ");
            Console.WriteLine("Calculate the tax (13%) on a item that costs $79.99.");
            Console.WriteLine("The item with tax would cost " + (79.99 * 1.13).ToString("C") + ".");

            Console.WriteLine(" ");
            Console.WriteLine("Calculate how many centimeters are in 5'6.");
            Console.WriteLine("There are " + (5 * (12 * 2.54) + (6 * 2.54)) + (" centimeters in 5'6."));

        }
    }
}












