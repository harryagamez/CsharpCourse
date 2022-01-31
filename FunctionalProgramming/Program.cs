
Operation mySum = Functions.Sum;
// Console.WriteLine(mySum(2, 3));

mySum = Functions.Prod;
// Console.WriteLine(mySum(3,4));

Show myString = Functions.ConsoleShow;
myString += Console.WriteLine;
// myString("Hola mundo");
// Functions.Some("Juan", "Guevara", myString);

#region Action
// Action: Delegado genérico; función cualquiera que reciba cualquier # de parametros pero no regresa nada

Action<string> showMessage = Console.WriteLine;
// showMessage("Hola");

// Action<string, string> showMessage2 = (a, b) => Console.WriteLine($"{a}{b}");
Action<string, string> showMessage2 = (a, b) =>
{
    Console.WriteLine($"{a} {b}");
};
// showMessage2("Harry", "Agámez");

Action<string, string, string> showMessage3 = (a, b, c) => Console.WriteLine($"{a} {b} {c}");

// showMessage3("Harry", "Agámez", "Dev");

// Functions.SomeAction("Harry", "Agámez", (a) =>
// {
//    Console.WriteLine("Soy una expresión lambda " +a);
// });


// Functions.SomeAction("Harry", "Agámez", showMessage);

#endregion

#region Func

Func<int> numberRandom = () => new Random().Next(0, 100); // <type> define el tipo de dato que retorna
Func<int, int> numberRandomLimit = (limit) => new Random().Next(0, limit); // el último <type> define el tipo de dato que recibe como parametro

//Console.WriteLine(numberRandom());
//Console.WriteLine(numberRandomLimit(500));

#endregion

#region Predicate

Predicate<string> hasSpaceOrA = (word) => word.Contains(" ") || word.ToUpper().Contains("A");
Console.WriteLine(hasSpaceOrA("beer"));

var words = new List<string>()
{
    "beer",
    "patito",
    "sandía",
    "hola mundo",
    "c#"
};

var wordsNew = words.FindAll(hasSpaceOrA);
var wordsNew2 = words.FindAll( x => !hasSpaceOrA(x));
foreach(var word in wordsNew2)
    Console.WriteLine(word);


#endregion

#region Delegados
delegate int Operation(int a, int b);
public delegate void Show(string message);
public delegate void Show2(string message, string message2);
public delegate void Show3(string message, string message2);

#endregion

public class Functions
{
    public static int Sum(int x, int y) => x + y;
    public static int Prod(int num1, int num2) => num1 * num2;
    public static void ConsoleShow(string m) => Console.WriteLine(m.ToUpper());

    public static void Some(string name, string lastname, Show fn)
    {
        Console.WriteLine("Hago algo al inicio");
        fn($"Hola {name} {lastname}");
        Console.WriteLine("Hago algo al final");
    }
    public static void SomeAction(string name, string lastname, Action<string> fn)
    {
        Console.WriteLine("Hago algo al inicio");
        fn($"Hola {name} {lastname}");
        Console.WriteLine("Hago algo al final");
    }
}
