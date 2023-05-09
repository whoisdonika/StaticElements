using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassPerson
{
    internal class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private static int counter;
        public static int Counter
        {
            get { return counter; }
        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            counter++;
        }
    }
}

