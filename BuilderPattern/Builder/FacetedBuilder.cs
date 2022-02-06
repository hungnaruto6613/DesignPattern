//namespace BuilderPattern.Builder
//{
//    public class Person
//    {
//        public string StreetAddress, PostCode, City;
//        public string CompanyName, Position;
//        public int AnnualIncome;
//        public override string ToString()
//        {
//            return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(PostCode)}: {PostCode}, {nameof(City)}: {City}, {nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}";
//        }
//    }

//    public class PersonBuilder
//    {
//        protected Person person = new Person();
//        public PersonJobBuilder Works => new PersonJobBuilder(person);
//        public PersonAddressBuilder AddressLive => new PersonAddressBuilder(person);
//        public static implicit operator Person(PersonBuilder pb)
//        {
//            return pb.person;
//        }
//    }

//    public class PersonJobBuilder : PersonBuilder
//    {
//        public PersonJobBuilder(Person person)
//        {
//            this.person = person;
//        }

//        public PersonJobBuilder At(string companyName)
//        {
//            person.CompanyName = companyName;
//            return this;
//        }

//        public PersonJobBuilder AsA(string position)
//        {
//            person.Position = position;
//            return this;
//        }

//        public PersonJobBuilder Income(int income)
//        {
//            person.AnnualIncome = income;
//            return this;
//        }
//    }

//    public class PersonAddressBuilder : PersonBuilder
//    {
//        public PersonAddressBuilder(Person person)
//        {
//            this.person = person;
//        }

//        public PersonAddressBuilder AtStreet(string address)
//        {
//            person.StreetAddress = address;
//            return this;
//        }

//        public PersonAddressBuilder HavePostCode(string postCode)
//        {
//            person.PostCode = postCode;
//            return this;
//        }

//        public PersonAddressBuilder AtCity(string city)
//        {
//            person.City = city;
//            return this;
//        }
//    }
//}
