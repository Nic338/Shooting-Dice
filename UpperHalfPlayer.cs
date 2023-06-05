using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player whose role will always be in the upper half of their possible rolls
    public class UpperHalfPlayer : Player
    {
        public override int Roll()
        {
            //create a variable that is half of the max of the diceSize
            int halfOfDice = DiceSize / 2;
            //return a random number STARTING at the half of the dice size
            return new Random().Next(halfOfDice, DiceSize) + 1;
        }
    }
}