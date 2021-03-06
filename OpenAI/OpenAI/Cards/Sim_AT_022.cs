using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_AT_022 : SimTemplate //Fist of Jaraxxus
    {

        //   When you play or discard this, deal $4 damage to a random enemy.<

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {

            int dmg = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
            p.doDmgToRandomEnemyCLIENT2(dmg, true, ownplay);
        }

        public override void onCardIsDiscarded(Playfield p, CardDB.Card card, bool own)
        {

            int dmg = (own) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);

            p.doDmgToRandomEnemyCLIENT2(dmg, true, own);
        }
    }
}