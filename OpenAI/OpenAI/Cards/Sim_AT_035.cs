﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{

    class Sim_AT_035 : SimTemplate//Beneath the Grounds
    {
        //Shuffle 3 Ambushes into your opponent's deck. When drawn, you summon a 4/4 Nerubian.
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.FP1_007t);//nerub

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;

            //hard to simulate
            if (ownplay)
            {
                p.enemyDeckSize += 3;
            }
            else
            {
                p.ownDeckSize += 3;
            }
            p.callKid(kid, pos, ownplay);
            p.callKid(kid, pos, ownplay);
        }
    }
}
