using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_GVG_029 : SimTemplate //Ancestor's Call
    {

        //    Put a random minion from each player's hand into the battlefield.
        CardDB.Card enemymob = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_593);
        
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            Handmanager.Handcard c = null;
            int sum = 10000;
            foreach (Handmanager.Handcard hc in p.owncards)
            {
                if (hc.card.type == CardDB.cardtype.MOB)
                {
                    int s = hc.card.Health + hc.card.Attack + ((hc.card.tank) ? 1 : 0) + ((hc.card.Shield) ? 1 : 0);
                    if (s < sum)
                    {
                        c = hc;
                        sum = s;
                    }
                }
            }
            if (sum < 9999 && c != null)
            {
                p.callKid(c.card, p.ownMinions.Count, true);
                p.removeCard(c);
                p.triggerCardsChanged(true);
            }


            if (p.enemyAnzCards >= 2)
            {
                p.callKid(enemymob, p.enemyMinions.Count, false);
                p.enemyAnzCards--;
                p.triggerCardsChanged(false);
            }
        }
    }
}