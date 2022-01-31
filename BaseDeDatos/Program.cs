using BaseDeDatos;
using System.Data.SqlClient;

try
{
    BeerDB beerDB = new BeerDB("PC-HARRY", "CsharpDB", "sa", "admin123");
    bool again = true;
    int op = 0;

    do
    {
        ShowMenu();
        Console.Write("Elige una opción: ");
        op = int.Parse(Console.ReadLine());

        switch (op)
        {
            case 1:
                Show(beerDB);
                break;
            case 2:
                Add(beerDB);
                break;
            case 3:
                Edit(beerDB);
                break;
            case 4:
                Delete(beerDB);
                break;
            case 0:
                again = false;
                break;
        }
    } while (again);   

    
}
catch(SqlException)
{
    Console.WriteLine("No pudimos conectarnos");
}

static void ShowMenu()
{
    Console.Clear();
    Console.WriteLine("\n----------------------Menú----------------------");
    Console.WriteLine("1. - Mostrar");
    Console.WriteLine("2. - Agregar");
    Console.WriteLine("3. - Editar");
    Console.WriteLine("4. - Eliminar");
    Console.WriteLine("0. - Salir");
}

static void Edit(BeerDB beerDB)
{
    Console.Clear();
    Show(beerDB);
    Console.WriteLine("\n----------------------Editar Cerveza----------------------");
    Console.Write("Escribe el Id de tu cerveza a editar: ");
    int id = int.Parse(Console.ReadLine());

    Beer beer = beerDB.Get(id);
    if(beer != null)
    {
        Console.Write("Escriba el nombre: ");
        string name = Console.ReadLine();
        Console.Write("Escribe el Id de la marca: ");
        int brandId = int.Parse(Console.ReadLine());

        beer.Name = name;
        beer.BrandId = brandId;
        beerDB.Edit(beer);
    } else
    {
        Console.WriteLine("La cerveza no existe");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
    }
}

static void Add(BeerDB beerDB)
{
    Console.Clear();
    Console.WriteLine("Agregar nueva cerveza");
    Console.Write("Escribe el nombre de la cerveza: ");
    string name = Console.ReadLine();
    Console.Write("Escribe el Id de la Marca de la cerveza: ");
    int brandId = int.Parse(Console.ReadLine());

    Beer beer = new Beer(name, brandId);
    beerDB.Add(beer);
}

static void Show(BeerDB beerDB)
{
    Console.Clear();
    Console.WriteLine("Cervezas de la base de datos");
    Console.WriteLine("--------------------------------------------\n");
    List<Beer> beers = beerDB.GetAll();

    foreach (var beer in beers)
    {
        Console.WriteLine($"Id: {beer.Id}, Name: {beer.Name}");
    }

    Console.WriteLine("\nPresione una tecla para continuar...");
    Console.ReadKey();
}

static void Delete(BeerDB beerDB)
{
    Console.Clear();
    Show(beerDB);
    Console.WriteLine("\n----------------------Eliminar Cerveza----------------------");
    Console.Write("Escribe el Id de tu cerveza a eliminar: ");
    int id = int.Parse(Console.ReadLine());

    Beer beer = beerDB.Get(id);
    if (beer != null)
    {   
        beerDB.Delete(id);
    }
    else
    {
        Console.WriteLine("La cerveza no existe");
        Console.WriteLine("\nPresione una tecla para continuar...");
        Console.ReadKey();
    }
}

