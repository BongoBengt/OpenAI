using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
	class Sim_FP1_030 : SimTemplate //loatheb
	{

//    kampfschrei:/ im nächsten zug kosten zauber für euren gegner (5) mehr.
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (own.own)
            {
                p.anzOwnLoatheb++;
            }
            else
            {
                p.anzEnemyLoatheb++;
            }

		}

	

	}
}