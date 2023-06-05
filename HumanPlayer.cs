using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        //created an int variable the user can input
        int humanRoll;
        public override int Roll()
        {

            Console.WriteLine($"What number would you like to roll {Name}?");
            humanRoll = int.Parse(Console.ReadLine());
            // make sure the human is rolling between 1 and 6 like a normal 6 sided die would roll
            if (humanRoll >= 1 && humanRoll <= 6)
            {
                return humanRoll;
            }
            else
            {
                Console.WriteLine("Hey! Thats not tournament regulation dice! Try again!");
                humanRoll = int.Parse(Console.ReadLine());
                return humanRoll;
            }
        }
    }
}