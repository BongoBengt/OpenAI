using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
	class Sim_FP1_003 : SimTemplate //echoingooze
	{

//    kampfschrei:/ beschwört am ende des zuges eine exakte kopie dieses dieners.
        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.playedThisTurn && triggerEffectMinion.own == turnEndOfOwner)
            {
                p.callKid(triggerEffectMinion.handcard.card, triggerEffectMinion.zonepos, turnEndOfOwner);
                List<Minion> temp = (turnEndOfOwner) ? p.ownMinions : p.enemyMinions;
                foreach (Minion mnn in temp)
                {
                    if (mnn.name == CardDB.cardName.echoingooze && triggerEffectMinion.entityID != mnn.entityID)
                    {
                        mnn.setMinionTominion(triggerEffectMinion);
                        break;
                    }
                }
            }
        }

	}
}