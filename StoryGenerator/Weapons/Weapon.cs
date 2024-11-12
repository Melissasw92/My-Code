namespace StoryGenerator.MainCharacter;

public class Weapon : MainCharacter
        {
            public string Name;
            public Weapon(string name)
            {
                Name = name;
            }

        }

        static Weapon GenerateRandonWeapon()
        {
            Random rand = new Random();
            string[] weapons = { "sword", "quarterstaff", "warhammer", "axe", "dagger", "cross bow", "long bow" };
            int weaponStrength = 15;

            return new Weapon(weapons[rand.Next(weapons.Length)]);

        }