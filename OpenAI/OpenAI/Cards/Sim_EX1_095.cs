using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
	class Sim_EX1_095 : SimTemplate //gadgetzanauctioneer
	{

//    zieht jedes mal eine karte, wenn ihr einen zauber wirkt.

        public override void OnCardIsGoingToBePlayed(Playfield p, CardDB.Card c, bool wasOwnCard, Minion triggerEffectMinion, Minion target, int choice)
        {
            if (c.type == CardDB.cardtype.SPELL && wasOwnCard == triggerEffectMinion.own)
            {
                p.drawACard(CardDB.cardIDEnum.None, wasOwnCard);
            }

        }

	}
}