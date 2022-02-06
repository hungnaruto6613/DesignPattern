using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Factory
{
    public interface IAnimal
    {
        string GetName();
    }

    public class Cat : IAnimal
    {
        public string GetName()
        {
            return "I am Cat";
        }
    }

    public class Dog : IAnimal
    {
        public string GetName()
        {
            return "I am Dog";
        }
    }

    public class Duck: IAnimal
    {
        public string GetName()
        {
            return "I am Duck";
        }
    }

    interface IAnimalFactory
    {
        IAnimal CreateAnimal();
    }

    public class BasicIAnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            Random random = new Random();
            int type = random.Next(0, 3);
            if (type == 0)
            {
                return new Dog();
            }
            if (type == 1)
            {
                return new Duck();
            }
            return new Cat();
        }
    }

    public class RandomIAnimalFactory : IAnimalFactory
    {
        int index = 0;
        public IAnimal CreateAnimal()
        {
            if(index == 0)
            {
                index++;
                return new Dog();
            }
            if (index == 1)
            {
                index++;
                return new Duck();
            }
            index++;
            return new Cat();
        }
    }
}
