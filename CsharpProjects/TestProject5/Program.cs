string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};

DisplayStudents(students);
DisplayStudents(new string[] {"Robert","Vanya"});

void DisplayStudents(string[] students) 
{
    foreach (string student in students) 
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}

// Caluclar la raiz cuadrada de 16

//¿Cuál es el propósito de las declaraciones condicionales en C#?
//Las declaraciones condicionales en C# se utilizan para ejecutar un bloque de código si se cumple una condición específica.

// Declarar una matriz de enteros con los balores 1, 2 y 3
int[] numbers = {1, 2, 3};

// ¿Cómo se escribe una elsedeclaración en C#?

// ¿Cómo se declara un tipo de retorno para un método C# que devuelve un entero?
// int 


int x = 5;
if (x > 0) {
    Console.WriteLine("Positive");
} else if (x < 0) {
    Console.WriteLine("Negative");
} else {
    Console.WriteLine("Zero");
}