using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
	class Sim_EX1_166b : SimTemplate //dispel
	{

//    bringt einen diener zum schweigen/.

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (target != null) p.minionGetSilenced(target);
		}

	}
}