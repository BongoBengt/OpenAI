using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_UNG_916 : SimTemplate //Stampede
    {

        //Each time you play a Beast this turn, add_a_random Beast to_your hand.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {

            p.Stampede++;
        }

    }

}