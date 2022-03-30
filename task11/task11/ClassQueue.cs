using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;
using System.Linq;

namespace task11
{
    class ClassQueue:ICloneable
    {
        Queue<Person> people = null;
    
        public ClassQueue()
        {
            people = new Queue<Person>();
        }

        public Queue<Person> AddElement(Person elem)
        {
            people.Enqueue(elem);
            return people;
        }

        public Queue<Person> DeleteElement()
        {
            if(people.Count!=0)
                people.Dequeue();
            else
                Console.WriteLine("Нельзя удалить элемент. Очередь пустая!");
            return people;
        }

        public void Show()
        {
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }

        public void PersonCount()
        {
            int i = 0;
            foreach (var person in people)
            {
                i++;
            }
            Console.WriteLine(i);
        }

        public void EngineerPrint()
        {
            foreach (Person p in people)
            {
                if (p is Engineer)
                {
                    Console.WriteLine(p);
                }
            }
        }

        public void WorkerPrint()
        {
            foreach (Person p in people)
            {
                if (p is Worker)
                {
                    Console.WriteLine(p);
                }
            }
        }

        public object Clone()
        {
            Queue<Person> clonable = new Queue<Person>();
            foreach (var elem in people)
            {
                clonable.Enqueue((Person)elem.Clone());
            }
            return clonable;
        }

        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        public Queue<Person> Sort()
        {
            var list = people.ToList();
            list.Sort();
            people = new Queue<Person>(list);
            return people;
        }

        public void Search(Person elem)
        {
            bool find = false;
            foreach (var person in people)
            {
               if ((person.ToString()).Contains(elem.ToString()))
                {
                    find = true;
                    Console.WriteLine(elem);
                }
 
            }
            if (!find)
                Console.WriteLine("Не нашлось!!!");
        }


    }
}




    