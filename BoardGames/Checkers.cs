using System;

class BoardGames
{
    public string Name { get; set; }
    public int minPlayers { get; set; }
    public int maxPlayers { get; set; }
    public int playTime { get; set; }
    public void Play()
    {
        Console.WriteLine("Playing the boardgame.")
    }
    static void DisplayInfo();
    {

        Console.WriteLine($"{Name}");
        Console.WriteLine($"{maxPlayer}");
        Console.WriteLine($"{playTime}");
    }
    

}

class Checkers : BoardGames
{
    int move = 1;
    int takePiece = 1;
    int redPlayer = 12;
    int blackPlayer = 12;

    string name = "Checkers";
   {
    Name = name;
   }
minPlayers = 1;
maxPlayers = 2;
playTime = 30;

public override void Play()
{
    Console.WriteLine("You have embarked on the journey of checkers. Player beware.");
}

}

  public override void DisplayInfo()
{
    Console.WriteLine($"{Name}");
    Console.WriteLine($"{maxPlayer}");
    Console.WriteLine($"{playTime}");
}



class Sorry : BoardGames
{
    int maxPlayer = 4;
    int minPlayers = 2;
    int playTime = 60;
    string Name = "Sorry!";

    public override void Play()
    {
        Console.WriteLine("You have embarked on the journey of Sorry! Be careful or you might be the sorry one.");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{Name}");
        Console.WriteLine($"{maxPlayer}");
        Console.WriteLine($"{playTime}");
    }

}

static void Main(string[] args)
{
    Sorry.Play();
    Sorry.DisplayInfo();

    Checkers.Play();
    Checkers.DisplayInfo():
}