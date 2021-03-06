﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_AT_010 : SimTemplate //Ram Wrangler
    {

        //Battlecry: If you have a Beast, summon a random Beast.

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.AT_099t);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            bool haspet = false;
            foreach (Minion m in (own.own) ? p.ownMinions : p.enemyMinions)
            {
                if (m.handcard.card.race == TAG_RACE.BEAST) haspet = true;
            }

            if (!haspet) return;

            int pos = (own.own) ? p.ownMinions.Count : p.enemyMinions.Count;

            p.callKid(kid, pos, own.own, true);
        }
    }
}