using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder
{
    /*public class Person
    {
        public string Name, Position;
        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Position)}: {Position}";
        }
    }

    public abstract class FunctionalBuilder<TSubject, TSelf> 
        where TSubject : new()
        where TSelf : FunctionalBuilder<TSubject, TSelf>
    {
        private readonly List<Func<Person, Person>> actions = new List<Func<Person, Person>>();
        public TSelf Do(Action<Person> action) => AddAction(action);
        // public TSelf Called(string name) => Do(p => p.Name = name);
        public Person Build() => actions.Aggregate(new Person(), (p, f) => f(p));
        private TSelf AddAction(Action<Person> action)
        {
            actions.Add(p =>
            {
                action(p);
                return p;
            });
            return (TSelf)this;
        }
    }

    public sealed class PersonBuilder: FunctionalBuilder<Person, PersonBuilder>
    {
        public PersonBuilder Called(string name) => Do(p => p.Name = name);
    }

    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WorkAs(this PersonBuilder builder, string position) => builder.Do(p => p.Position = position);
    }*/

    //public static class PersonBuilderExtensions
    //{
    //    public static PersonBuilder WorkAs(this PersonBuilder builder, string position) => builder.Do(p =>  p.Position = position);
    //}

    //public sealed class PersonBuilder
    //{
    //    private readonly List<Func<Person, Person>> actions = new List<Func<Person, Person>>();
    //    public PersonBuilder Do(Action<Person> action) => AddAction(action);
    //    public PersonBuilder Called(string name) => Do(p => p.Name = name);
    //    public Person Build() => actions.Aggregate(new Person(), (p, f) => f(p));
    //    private PersonBuilder AddAction(Action<Person> action)
    //    {
    //        actions.Add(p =>
    //        {
    //            action(p);
    //            return p;
    //        });
    //        return this;
    //    }
}
