namespace DotaPicker
{
    class Hero
    {
        internal HeroID ID;
        internal HeroID[] Enemy;
        //internal HeroID[] Friend;
        internal bool IsCarry;
        internal bool IsSupport;
        internal eRole[] Roles;
        internal eType Type;
        public Hero(string name, int rank)
        {
            ID = new HeroID(name, rank);
        }
        public void AssignCounters(HeroID[] Enemy)
        {
            this.Enemy = Enemy;
        }
        public void AssignParameters(bool IsCarry, bool IsSupport, eRole[] Roles, eType Type)
        {
            this.IsCarry = IsCarry;
            this.IsSupport = IsSupport;
            this.Roles = Roles;
            this.Type = Type;
        }
    }

    class HeroC : HeroID
    {
        internal int Rank;

        public HeroC(int id, int Rank) : base(HeroDb.ihero(id).Name, Rank)
        {
            this.Rank = Rank;
        }
    }

    class HeroID
    {
        internal string Name;
        public HeroID(string Name, int Rank)
        {
            this.Name = Name;
        }
    }

    enum eType
    {
        Agility,
        Strength,
        Intelligence,
    }

    enum eRole
    {
        Nuker,
        Initiator,
        Pusher,
        Disabler,
        Durable,
        Escape,
        Jungler
    }
}
