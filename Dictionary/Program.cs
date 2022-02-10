// Dictionary: Nos permite crear una colección de tipo Dictionary<TKey, TValue>. Es una colección que permite guardar un valor asociado a una key.

// Declaración de Dictionary
Dictionary<int, string> dictionary = new Dictionary<int, string>();

// Forma de agregar elementos a un diccionario
dictionary.Add(1, "Picas");
dictionary.Add(2, "Corazones");
dictionary.Add(3, "Bastos");
dictionary.Add(4, "Diamantes");

// Forma alt de agregar elementos a un diccionario
dictionary[5] = "Joker";

// Imprimir elemento de Diccionario y diccionario completo
Console.WriteLine(dictionary[4]);

foreach(var key in dictionary)
{
    Console.WriteLine($"{key.Key} - {key.Value}");
}

// Eliminar elemento del diccionario
dictionary.Remove(4);

// Encontrar elemento by Key. Regresa un valor booleano.
dictionary.ContainsKey(5);
