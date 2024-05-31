using _5by5_Iterator;
using System;
using System.Collections.Generic;

public class Manipulate
{
    public List<Person> Lista { get; private set; }
    public Stack<Person> Pilha { get; private set; }
    public Queue<Person> Fila { get; private set; }

    public Manipulate()
    {
        Lista = new List<Person>();
        Pilha = new Stack<Person>();
        Fila = new Queue<Person>();
    }
    public void AddPerson(Person p)
    {
        Lista.Add(p);
        Pilha.Push(p);
        Fila.Enqueue(p);
    }

    //Retornar um iterador generico para qualquer manipulação de person
    public IEnumerator<Person> GetIterator(IEnumerable<Person> collection)
    {
        return collection.GetEnumerator();
    }
}
