using _5by5_Iterator;

var collection = new PersonsCollection();
collection.AddItem(new("Pestana", new Random().Next(1, 100)));
collection.AddItem(new("Felipe", new Random().Next(1, 100)));
collection.AddItem(new("Fabio", new Random().Next(1, 100)));
collection.AddItem(new("Andre", new Random().Next(1, 100)));

foreach(var item in collection)
{
    Console.WriteLine(item);
}

collection.ReverseDirection();

foreach (var item in collection)
{
    Console.WriteLine(item);
}

collection = collection.OrderByName();