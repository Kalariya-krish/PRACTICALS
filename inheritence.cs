using System;

namespace PRACTICALS
{
    internal class inheritence
    {
        class Person
        {
            protected int ID;
            public string name;
            protected string city;

            public Person(int ID, string name, string city)
            {
                this.ID = ID;
                this.name = name;
                this.city = city;
            }
        }
    }
}
