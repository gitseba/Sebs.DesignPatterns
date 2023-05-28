using Sebs.Creational.Builder.Faceted.Builders;
using Sebs.Creational.Builder.Faceted.Models;

namespace Sebs.Creational.Builder.Faceted
{
    /// <summary>
    /// The Faceted Builder pattern is a variation of the Builder pattern that aims to provide a fluent interface 
    /// for building complex objects with multiple facets or properties. It allows you to separate the construction process 
    /// into different builder objects, each responsible for setting a specific subset of properties or facets of the final object.

    /// The key idea behind the Faceted Builder pattern is to provide a clear and readable way of constructing objects 
    /// by utilizing a chain of method calls, where each method corresponds to a different aspect of the object being built.
    /// This allows you to specify different properties or facets independently and in any desired order.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {

            PersonModel person = new PersonBuilder()
              .Profile
                  .Name("Seb").WorksAs("Engineer")
              .Lives
                  .StaysAt("str B Voda nr 13")
                  .InCity("Homeland");

            Console.ReadLine();
        }
    }
}