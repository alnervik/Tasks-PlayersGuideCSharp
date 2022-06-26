// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Lets check the area of your triangle.");
Console.WriteLine("Please input the base:");
string triangleBaseText = Console.ReadLine();
int triangleBase = Convert.ToInt32(triangleBaseText);
Console.WriteLine("Please input the height:");
string triangleHeightText = Console.ReadLine();
int triangleHeight = Convert.ToInt32(triangleHeightText);
decimal triangleArea = (triangleBase * triangleHeight) / 2;
Console.WriteLine("Hmm lets see.. the area is: " + triangleArea);
*/
// kap 7 s56 uppgift:
/*
Console.WriteLine("How many eggs gathered today?");
string totalAmountEggsText = Console.ReadLine();
int.TryParse(totalAmountEggsText, out int totalAmountEggs);
float eggsEachSister = totalAmountEggs / 4;
int eggsForDuckBear = totalAmountEggs % 4;
Console.WriteLine($"The sisters get: {eggsEachSister} eggs each");
Console.WriteLine($"And the duckbear gets: {eggsForDuckBear} eggs"); */
//kap 7 s57 uppgift:
/*
Console.WriteLine("How many provinces do you have?");
string totalProvincesText = Console.ReadLine();
int.TryParse(totalProvincesText, out int totalProvinces);

Console.WriteLine("How many duchies do you have?");
string totalDuchiesText = Console.ReadLine();
int.TryParse(totalDuchiesText, out int totalDuchies);

Console.WriteLine("How many estates do you have?");
string totalEstatesText = Console.ReadLine();
int.TryParse(totalEstatesText, out int totalEstates);

int totalScore = (totalDuchies * 3) + (totalEstates * 1) + (totalProvinces * 6);
Console.WriteLine("The point total is " + totalScore); */
//kap 8 s 68
/*
Console.Title = "Defense of Consolas!";
Console.WriteLine("What row?");
string targetRowText = Console.ReadLine();
int.TryParse(targetRowText, out int targetRow);

Console.WriteLine("What column?");
string targetColumnText = Console.ReadLine();
int.TryParse(targetColumnText, out int targetColumn);

string deployNorth = $"Row: {(targetRow+1)} Column: {targetColumn}";
string deployEast = $"Row: {targetRow} Column: {(targetColumn + 1)}";
string deploySouth = $"Row: {(targetRow - 1)} Column: {targetColumn}";
string deployWest = $"Row: {targetRow} Column: {(targetColumn - 1)}";

Console.WriteLine("Deploy protection at:");

Console.BackgroundColor = ConsoleColor.Magenta;
Console.WriteLine($"North - {deployNorth}");

Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine($"East - {deployEast}");

Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.WriteLine($"South - {deploySouth}");

Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"West - {deployWest}");

Console.Beep(400, 200);
Console.Beep(600, 200);
Console.Beep(300, 200);
Console.Beep(200, 200);
Console.Beep(100, 200); */
//kap 9 s75
/*
Console.WriteLine("Input the number:");
string clockNumberText = Console.ReadLine();
int.TryParse(clockNumberText, out int clockNumber);

//om det är jämn nummer säger den tick. iom delar du 2 med jämn nummer blir det 0 kvar.
if (clockNumber % 2 == 0)
{
    Console.WriteLine("Tick");
}
//blir det inte 0 kvar? då har vi ojämnt nummer och tock skrivs ut
else
{
    Console.WriteLine("Tock");
} */

// kap 9 uppgift 2
/*
Console.WriteLine("Write a number for x-value");
int xValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write a number for y-value");
int yValue = Convert.ToInt32(Console.ReadLine());
if (xValue < 0 && yValue > 0) Console.WriteLine("The enemy is to the NW");
if (xValue == 0 && yValue > 0) Console.WriteLine("The enemy is to the N!");
if (xValue > 0 && yValue > 0) Console.WriteLine("The enemy is to the NE!");
if (xValue < 0 && yValue == 0) Console.WriteLine("The enemy is to the W!");
if (xValue == 0 && yValue == 0) Console.WriteLine("The enemy is hereeee!");
if (xValue > 0 && yValue == 0) Console.WriteLine("The enemy is to the E!");
if (xValue < 0 && yValue < 0) Console.WriteLine("The enemy is to the SW!");
if (xValue == 0 && yValue < 0) Console.WriteLine("The enemy is to the S!");
if (xValue > 0 && yValue < 0) Console.WriteLine("The enemy is to the SE!");
*/
// kap 10 uppgift 1+2:
/*
Console.WriteLine("Hello! What is your name?");
string username = Console.ReadLine();
Console.WriteLine("The following items are available:");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torches");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food supplies");

Console.WriteLine("What do you want to know the price of?");
int productChoice = Convert.ToInt32(Console.ReadLine());

string product = productChoice switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing equipment",
    4 => "Clean water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food supplies",
    _ => "what item is that?. pick another option..",
};

int productPrice = product switch
{
    "Rope"  => 10,
    "Torches" => 15,
    "Climbing equipment" => 25,
    "Clean water" => 1,
    "Machete" => 20,
    "Canoe" => 200,
    "Food supplies" => 1,
};
if (username == "Kalle")
{
    Console.WriteLine($"{product} costs {productPrice / 2} gold.");
}
else
    {
        Console.WriteLine($"{product} costs {productPrice} gold.");
    }
*/