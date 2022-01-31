// Tipos Anónimos: Son objetos que no pertenecen a ninguna clase. Son readonly.

var hector = new
{
    Name = "Harry",
    Country = "Colombia"
};

Console.WriteLine($"{hector.Name}, {hector.Country}");

var beers = new[]
{
    new { Name = "Red", Brand = "Delirium"},
    new { Name = "London Porter", Brand = "Fullers"}
};

foreach(var beer in beers)
{
    Console.WriteLine($"Cerveza: {beer.Name}, Marca: {beer.Brand}");
}