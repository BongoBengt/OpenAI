using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_GVG_027 : SimTemplate //Iron Sensei
    {

        //   At the end of your turn, give another friendly Mech +2/+2.

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (turnEndOfOwner == triggerEffectMinion.own)
            {
                List<Minion> temp = (turnEndOfOwner) ? p.ownMinions : p.enemyMinions;
                List<Minion> tempmech = new List<Minion>();
                foreach (Minion m in temp)
                {
                    if ((TAG_RACE)m.handcard.card.race == TAG_RACE.MECHANICAL)
                    {
                        tempmech.Add(m);
                    }
                }
                if (tempmech.Count >= 1)
                {
                    p.minionGetBuffed(p.searchRandomMinion(tempmech, (triggerEffectMinion.own ? Playfield.searchmode.searchLowestHP : Playfield.searchmode.searchHighestHP)), 2, 2);
                }
            }
        }
    }
}