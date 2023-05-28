using Sebs.Creational.Builder.Faceted.Models;

namespace Sebs.Creational.Builder.Faceted.Builders
{
    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(PersonModel personModel)
        {
            person = personModel;
        }

        public PersonAddressBuilder StaysAt(string address)
        {
            person.Address = address;
            return this;
        }
        public PersonAddressBuilder InCity(string city)
        {
            person.City = city;
            return this;
        }
    }
}