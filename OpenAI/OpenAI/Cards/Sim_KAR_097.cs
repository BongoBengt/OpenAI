using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_KAR_097 : SimTemplate //Medivh, the Guardian
    {
        // Battlecry: Equip Atiesh, Greatstaff of the Guardian.

        CardDB.Card w = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.KAR_097t);

        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
            p.equipWeapon(w, true);
        }
    }
}