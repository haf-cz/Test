using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Jan = new Person("Jan", "Novak", new DateTime(1987, 11, 19));
            Console.WriteLine("Press Enter to end");
            Console.ReadLine();
        }

        private class Person
        {
             public Person(string FirstName, string v2, DateTime DateOfBirth)
            {
                this.FirstName = FirstName;
                this.LastName = v2;
                this.DateOfBirth = DateOfBirth;
            }

            public DateTime DateOfBirth { get; internal set; }
            public string FirstName { get; internal set; }
            public string LastName { get; internal set; }

            public int Age
            {
                get
                {
                    return (DateTime.Now - this.DateOfBirth).Days / 365;
                }
            }

            public override string ToString() => $"{FirstName} {LastName} is {Age} old";
        }
    }
}
