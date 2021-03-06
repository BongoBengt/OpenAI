using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
	class Sim_OG_273 : SimTemplate //* Stand Against Darkness
	{
		//Summon five 1/1 Silver Hand Recruits.
		
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_101t);

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            for (int i = 0; i < 5; i++)
            {
				int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
                p.callKid(kid, pos, ownplay);
            }
        }
    }
}
