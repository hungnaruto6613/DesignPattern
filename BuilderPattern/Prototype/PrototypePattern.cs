using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Prototype
{
    public interface IDeepCopiable<T> 
    {
        T DeepCopy();
    }
    public class Address: IDeepCopiable<Address>
    {
        public string StreetName;
        public int HouseNumber;
        public Address(string streetName, int houseNumber)
        {
            if (streetName == null)
            {
                throw new ArgumentNullException(nameof(streetName));
            }
            StreetName = streetName;
            HouseNumber = houseNumber;
        }
        public Address(Address other)
        {
            StreetName = other.StreetName;
            HouseNumber = other.HouseNumber;
        }
        public override string ToString()
        {
            return $"{nameof(StreetName)}: {StreetName}, {nameof(HouseNumber)}: {HouseNumber}";
        }

        public Address DeepCopy()
        {
            return (Address)MemberwiseClone();
        }
    }

    public class Person : IDeepCopiable<Person>
    {
        public string[] Names;
        public Address Address;
        public Person(string[] names, Address address) 
        {
            Names = names ?? throw new ArgumentNullException(paramName: nameof(Names));
            Address = address ?? throw new ArgumentNullException(paramName: nameof(Address));
        }
        public Person()
        {

        }
        public Person(Person other)
        {
            this.Names = other.Names;
            this.Address = new Address(other.Address);
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(", ", Names)}, {nameof(Address)}: {Address}";
        }

        public Person DeepCopy()
        {
            return new Person((string[])Names.Clone(), Address.DeepCopy());
        }
    }

    public class Employee: Person, IDeepCopiable<Employee>
    {
        public int Salary;
        public Employee(string[] names, Address address, int salary)
            : base(names, address)
        {
            Salary = salary;
        }
        public Employee() : base()
        {

        }
        public override string ToString()
        {
            return $"{base.ToString()}, {nameof(Salary)}: {Salary}";
        }

        public Employee DeepCopy()
        {
            return new Employee((string[])Names.Clone(), Address.DeepCopy(), Salary);
        }
    }
}
