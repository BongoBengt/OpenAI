﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenAI
{
    class Sim_LOEA16_4 : SimTemplate //Timepiece of Horror
    {
        //giv a minion +10/10

        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            List<Minion> targets = (ownplay) ? new List<Minion>(p.enemyMinions) : new List<Minion>(p.ownMinions);
            int times = (ownplay) ? p.getSpellDamageDamage(10) : p.getEnemySpellDamageDamage(10);

            if (ownplay)
            {
                targets.Add(p.enemyHero);
                targets.Sort((a, b) => -a.Hp.CompareTo(b.Hp));  // most hp -> least
            }
            else
            {
                targets.Add(p.ownHero);
                targets.Sort((a, b) => a.Hp.CompareTo(b.Hp));  // least hp -> most
            }

            // Distribute the damage evenly among the targets
            int i = 0;
            while (i < times)
            {
                int loc = i % targets.Count;
                p.minionGetDamageOrHeal(targets[loc], 1);
                i++;
            }
        }
    }
}