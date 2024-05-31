using _5by5_Iterator;
using System;

var manipulator = new Manipulate();


    manipulator.AddPerson(new Person("Pestana", new Random().Next(1,100)));
    manipulator.AddPerson(new Person("Fabio", new Random().Next(1, 100)));
    manipulator.AddPerson(new Person("Andre", new Random().Next(1, 100)));



Console.WriteLine("FOREACH LISTA");
foreach (var i in manipulator.Lista)
{
    Console.WriteLine(i);
}
Console.WriteLine("========================");
Console.WriteLine("FOREACH PILHA");
foreach (var i in manipulator.Pilha)
{
    Console.WriteLine(i);
}
Console.WriteLine("========================");
Console.WriteLine("FOREACH FILA");
foreach (var i in manipulator.Fila)
{
    Console.WriteLine(i);
}
Console.WriteLine("========================");

Console.WriteLine("ITERANDO LISTA");
var listaIterator = manipulator.GetIterator(manipulator.Lista);
while (listaIterator.MoveNext())
    {
        Console.WriteLine(listaIterator.Current);
    }
Console.WriteLine("========================");

Console.WriteLine("ITERANDO PILHA");
var pilhaIterator = manipulator.GetIterator(manipulator.Pilha);
while (pilhaIterator.MoveNext())
{
    Console.WriteLine(pilhaIterator.Current);
}
Console.WriteLine("========================");

Console.WriteLine("ITERANDO FILA");
var filaIterator = manipulator.GetIterator(manipulator.Fila);
while (filaIterator.MoveNext())
{

    Console.WriteLine(filaIterator.Current);
}
Console.WriteLine("========================");


