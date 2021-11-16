using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_C
{
    class Player
    {
        public int wins;
        public string choice;
        public string[] gestures = new string[5];

        public Player()
        {
            gestures[0] = "rock";
            gestures[1] = "paper";
            gestures[2] = "scissors";
            gestures[3] = "lizard";
            gestures[4] = "spock";
        }

        public virtual string Make_choice()
        {
            return "";
        }

        public virtual string Make_choice(int round, int opponent_wins)
        {
            return "";
        }
    }
}
