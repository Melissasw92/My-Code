using StoryGenerator;

public class Villain
        {
            private string villain;
            public string villainName
            {
                get { return villain; }
                set { villain = value; }
            }

            public abstract void GenerateRandomVillian();

        }

        public override void GenerateRandomVillian()
        {

            Random rand = new Random();
            string[] villainType = { "warlock", "evil queen", "evil prince", "sorcerer" };
            string[] villianCreature = { "dragon", "giant", "squid", "ogre" };
            return new Villain { villainName = villainType[rand.Next(villainType.Length)] };

        }