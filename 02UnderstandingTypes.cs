// See https://aka.ms/new-console-template for more information


////1.What type would you choose for the following “numbers”?
//Tel > int
//height(cm) > float
//age > byte
//gender > char
//salary(money) > decimal
//ISBN > ulong
//price(money) > decimal
//weight > float
//population > ulong
//stars > ulong
//employee > ushort

////2. What are the difference between value type and reference type variables? What is boxing and unboxing?
//value type directly hold the value while reference type hold the memory address for this value
//value type(all numerial and bool): int, float ,double,bool 
//Reference type(char type): string, stringbuilder, object

//convert a value type to reference type -- boxing
//convert a reference type to a value type -- unboxing


//Playing with Console App
Console.WriteLine("color?");
string color = Console.ReadLine();
Console.WriteLine("sign?");
string sign = Console.ReadLine();
Console.WriteLine("address num?");
string num = Console.ReadLine();
Console.WriteLine($"Your hacker name  is {color + sign + num}");

//char color = Console.ReadKey();
//Console.WriteLine("Your color is" { color });




string NumRead =Console.ReadLine();
int centuries = Convert.ToInt32(NumRead);
int years = centuries * 100;
float days =years * 365.24F;
float hours =days * 24;
float minutes =hours * 60;
double seconds =minutes * 60;
double milliseconds =seconds * 1000;
double microseconds = milliseconds * 1000;
decimal nanoseconds = (decimal)(microseconds * 1000);

Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");


//Controlling Flow and Converting Types
// 1. What happens when you divide an int variable by 0?
int number1 = 3000;
int number2 = 0;
Console.WriteLine((double)number1 / number2);
//The example displays the following output:
//        Infinity







