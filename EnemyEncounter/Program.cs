using System;




public static class RandomNumberGenerator
{
    public static int GenerateRandomNumber(int minValue, int maxValue)
    {
        Random random = new Random();
        return random.Next(minValue, maxValue + 1); // +1 to include maxValue
    }
}
public class Enemy
{
    public string Name { get; set; }
    public int HP = 100;

    public int Attack = 10;

    public int Defense = 5;
    public int SpecialAttack = 30;

}

public class MainCharacter
{
    public string Name { get; set; }
    int HP = 100;
    int Attack = 20;
    int Defense = 10;

    int SpecialAttack = 30;
    public void Battle(Enemy enemy)
    {
        Console.WriteLine($"The enemy {enemy.Name} has appeared before you, weapon raised to strike. Do you attack (1), or defend (2)?");
        int userInput = int.Parse(Console.ReadLine());

        while (this.HP > 0 && enemy.HP > 0)
        {




            switch (userInput)
            {
                case 1:
                    Console.WriteLine("You attack! Enemy defends but isn't able to deflect your attack.");
                    enemy.HP -= this.Attack;
                    break;


                case 2:
                    Console.WriteLine("You defend against the incoming enemy attack, throwing your shielf up to soften the blow. But you are hit with their weapon which results in half damage.");
                    this.HP -= enemy.Attack/2;
                    break;


            }

            Console.WriteLine($"{this.Name}, you have {this.HP} HP. {enemy.Name} has {enemy.HP} HP.\n");
            Console.WriteLine($"{this.Name}, Do you attack (1) {enemy.Name} or defend(2) yourself? ");
            int newInput = int.Parse(Console.ReadLine());

            switch (newInput)
            {
                case 1:
                    Console.WriteLine($"You hurl yourself towads {enemy.Name}, weapon swinging swiftly through the air. But... they saw you coming.");
                    Console.WriteLine("They parry your strike with a swipe of their owne weapon, throwing you off balance and landing your hit on their body armor.");
                    Console.WriteLine($"{enemy.Name}  takes damage.");
                    enemy.HP -= this.Attack;
                    break;
                    
                case 2:
                    Console.WriteLine($"{enemy.Name} hurls a dagger faster than you thought possible.");
                    Console.WriteLine("You are unable to defend yourself from the dagger, it came too quickly. It digs into your leg and lodges there.");
                    this.HP -= enemy.Attack;
                    break;
            }

            Console.WriteLine($"{this.Name} has {this.HP} remaining. {enemy.Name} has {enemy.HP} remaining.");

            if (this.HP <= 50 || enemy.HP <= 50)
            {

                while (this.HP <= 0 || enemy.HP <= 0)
                {
                    Console.WriteLine($"Continue to attack (1) or defend (2). Hit (3) to use your hidden attack. Be warned, it releases {enemy.Name}'s as well. ");
                    userInput = int.Parse(Console.ReadLine());

                    if (userInput == 1)
                    {
                        Console.WriteLine($"You attack {enemy.Name}. They defend themselves and deflect the blow.");
                        enemy.HP -= this.Attack/2;
                        Console.WriteLine($"{enemy.Name} has {enemy.HP} left. Keep going!");
                    }

                    if (userInput == 2)
                    {
                        Console.WriteLine("You defend yourself against another attack and take only half the damage.");
                        this.HP -= enemy.Attack/2;
                        Console.WriteLine($"{this.Name} has {this.HP} left. {enemy.Name} has {enemy.HP} left.");

                    }

                    if (userInput == 3)
                    {
                        Console.WriteLine($"You release a fire ball towards {enemy.Name}. It is so hot it leaves a char trail behind it.");
                        Console.WriteLine($"{enemy.Name} tries to swifty escape the firey death hurled their way.");
                        Console.WriteLine($"However, {enemy.Name} sent a ripple through the earth, cleaving the ground in two. And it's heading your way.");
                        Console.WriteLine("Do either of you escape unharmed? A 20 sided dice has just been thrown into the air to determine your fate.");
                        Console.WriteLine("It is not known if high or low will work in your favor. Now let's let the dice work it's magic.");

                        int Number = RandomNumberGenerator.GenerateRandomNumber(1, 20);
                        Console.WriteLine("The dice falls, and it rolls and rolls before it finally settles on it's side...");
                        Console.WriteLine("The dice reads: " + Number);

                    



                    if (Number <= 10)
                    {
                        Console.WriteLine("You jump to the side to avoid the collasping earth. Your fingers out stretched, searching for a hand hold...");
                        Console.WriteLine($"...and miss. {enemy.Name}'s blow was successful.");
                        Console.WriteLine($"{this.Name} has {this.HP} HP remaining. {enemy.Name} has {enemy.HP} HP remaining.");
                        this.HP -= enemy.SpecialAttack;
                    }

                    else
                    {
                        Console.WriteLine($"You jump to the side with a well aimed leap, and successfully avoid {enemy.Name}'s attack.");
                        Console.WriteLine($"You turn around just in time to glimpse {enemy.Name} engulfed in flames. Your attack was successful.");
                        enemy.HP -= this.SpecialAttack;
                        Console.WriteLine($"{this.Name} has {this.HP} HP remaining. {enemy.Name} has {enemy.HP} HP remaining.");
                    }
                    }

                    if (this.HP <= 0)
                    {
                        Console.WriteLine("You have been defeated and the battle has been lost. Better luck next time.");
                        break;
                    }
                    if (enemy.HP <= 0)
                    {
                        Console.WriteLine("The enemy has been defeated. Congratulations!");
                        break;
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MainCharacter mainCharacter = new MainCharacter();
            Enemy enemy = new Enemy();


            Console.WriteLine("Hello, hero. What is your name?");
            mainCharacter.Name = Console.ReadLine();

            Console.WriteLine("Enter a name for our enemy: ");
            enemy.Name = Console.ReadLine();

            mainCharacter.Battle(enemy);


        }
    }

}










