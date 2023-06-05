using System;
using System.Collections.Generic;
using System.Linq;

namespace ShootingDice
{
    // A SmackTalkingPlayer who randomly selects a taunt from a list to say to the other player
    public class CreativeSmackTalkingPlayer : Player
    {
        private List<string> _Taunts {get;} = new List<string>()
        {"Your mothers an ugly goblin", "Sheesh, try to actually roll the dice this time","You could roll twice and still not beat me","I hope you got a lot of money on ya, because this is gonna hurt","Go ahead and bet it all, you're worthless anyway","I can't believe they put me up against people like this", "Who cares what time it is, theres always time to embarass another sad sap like yourself","I'll make sure to call the whambulance for you since all you do is whine" };


        public override int Roll()
        {
            int randomTaunt = new Random().Next(_Taunts.Count);
            Console.WriteLine(_Taunts[randomTaunt]);
            return base.Roll();
        }
    }
}