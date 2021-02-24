using System;

namespace BlackJack
{
    class Program
    {
        /// <summary>
        /// Asks to press one to draw card
        /// </summary>
        /// <returns> 1 to draw a card </returns>
        static int StartOption(){
            Console.WriteLine("Press 1 to draw.");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }      

        static void Main(string[] args)
        {
            int option = StartOption();
             Int32[] values;
             values = new int[2];
            if (option == 1)
            {
            Random rnd = new Random();
            int rndoption = rnd.Next(1, 11);
            values[0] = rndoption;
            Console.WriteLine("Current number: " + rndoption );
            }
            Console.WriteLine("(1)Draw again?");
            Console.WriteLine("(2)Hold cards?");
            

        }
    }
}
