using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
	class Sim_OG_313 : SimTemplate //* Addled Grizzly
	{
		//After you summon a minion, give it +1/+1.
		
		public override void onMinionWasSummoned(Playfield p, Minion m, Minion summonedMinion)
        {
			if (m.own == summonedMinion.own && m.entityID != summonedMinion.entityID)
			{
				p.minionGetBuffed(summonedMinion, 1, 1);
			}
        }
	}
}