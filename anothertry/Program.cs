using System;

namespace anothertry
{
    class Program
    {
        static void Main(string[] args)
        {

            //find out how many dice the person wants to roll
            Console.WriteLine("Let's roll some dice!!");
            Console.WriteLine("How many dice would you like to roll?");
            var numDice = Convert.ToInt32(Console.ReadLine());


            //assign r the reference Random class in C#
            Random r = new Random(); 

            //create the array that will hold the rolls
            int roll1 = 0;
            int roll2 = 0;
            int sumRoll = 0;
            int[] rollTotal = new int[11];


            //
            for (int i = 0; i < numDice; i++)
            {
                // rolls the two dice and then add the rolls together for a total
                roll1 = r.Next(1, 7);
                roll2 = r.Next(1, 7);
                sumRoll = roll1 + roll2;

                //record this in the correct spot of the array as a time this total has been rolled
                rollTotal[sumRoll -2]++;

            } //  end for loop to determine the rolls

            // display a discrition of the histogram and showing the number of rolls inputed by user
            Console.Write("Each '*' represents 1% of the rolls.");
            Console.Write("Total number of rolls = " + numDice);


            //initialize percentage vairable as integer at 0
            int thisPerc = 0;

            //for loop to determine each number's percentage of rolls
            for (int i = 0; i < 11; i++)
            {
                //calculate the % using the cast feature
                thisPerc = (int)((rollTotal[i] / (float)numDice) *100);

                //initialize to empty string
                string stars = "";

                //build the string to hold the amount of stars equal to its percentage points
                for (int j = 0; j < thisPerc; j++)
                {
                    stars = stars + "*";
                }//end for of build string


                //write the string
                Console.WriteLine("\n" + (i+2) + ": " + stars);


            } //  end for loop to print the histogram
            
        }// end Main
    }// end class Program
}// end namespace 


