using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDictionary
{
    class Program
    {
        //Коллекция Dictionary<T,V>

        /*Еще один распространенный тип коллекции представляют словари. Словарь хранит объекты, 
         *которые представляют пару ключ-значение. Каждый такой объект является объектом структуры
         *KeyValuePair<TKey, TValue>. Благодаря свойствам Key и Value, которые есть у данной структуры, 
         *мы можем получить ключ и значение элемента в словаре.*/
        static void Main(string[] args)
        {
            Dictionary<int, string> MusicalInstruments = new Dictionary<int, string>(4);
            MusicalInstruments.Add(1, "Guitar");
            MusicalInstruments.Add(2, "Balalaika");
            MusicalInstruments.Add(3, "Piano");
            MusicalInstruments.Add(4, "Harp");

            foreach (KeyValuePair<int,string> instrument in MusicalInstruments)
            {
                Console.WriteLine(instrument.Key + " - " + instrument.Value);
            }

            //Получение элемента по ключу и вывод его value
            string instrument2 = MusicalInstruments[1];
            Console.WriteLine(instrument2);

            //Изменение объекта и вывод его value
            MusicalInstruments[2] = "Flute";
            Console.WriteLine(MusicalInstruments[2]);

            //Удаление по ключу и вывод через foreach
            MusicalInstruments.Remove(4);
            foreach (KeyValuePair<int, string> instrument in MusicalInstruments)
            {
                Console.WriteLine(instrument.Key + " - " + instrument.Value);
            }

            /*Класс словарей также, как и другие коллекции, предоставляет методы Add и 
             *Remove для добавления и удаления элементов. Только в случае словарей в метод 
             *Add передаются два параметра: ключ и значение. А метод Remove удаляет не по индексу, 
             *а по ключу.Так как в нашем примере ключами является объекты типа int, а значениями -
             *объекты типа string, то словарь в нашем случае будет хранить объекты KeyValuePair<int, 
             *string>. В цикле foreach мы их можем получить и извлечь из них ключ и значение.*/


            //Кроме того, мы можем получить отдельно коллекции ключей и значений словаря:

            Dictionary<char, Person> people = new Dictionary<char, Person>();
            people.Add('v',new Person() { Name = "Adam"});
            people.Add('c',new Person() { Name = "Eva"});
            people.Add('u',new Person() { Name = "Alex"});

            foreach (KeyValuePair<char,Person> keyValue in people)
            {
                // keyValue.Value представляет класс Person
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            // перебор ключей
            foreach (char c in people.Keys)
            {
                Console.WriteLine(c);
            }

            // перебор по значениям
            foreach (Person p in people.Values)
            {
                Console.WriteLine(p.Name);
            }

            /*^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ 
             *Здесь в качестве ключей выступают объекты типа char, а значениями - объекты Person. 
             *Используя свойство Keys, мы можем получить ключи словаря, а свойство Values соответственно 
             *хранит все значения в словаре.
             ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^*/

        }
    }
}
