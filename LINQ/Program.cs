using System.Linq;


List<Beer> beers = new List<Beer>()
{
    new Beer() {Name = "Corona", Country = "Mexico"},
    new Beer() {Name = "Aguila", Country = "Colombia"},
    new Beer() {Name = "Erdinger", Country = "Alemania"},
};

foreach(var beer in beers)
    Console.WriteLine(beer);

Console.WriteLine("------------------------ \n");

// select: Me permite seleccionar elementos de una lista
var beersName = from beer in beers
                select new
                {
                    Name = beer.Name,
                    Letters = beer.Name.Length,
                    Fixed = 1
                };
foreach(var beer in beersName)
    Console.WriteLine($"{beer.Name} {beer.Letters} {beer.Fixed}");

Console.WriteLine("------------------------ \n");

var beersNameReal = from b in beersName
                    select new
                    {
                        Name = b.Name
                    };
foreach(var beer in beersName)
    Console.WriteLine(beer.Name);

Console.WriteLine("------------------------ \n");

// where: Me permite filtrar una lista o una colección basandonos en un parámetro
var beerMexico = from b in beers
                 where b.Country == "Mexico"
                 || b.Country == "Alemania"
                 select b;

foreach (var beer in beerMexico)
    Console.WriteLine(beer);

Console.WriteLine("------------------------ \n");

// orderby: Me permite ordenar una colección basandonos en un campo
var orderedBeers = from b in beers
                   orderby b.Country descending
                   select b;
foreach(var beer in orderedBeers)
    Console.WriteLine(beer);


public class Beer
{
    public string? Name { get; set; }
    public string? Country { get; set; }

    public override string ToString()
    {
        return $"Nombre: {Name}, País: {Country}";
    }
}
