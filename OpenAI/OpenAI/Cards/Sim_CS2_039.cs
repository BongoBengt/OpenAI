using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
	class Sim_CS2_039 : SimTemplate //windfury
	{

//    verleiht einem diener windzorn/.
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            p.minionGetWindfurry(target);
		}

	}
}