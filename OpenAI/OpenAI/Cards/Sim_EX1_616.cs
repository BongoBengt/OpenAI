using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
	class Sim_EX1_616 : SimTemplate //manawraith
	{

//    alle diener kosten (1) mehr.
        public override void onAuraStarts(Playfield p, Minion own)
		{
            p.anzManaWraith ++;
		}

        public override void onAuraEnds(Playfield p, Minion m)
        {
            p.anzManaWraith--;
        }

	}
}