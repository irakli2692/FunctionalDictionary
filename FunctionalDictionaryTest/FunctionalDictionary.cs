using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable RedundantBoolCompare

namespace FunctionalDictionaryTest
{
    public class FunctionalDictionary<TKey, TValue> : IFunctionalDictionary<TKey, TValue>
    {
        private readonly IList<KeyValuePair<Func<TKey, bool>, TValue>> _items =
            new List<KeyValuePair<Func<TKey, bool>, TValue>>();

        public TValue this[TKey key]
        {
            get
            {
                foreach (var pair in _items.Where(pair => pair.Key(key) == true))
                {
                    return pair.Value;
                }

                throw new KeyNotFoundException("key doesn't match any function");
            }
        }


        public void Add(Func<TKey, bool> function, TValue value)
        {
            _items.Add(new KeyValuePair<Func<TKey, bool>, TValue>(function, value));
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool ContainsKey(TKey key)
        {
            return _items.Any(pair => pair.Key(key) == true);
        }

        public IEnumerator<KeyValuePair<Func<TKey, bool>, TValue>> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}