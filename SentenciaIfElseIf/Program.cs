
bool areYouHungry = true;
bool youHaveMoney = true;

if (areYouHungry && youHaveMoney && IsRestaurantOpen("Lonches pepe", 11))
{
    Console.WriteLine("Come");
}
else
{
    Console.WriteLine("No comes");
}

static bool IsRestaurantOpen(string name, int hour = 0)
{
    if (name == "Lonches pepe" && hour > 8 && hour < 23)
    {
        return true;
    } else if (name ==  "Restaurant 24 horas")
    {
        return true;
    } else
    {
        return false;
    }

}
