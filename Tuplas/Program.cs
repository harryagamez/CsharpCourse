/* Tuplas: Una lista de variables que pueden ser de distinto tipo. A diferencia de los tipos anónimos,
las tuplas sí son editables */

// Forma típica de crear una tupla
(int id, string name) product = (1, "Cerveza stout");
Console.WriteLine($"{product.id} - {product.name}");

// Editando un campo de la tupla
product.name = "Cerveza porter";
Console.WriteLine($"{product.id} - {product.name}");

// Forma alterna de crear una tupla
var person = (1, "Harry");
Console.WriteLine($"{person.Item1} - {person.Item2}");

// Forma alterna2 de crear una tupla
var tupla = ( entero: 12, 
    cadena: "hola", 
    flotante: 1.2, 
    fecha: DateTime.Now, 
    objeto: new Person() { Name = "Harry" });
Console.WriteLine(tupla.entero);
Console.WriteLine(tupla.cadena);
Console.WriteLine(tupla.flotante);
Console.WriteLine(tupla.fecha);
Console.WriteLine(tupla.objeto.Name);


// Forma de crear un arreglo de tuplas
var people = new[]
{
    (1, "Harry"),
    (2, "Nathalia"),
    (3, "Lady")
};

foreach (var p in people)
{
    Console.WriteLine($"{p.Item1} - {p.Item2}");
}

// Forma alterna de crear un arreglo de tuplas
(int id, string name)[] people2 = new[]
{
    (1, "Agamez"),
    (2, "Martinez"),
    (3, "Pedraza"),
    (4, "Ardila")
};

foreach (var p2 in people2)
{
    Console.WriteLine($"{p2.id} - {p2.name}");
}

var cityInfo = getLocationCDMX();
Console.WriteLine($"Lat: {cityInfo.lat} Long: {cityInfo.lng} Name: {cityInfo.name}");

// En caso de que necesite retornar un solo elemento, uso _ en lugar de las variables no deseadas
var (_, lng, _) = getLocationCDMX();
Console.WriteLine(lng);

/* Una de los usos de las tuplas es cuando debemos regresar más de un valor dentro de una función*/

static (float lat, float lng, string name) getLocationCDMX()
{
    float lat = 19.12121f;
    float lng = -99.19212f;
    string name = "CDMX";

    return (lat, lng, name);
}

Console.WriteLine(Person.GetSome().food);
Console.WriteLine(Person.GetSome().number);

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Definiendo un método que regresa una tupla
    public static (int number, string food) GetSome() => (1, "papas");
}
