using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who always rolls in the upper half of their possible role and
    //  who throws an exception when they lose to the other player
    public class SoreLoserUpperHalfPlayer : Player
    {
        public override int Roll()
        {
            int halfOfDice = DiceSize / 2;
            return new Random().Next(halfOfDice, DiceSize) + 1;
        }
        public override void Play(Player other)
        {
            try
            {

            int myRoll = Roll();
            int otherRoll = other.Roll();

            Console.WriteLine($"{Name} rolls a {myRoll}");
            Console.WriteLine($"{other.Name} rolls a {otherRoll}");
            if (myRoll > otherRoll)
            {
                Console.WriteLine($"{Name} Wins!");
            }
            else if (myRoll < otherRoll)
            {
                Console.WriteLine($"{other.Name} Wins!");
                throw new Exception("I DIDNT LOSE SHUT UP");
            }
            else
            {
                // if the rolls are equal it's a tie
                Console.WriteLine("It's a tie");
            }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}