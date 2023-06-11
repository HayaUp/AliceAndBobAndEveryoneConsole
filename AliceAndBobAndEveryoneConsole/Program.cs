using System;
using System.Collections.Generic;

namespace AliceAndBobAndEveryoneConsole
{
    public class User
    {
        public int Id;
        public string Name;

        public void Show()
        {
            Console.WriteLine($"{nameof(Id)} = {Id} / {nameof(Name)} = {Name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[]
            {
                "Alice",
                "Bob",
                "Carol",
                "Charlie",
                "Dave",
                "Ellen",
                "Frank",
                "Gari",
                "Haiku",
                "Issac",
                "Ivan",
                "Justin",
                "Katana",
                "Last",
                "Mallory",
                "Marvin",
                "Mallet",
                "Matilda",
                "Ninja",
                "Oscar",
                "Pat",
                "Peggy",
                "Plod",
                "Quantum",
                "Ramen",
                "Steve",
                "Trent",
                "Trudy",
                "Udon",
                "Victor",
                "Walter",
                "Xanadu",
                "Yakitori",
                "Zoe",
            };

            var users = new List<User>();

            for(int i = 0; i < names.Length; i++)
            {
                users.Add(new User { Id = i + 1, Name = names[i] });
            }

            users.ForEach(item => item.Show());
        }
    }
}
