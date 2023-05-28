using Sebs.Creational.Builder.Faceted.Models;

namespace Sebs.Creational.Builder.Faceted.Builders
{
    //Facade builder
    public class PersonBuilder
    {
        protected PersonModel person = new PersonModel();

        public PersonProfileBuilder Profile => new(person);
        public PersonAddressBuilder Lives => new(person);

        public static implicit operator PersonModel(PersonBuilder pb)
        {
            return pb.person;
        }
    }
}