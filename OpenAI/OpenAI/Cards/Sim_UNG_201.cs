using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_UNG_201 : SimTemplate //Primalfin Totem
    {

        //At the end of your turn, summon a 1/1 Murloc.

        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_201t);//Primalfin

        public override void onTurnEndsTrigger(Playfield p, Minion triggerEffectMinion, bool turnEndOfOwner)
        {
            if (triggerEffectMinion.own == turnEndOfOwner)
            {
                int posi = triggerEffectMinion.zonepos;
                p.callKid(kid, posi, triggerEffectMinion.own);
            }
        }

    }

}