using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        //Коллекция Stack<T>
        /*Класс Stack<T> представляет коллекцию, которая использует алгоритм LIFO 
         * ("последний вошел - первый вышел"). При такой организации каждый следующий 
         * добавленный элемент помещается поверх предыдущего. Извлечение из коллекции 
         * происходит в обратном порядке - извлекается тот элемент, который находится 
         * выше всех в стеке.*/

        /*В классе Stack можно выделить два основных метода, которые позволяют управлять элементами:
         * Push: добавляет элемент в стек на первое место
         * Pop: извлекает и возвращает первый элемент из стека
         * Peek: просто возвращает первый элемент из стека без его удаления*/
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            numbers.Push(3);
            numbers.Push(7);
            numbers.Push(2);    //в стеке будет такой порядок 2, 7, 3

            int stackElement = numbers.Pop(); //В стеке 7, 3
            Console.WriteLine(stackElement);

            Stack<Person> persons = new Stack<Person>();
            persons.Push(new Person() { Age = 34, Name = "Вася"});
            persons.Push(new Person() { Age = 25, Name = "Петя"});
            persons.Push(new Person() { Age = 18, Name = "Анна"}); //В стеке будеь такой порядок: Анна, Петя, Вася

            foreach (Person per in persons)
            {
                Console.WriteLine(per.Name, " ", per.Age);
            }

            Person p = persons.Pop();   //Теперь в стеке : Петя, Вася
            Person.ShowPerson(p);

        }
    }
}
