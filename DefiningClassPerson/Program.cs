using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassPerson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Gosho", 13);
            Person person2 = new Person("Boyan", 15);
            Person person3 = new Person("Petya", 27);
            Console.WriteLine(Person.Counter);
        }
    }
}
