using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_AT_014 : SimTemplate //Shadowfiend
    {

        //Whenever you draw a card, reduce its Cost by (1).

        public override void onAuraStarts(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.anzOwnShadowfiends++;
            }
            else
            {
                p.anzEnemyShadowfiends++;
            }
        }

        public override void onAuraEnds(Playfield p, Minion m)
        {
            if (m.own)
            {
                p.anzOwnShadowfiends--;
            }
            else
            {
                p.anzEnemyShadowfiends--;
            }
        }



    }

}