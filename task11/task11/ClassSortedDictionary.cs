using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;
using System.Linq;

namespace task11
{
    class ClassSortedDictionary:ICloneable
    {
        SortedDictionary<Person, Worker> dictionary = null;

        public ClassSortedDictionary()
        {
            dictionary = new SortedDictionary<Person, Worker>();
        }

        public SortedDictionary<Person, Worker> AddElement(Person key, Worker value)
        {
            dictionary.Add(key, value);
            return dictionary;
        }

        public SortedDictionary<Person, Worker> DeleteElement(Person key)
        {
            dictionary.Remove(key);
            return dictionary;
        }

        public void Show()
        {
            foreach(var element in dictionary )
                Console.WriteLine(element);
        }

        public object Clone()
        {
            SortedDictionary<Person, Worker> clonable = new SortedDictionary<Person, Worker>();

            foreach (var element in dictionary)
            {
                Person key = (Person)element.Key.Clone();
                Worker value = (Worker)element.Value.Clone();
                clonable.Add(key, value);
            }

            return clonable;
        }

        public void ShowWorkers()
        {
            foreach (var element in dictionary)
            {
                Console.WriteLine(element.Value);
            }  
        }

        public void ShowPersons()
        {
            foreach (var element in dictionary)
            {
                Console.WriteLine(element.Key);
            }
        }

        public void Length()
        {
            int count = 0;
            foreach (var element in dictionary)
            {
                count++;
            }
            Console.WriteLine(count);
        }

        public void Sort()
        {
            foreach (var element in dictionary.OrderBy(key => key.Value.Name))
                Console.WriteLine(element);
        }


    }
}
