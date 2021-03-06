using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
	class Sim_BRMA14_5H : SimTemplate //* 4/4 toxitron
	{
		//   At the start of your turn, deal 1 damage to all other minions.

		public override void onTurnStartTrigger(Playfield p, Minion triggerEffectMinion, bool turnStartOfOwner)
		{
		   if (triggerEffectMinion.own == turnStartOfOwner)
		   {
				foreach (Minion m in p.enemyMinions)
				{
				   if (triggerEffectMinion.entityID != m.entityID) p.minionGetDamageOrHeal(m, 1);
				}
				foreach (Minion m in p.ownMinions)
				{
				   if (triggerEffectMinion.entityID != m.entityID) p.minionGetDamageOrHeal(m, 1);
				}
		   }
		}

	}
}