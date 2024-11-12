
//using StoryGenerator;
public class Items 
        {
            
            public string Item {get; set;}
            public abstract void GenerateRandomItems();

        }

        public override void GenerateRandomItems()
        {
            Random rand = new Random();
            string[] item = { "precious gem", "gold", "dagger", "sword", "map", "letter", "beer", "arrows" };
            return new Items { Item = item[rand.Next(item.Length)] };


        }
    