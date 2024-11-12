using StoryGenerator;
       public class Role : MainCharacter
        {
            public string role { get; set; }
            public abstract void GenerateRandomRole();
        }

        public override void GenerateRandomRole()
        {
            Random rand = new Random();
            string[] mainCharacterRole = { "blacksmith", "servant", "knight", "rogue", "criminal", "cook", "stable hand", "common folk", "wizard" };
            return new Role { role = mainCharacterRole[rand.Next(mainCharacterRole.Length)] };

        }
