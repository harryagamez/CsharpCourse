

var numbers = new List<int> { 1, 2, 3, 5, 7, 54 };

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

var students = new List<People>()
{
    new People(){Name = "Harry", Country = "Colombia"},
    new People(){Name = "Nathalia", Country = "Colombia"},
    new People(){Name = "Julieta", Country="Estados Unidos"}
};

Show(students);

students.RemoveAt(0);
Show(students);

static void Show(List<People> students)
{
    Console.WriteLine("-- Personas --");
    foreach (var people in students)
    {
        Console.WriteLine($"Nombre:{people.Name}, País: {people.Country}");
    }
}

class People
{
    public string? Name { get; set; }
    public string? Country { get; set; }
}