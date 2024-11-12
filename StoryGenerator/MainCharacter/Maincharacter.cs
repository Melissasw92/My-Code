using StoryGenerator;

public abstract class MainCharacter
        {
            public string Name { get; set; } // Public getter/setter for name
            public string Age { get; set; } // Public getter/setter for age
            public string[] hairColor = { "brown", "red", "blonde", "white", "black", "gray", "silver" };
            public string[] race = { "human", "elf", "half-elf", "fairy", "orc" };
            public string[] eyeColor = { "brown", "blue", "green", "silver", "purple", "red" };
            public Role Role { get; set; }
            public Weapon Weapon { get; set; } // Public getter/setter for role
            
            public string Item { get; set; }
        }