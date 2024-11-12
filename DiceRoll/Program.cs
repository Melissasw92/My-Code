ConsoleApplication.Run();

public class ConsoleApplication
{
    public static void Run()
    {
        

        Random rand = new();

        int DiceRoll1 = rand.Next(1, 7);
        int DiceRoll2 = rand.Next(1, 7);
        int DiceRoll3 = rand.Next(1, 7);
        int DiceRoll4 = rand.Next(1, 7);
        int DiceRoll5 = rand.Next(1, 7);


        Console.WriteLine("Initial Roll: ");
        Console.WriteLine($"Die 1: {DiceRoll1}");
        Console.WriteLine($"Die 2: {DiceRoll2}");
        Console.WriteLine($"Die 3: {DiceRoll3}");
        Console.WriteLine($"Die 4: {DiceRoll4}");
        Console.WriteLine($"Die 5: {DiceRoll5}");

        
        int reRollCount = 2;
        while (reRollCount > 0)
        {
            Console.Write($"Enter the dice numbers to reroll (comma-separated, ex: 2,3,5) or leave blank to keep current dice.");
            Console.Write($"You have {reRollCount} rerolls remaining.");
            string userInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(userInput))
            {
                string[] DicereRoll = userInput.Split(',');

                foreach (string dieIndex in DicereRoll)
                {
                    if (int.TryParse(dieIndex, out int diceNum)) // Check for valid integer
                    {
                        if (diceNum >= 1 && diceNum <= 5) // valid dice number
                        {

                            switch (diceNum)
                            {
                                case 1:
                                    DiceRoll1 = rand.Next(1, 7);
                                    break;

                                case 2:
                                    DiceRoll2 = rand.Next(1, 7);
                                    break;

                                case 3:
                                    DiceRoll3 = rand.Next(1, 7);
                                    break;

                                case 4:
                                    DiceRoll4 = rand.Next(1, 7);
                                    break;

                                case 5:
                                    DiceRoll5 = rand.Next(1, 7);
                                    break;
                            }
                        
                        
                        }
                        else
                        {
                            Console.WriteLine("Invalid input");
                        }
                    }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
                    

                    }
                }
                Console.WriteLine("Updated Rolls:");
                Console.Write($"Die 1: {DiceRoll1}");
                Console.Write($"Die 2: {DiceRoll2}");
                Console.Write($"Die 3: {DiceRoll3}");
                Console.Write($"Die 4: {DiceRoll4}");
                Console.Write($"Die 5: {DiceRoll5}");
                

                reRollCount--;
            

        }
        int DieSum = (DiceRoll1 + DiceRoll2 + DiceRoll3 + DiceRoll4 + DiceRoll5);
        //if dice roll has two of same value = +10
        //if dice roll has three of same value = +15
        //if dice roll has four of same value =  +25
        //if dice roll has five of same value = +30

        int BonusPoints = 0;
        int[] AllDiceRolls = [DiceRoll1, DiceRoll2, DiceRoll3, DiceRoll4, DiceRoll5];

        foreach (int DieVal in AllDiceRolls)
        {
            int count = AllDiceRolls.Count(x => x == DieVal);

            switch (count)
            {
                case 2:
                    BonusPoints += 10;
                    break;

                case 3:
                    BonusPoints += 15;
                    break;

                case 4:
                    BonusPoints += 25;
                    break;

                case 5:
                    BonusPoints += 30;
                    break;
            }

        }

        int FinalSum = BonusPoints + DieSum;
        Console.WriteLine($"Final Score: {FinalSum}");
    }
}
