using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_LOE_023 : SimTemplate //Jeweled Scarab
	{
        //Battlecry: Discover a 3-Cost card.

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.drawACard(CardDB.cardIDEnum.None, own.own, true);
        }
	}
}
