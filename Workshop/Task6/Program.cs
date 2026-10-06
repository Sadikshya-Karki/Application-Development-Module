List<string> fruits = new() {"Apple", "Banana", "Pineapple"};

fruits.Add("Litchi");
fruits.Remove("Apple");

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}


Dictionary<int, string> falful = new Dictionary<int, string>
{
    { 1, "Apple" },
    { 2, "Banana" },
    { 3, "Pineapple" },
};

falful.Add(4, "Litchi");  

foreach (KeyValuePair<int, string> item in falful)
{
    Console.WriteLine($"ID: {item.Key}, Fruit: {item.Value}");
}