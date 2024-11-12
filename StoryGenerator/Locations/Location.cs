//using StoryGenerator;

public class Location
{
    public string Name;
    public Location(string name)
    {
        Name = name;
    }

    public void GenerateRandomLocation();

    void GenerateRandomLocation()
    {

        Random rand = new Random();
        string[] locations = { "forest", "castle", "village", "mansion", "ancient runes", "tavern", "haunted moutains" };
        return new Location(locations[rand.Next(locations.Length)]);
    }
}