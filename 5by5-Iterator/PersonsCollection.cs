using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_Iterator
{
     internal class PersonsCollection : IteratorAggregate
    {
        List<Person> _collection = new List<Person>();
        bool _direction = false;

        public void ReverseDirection()
        {
              _direction = !_direction;
        }

        public List<Person> OrderByName()
        {
            List<Person> l = _collection.OrderBy(l => l.GetName()).ToList();
            return l;
        }
        public List<Person> GetItems()
        {
            return _collection;
        }
        public void AddItem(Person person)
        {
            _collection.Add(person);
        }
        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this,_direction);
        }
    }
}
