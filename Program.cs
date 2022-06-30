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
//kap 11 uppgift 1
/*
int choosenNumber;
do
{
    Console.WriteLine("Malin write a number between 0 and 100: ");
    choosenNumber = Convert.ToInt32(Console.ReadLine());
}
while (choosenNumber < 0 || choosenNumber > 100);
Console.Clear();

Console.WriteLine("Kalle guess the number. between 0 and 100");

while(true)
{
    Console.WriteLine("What's your next guess? ");
    int guessedNumber = Convert.ToInt32(Console.ReadLine());

    if (guessedNumber > choosenNumber) Console.WriteLine($"{guessedNumber} is too high");
    else if (guessedNumber < choosenNumber) Console.WriteLine($"{guessedNumber} is too low");
    else break;
}
Console.WriteLine("You guessed the right number!"); */
// kap 11 uppgift 2
/*
for (int totalNumber = 1; totalNumber <= 20; totalNumber++)
{
    if (totalNumber % 5 == 0 && totalNumber % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{totalNumber}: Electric and fire");
    }
    else if (totalNumber % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{totalNumber}: Electric");
    }
    else if (totalNumber % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{totalNumber}: Fire");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{totalNumber}: Normal");
    }
}
*/
// kap 12 uppgift 1
/*
//orimligt svår för mig.. kunde lösa första delen. fick leta hjälp på andra. hade nog inte gjort på detta sätt..
int[] userNumbers = new int[5];
Console.WriteLine("Please enter 5 numbers:");
// Följande for ber användaren om lika många siffror som det är i array. i detta fallet är det 5
for (int index = 0; index < userNumbers.Length; index++)
{
    int input = Convert.ToInt32(Console.ReadLine());
    userNumbers[index] = input; //index blir total 5. userNumbers (array) sparar 5 olika nummer i sig utifrån input.
}
//påbörjan på delen som ska kopiera föregående array
int[] copyNumbers = new int[5];
//i första steget så kopierar vi usersNumbers till copyNumber. vi använder samma index för att få 5 st omgångar av kopia.
for (int copyIndex = 0; copyIndex < copyNumbers.Length; copyIndex++) //när den kört genom 5 gånger har input gått från usersNumbers till copyNumbers
    copyNumbers[copyIndex] = userNumbers[copyIndex];
// Nu har båda arrays samma siffror. För att visa detta kör vi nedanstående for loop. Den går genom
// 5 omgångar. Presenterar den sparade value i sig via WriteLine.
for (int copyIndex = 0; copyIndex < copyNumbers.Length; copyIndex++)
    Console.WriteLine($"{userNumbers[copyIndex]} and {copyNumbers[copyIndex]}");
*/
//kap 12 uppgift 2.1
/*
int[] arraySmall = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int currentSmallest = int.MaxValue; // Start higher than anything in the array.

foreach (int index in arraySmall)
{
    if (index < currentSmallest)
        currentSmallest = index;
}
Console.WriteLine($"The smallest number in array is: {currentSmallest}");
*/
//kap 12 uppgift 2.2:
/*
int[] arrayAverage = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;

foreach (int index in arrayAverage)
{
    total += index;
}
float average = (float)total / arrayAverage.Length;
Console.WriteLine($"The arrays average number is: {average}");
*/
//kap 13 uppgift 1
//tog till en del hjälp. skrev om uppgift från kap 11
/*
int chosenNumber = AskForNumberInRange("Malin, enter a number between 0 and 100", 0, 100);
Console.Clear();
Console.WriteLine("Kalle, guess a number between 0 and 100" );
while (true)
{
    int guessedNumber = AskForNumber("What's your next guess? ");
    if (guessedNumber > chosenNumber) Console.WriteLine($"{guessedNumber} is too high");
    else if (guessedNumber < chosenNumber) Console.WriteLine($"{guessedNumber} is too low");
    else break;
}
Console.WriteLine("You guessed the right number!");



int AskForNumber (string text)
{
    Console.WriteLine(text);
    int chosenNumber = Convert.ToInt32(Console.ReadLine());
    return chosenNumber;
}

int AskForNumberInRange (string text, int min, int max)
{
    while (true)
    {
        int chosenNumber = AskForNumber(text);
        if (chosenNumber >= min && chosenNumber <= max)
            return chosenNumber;
    }
}
*/
// kap 13 uppgift 2
//tog till hjälp
/*
Countdown(10);

void Countdown(int number)
{
    if (number == 0) return;
    Console.WriteLine(number);
    Countdown(number - 1);
}
*/
//kap 16, uppgift 1

Chest state = Chest.Locked;

while (true)
{
    if (state == Chest.Locked)
    {
        UnlockingChest();
    }
    else if (state == Chest.Unlocked)
    {
        LockOrOpenChest();
    }
}


void UnlockingChest()
{
    Console.WriteLine( "The chest is locked. What do you want to do?" );
    string unlock = Console.ReadLine();
        if ( unlock == "unlock" || unlock == "Unlock" )
        {
        state = Chest.Unlocked;
        }
}
void LockOrOpenChest()
{
    Console.WriteLine( "The chest is unlocked. What do you want to do?" );
    string lockedOrOpen = Console.ReadLine();
        if ( lockedOrOpen == "lock" || lockedOrOpen == "Lock" )
        {
        state = Chest.Locked;
        }
        else if ( lockedOrOpen == "open" || lockedOrOpen == "Open" )
        {
        state = Chest.Open;
        }
}


void CloseChest()
{
    Console.WriteLine( "The chest is open. What do you want to do?" );
    string close = Console.ReadLine();
        if ( close == "close" || close == "Close" )
    {

    }
}



//=====================
//E N U M E R A T I O N
//=====================

enum Chest
{
    Locked,
    Unlocked,
    Open
}