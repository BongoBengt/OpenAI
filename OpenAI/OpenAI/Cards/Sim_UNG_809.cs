using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_UNG_809 : SimTemplate //Fire Fly
    {

        //Battlecry: Add a 1/2 Elemental to your hand.

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.CardToHand(CardDB.cardName.flameelemental, own.own);
        }

    }

}