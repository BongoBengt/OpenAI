using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_AT_023 : SimTemplate //Void Crusher
    {

        //insprire: Destroy a random minion for each player.

        public override void onInspire(Playfield p, Minion m)
        {
            Minion choosen2 = p.searchRandomMinion(p.enemyMinions, Playfield.searchmode.searchLowestAttack);
            if (choosen2 != null) p.minionGetDestroyed(choosen2);

            Minion choosen1 = p.searchRandomMinion(p.ownMinions, Playfield.searchmode.searchHighestAttack);
            if (choosen1 != null) p.minionGetDestroyed(choosen1);
        }
    }
}