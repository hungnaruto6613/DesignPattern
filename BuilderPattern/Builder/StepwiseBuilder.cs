using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    public enum CarType
    {
        Sedan,
        Crossover
    }

    public class Car
    {
        public CarType Type;
        public int WheelSize;
        public override string ToString()
        {
            return $"{nameof(Type)}: {Type.ToString()}, {nameof(WheelSize)}: {WheelSize}";
        }
    }

    public interface ISpecifyCarType
    {
        ISpecifyWheelSize OfType(CarType type);
    }

    public interface ISpecifyWheelSize
    {
        IBuildCar WithWheels(int wheelSize);
    }

    public interface IBuildCar
    {
        Car Build();
    }

    public class CarBuilder
    {
        private class Impl : ISpecifyCarType, ISpecifyWheelSize, IBuildCar
        {
            private Car car = new Car();
            public Car Build()
            {
                return car;
            }

            public ISpecifyWheelSize OfType(CarType type)
            {
                car.Type = type;
                return this;
            }

            public IBuildCar WithWheels(int wheelSize)
            {
                switch (car.Type)
                {
                    case CarType.Crossover when wheelSize < 17 || wheelSize > 20:
                    case CarType.Sedan when wheelSize < 15 || wheelSize > 17:
                        throw new ArgumentException($"Wrong size of wheel for {car.Type}");
                }
                car.WheelSize = wheelSize;
                return this;
            }
        }

        public static ISpecifyCarType Create()
        {
            return new Impl();
        }
    }
}
