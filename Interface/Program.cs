
Shark[] sharks = new Shark[]
{
    new Shark("Tiburonsin", 56),
    new Shark("Jaws", 65)
};

IFish[] fishs = new IFish[]
{
    new Sirena(30),
    new Shark("Tiburonsin", 40)
};

ShowFish(sharks);
ShowAnimals(sharks);
ShowFish(fishs);

static void ShowAnimals(IAnimal[] animals)
{
    Console.WriteLine(" - Mostramos los animales -- ");
    int i = 0;
    while (i < animals.Length)
    {
        Console.WriteLine(animals[i].Name);
        i++;
    }
}

static void ShowFish(IFish[] fishs)
{
    Console.WriteLine(" - Mostramos los peces -- ");
    int i = 0;
    while (i < fishs.Length)
    {
        Console.WriteLine(fishs[i].Swim());
        i++;
    }
}

public class Sirena: IFish
{    
    public int Speed { get; set; }

    public Sirena(int Speed)
    {
        this.Speed = Speed;
    }

    public string Swim()
    {
        return $"La sirena nada a {Speed} Km/h";
    }
}

public class Shark : IAnimal, IFish
{
    public string Name { get; set; }
    public int Speed { get; set; }

    public Shark(string Name, int Speed)
    {
        this.Name = Name;
        this.Speed = Speed;
    }

    public string Swim()
    {
        return $"{Name} nada a {Speed} Km/h";
    }
}

/* 
Interfaz: Es un contrato que deben cumplir aquellas clases que implementen la interfaz. Se definen con la palabra
interface y sus nombres deben empezar con la palabra I. Ej: IPerson, IAnimal. Una clase puede implementar tantas
interfaces como quiera. Los métodos de la interfaz no llevan código, solo la definición.
*/

public interface IAnimal
{
    public string Name { get; set; }
}

public interface IFish
{
    public int Speed { get; set; }
    public string Swim();
}