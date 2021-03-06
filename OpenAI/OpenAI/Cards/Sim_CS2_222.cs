using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
	class Sim_CS2_222 : SimTemplate //stormwindchampion
	{

//    eure anderen diener haben +1/+1.
        public override void onAuraStarts(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnStormwindChamps++;
                foreach (Minion m in p.ownMinions)
                {
                    if (own.entityID != m.entityID) p.minionGetBuffed(m, 1, 1);
                }
            }
            else
            {
                p.anzEnemyStormwindChamps++;
                foreach (Minion m in p.enemyMinions)
                {
                    if (own.entityID != m.entityID) p.minionGetBuffed(m, 1, 1);
                }
            }

        }

        public override void onAuraEnds(Playfield p, Minion own)
        {
            if (own.own)
            {
                p.anzOwnStormwindChamps--;
                foreach (Minion m in p.ownMinions)
                {
                    if (own.entityID != m.entityID) p.minionGetBuffed(m, -1, -1);
                }
            }
            else
            {
                p.anzEnemyStormwindChamps--;
                foreach (Minion m in p.enemyMinions)
                {
                    if (own.entityID != m.entityID) p.minionGetBuffed(m, -1, -1);
                }
            }
        }

	}
}