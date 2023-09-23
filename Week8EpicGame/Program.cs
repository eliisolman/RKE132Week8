string FolderPath = @"/Users/eliisolman/projects";
string heroFile = "heroes.txt";
string villianFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(FolderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(FolderPath, villianFile));

//string[] heroes = {"Harry Potter", "Luke Skywalker", "Lara Croft", "Scooby-Doo"};
//string[] villains = {"Voldemort", "Darth Vader", "Dracuka", "Joker", "Sauron" };
string[] weapon = {"magic wand", "plastic fork", "banana", "wooden sword", "Lego brick"};

string hero = GetRandomValueFromArray(heroes);
string heroWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {hero} with {heroWeapon} saves the day!");

string villain = GetRandomValueFromArray(villains);
string villainWeapon = GetRandomValueFromArray(weapon);
Console.WriteLine($"Today {villain} with {villainWeapon} treis to take over the world!");



static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
    return randomStringFromArray;
}