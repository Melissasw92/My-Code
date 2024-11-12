using StoryGenerator;

public class Love : MainCharacter
        {
            public string loveInterest { get; set; }
            public abstract void GenerateRandomLove();

        }
        public override void GenerateRandomLove()
        {
            string[] loveInterest = { "prince", "princess", "rogue", "knight", "sorcerer", "stable person", "criminal" };

            Random rand = new Random();
            int randomIndex = rand.Next(loveInterest.Length);
            return new Love { loveInterest = loveInterest[randomIndex] };
        }
