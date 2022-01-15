using BuilderPattern.Builder;
using System;

namespace BuilderPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Builder
            var bd = new HtmlBuilder("ul");
            bd.AddChild("li", "Hello").AddChild("li", "Goodbye");
            Console.WriteLine(bd.ToString());
            Console.ReadLine();
        }
    }
}
