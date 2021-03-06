﻿using System;

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
            Console.WriteLine("Press 1 to begin");
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
            values = new int[2];
            Random rnd = new Random();
            int rndoption = rnd.Next(1, 11);
            int rndoption2 = rnd.Next(1, 11);
            AddSum(rndoption);
            AddSum(rndoption2);
            Console.WriteLine("Cards drawn: ");
            Console.WriteLine(rndoption);
            Console.WriteLine(rndoption2);

            Console.WriteLine("Current number: " + sum);
            Console.WriteLine("Press 1 to draw again");
            Console.WriteLine("Press 2 to hold");
            option = Convert.ToInt32(Console.ReadLine());

            while (option == 1)
            {
                rndoption = rnd.Next(1, 11);


                values[0] = rndoption;
                values[1] = rndoption2;
                if (sum > 21)
                {
                    Console.WriteLine("You lose!");
                    break;

                }

                if (rndoption == 11 && sum + 11 > 21)
                {
                    rndoption = 1;
                }
                AddSum(rndoption);
                Console.WriteLine(rndoption);
                Console.WriteLine("Current number: " + sum);
                Console.WriteLine("Press 1 to draw again");
                Console.WriteLine("Press 2 to hold");
                option = Convert.ToInt32(Console.ReadLine());



            }
            ///Holds cards while AI pulls its cards
            while (option == 2)
            {
                Random rnd2 = new Random();
                int rndAI = rnd2.Next(17, 26);
                Console.WriteLine("Current number: " + sum);
                Console.WriteLine("AI number:" + rndAI);

                ///Shows results


                if (sum > rndAI || sum == 21)
                {
                    Console.WriteLine("Player wins");
                    break;

                }
                else if (rndAI > 21)
                {
                    Console.WriteLine("Player wins");
                    break;
                }
                else if (sum == rndAI)
                {
                    Console.WriteLine("Tie!");
                    break;
                }
                else
                {
                    Console.WriteLine("AI wins!");
                    break;
                }
            }

            {

            }

        }

    }
}