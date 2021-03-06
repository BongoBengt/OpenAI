using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_UNG_034 : SimTemplate //Radiant Elemental
    {

        //Your spells cost (1) less.


        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnSorcerersApprentice++;
            }
            else
            {
                p.anzEnemysorcerersapprentice++;

            }

        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnSorcerersApprentice--;
            }
            else
            {
                p.anzEnemysorcerersapprentice--;
            }
        }
    }

}