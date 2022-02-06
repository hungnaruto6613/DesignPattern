using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Factory
{
    public interface IPerson
    {
        string GetName();
    }

    public class Person : IPerson
    {
        public int Id;
        public string Name;

        public Person(int id, string name)
        {
            this.Name = name;
            this.Id = id;
        }
        public string GetName()
        {
            return Name;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Id: {Id}";
        }
    }

    public interface IPersonFactory
    {
        IPerson CreatePerson(string name);
    }

    public class PersonFactory: IPersonFactory
    {
        public int index = 0;
        public IPerson CreatePerson(string name)
        {
            var person = new Person(index, name);
            index++;
            return person;
        }
    }
}
