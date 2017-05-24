using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotaPicker
{
    public static class HeroDb
    {
        internal static List<Hero> Heroes = new List<Hero>();
        public static void Init()
        {
            #region Heroes Definition
            Heroes.Add(new Hero("Abaddon", 5));
            Heroes.Add(new Hero("Alchemist", 5));
            Heroes.Add(new Hero("Ancient Apparition", 5));
            Heroes.Add(new Hero("Anti-Mage", 5));
            Heroes.Add(new Hero("Arc Warden", 5));
            Heroes.Add(new Hero("Axe", 5));
            Heroes.Add(new Hero("Bane", 5));
            Heroes.Add(new Hero("Batrider", 5));
            Heroes.Add(new Hero("Beastmaster", 5));
            Heroes.Add(new Hero("Bloodseeker", 5));
            Heroes.Add(new Hero("Bounty Hunter", 5));
            Heroes.Add(new Hero("Brewmaster", 5));
            Heroes.Add(new Hero("Bristleback", 5));
            Heroes.Add(new Hero("Broodmother", 5));
            Heroes.Add(new Hero("Centaur Warrunner", 5));
            Heroes.Add(new Hero("Chaos Knight", 5));
            Heroes.Add(new Hero("Chen", 5));
            Heroes.Add(new Hero("Clinkz", 5));
            Heroes.Add(new Hero("Clockwerk", 5));
            Heroes.Add(new Hero("Crystal Maiden", 5));
            Heroes.Add(new Hero("Dark Seer", 5));
            Heroes.Add(new Hero("Dazzle", 5));
            Heroes.Add(new Hero("Death Prophet", 5));
            Heroes.Add(new Hero("Disruptor", 5));
            Heroes.Add(new Hero("Doom", 5));
            Heroes.Add(new Hero("Dragon Knight", 5));
            Heroes.Add(new Hero("Drow Ranger", 5));
            Heroes.Add(new Hero("Earth Spirit", 5));
            Heroes.Add(new Hero("Earthshaker", 5));
            Heroes.Add(new Hero("Elder Titan", 5));
            Heroes.Add(new Hero("Ember Spirit", 5));
            Heroes.Add(new Hero("Enchantress", 5));
            Heroes.Add(new Hero("Enigma", 5));
            Heroes.Add(new Hero("Faceless Void", 5));
            Heroes.Add(new Hero("Gyrocopter", 5));
            Heroes.Add(new Hero("Huskar", 5));
            Heroes.Add(new Hero("Invoker", 5));
            Heroes.Add(new Hero("Io", 5));
            Heroes.Add(new Hero("Jakiro", 5));
            Heroes.Add(new Hero("Juggernaut", 5));
            Heroes.Add(new Hero("Keeper of the Light", 5));
            Heroes.Add(new Hero("Kunkka", 5));
            Heroes.Add(new Hero("Legion Commander", 5));
            Heroes.Add(new Hero("Leshrac", 5));
            Heroes.Add(new Hero("Lich", 5));
            Heroes.Add(new Hero("Lifestealer", 5));
            Heroes.Add(new Hero("Lina", 5));
            Heroes.Add(new Hero("Lion", 5));
            Heroes.Add(new Hero("Lone Druid", 5));
            Heroes.Add(new Hero("Luna", 5));
            Heroes.Add(new Hero("Lycan", 5));
            Heroes.Add(new Hero("Magnus", 5));
            Heroes.Add(new Hero("Medusa", 5));
            Heroes.Add(new Hero("Meepo", 5));
            Heroes.Add(new Hero("Mirana", 5));
            Heroes.Add(new Hero("Monkey King", 5));
            Heroes.Add(new Hero("Morphling", 5));
            Heroes.Add(new Hero("Naga Siren", 5));
            Heroes.Add(new Hero("Nature's Prophet", 5));
            Heroes.Add(new Hero("Necrophos", 5));
            Heroes.Add(new Hero("Night Stalker", 5));
            Heroes.Add(new Hero("Nyx Assassin", 5));
            Heroes.Add(new Hero("Ogre Magi", 5));
            Heroes.Add(new Hero("Omniknight", 5));
            Heroes.Add(new Hero("Oracle", 5));
            Heroes.Add(new Hero("Outworld Devourer", 5));
            Heroes.Add(new Hero("Phantom Assassin", 5));
            Heroes.Add(new Hero("Phantom Lancer", 5));
            Heroes.Add(new Hero("Phoenix", 5));
            Heroes.Add(new Hero("Puck", 5));
            Heroes.Add(new Hero("Pudge", 5));
            Heroes.Add(new Hero("Pugna", 5));
            Heroes.Add(new Hero("Queen of Pain", 5));
            Heroes.Add(new Hero("Razor", 5));
            Heroes.Add(new Hero("Riki", 5));
            Heroes.Add(new Hero("Rubick", 5));
            Heroes.Add(new Hero("Sand King", 5));
            Heroes.Add(new Hero("Shadow Demon", 5));
            Heroes.Add(new Hero("Shadow Fiend", 5));
            Heroes.Add(new Hero("Shadow Shaman", 5));
            Heroes.Add(new Hero("Silencer", 5));
            Heroes.Add(new Hero("Skywrath Mage", 5));
            Heroes.Add(new Hero("Slardar", 5));
            Heroes.Add(new Hero("Slark", 5));
            Heroes.Add(new Hero("Sniper", 5));
            Heroes.Add(new Hero("Spectre", 5));
            Heroes.Add(new Hero("Spirit Breaker", 5));
            Heroes.Add(new Hero("Storm Spirit", 5));
            Heroes.Add(new Hero("Sven", 5));
            Heroes.Add(new Hero("Techies", 5));
            Heroes.Add(new Hero("Templar Assassin", 5));
            Heroes.Add(new Hero("Terrorblade", 5));
            Heroes.Add(new Hero("Tidehunter", 5));
            Heroes.Add(new Hero("Timbersaw", 5));
            Heroes.Add(new Hero("Tinker", 5));
            Heroes.Add(new Hero("Tiny", 5));
            Heroes.Add(new Hero("Treant Protector", 5));
            Heroes.Add(new Hero("Troll Warlord", 5));
            Heroes.Add(new Hero("Tusk", 5));
            Heroes.Add(new Hero("Underlord", 5));
            Heroes.Add(new Hero("Undying", 5));
            Heroes.Add(new Hero("Ursa", 5));
            Heroes.Add(new Hero("Vengeful Spirit", 5));
            Heroes.Add(new Hero("Venomancer", 5));
            Heroes.Add(new Hero("Viper", 5));
            Heroes.Add(new Hero("Visage", 5));
            Heroes.Add(new Hero("Warlock", 5));
            Heroes.Add(new Hero("Weaver", 5));
            Heroes.Add(new Hero("Windranger", 5));
            Heroes.Add(new Hero("Winter Wyvern", 5));
            Heroes.Add(new Hero("Witch Doctor", 5));
            Heroes.Add(new Hero("Wraith King", 5));
            Heroes.Add(new Hero("Zeus", 5));
            #endregion

            #region Heroes Parameters
            hero(000).AssignParameters(true, true, new eRole[] { eRole.Durable }, eType.Strength);
            hero(001).AssignParameters(true, true, new eRole[] { eRole.Disabler, eRole.Durable, eRole.Initiator, eRole.Nuker }, eType.Strength);
            hero(002).AssignParameters(false, true, new eRole[] { eRole.Disabler, eRole.Nuker }, eType.Intelligence);
            hero(003).AssignParameters(true, false, new eRole[] { eRole.Nuker, eRole.Escape }, eType.Agility);
            hero(004).AssignParameters(true, false, new eRole[] { eRole.Nuker, eRole.Escape }, eType.Agility);
            hero(005).AssignParameters(false, false, new eRole[] { eRole.Disabler, eRole.Durable, eRole.Initiator, eRole.Jungler }, eType.Strength);
            hero(006).AssignParameters(false, true, new eRole[] { eRole.Disabler, eRole.Durable, eRole.Nuker }, eType.Intelligence);
            hero(007).AssignParameters(false, false, new eRole[] { eRole.Disabler, eRole.Escape, eRole.Initiator, eRole.Jungler }, eType.Intelligence);
            hero(008).AssignParameters(false, false, new eRole[] { eRole.Disabler, eRole.Durable, eRole.Initiator, eRole.Nuker }, eType.Strength);
            hero(009).AssignParameters(true, false, new eRole[] { eRole.Disabler, eRole.Initiator, eRole.Jungler, eRole.Jungler }, eType.Agility);
            hero(010).AssignParameters(false, false, new eRole[] { eRole.Escape, eRole.Nuker }, eType.Agility);
            hero(011).AssignParameters(true, false, new eRole[] { eRole.Disabler, eRole.Durable, eRole.Initiator, eRole.Nuker }, eType.Agility);
            hero(012).AssignParameters(true, false, new eRole[] { eRole.Durable, eRole.Initiator, eRole.Nuker }, eType.Strength);
            hero(013).AssignParameters(true, false, new eRole[] { eRole.Pusher, eRole.Escape, eRole.Nuker }, eType.Agility);
            hero(014).AssignParameters(false, false, new eRole[] { eRole.Durable, eRole.Initiator, eRole.Escape, eRole.Nuker, eRole.Disabler }, eType.Strength);
            hero(015).AssignParameters(true, false, new eRole[] { eRole.Disabler, eRole.Durable, eRole.Pusher, eRole.Initiator }, eType.Strength);
            hero(016).AssignParameters(false, true, new eRole[] { eRole.Jungler, eRole.Pusher }, eType.Intelligence);
            hero(017).AssignParameters(true, false, new eRole[] { eRole.Pusher, eRole.Pusher }, eType.Agility);
            hero(018).AssignParameters(false, false, new eRole[] { eRole.Initiator, eRole.Durable, eRole.Disabler, eRole.Nuker }, eType.Strength);
            hero(019).AssignParameters(false, true, new eRole[] { eRole.Disabler, eRole.Nuker, eRole.Jungler }, eType.Intelligence);
            hero(020).AssignParameters(false, false, new eRole[] { eRole.Initiator, eRole.Jungler, eRole.Escape, eRole.Disabler }, eType.Intelligence);
            hero(021).AssignParameters(false, true, new eRole[] { eRole.Nuker, eRole.Disabler }, eType.Intelligence);
            hero(022).AssignParameters(true, false, new eRole[] { eRole.Pusher, eRole.Nuker, eRole.Disabler }, eType.Intelligence);
            hero(023).AssignParameters(false, true, new eRole[] { eRole.Nuker, eRole.Disabler, eRole.Initiator }, eType.Intelligence);
            hero(024).AssignParameters(true, false, new eRole[] { eRole.Disabler, eRole.Initiator, eRole.Durable, eRole.Nuker }, eType.Strength);
            hero(025).AssignParameters(true, false, new eRole[] { eRole.Pusher, eRole.Durable, eRole.Disabler, eRole.Nuker }, eType.Strength);
            #endregion

            #region Hero Counters
            hero(000).AssignCounters(new HeroID[]
            {
                new HeroC(001, 3),
                new HeroC(002, 2),
                new HeroC(003, 3),
                new HeroC(004, 5),
                new HeroC(005, 3),
                new HeroC(006, 7),
                new HeroC(007, 8),
                new HeroC(008, 7),
                new HeroC(009, 8),
                new HeroC(010, 9),
                new HeroC(011, 3),
                new HeroC(012, 4),
                new HeroC(013, 5),
                new HeroC(014, 5),
                new HeroC(015, 3),
                new HeroC(016, 7),
                new HeroC(017, 4),
                new HeroC(018, 4),
                new HeroC(019, 9),
                new HeroC(020, 6),
                new HeroC(021, 8),
                new HeroC(022, 4),
                new HeroC(023, 5),
                new HeroC(024, 1),
                new HeroC(025, 5)
            });
            hero(001).AssignCounters(new HeroID[]
            {
                new HeroC(000, 7),
                new HeroC(002, 3),
                new HeroC(003, 4),
                new HeroC(004, 7),
                new HeroC(005, 7),
                new HeroC(006, 7),
                new HeroC(007, 6),
                new HeroC(008, 9),
                new HeroC(009, 6),
                new HeroC(010, 10),
                new HeroC(011, 5),
                new HeroC(012, 4),
                new HeroC(013, 6),
                new HeroC(014, 7),
                new HeroC(015, 3),
                new HeroC(016, 9),
                new HeroC(017, 6),
                new HeroC(018, 6),
                new HeroC(019, 10),
                new HeroC(020, 7),
                new HeroC(021, 9),
                new HeroC(022, 6),
                new HeroC(023, 8),
                new HeroC(024, 5),
                new HeroC(025, 6)
            });
            hero(002).AssignCounters(new HeroID[]
            { // Give this hero bonus points because he is good on durables and teamfights.
                new HeroC(000, 4),
                new HeroC(001, 5),
                new HeroC(003, 1),
                new HeroC(004, 2),
                new HeroC(005, 4),
                new HeroC(006, 3),
                new HeroC(007, 3),
                new HeroC(008, 3),
                new HeroC(009, 2),
                new HeroC(010, 4),
                new HeroC(011, 2),
                new HeroC(012, 2),
                new HeroC(013, 3),
                new HeroC(014, 3),
                new HeroC(015, 1),
                new HeroC(016, 7),
                new HeroC(017, 1),
                new HeroC(018, 3),
                new HeroC(019, 5),
                new HeroC(020, 4),
                new HeroC(021, 6),
                new HeroC(022, 6),
                new HeroC(023, 4),
                new HeroC(024, 0),
                new HeroC(025, 3)
            });
            #endregion

        }

        internal static HeroID ihero(int id)
        {
            return Heroes[id].ID;
        }

        internal static Hero hero(int id)
        {
            return Heroes[id];
        }

    }
}
