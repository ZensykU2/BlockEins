
// Aufgabe 1.1
/* Console.WriteLine("Bitte schreibe deinen Namen");
string name = Console.ReadLine();
Console.WriteLine($"Hallo {name}! Schön, dass du da bist.");
*/

//Aufgabe 1.2
/*Console.WriteLine("Bitte gib die erste Zahl ein:");
string num1 = Console.ReadLine();
Console.WriteLine("Bitte gib nun die zweite Zahl ein:");
string num2 = Console.ReadLine();
int sumNum1 = int.Parse(num1);
int sumNum2 = int.Parse(num2);
int sum = sumNum1 + sumNum2;
Console.WriteLine("Hier ist nun die Summe der zwei Zahlen: " + sum);
*/

//Aufgabe 2.1
/* int var1 = 2;
double var2 = 2.3;
string var3 = "Zwei";

Console.WriteLine(var1.GetType());
Console.WriteLine(var2.GetType());
Console.WriteLine(var3.GetType());
*/

/*Aufgabe 2.2
 Ein "=" fügt etwas hinzu und zwei "==" bedeutet est ist gleich gültig*/

//Aufgabe 3.1
/* string name = "Cristian";

string gross = name.ToUpper();
string klein = name.ToLower();

string reversed = new string(name.Reverse().ToArray());

Console.WriteLine(reversed);
Console.WriteLine(gross);
Console.WriteLine(klein);
*/

//Aufgabe 3.2
/*Console.Write("Gib das erste Wort ein: ");
string wort1 = Console.ReadLine();
Console.Write("Gib das zweite Wort ein: ");
string wort2 = Console.ReadLine();
string neuesWort = wort1 + wort2;
Console.WriteLine("Das neue Wort ist: " + neuesWort);
*/

//Aufgabe 4.1
/*Console.WriteLine("Bitte gib die erste Zahl ein: ");
string num1 = Console.ReadLine();
Console.WriteLine("Bitte gib die zweite Zahl ein: ");
string num2 = Console.ReadLine();
double parseNum1 = double.Parse(num1);
double parseNum2 = double.Parse(num2);

double divisionNum = parseNum1 / parseNum2;
double additionNum = parseNum1 + parseNum2;
double subtractionNum = parseNum1 - parseNum2;
double multiplicationNum = parseNum1 * parseNum2;

Console.WriteLine($"Addition: {Math.Round(additionNum, 2)}");
Console.WriteLine($"Subtraktion: {Math.Round(subtractionNum, 2)}");
Console.WriteLine($"Multiplikation: {Math.Round(multiplicationNum, 2)}");
Console.WriteLine($"Division: {Math.Round(divisionNum, 2)}");
*/

/*Aufgabe 4.2 
 In Python ist der Unterschied zwischen "/" und "//" ob die nach-komma-stelle angezeigt werden soll oder es gerundet werden soll*/

//Aufgabe 5.1
/* int x = 5;
x += 1;
Console.WriteLine(x);
x -= 2;
Console.WriteLine(x);
*/

//Aufgabe 6.1
/*double preisProRiegel = 3.20;
double geld = 20.0;
int anzahlRiegel = (int)(geld / preisProRiegel);
double restGeld = geld % preisProRiegel;

Console.WriteLine($"Mit {geld} Franken kannst du {anzahlRiegel} Riegel kaufen.");
Console.WriteLine("Es bleiben " + restGeld.ToString("F2") + " Franken übrig.");
*/

//Aufgabe 7.1
/* Console.Write("Bitte gib die erste Zahl ein: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Bitte gib die zweite Zahl ein: ");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Die erste Zahl ist größer als die zweite Zahl.");
}
else if (num1 == num2)
{
    Console.WriteLine("Die beiden Zahlen sind gleich.");
}
else
{
    Console.WriteLine("Die zweite Zahl ist größer als die erste Zahl.");
}
*/

/*Aufgabe 7.2 
 Es gibt True aus.*/

//Aufgabe 8.1 & 8.2
/*Console.WriteLine("Bitte gib eine Zahl ein");
string stringNum = Console.ReadLine();
double num = double.Parse(stringNum);
if(num > 10 && num < 20 )
{
    Console.WriteLine($"Die Nummer {num} ist grösser als 10 und kleiner als 20");
}
else if(num < 0 || num > 100)
{
    Console.WriteLine($"Die Nummer {num} ist kleiner als 0 oder grösser als 100");
}
*/

//Aufgabe 8.3
// Bei "&&" müssen beide zutreffen bei "||" muss eins davon zutreffen.

//Aufgabe 9.1 & 9.2 & 9.3
/* Console.Write("Bitte füge dein Passwort ein");
string password = Console.ReadLine();
if (password != null && password.Length > 8)
{
    Console.WriteLine("Das Passwort ist lang genug.");
}
else
{
    Console.WriteLine("Das Passwort ist zu kurz.");
}
*/

//Aufgabe 10
/* Console.Write("Wie schnell fährt dein Auto (km/h)? ");
double geschwindigkeit = Convert.ToDouble(Console.ReadLine());
Console.Write("Wie hoch ist der Verbrauch deines Autos (Liter pro 100 km)? ");
double verbrauchPro100km = Convert.ToDouble(Console.ReadLine());
Console.Write("Wie viele Kilometer möchtest du fahren? ");
double distanz = Convert.ToDouble(Console.ReadLine());

double fahrzeitStunden = distanz / geschwindigkeit;

double fahrzeitMinuten = fahrzeitStunden * 60;

double gesamtverbrauch = (verbrauchPro100km / 100) * distanz;

Console.WriteLine($"Fahrzeit: {fahrzeitMinuten:F2} Minuten");
Console.WriteLine($"Gesamter Benzinverbrauch: {gesamtverbrauch:F2} Liter");
*/

//Aufgabe 11
Console.Write("Bitte gib dein Gewicht in Kilogramm ein: ");
double weight = Convert.ToDouble(Console.ReadLine());

Console.Write("Bitte gib deine Größe in Metern ein (z.B. 1.75): ");
double height = Convert.ToDouble(Console.ReadLine());
double bmi = weight / (height * height);
string classification = bmi switch
{
    < 18.5 => "Untergewicht",
    < 25 => "Normalgewicht",
    < 30 => "Übergewicht",
    < 35 => "Adipositas Grad I",
    < 40 => "Adipositas Grad II",
    _ => "Adipositas Grad III"
};

Console.WriteLine($"Dein BMI beträgt: {bmi:F2}");
Console.WriteLine($"Klassifikation: {classification}");
