using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Factory
{
    public interface IAnimals
    {
        string GetName();
    }

    public abstract class TwoLegsAnimal : IAnimals
    {
        public abstract string GetName();
    }

    public abstract class FourLegsAnimal: IAnimals
    {
        public abstract string GetName();
    }

    public class Tiger : FourLegsAnimal
    {
        public override string GetName()
        {
            return "I am Tiger";
        }
    }

    public class Chickend : TwoLegsAnimal
    {
        public override string GetName()
        {
            return "I am Chicken";
        }
    }

    interface IAnimalsFactory
    {
        IAnimals CreateAnimal();
    }

    public abstract class AbstractAnimalFactory : IAnimalsFactory
    {
        public abstract IAnimals CreateAnimal();
    }

    public class AbstractTwoLegsAnimalFactory : AbstractAnimalFactory
    {
        public override IAnimals CreateAnimal()
        {
            return new Chickend();
        }
    }

    public class AbstractFourLegsAnimalFactory : AbstractAnimalFactory
    {
        public override IAnimals CreateAnimal()
        {
            return new Tiger();
        }
    }
}
