using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_AT_006 : SimTemplate //Dalaran Aspirant
    {

        //insprire: gain Spell Damage +1

        public override void onInspire(Playfield p, Minion m)
        {
            m.spellpower++;
            if (m.own)
            {
                p.spellpower++;
            }
            else
            {
                p.enemyspellpower++;
            }
        }



    }

}