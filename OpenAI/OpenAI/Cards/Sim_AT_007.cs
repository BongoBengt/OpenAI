﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_AT_007 : SimTemplate //Spellslinger
    {

        //Battlecry: Add a random spell to each player's hand.

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, !own.own, true);
            p.drawACard(CardDB.cardIDEnum.None, own.own, true);
        }
    }
}