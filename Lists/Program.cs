using System.Collections.Generic;

List<int> numbers = new List<int>();
numbers.Add(5);
numbers.Add(2);

Console.WriteLine(numbers.Count);


List<int> numbers2 = new List<int>()
{
    1,2,3,4,5,6,7,8,9
};

Console.WriteLine(numbers2.Count);

numbers2.Add(66);
Console.WriteLine(numbers2.Count);


numbers2.Clear();
Console.WriteLine(numbers2.Count);

List<string> countries = new List<string>()
{
    "Mexico", "Argentina", "España"
};
Console.WriteLine(countries.Count);