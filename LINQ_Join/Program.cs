
List<Beer> beers = new List<Beer>()
{
    new Beer(){Name = "Corona", Country = "México"},
    new Beer(){Name = "Aguila", Country = "Colombia"},
    new Beer(){Name = "Delirium", Country = "Bélgica"},
    new Beer(){Name = "Poker", Country = "Colombia"}
};

List<Country> countries = new List<Country>()
{
    new Country(){Name = "México", Continent = "América"},
    new Country(){Name = "Colombia", Continent = "América"},
    new Country(){Name = "Bélgica", Continent = "Europa"},
};

var beersWithContinent = from beer in beers
                         join country in countries
                         on beer.Country equals country.Name
                         select new
                         {
                             Name = beer.Name,
                             Country = beer.Country,
                             Continent = country.Continent,
                         };
foreach(var beer in beersWithContinent)
    Console.WriteLine($"{beer.Name} - {beer.Country} - {beer.Continent}");

public class Beer
{
    public string? Name { get; set; }
    public string? Country { get; set; }
}

public class Country
{
    public string? Name { get; set; }
    public string? Continent { get; set; }
}
