using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
	class Sim_CFM_325 : SimTemplate //* Small-time Buccaneer
	{
		// Has +2 Attack while you have a weapon equipped.

        public override void getBattlecryEffect(Playfield p, Minion m, Minion target, int choice)
        {
            if (m.own)
            {
                if (p.ownWeaponDurability > 0) p.minionGetBuffed(m, 2, 0);
            }
            else
            {
                if (p.enemyWeaponDurability > 0) p.minionGetBuffed(m, 2, 0);
            }
        }
    }
}