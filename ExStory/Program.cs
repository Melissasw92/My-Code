using System;

namespace Story
{

    class StoryGenerator
    {
        static void Main()
        {
            Console.Write("Hello Adventurer! Would you like to go on a journey with me? (y/n)");
            string Input = Console.ReadLine().ToUpper();

            if (Input != "y" && Input != "n")
            {
                Console.WriteLine("Invalid input. Y/N");
            }

            if (Input == "n")
            {
                Console.WriteLine("Another time then!");
                return;
            }
            if (Input == "y")
            {
                Console.Write("Great! Let's begin. Tell me about yourself. What is your name?");

                MainCharacter maincharacter = new MainCharacter(); // Create an instance
                maincharacter.Name = Console.ReadLine(); // Set name
            }

            Console.Write(<span class="math-inline">"Hello, \{maincharacter\.Name\}\! How old are you?"\);
maincharacter\.Age \= Console\.ReadLine\(\);
Console\.Write\("You will need a weapon for this story\."\);
Weapon randomWeapon \= GenerateRandonWeapon\(\); // Call the method
maincharacter\.Weapon \= randomWeapon;
Console\.WriteLine\(</span>"You have obtained a(n) {maincharacter.Weapon.Name}. Congrats!");

            Console.Write(<span class="math-inline">"\{maincharacter\.Name\}, aged \{maincharacter\.Age\} with the weapon \{maincharacter\.Weapon\}\. Let's find out your role in this story\."\);
Role randomMainCharacterRole \= GenerateRandomRole\(\);
maincharacter\.Role \= randomMainCharacterRole; // Assign role
Console\.WriteLine\(</span>"Your role in this story is {maincharacter.Role}.");

            Location locations = GenerateRandomLocation(); // Call the method
        }

        public class MainCharacter // Make class public
        {
            public string Name { get; set; } // Public getter/setter for name
            public string Age { get; set; } // Public getter/setter for age
            public string[] hairColor = { "brown", "red", "blonde", "white", "black", "gray", "silver" };
            public string[] heightM;
            public string[] race = { "human", "elf", "half-elf", "fairy", "orc" };
            public string[] eyeColor = { "brown", "blue", "green", "silver", "purple", "red" };
            public Role Role { get; set; } // Public getter/setter for role
        }


        class Role
        {
            public string role { get; set; } // Public getter/setter for role
        }

        static Role GenerateRandomRole()
        {
            Random rand = new Random();
            string[] mainCharacterRole = { "princess", "prince", "knight", "rogue", "criminal", "king", "queen", "common folk", "wizard" };
            return new Role { role = mainCharacterRole[rand.Next(mainCharacterRole.Length)] }; // Get random role
        }

        class Location
        {
            public string[] locations = { "forest", "castle", "village", "mansion", "ancient runes", "tavern", "haunted moutains" };
        }

        static Location GenerateRandomLocation()
        {
            Random rand
