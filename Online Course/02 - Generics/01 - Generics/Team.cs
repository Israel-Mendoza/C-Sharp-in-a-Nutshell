interface Player { }

record FootballPlayer(string name, string position) : Player { } // Implements the Player interface
record BasketballPlayer(string name, string position) : Player { } // Implements the Player interface

class Team<T> where T : Player // T can only be a Player (like FootballPlayer or BasketballPlayer)
{
    // Initializing fields:
    public string TeamName { get; init; }
    private List<T> teamMembers = new List<T>();
    public int TotalWins { get; private set; }
    public int TotalTies { get; private set; }
    public int TotalLosses { get; private set; }
    // Constructor:
    public Team(string teamName) { this.TeamName = teamName; }

    public bool AddTeamMember(T player)
    {
        if (teamMembers.Contains(player))
            return false;
        teamMembers.Add(player);
        return true;
    }
    public int Ranking { get => (TotalLosses * 2) + TotalTies + 1; }
    private string SetScore(int ourScore, int theirScore)
    {
        string finalMessage = "lost to";
        if (ourScore > theirScore)
        {
            TotalWins++;
            finalMessage = "beat";
        }
        else if (ourScore == theirScore)
        {
            TotalTies++;
            finalMessage = "tied";
        }
        else
            TotalLosses++;
        return finalMessage;
    }
    public override string ToString() => $"{TeamName} (Ranked {Ranking})";
    public void PrintTeamMembers()
    {
        foreach (var player in teamMembers)
            Console.WriteLine(player);
    }
    public void ScoreResults(int ownScore, int otherScore, Team<T> otherTeam)
    {
        string message = this.SetScore(ownScore, otherScore);
        otherTeam.SetScore(otherScore, ownScore);
        Console.WriteLine($"{this} {message} {otherTeam}");
    }
}
