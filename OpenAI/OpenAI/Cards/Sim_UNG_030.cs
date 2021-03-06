using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_UNG_030 : SimTemplate //Binding Heal
    {

        //Restore #5 Health to a minion and your hero.

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {

            int heal = (ownplay) ? p.getSpellHeal(5) : p.getEnemySpellHeal(5);
            p.minionGetDamageOrHeal(target, -heal);
            p.minionGetDamageOrHeal(p.ownHero, -heal);
        }

    }

}