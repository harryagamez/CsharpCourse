int i = 0;

while(i < 10)
{
    Console.WriteLine("Iteración de i: {0}", i);
    i++;
}



int index = 0;

string[] friends = new string[6]
{
    "Harry",
    "Nathalia",
    "Yinel",
    "Maria",
    "Paola",
    "Lady"    
};

while (index < friends.Length)
{
    Console.WriteLine(friends[index]);
    index++;
}

bool run = false;

do
{
    Show();
} while (run);


static void Show()
{
    Console.WriteLine("Entro una vez y ya");
}
