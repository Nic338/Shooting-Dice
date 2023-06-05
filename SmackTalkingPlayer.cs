using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A Player who shouts a taunt every time they roll dice
    public class SmackTalkingPlayer : Player
    {
        public string Taunt { get; } = "You're trash and so are your rolls";

        public override int Roll()
        {
            // added Console.WriteLine of a taunt before each roll
            Console.WriteLine(Taunt);
            return base.Roll();
        }
    }

}