using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_UNG_803 : SimTemplate //Emerald Reaver
    {

        //Battlecry: Deal 1 damage to each hero.

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.minionGetDamageOrHeal (p.ownHero, 1);
            p.minionGetDamageOrHeal (p.enemyHero, 1);
        }

    }

}