using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndYield
{
    class Program
    {
        /*Итератор по сути представляет блок кода, который использует оператор yield для перебора набора значений. 
         *Данный блок кода может представлять тело метода, оператора или блок get в свойствах.*/
        static void Main(string[] args)
        {
            #region Sample1
            //Numbers numbers = new Numbers();
            //foreach (int n in numbers)
            //{
            //    Console.WriteLine(n);
            //}
            #endregion
            #region Sample2
            Library library = new Library();
            /*Вызов library.GetBooks(5) будет возвращать набор из не более чем 5 объектов Book. 
             *Но так как у нас всего три таких объекта, то в методе GetBooks после трех операций сработает оператор yield break.*/
            foreach (Book b in library.GetBooks(7))
            {
                Console.WriteLine(b.Name);
            }
            #endregion
        }
    }

    #region Sample1
    //class Numbers
    //{
    //    public IEnumerator GetEnumerator()
    //    {
    //        for(int i = 0; i < 6; i++)
    //        {
    //            yield return i * i;
    //        }
    //    }
    //}
    #endregion
    #region Sample2
    class Book
    {
        public Book(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
    }

    class Library
    {
        private Book[] books;
        public Library()
        {
            books = new Book[] { new Book("Иметь или быть"), new Book("Фонтаны рая"), new Book("Наука логики") };
        }

        public int Length
        {
            get { return books.Length; }
        }

        /*Определенный здесь итератор - метод IEnumerable GetBooks(int max) в качестве параметра принимает количество выводимых объектов. 
         *В процессе работы программы может сложиться, что его значение будет больше, чем длина массива books. И чтобы не произошло ошибки, 
         *используется оператор yield break. Этот оператор прерывает выполнение итератора.*/
        public IEnumerable GetBooks(int max)
        {
            for(int i = 0; i < max; i++)
            {
                if (i == books.Length)
                {
                    yield break;
                }
                else
                {
                    yield return books[i];
                }
            }
        }
    }
    #endregion
}
