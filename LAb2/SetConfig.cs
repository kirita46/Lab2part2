using System;
using System.Collections.Generic;
using System.Linq;

namespace LAb2
{
    public class Set<T>
    {
        private List<T> elements;

        public Set()
        {
            elements = new List<T>();
        }

        public Set(IEnumerable<T> elements)
        {
            this.elements = new List<T>(elements);
        }

        public static Set<T> operator +(Set<T> set, T item)
        {
            if (!set.elements.Contains(item))
                set.elements.Add(item);
            return set;
        }

        public static Set<T> operator +(Set<T> set1, Set<T> set2)
        {
            var union = new Set<T>(set1.elements);
            foreach (var item in set2.elements)
            {
                union += item;
            }
            return union;
        }

        public static Set<T> operator *(Set<T> set1, Set<T> set2)
        {
            var intersection = new Set<T>(set1.elements.Intersect(set2.elements));
            return intersection;
        }

        public static explicit operator int(Set<T> set)
        {
            return set.elements.Count;
        }

        public static bool operator false(Set<T> set)
        {
            return set.elements.Count < 3 || set.elements.Count > 10;
        }

        public static bool operator true(Set<T> set)
        {
            return set.elements.Count >= 3 && set.elements.Count <= 10;
        }

        public int Count => elements.Count;

        public T this[int index]
        {
            get => elements[index];
            set => elements[index] = value;
        }

        public override string ToString()
        {
            return "{" + string.Join(", ", elements) + "}";
        }

        public IEnumerable<T> Distinct<T>()
        {
            throw new NotImplementedException();
        }
    }
}