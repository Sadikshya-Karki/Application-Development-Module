// Declaring and Initializing
byte a = 200;
short b = 1000;
int c = 500;
long d = 800;
float e = 2.24f;
double f = 3.3333;
decimal g = 7.7733m;
char h = 's';
bool i = true;

// Converting integer number into string
int number = 42;
string text = number.ToString();

Console.WriteLine($"integer number to string: {text}"); 

// Converting a string into double
string tpi = "3.14";
double dpi = double.Parse(tpi);

Console.WriteLine($"string to double: {tpi}");

// Printing all variables
Console.WriteLine($"a    ({a.GetType()}) : {a}");
Console.WriteLine($"b   ({b.GetType()}) : {b}");
Console.WriteLine($"c     ({c.GetType()}) : {c}");
Console.WriteLine($"d    ({d.GetType()}) : {d}");
Console.WriteLine($"e   ({e.GetType()}) : {e}");
Console.WriteLine($"f  ({f.GetType()}) : {f}");
Console.WriteLine($"g ({g.GetType()}) : {g}");
Console.WriteLine($"h    ({h.GetType()}) : {h}");
Console.WriteLine($"i   ({i.GetType()}) : {i}");

