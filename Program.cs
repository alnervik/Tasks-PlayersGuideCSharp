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
// kap 