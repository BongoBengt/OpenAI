using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
	class Sim_EX1_241 : SimTemplate //lavaburst
	{

//    verursacht $5 schaden. überladung:/ (2)

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(5) : p.getEnemySpellDamageDamage(5);
            p.minionGetDamageOrHeal(target, dmg);
            p.changeRecall(ownplay, 2);
            
		}

	}
}