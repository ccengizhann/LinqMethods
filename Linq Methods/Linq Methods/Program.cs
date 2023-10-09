using Linq_Methods.Entities;
using System.Security.Cryptography;
using System;


#region Concat çıktı alınamadı

/*static SoccerPlayer[] GetGsPlayers()
{
    SoccerPlayer[] gsPlayers =
                   { new SoccerPlayer { Name="Sacha", Position="Right-Back"},
                 new SoccerPlayer { Name="Mauro", Position="Centre-Forward"},
                 new SoccerPlayer { Name="Fernando", Position="Goalkeeper" },
                 new SoccerPlayer { Name="Wilfried", Position="Left Winger" }};
    return gsPlayers;
}


static SoccerPlayer[] GetFbPlayers()
{
    SoccerPlayer[] fbPlayers =
                   { new SoccerPlayer { Name="Dominik", Position="Goalkeeper" },
                 new SoccerPlayer { Name="Rodrigo", Position="Centre-Back" },
                 new SoccerPlayer { Name="Sebastian", Position="Attacking Midfield" },
                 new SoccerPlayer { Name="Ferdi", Position="Left-Back" }};
    return fbPlayers;
}


static void ConcatPlayerName()
{
    SoccerPlayer[] gsPlayers = GetGsPlayers();
    SoccerPlayer[] fbPlayers = GetFbPlayers();

     IEnumerable<string> query =
     gsPlayers.Select(gsPlayer => gsPlayer.Name).Concat(fbPlayers.Select(fbPlayer => fbPlayer.Name));


    foreach (string name in query)
    {
        Console.WriteLine(name);
    }

}*/

#endregion





/*
#region Distinct


List<Film> films = new List<Film> { 
            new Film("The Shawshank Redemption",1994,"Tim Robbins"),
            new Film("The Godfather", 1972,"Marlon Brando"),
            new Film("The Dark Knight", 2008, "Christian Bale"),
            new Film("The Godfather", 1972,"Marlon Brando"),
            new Film("The Godfather", 1972,"Marlon Brando"),
            new Film("The Shawshank Redemption",1994,"Tim Robbins"),
            new Film("Pulp Fiction", 1994,"John Travolta")  };

IEnumerable<Film> noduplicates =  films.Distinct();

foreach (var film in noduplicates)

    Console.WriteLine(film.Name + " " + film.PublishYear + " " + film.MainActor);

#endregion*/

/*
#region Skip

List<string> F1Teams = new List<string>() {
            "Mercedes-AMG F1Teamronas Formula One Team",
            "Scuderia Ferrari",
            "Red Bull Racing",
            "McLaren F1 Team",
            "Aston Martin Cognizant Formula One Team",
            "Alpine F1 Team",
            "Scuderia AlphaTauri",
            "Alfa Romeo Racing Orlen",
            "Williams Racing",
            "Haas F1 Team" 
};
    Console.WriteLine("All f1Teams except the first four:");
   
foreach (string f1Team in F1Teams.Skip(4))
{
    Console.WriteLine(f1Team);
}


#endregion*/

/*
#region Take

int[] years = { 1954, 2008, 1576, 1872, 1938, 2023, 2004 };

IEnumerable<int> topTwoYears = years.OrderByDescending(year => year).Take(2);

Console.WriteLine("The top two years are: ");

foreach (int year in topTwoYears)
{
    Console.WriteLine(year);
} 
#endregion
*/

/*
#region Zip
string[] firstNames = { "Tyler", "James", "Indiana ", "Vito ", "Hannibal" };
string[] lastNames = { "Durden", "Bond", "Jones " , "Corleone ", "Lecter " };

var famousChracters = firstNames.Zip(lastNames, (first, second) => first + " " + second);

foreach (var item in famousChracters)
    Console.WriteLine(item);

#endregion
*/


/*Çıktı alınamadı

#region Join

public static void JoinEx1()
{
    Principal wolff = new Principal { Name = "Toto , Wolff" };
    Principal horner = new Principal { Name = "Christian , Horner" };
    Principal brown = new Principal { Name = "Zak , Brown " };
    Principal steiner = new Principal { Name = "Guenther , Steiner" };

    F1Team petronas = new F1Team { Name = " Mercedes-AMG Petronas Formula One Team", Principal = wolff };
    F1Team redBull = new F1Team { Name = " Red Bull Racing", Principal = horner };
    F1Team mcLaren = new F1Team { Name = "McLaren F1 Team", Principal = brown };
    F1Team haas = new F1Team { Name = " Haas F1 Team", Principal = steiner };

    List<Principal> people = new List<Principal> { wolff, horner, brown, steiner };
    List<F1Team> F1Teams = new List<F1Team> { petronas, redBull, mcLaren, haas };

    // Create a list of Principal-F1Team pairs where
    // each element is an anonymous type that contains a
    // F1Team's name and the name of the Principal that owns the F1Team.
    var query =
        people.Join(F1Teams,
                    Principal => Principal,
                    F1Team => F1Team.Principal,
                    (Principal, F1Team) =>
                        new { PrincipalName = Principal.Name, F1Team = F1Team.Name });

    foreach (var obj in query)
    {
        Console.WriteLine(
            "{0} - {1}",
            obj.PrincipalName,
            obj.F1Team);
    }
}
#endregion*/

/*
#region Cast

System.Collections.ArrayList cities = new System.Collections.ArrayList();
cities.Add("İstanbul");
cities.Add("Ankara");
cities.Add("Balıkesir");
cities.Add("Giresun");
cities.Add("Adana");

IEnumerable<string> query =
    cities.Cast<string>().OrderBy(city => city).Select(city => city);

// The following code, without the cast, doesn't compile.
//IEnumerable<string> query1 =
//    cities.OrderBy(city => city).Select(city => city);

foreach (string city in query)
{
    Console.WriteLine(city);
}

#endregion
*/

/*
#region Prepend
List<string> languages = new List<string> { "C#", "Python", "Swift", "Java" };

Console.WriteLine(string.Join(", ", languages.Prepend("PHP")));

List<string> newlanguages = languages.Prepend("PHP").ToList();

Console.WriteLine(string.Join(", ", newlanguages));


#endregion

*/