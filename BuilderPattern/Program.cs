using BuilderPattern.Builder;
using BuilderPattern.Factory;
using System;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*===========Builder pattern============*/
            // Builder
            //var bd = new HtmlBuilder("ul");
            //bd.AddChild("li", "Hello").AddChild("li", "Goodbye");

            // Inheritance Builder
            //var myLove = Person.New.WorkAs("DBA").Called("Chuot Chean").Build();

            // StepWise Builder
            //var car = CarBuilder.Create()   // ISpecifyCarType
            //    .OfType(CarType.Crossover)  // ISpecifyWheelSize
            //    .WithWheels(18)             // IBuildCar
            //    .Build();

            // Functional Builder
            //var person = new PersonBuilder().Called("Chuot").WorkAs("Developer").Build();

            // Faceted Builder
            //var person = new PersonBuilder();
            //Person pb = person
            //            .AddressLive.AtCity("Konoha").AtStreet("Chuot").HavePostCode("123434")
            //            .Works.At("Hung Company").AsA("DBA").Income(123);

            // Builder excercise
            //var classBuilder = new ClassBuilder("Developer");
            //var code = classBuilder.AddField("Name", "string").AddField("Position", "string").AddField("Age", "int").AddField("Sex", "string");

            /*===========Factory pattern============*/
            // Factory Method
            //IAnimalFactory animalFactory;
            //Random random = new Random();
            //int type = 1;
            //if (type == 0)
            //{
            //    animalFactory = new BasicIAnimalFactory();
            //}
            //else
            //{
            //    animalFactory = new RandomIAnimalFactory();
            //}
            ////IAnimal animal = animalFactory.CreateAnimal();

            //Console.WriteLine(animalFactory.CreateAnimal().GetName());
            //Console.WriteLine(animalFactory.CreateAnimal().GetName());
            //Console.WriteLine(animalFactory.CreateAnimal().GetName());
            //Console.WriteLine(animalFactory.CreateAnimal().GetName());
            //Console.WriteLine(animalFactory.CreateAnimal().GetName());

            // FactoryPattern
            //IAnimalsFactory animals;
            //animals = new AbstractFourLegsAnimalFactory();
            //Console.WriteLine(animals.CreateAnimal().GetName());

            //animals = new AbstractTwoLegsAnimalFactory();
            //Console.WriteLine(animals.CreateAnimal().GetName());
            IPersonFactory personFactory = new PersonFactory();
            var person1 = personFactory.CreatePerson("Hung");
            var person2 = personFactory.CreatePerson("Chuot");
            Console.WriteLine(person1.ToString());
            Console.WriteLine(person2.ToString());
            Console.ReadLine();
        }
    }
}
