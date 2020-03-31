using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace ObservableCollection
{
    class Program
    {
        //Класс ObservableCollection


        /*Кроме стандартных классов коллекций типа списков, очередей, словарей, стеков .NET также предоставляет специальный класс ObservableCollection. 
         *Он по функциональности похож на список List за тем исключением, что позволяет известить внешние объекты о том, что коллекция была изменена.
         */
        static void Main(string[] args)
        {
            ObservableCollection<User> users = new ObservableCollection<User>
            {
                new User{Name = "Adam"},
                new User{Name = "Alex"},
                new User{Name= "Eva"}
            };

            users.CollectionChanged += Users_CollectionChanged;

            users.Add(new User() { Name = "Bob" });
            users.RemoveAt(1);
            users[0] = new User { Name = "Sam" };

            foreach (var user in users)
            {
                Console.WriteLine(user.Name);
            }
        }

        private static void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: //если добавление
                    User newUser = e.NewItems[0] as User;
                    Console.WriteLine($"Добавлен новый объект: {newUser.Name}");
                    break;
                case NotifyCollectionChangedAction.Remove: //Если удаление
                    User oldUser = e.OldItems[0] as User;
                    Console.WriteLine($"Удален объект: {oldUser.Name}");
                    break;
                case NotifyCollectionChangedAction.Replace: //если замена
                    User replacedUser = e.OldItems[0] as User;
                    User replacingUser = e.NewItems[0] as User;
                    Console.WriteLine($"Объект {replacedUser.Name} заменен объектом {replacingUser.Name}");
                    break;
            }
        }
    }
}
