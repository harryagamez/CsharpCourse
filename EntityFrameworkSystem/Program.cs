using BD;
using Microsoft.EntityFrameworkCore;
using System.Linq;

DbContextOptionsBuilder<CsharpDBContext> optionsBuilder = new DbContextOptionsBuilder<CsharpDBContext>();
optionsBuilder.UseSqlServer("Server=PC-HARRY; Database=CsharpDB; User=sa; Password=admin123;");

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
            Show(optionsBuilder);
            break;
        case 2:
            Add(optionsBuilder);
            break ;
        case 3:
            Edit(optionsBuilder);
            break;
        case 4:
            Delete(optionsBuilder);
            break;
        case 0:
            again = false;
            break;
    }

} while (again);

static void Delete(DbContextOptionsBuilder<CsharpDBContext> optionsBuilder)
{
    Console.Clear();
    Show(optionsBuilder);
    Console.WriteLine("Eliminar Cerveza");
    Console.Write("Escribe el Id de la cerveza a eliminar: ");
    int id = int.Parse(Console.ReadLine());
    using (var context = new CsharpDBContext(optionsBuilder.Options))
    {
        Beer beer = context.Beers.Find(id);
        if (beer != null)
        {
            context.Beers.Remove(beer);
            context.SaveChanges();
        } else
        {
            Console.WriteLine("\nCerveza no existente");
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}

static void Edit(DbContextOptionsBuilder<CsharpDBContext> optionsBuilder)
{
    Console.Clear();
    Show(optionsBuilder);
    Console.WriteLine("Editar Cerveza");
    Console.Write("Escribe el Id de la cerveza a editar: ");
    int id = int.Parse(Console.ReadLine());
    using(var context = new CsharpDBContext(optionsBuilder.Options))
    {
        Beer beer = context.Beers.Find(id);
        if(beer != null)
        {
            Console.Write("Escribe el nombre: ");
            string name = Console.ReadLine();
            Console.Write("Escribe el Id de la marca: ");
            int brandId = int.Parse(Console.ReadLine());
            beer.Name = name;
            beer.BrandId = brandId;
            context.Entry(beer).State = EntityState.Modified;
            context.SaveChanges();
        } else
        {
            Console.WriteLine("\nCerveza no existente");
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }

}

static void Add(DbContextOptionsBuilder<CsharpDBContext> optionsBuilder)
{
    Console.Clear();
    Console.WriteLine("Agregar nueva cerveza");
    Console.Write("Escribe el nombre de la cerveza: ");
    string name = Console.ReadLine();
    Console.WriteLine("Escribe el id de la marca: ");
    int brandId = int.Parse(Console.ReadLine());
    using(var context = new CsharpDBContext(optionsBuilder.Options))
    {
        Beer beer = new Beer()
        {
            Name = name,
            BrandId = brandId
        };
        context.Add(beer);
        context.SaveChanges();
    }
}

static void Show(DbContextOptionsBuilder<CsharpDBContext> optionsBuilder)
{
    Console.Clear();
    Console.WriteLine("Cervezas en la base de datos");

    using(var context = new CsharpDBContext(optionsBuilder.Options))
    {
        // List<Beer> beers = context.Beers.ToList();
        //List<Beer> beers = context.Beers.OrderBy(b => b.Name).ToList();
        List<Beer> beers = (from b in context.Beers
                            orderby b.Name
                            select b).Include(b => b.Brand).ToList();
        /* Las dos consultas LINQ anteriores hacen exactamente lo mismo */
        foreach (Beer beer in beers)
        {
            Console.WriteLine($"{beer.Id} - {beer.Name} {beer.Brand.Name}");
        }
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
    }
}

static void ShowMenu()
{
    Console.Clear();
    Console.WriteLine("\n------Menú------");
    Console.WriteLine("1. - Mostrar");
    Console.WriteLine("2. - Agregar");
    Console.WriteLine("3. - Editar");
    Console.WriteLine("4. - Eliminar");
    Console.WriteLine("0. - Salir");
}
