using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_GVG_047 : SimTemplate //Sabotage
    {

        //   Destroy a random enemy minion. Combo: And your opponent's weapon.


        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> temp = (ownplay)? p.enemyMinions : p.ownMinions;
            if (temp.Count >= 1)
            {
                p.minionGetDestroyed(p.searchRandomMinion(temp, (ownplay ? Playfield.searchmode.searchLowestAttack : Playfield.searchmode.searchHighestAttack)));
                
            }
            if (p.cardsPlayedThisTurn >= 1) p.lowerWeaponDurability(1000, !ownplay);
        }
    }
}