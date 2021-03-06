using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
	class Sim_CFM_790 : SimTemplate //* Dirty Rat
	{
		// Taunt. Battlecry: Your opponent summons a random minion from their hand.

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_300); //Enchanted Raven

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            int zonepos = (m.own) ? p.enemyMinions.Count : p.ownMinions.Count;
            if (p.enemyDeckSize >= 1) p.callKid(kid, zonepos, !m.own);
        }
    }
}