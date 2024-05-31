using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5by5_Iterator
{
    abstract class  Iterator : IEnumerator
    {

        object IEnumerator.Current => Current();
        public abstract int Position();
        public abstract bool MoveNext();
        public abstract object Current();
        public abstract void Reset();
    }
    abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
    internal class AlphabeticalOrderIterator : Iterator
    {
        private PersonsCollection _collection;
        private int _index = -1;
        private bool _reverse = false;
        public AlphabeticalOrderIterator(PersonsCollection collection, bool reverse = false)
        {
            this._collection = collection;
            this._reverse = reverse;

            if (reverse)
            {
                this._index = collection.GetItems().Count;
            }
        }
        public override object Current()
        {
            return this._collection.GetItems()[this._index];
        }
        public override int Position()
        {
            return this._index;
        }
        public override bool MoveNext()
        {
            int updateIndex = this._index + (this._reverse ? -1 : 1);
            if(updateIndex >= 0 && updateIndex < this._collection.GetItems().Count)
            {
                this._index= updateIndex;
                return true;
            }
            else
            {
                return false;
            }
        }
        public override void Reset()
        {
            this._index = this._reverse ? this._collection.GetItems().Count - 1 : 0;
        }
    }
}
