using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
	class Sim_OG_284 : SimTemplate //* Twilight Geomancer
	{
		//Taunt. Battlecry: Give your C'Thun Taunt (wherever it is).
		
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (own.own) p.anzOgOwnCThunTaunt++;
		}
	}
}