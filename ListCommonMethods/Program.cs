
/* Mëtodos útiles de las listas */

List<int> numbers = new List<int> { 4, 2, 3, 5, 22 };
Show(numbers);

// Insert: Inserta un elemento en la posición indicada (<posicion>, <elemento a insertar>)
numbers.Insert(1, 6);
Show(numbers);

// Contains: Indicado un elemento, returna un true si existe dicho elemento o false en caso contrario
if (numbers.Contains(5))
    Console.WriteLine("Existe");
else
    Console.WriteLine("No existe");

// IndexOf: Indicado un elemento, regresa en qué posición se encuentra (empezando desde 0). Si no existe, regresa -1
int pos = numbers.IndexOf(22);
Console.WriteLine(pos);
pos = numbers.IndexOf(100);
Console.WriteLine(pos);

// Sort: Método mutable(modifica el objeto). Ordena el objeto una vez utilizado el método
numbers.Sort();
Show(numbers);

// Add Range: Me permite agregar una lista a otra lista ya establecida
numbers.AddRange(new List<int>()
{
    300, 100, 400
});
Show(numbers);

static void Show(List<int> numbers)
{
    Console.WriteLine("*--- Números ---*");
    foreach (var number in numbers) {
        Console.WriteLine(number);
    }
}