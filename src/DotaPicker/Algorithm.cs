using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaPicker
{
    class Algorithm
    {
        Hero[] Radiant;
        Hero[] Dire;
        public Algorithm(Hero[] Radiant, Hero[] Dire)
        {
            this.Radiant = Radiant;
            this.Dire = Dire;
        }
        #region Win Chance
        public int CalculateWinChanceDire()
        {
            return 0;
        }
        public int CalculateWinChanceRadiant()
        {
            return 0;
        }
        #endregion
        #region Recommend Pick
        public HeroID[] RecommendDire()
        {
            List<HeroID> Pick = new List<HeroID>();
            foreach(Hero dir in Dire)
            {
                foreach(Hero rad in Radiant)
                {
                    foreach(HeroC h in rad.Enemy)
                    {
                        if (h.Name == dir.ID.Name)
                        {
                            if (h.Rank < 5)
                            {
                                Pick.Add(h);
                            }
                            break;
                        }
                    }
                }
            }
            Pick.Sort();
            return Pick.ToArray();
        }
        public Hero[] RecommendRadiant()
        {
            return null;
        }
        #endregion
        #region Bad Pick
        public Hero[] BadPickRadiant()
        {
            return null;
        }
        public Hero[] BadPickDire()
        {
            return null;
        }
        #endregion
    }
}
