using System;

namespace BlackJack
{
    class Program
    {
        static int sum = 0;
        /// <summary>
        /// Asks to press one to draw card
        /// </summary>
        /// <returns> 1 to draw a card </returns>
        static int StartOption()
        {
            Console.WriteLine("Press 1 to draw.");
            int option = Convert.ToInt32(Console.ReadLine());
            return option;
        }
        /// <summary>
        /// suma nuevos cartas con la carta presente
        /// </summary>
        /// <param name="rndoption">Es la carta random</param>
        static void AddSum(int rndoption)
        {
            sum = sum + rndoption;
        }


        static void Main(string[] args)
        {
            int option = StartOption();
            Int32[] values;
            values = new int[1];
            while (option == 1)
            {
                Random rnd = new Random();
                int rndoption = rnd.Next(1, 11);
                values[0] = rndoption;
                AddSum(rndoption);
                Console.WriteLine("Current number: " + sum);
                Console.WriteLine("Press 1 to draw again");
                Console.WriteLine("Press 2 to hold");
                option = Convert.ToInt32(Console.ReadLine());

                if (sum > 21)
                {
                    Console.WriteLine("You lose!");
                    break;

                }
            }
            ///Holds cards while AI pulls its cards
            while (option == 2)
            {
                Random rnd = new Random();
                int rndAI = rnd.Next(17, 26);
                Console.WriteLine("Current number: " + sum);
                Console.WriteLine("AI number:" + rndAI);

                ///Shows results
                

                if(sum > rndAI || sum == 21)
                {
                    Console.WriteLine("Player wins");
                    break;
                    
                }
                else if(rndAI > 21){
                    Console.WriteLine("Player wins");
                    break;
                }
                else if (sum == rndAI)
                {
                    Console.WriteLine("Tie!");
                    break;
                }
                else{
                    Console.WriteLine("AI wins!");
                    break;
                }
            }
                
            {
                
            }

        }

    }
}