//! MODULO DE OPERADORES DE COMPARACION
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox")); // Comprueba si la cadena contiene la subcadena " fox ".
Console.WriteLine(pangram.Contains("cow")); // Comprueba si la cadena contiene la subcadena " cow ".

// These two lines of code will create the same output

Console.WriteLine(pangram.Contains("fox") == false); // Comprueba si la cadena no contiene la subcadena " fox ".
Console.WriteLine(!pangram.Contains("fox")); // Comprueba si la cadena no contiene la subcadena " fox ".


//? --------------------------------------------------------------------------

//! MODULO DE OPERADORES LOGICOS (IF)

bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}


bool flag = true;
int value = 0;

if (flag)
{
    Console.WriteLine($"Inside the code block: {value}");
}

value = 10;
Console.WriteLine($"Outside the code block: {value}");

//?-----------------------------------------------------------------------

var fruit = "pera";

//! MODULO DE OPERADORES LOGICOS (SWITCH)

switch (fruit)
{
    case "apple":
        Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        Console.WriteLine($"App will display information for banana.");
        break;

    case "cherry":
        Console.WriteLine($"App will display information for cherry.");
        break;
    default:
        Console.WriteLine($"App will display information for {fruit}.");
        break;
}

//?-----------------------------------------------------------------------

//! MODULO DE OPERADORES LOGICOS (FOR)

// Recorre los números del 1 al 10
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
        Console.WriteLine($"{i} - FizzBuzz");
    else if (i % 3 == 0)
        Console.WriteLine($"{i} - Fizz");
    else if (i % 5 == 0)
        Console.WriteLine($"{i} - Buzz");
    else
        Console.WriteLine($"{i}");
}

//?-----------------------------------------------------------------------

//! MODULO DE OPERADORES LOGICOS (WHILE)

Random random = new Random();
int current = random.Next(1, 11);


do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);


while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
