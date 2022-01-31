
People harry = new People()
{
    Name = "Harry",
    Age = 36
};

People nathalia = new People()
{
    Name = "Nathalia",
    Age = 37
};

Console.WriteLine(People.GetCount());


public class People
{
    public static int Count = 0;
    public string ? Name { get; set; } 
    public int Age { get; set; }

    public People()
    {
        Count++;
    }

    public static string GetCount()
    {
        return $"Esta clase se ha utilizado {Count} veces";
    }
}
