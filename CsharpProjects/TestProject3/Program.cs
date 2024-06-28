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

