// Creating Teams
var toluca = new Team<FootballPlayer>("Toluca FC");
var tigres = new Team<FootballPlayer>("UANL");
var america = new Team<FootballPlayer>("América");
var dallas = new Team<BasketballPlayer>("Dallas Mavericks");
var miami = new Team<BasketballPlayer>("Miami Heat");

// Adding players to their teams:
toluca.AddTeamMember(new FootballPlayer("Thiago Volpi", "Goalkeeper"));
toluca.AddTeamMember(new FootballPlayer("Jean Meneses", "Forward"));

tigres.AddTeamMember(new FootballPlayer("André Gignac", "Forward"));
tigres.AddTeamMember(new FootballPlayer("Nahuel Guzmán", "Goalkeeper"));

america.AddTeamMember(new FootballPlayer("Álvaro Fidalgo", "Midfielder"));
america.AddTeamMember(new FootballPlayer("Jonathan Dos Santos", "Midfielder"));

dallas.AddTeamMember(new BasketballPlayer("Davis Bertans", "Power Forward"));
dallas.AddTeamMember(new BasketballPlayer("Luka Doncic", "Point guard"));

miami.AddTeamMember(new BasketballPlayer("Jimmy Butler", "Forward"));
miami.AddTeamMember(new BasketballPlayer("Kevin Love", "Forward"));


// Printing the roaster:
toluca.PrintTeamMembers();
// FootballPlayer { name = Thiago Volpi, position = Goalkeeper }
// FootballPlayer { name = Jean Meneses, position = Forward }
tigres.PrintTeamMembers();
// FootballPlayer { name = André Gignac, position = Forward }
// FootballPlayer { name = Nahuel Guzmán, position = Goalkeeper }
america.PrintTeamMembers();
// FootballPlayer { name = Álvaro Fidalgo, position = Midfielder }
// FootballPlayer { name = Jonathan Dos Santos, position = Midfielder }
dallas.PrintTeamMembers();
// BasketballPlayer { name = Davis Bertans, position = Power Forward }
// BasketballPlayer { name = Luka Doncic, position = Point guard }
miami.PrintTeamMembers();
// BasketballPlayer { name = Jimmy Butler, position = Forward }
// BasketballPlayer { name = Kevin Love, position = Forward }

// Recording the final scores:
toluca.ScoreResults(3, 1, tigres);
// Toluca FC (Ranked 1) beat UANL (Ranked 3)
toluca.ScoreResults(3, 0, america);
// Toluca FC (Ranked 1) beat América (Ranked 3)
tigres.ScoreResults(1, 1, america);
// UANL (Ranked 4) tied América (Ranked 4)
dallas.ScoreResults(78, 98, miami);
// Dallas Mavericks (Ranked 3) lost to Miami Heat (Ranked 1)