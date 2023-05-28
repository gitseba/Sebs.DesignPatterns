using Sebs.Creational.Builder.Faceted.Models;

namespace Sebs.Creational.Builder.Faceted.Builders
{
    //Facade builder
    public class PersonBuilder
    {
        protected PersonModel person = new PersonModel();

        public PersonProfileBuilder Profile => new PersonProfileBuilder(person);
        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

        public static implicit operator PersonModel(PersonBuilder pb)
        {
            return pb.person;
        }
    }
}