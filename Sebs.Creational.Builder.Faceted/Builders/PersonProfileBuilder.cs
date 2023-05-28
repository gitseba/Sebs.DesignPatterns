using Sebs.Creational.Builder.Faceted.Models;

namespace Sebs.Creational.Builder.Faceted.Builders
{
    public class PersonProfileBuilder : PersonBuilder
    {
        public PersonProfileBuilder(PersonModel personModel)
        {
            person = personModel;
        }

        public PersonProfileBuilder Name(string name)
        {
            person.Name = name;
            return this;
        }
        public PersonProfileBuilder WorksAs(string position)
        {
            person.Position = position;
            return this;
        }
    }
}