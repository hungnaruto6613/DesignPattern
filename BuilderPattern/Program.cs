
using DesignPattern.OOP;
using System;
using System.Collections.Generic;

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

            //// FactoryPattern
            //IAnimalsFactory animals;
            //animals = new AbstractFourLegsAnimalFactory();
            //Console.WriteLine(animals.CreateAnimal().GetName());

            //animals = new AbstractTwoLegsAnimalFactory();
            //Console.WriteLine(animals.CreateAnimal().GetName());
            //IPersonFactory personFactory = new PersonFactory();
            //var person1 = personFactory.CreatePerson("Hung");
            //var person2 = personFactory.CreatePerson("Chuot");
            //Console.WriteLine(person1.ToString());
            //Console.WriteLine(person2.ToString());

            //// Prototype pattern
            //var employee = new Employee(new string[] { "Hung", "Khung" }
            //, new Address("Konoha", 12)
            //, 1000000000);

            //var otherEmployee = new Employee();
            //otherEmployee.Address = new Address("Konoha 1", 12);
            //otherEmployee.Names = new string[] { "Hung 1", "Khung 1" };
            //otherEmployee.Salary = 20000;

            //var clonedEmployee = otherEmployee.DeepCopy();
            //clonedEmployee.Names = new string[] { "chuot 1", "sida 1" };
            //clonedEmployee.Salary = 12312313;
            //clonedEmployee.Address = new Address("lang la 1", 32);
            //Console.WriteLine(employee.ToString());
            //Console.WriteLine(otherEmployee.ToString());
            //Console.WriteLine(clonedEmployee.ToString());

            Shape shape = new Circle();
            Shape shape1 = new Rectangle();
            Shape shape2 = new Triangle();
            shape.Draw();
            shape1.Draw();
            shape2.Draw();
            Console.ReadLine();
        }
    }
}
