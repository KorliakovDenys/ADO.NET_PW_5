using ADO.NET_PW_5.Data;
using ADO.NET_PW_5.Models;

var gameDbContext = new GameDbContext();

// var rpg = new Style() { Name = "RPG" };
// var shooter = new Style() { Name = "Shooter" };
// var simulator = new Style() { Name = "Simulator" };
//
// gameDbContext.Style?.Add(rpg);
// gameDbContext.Style?.Add(shooter);
// gameDbContext.Style?.Add(simulator);
//
// var GiantSoftware = new Studio() { Name = "Giants Software" };
// var CDProjectRed = new Studio() { Name = "CD Projekt Red "};
// var RG = new Studio() { Name = "Rockstar Games" };
//
//
// gameDbContext.Studio?.Add(GiantSoftware);
// gameDbContext.Studio?.Add(CDProjectRed);
// gameDbContext.Studio?.Add(RG);
//
// var single = new GameMode() { Name = "SinglePlayer" };
// var multi = new GameMode() { Name = "Multiplayer" };
//
// gameDbContext.GameMode?.Add(single);
// gameDbContext.GameMode?.Add(multi);
//
// gameDbContext.Games?.Add(new Game() { Title = "GTA V", Studio = RG, Style = shooter, CopiesSold = 180000000, GameMode = multi});
// gameDbContext.Games?.Add(new Game() { Title = "GTA IV", Studio = RG, Style = shooter, CopiesSold = 20000000,GameMode = multi});
// gameDbContext.Games?.Add(new Game() { Title = "The Witcher III", Studio = CDProjectRed, Style = rpg, CopiesSold = 50000000, GameMode = single});
// gameDbContext.Games?.Add(new Game() { Title = "The Witcher II", Studio = CDProjectRed, Style = rpg, CopiesSold = 50000000, GameMode = single});
// gameDbContext.Games?.Add(new Game() { Title = "Farming Simulator 22", Studio = GiantSoftware, Style = simulator, CopiesSold = 20000000, GameMode = multi});
// gameDbContext.Games?.Add(new Game() { Title = "Farming Simulator 22", Studio = GiantSoftware, Style = simulator, CopiesSold = 20000000, GameMode = multi});
// gameDbContext.SaveChanges();

PrintIEnumerable(gameDbContext.Studio!);
PrintIEnumerable(gameDbContext.Style!);
PrintIEnumerable(gameDbContext.GameMode!);
PrintIEnumerable(gameDbContext.Games!);

static void PrintIEnumerable(IEnumerable<object> collection) {
    foreach (var el in collection) {
        Console.WriteLine(el.ToString());
    }

    Console.WriteLine(new string('-', 20));
}

