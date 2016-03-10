using System;
using System.Collections.Generic;

namespace FunctionalDictionaryTest
{
    public interface IFunctionalDictionary<TKey, TValue> : IEnumerable<KeyValuePair<Func<TKey, bool>, TValue>>
    {
        TValue this[TKey key] { get; }
        void Add(Func<TKey, bool> function, TValue value);
        void Clear();
        bool ContainsKey(TKey key);
    }
}