// Declarar un array bidimensional sin inicializarlo e inicializarlo después
int[] nums;
nums = new int[] { 9, 2, 4, -3 ,22, 6, 14, 8, 1, 10, 11 };

// Declarar un array e inicializarlo
string[] friends = new string[8] // Donde 8 es la longitud del array
{
    "Harry",
    "Nathalia",
    "Yinel",
    "Maria",
    "Paola",
    "Lady",
    "Juan",
    null
};

// Ordenar array con el método Sort (ascending)
Array.Sort(nums);
Array.Sort(friends);
Console.WriteLine(string.Join(", ", nums)); // Imprimir array como string
Console.WriteLine(string.Join(", ", friends));

// Invertir array
Array.Reverse(nums);
Array.Reverse(friends);
Console.WriteLine(string.Join(", ", nums));
Console.WriteLine(string.Join(", ", friends));


