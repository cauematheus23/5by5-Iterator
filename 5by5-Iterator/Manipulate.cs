using _5by5_Iterator;
using System;
using System.Collections.Generic;

public class Manipulate
{
    public List<Person> Lista { get;  set; }
    public Stack<Person> Pilha { get;  set; }
    public Queue<Person> Fila { get;  set; }
    public Queue<Person> _colletion { get;  set; }
    public Manipulate()
    {
        Lista = new List<Person>();
        Pilha = new Stack<Person>();
        Fila = new Queue<Person>();
        _colletion = new Queue<Person>();
    }
    public void AddPerson(Person p)
    {
        Lista.Add(p);
        Pilha.Push(p);
        Fila.Enqueue(p);
        _colletion.Enqueue(p);
    }

    //Retornar um iterador generico para qualquer manipulação de person
    public IEnumerator<Person> GetIterator(IEnumerable<Person> collection)
    {
        return collection.GetEnumerator();
    }
    
}
