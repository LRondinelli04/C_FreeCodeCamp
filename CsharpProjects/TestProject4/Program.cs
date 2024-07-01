/* Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");
 */

string message = "Find what is (inside the parentheses)";

int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

// IndexOf devuelve la posición de la primera ocurrencia de un carácter o una cadena en un string
string myString = "C# Time";
Console.WriteLine(myString.IndexOf('C'));

// IndexOfAny devuelve la posición de la primera ocurrencia de uno de los caracteres especificados en un string
Console.WriteLine(myString.IndexOfAny(new char[] { 'T', 'i' }));

// LastIndexOf devuelve la posición de la última ocurrencia de un carácter o una cadena en un string
Console.WriteLine(myString.LastIndexOf('e'));

// Insert inserta una cadena en una posición específica de un string
Console.WriteLine(myString.Insert(3, "is "));

// Remove elimina un número específico de caracteres de un string
Console.WriteLine(myString.Remove(2, 3));

// Replace reemplaza todas las ocurrencias de un carácter o una cadena en un string
Console.WriteLine(myString.Replace("C#", "VB.NET"));

// Substring devuelve una parte de un string
Console.WriteLine(myString.Substring(2, 3));


// PadLeft genera un nuevo string con el string original alineado a la izquierda
// rellena con espacios en blanco o con el caracter especificado la cantidad de espacios necesarios para completar la longitud especificada
string myWords = "Learning C#";
Console.WriteLine(myWords.PadLeft(12));