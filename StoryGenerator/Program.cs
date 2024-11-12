// using System;
// using System.Runtime.InteropServices;
// using StoryGenerator.MainCharacter;
// using StoryGenerator.Locations;
// using StoryGenerator.Villains;
// using StoryGenerator.PlotLine;
// using StoryGenerator.RandomItems;




namespace StoryGenerator
{

    class StoryGenerator
    {
        static void Main()
        {
            Console.Write("Hello Adventurer! Would you like to go on a journey with me? (y/n) "); // Welcome message
            string Input = Console.ReadLine();

            if (Input != "y" && Input != "n")
            {
                Console.WriteLine("Invalid input. y/n");
                //Input = Console.ReadLine().ToUpper();
            }

            if (Input == "n")
            {
                Console.WriteLine("Another time then!"); //ends program
                return;
            }
            if (Input == "y")
            {
                Console.WriteLine("Great! Let's begin."); //starts interactive story generator.
            }



            MainCharacter maincharacter = new MainCharacter();
            Console.Write("Every adventurer has a hero's name. What is the name of the hero in our story? "); //promt for Character name
            maincharacter.Name = Console.ReadLine();

            Console.Write($"Hello, {maincharacter.Name}! How old is your hero? "); //promt for Character age
            maincharacter.Age = Console.ReadLine();

            Console.WriteLine("You will need a weapon for this story.\n"); //Randomize a weapon.

            Weapon randomWeapons = GenerateRandonWeapon();
            maincharacter.Weapon = new Weapon(randomWeapons.Name);
            Console.WriteLine($"You have obtained a(n) {maincharacter.Weapon.Name}. Congrats!\n"); //obtain weapon

            Console.WriteLine("Let's find out your role in this story.");

            Role randomMainCharacterRole = GenerateRandomRole();
            maincharacter.Role = randomMainCharacterRole;

            Console.WriteLine($"Your role in this story is {maincharacter.Role.role}.\n"); //what is the characters background for this story?


            Location startingLocation = GenerateRandomLocation();

            Console.WriteLine($"Our hero's story begins at the {startingLocation.Name}."); //starting location for the story

            Console.WriteLine($"You are approached by a member of the {startingLocation.Name}. Do you interact (y/n)?"); //interact with a NPC
            Input = Console.ReadLine();

            if (Input != "y" && Input != "n")
            {
                Console.WriteLine("Invalid input.");
            }

            if (Input == "n")
            {
                Console.WriteLine($"Person:\"Hello stranger! I just wanted to tell you what was happening around {startingLocation.Name}. Are you sure you don't want to hear what happened? (y/n) \"");
                Input = Console.ReadLine(); //promt if the hero character wants to interact
            }
            if (Input != "y" && Input != "n")
            {
                Console.WriteLine("Invalid input.");
            }
            if (Input == "n")
                Console.WriteLine("\"I'm sure you'll hear about it eventually. Have a great day!\""); //end program if character says no.

            if (Input == "y")
            {
                Console.WriteLine($"\"Hello {maincharacter.Name}, did you hear about what happened at the {startingLocation.Name}? I wonder if anyone can help.\""); //start plit of the story
            }

            Console.WriteLine($"Hero: \"I am just a {maincharacter.Role.role}. But I may be able to help. What happened?\"");

            Villain startingVillain = GenerateRandomVillian();

            Console.WriteLine($"Person: \"The {startingVillain.villainName} made an appearance here. Last time the {startingVillain.villainName} was around, there was mass devistation. That thing needs to be taken care of.\"");
            // introduce the villain of the story
            Console.WriteLine($"Person: \"There's a rumor that the king has a reward for the person who can help them rid the {startingLocation.Name} of the {startingVillain.villainName}. I would imagine it's a hefty reward.\"");
            Console.WriteLine($"Person: \"If I was able, I would attempt to claim that reward for myself. But alas, I am not physically able.\"");


            Console.WriteLine($"\"Dear hero, are you up for the challenge of defeating the {startingVillain.villainName}? (y/n)\""); //promt user if they want to take on the villain
            Input = Console.ReadLine();

            if (Input != "y" && Input != "n")
            {
                Console.WriteLine("Invalid input.");
            }
            else if (Input == "n") //exit program.
            {
                Console.WriteLine("\"I don't blame you. Come back when you are ready to take it on.\""); //if no, ends the program.
            }
            else if (Input == "y") //continue storyline
            {

                Console.WriteLine($"Hero: \"We can't have that. I might just be a {maincharacter.Role.role}, with only a(n) {maincharacter.Weapon.Name}, but I will take on the {startingVillain.villainName}.\"");
                // hero accepts challenge.
            }


            Console.WriteLine();
            Console.WriteLine($"{maincharacter.Name} is pointed in the direction of the home where the leader of the {startingLocation.Name} resides.");
        }
    }
            //hero starts journey to leaders home








        // public class MainCharacter
        // {
        //     public string Name { get; set; } // Public getter/setter for name
        //     public string Age { get; set; } // Public getter/setter for age
        //     public string[] hairColor = { "brown", "red", "blonde", "white", "black", "gray", "silver" };
        //     public string[] race = { "human", "elf", "half-elf", "fairy", "orc" };
        //     public string[] eyeColor = { "brown", "blue", "green", "silver", "purple", "red" };
        //     public Role Role { get; set; }
        //     public Weapon Weapon { get; set; } // Public getter/setter for role

        // }


        // public class Role
        // {
        //     public string role { get; set; }
        // }

        // static Role GenerateRandomRole()
        // {
        //     Random rand = new Random();
        //     string[] mainCharacterRole = { "blacksmith", "servant", "knight", "rogue", "criminal", "cook", "stable hand", "common folk", "wizard" };
        //     return new Role { role = mainCharacterRole[rand.Next(mainCharacterRole.Length)] };

        // }

        // public class Location
        // {
        //     public string Name;
        //     public Location(string name)
        //     {
        //         Name = name;
        //     }
        // }
        // static Location GenerateRandomLocation()
        // {

        //     Random rand = new Random();
        //     string[] locations = { "forest", "castle", "village", "mansion", "ancient runes", "tavern", "haunted moutains" };
        //     return new Location(locations[rand.Next(locations.Length)]);
        // }

        // public class Villain
        // {
        //     private string villain;
        //     public string villainName
        //     {
        //         get { return villain; }
        //         set { villain = value; }
        //     }

        // }

        // static Villain GenerateRandomVillian()
        // {

        //     Random rand = new Random();
        //     string[] villainType = { "warlock", "evil queen", "evil prince", "sorcerer" };
        //     string[] villianCreature = { "dragon", "giant", "squid", "ogre" };
        //     return new Villain { villainName = villainType[rand.Next(villainType.Length)] };

        // }

        // public class Weapon
        // {
        //     public string Name;
        //     public Weapon(string name)
        //     {
        //         Name = name;
        //     }

        // }

        // static Weapon GenerateRandonWeapon()
        // {
        //     Random rand = new Random();
        //     string[] weapons = { "sword", "quarterstaff", "warhammer", "axe", "dagger", "cross bow", "long bow" };
        //     int weaponStrength = 15;

        //     return new Weapon(weapons[rand.Next(weapons.Length)]);

        // }

        // public class Love
        // {
        //     public string loveInterest { get; set; }

        // }
        // static Love GenerateRandomLove()
        // {
        //     string[] loveInterest = { "prince", "princess", "rogue", "knight", "sorcerer", "stable person", "criminal" };

        //     Random rand = new Random();
        //     int randomIndex = rand.Next(loveInterest.Length);
        //     return new Love { loveInterest = loveInterest[randomIndex] };
        // }

        // public class Plot
        // {
        //     public string plots { get; set; }
        //     public string challenges { get; set; }
        //     public string Goal;
        //     public string Challenge;


        // }

        // static Plot GenerateRandomPlot()
        // {
        //     string[] plots = { "break the curse", "defeat the villian", "save the village", "defeat invaders", "find the lost artifact" };
        //     string[] challenges = { "magical barrier", "guards", "hidden cave", "the king turned evil" };

        //     Random rand = new Random();

        //     return new Plot { Goal = plots[rand.Next(plots.Length)], Challenge = challenges[rand.Next(challenges.Length)] };
        // }

    //     class Items
    //     {
    //         public string item { get; set; }

    //     }

    //     static Items GenerateRandomItems()
    //     {
    //         Random rand = new Random();
    //         string[] item = { "precious gem", "gold", "dagger", "sword", "map", "letter", "beer", "arrows" };
    //         return new Items { item = item[rand.Next(item.Length)] };


    //     }
    // }
}
