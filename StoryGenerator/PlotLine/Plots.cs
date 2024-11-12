using StoryGenerator;

 public class Plot
        {
           
            public string challenges { get; set; }
            public string Goal { get; set; }
            public string Challenge;
            public abstract void GenerateRandomPlot();


        }

        public override void GenerateRandomPlot()
        {
            string[] plots = { "break the curse", "defeat the villian", "save the village", "defeat invaders", "find the lost artifact" };
            string[] challenges = { "magical barrier", "guards", "hidden cave", "the king turned evil" };

            Random rand = new Random();

            return new Plot { Goal = plots[rand.Next(plots.Length)], Challenge = challenges[rand.Next(challenges.Length)] };
        }