namespace Sebs.Creational.Builder.Faceted.Models
{
    /// <summary>
    /// Motivation for a faceted builder: 
    /// Basically a builder that acts a facade for multiple other builders that can built a single object
    /// </summary>
    public class PersonModel
    {
        //Section 1
        public string Name { get; set; }
        public string Position { get; set; }

        //Section 2
        public string Address { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return string.Format($"Name: {Name} - Position: {Position} - Address: {Address}- City: {City}");
        }
    }
}