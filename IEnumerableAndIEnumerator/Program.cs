using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumerableAndIEnumerator
{
    #region Sample2

    //class Week : IEnumerable
    //{
    //    string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

    //    public IEnumerator GetEnumerator()
    //    {
    //        return days.GetEnumerator();
    //    }
    //}
    #endregion
    #region Sample3
    class WeekEnumerator : IEnumerator
    {
        string[] days;
        int position = -1;
        public WeekEnumerator(string[] days)
        {
            this.days = days;
        }

        public object Current
        {
            get
            {
                if (position == -1 || position >= days.Length)
                    throw new InvalidOperationException();
                return days[position];
            }
        }

        public bool MoveNext()
        {
            if (position < days.Length - 1)
            {
                position++;
                return true;
            }
            else
                return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }

    class Week
    {
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public IEnumerator GetEnumerator()
        {
            return new WeekEnumerator(days);
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            #region Sample1
            ////без использования цикла foreach перебирем коллекцию с помощью интерфейса IEnumerator:
            //int[] numbers = { 0, 2, 4, 6, 8, 10 };
            //IEnumerator ie = numbers.GetEnumerator(); // Получаем IEnumerator
            //while (ie.MoveNext()) // Пока н ебудет возвращено false
            //{
            //    int item = (int)ie.Current; //Берем элемент на текущей позиции
            //    Console.WriteLine(item);
            //}
            //ie.Reset(); //Сбрасываем указатель в начало массива
            #endregion
            #region Sample2
            ////Реализация IEnumerable и IEnumerator
            //Week week = new Week();
            //foreach (var day in week)
            //{
            //    Console.WriteLine(day);
            //}
            #endregion
            #region Sample3
            //Однако, возможно, потребуется задать свою собственную логику перебора объектов.Для этого реализуем интерфейс IEnumerator:
            Week week = new Week();
            foreach (var day in week)
            {
                Console.WriteLine(day);
            }
            //В примерах выше использовались необобщенные версии интерфейсов, однако мы также можем использовать их обобщенные двойники
            #endregion
        }
    }
}
