namespace Sebs.Creational.Builder.Email
{
    /// <summary>
    /// CreationalBuilder pattern can allow a lot of flexibility in how a class is created with fairly little effort. 
    ///  
    /// Separates the construction of a complex object from its representation so that 
    /// the same construction process can create different representations.
    /// Separate the logic from representation. •Reuse logic to work with different set of data.
    /// </summary>
    public class EmailBuilder
    {
        /// <summary>
        /// Encapsulated Model
        /// </summary>
        private readonly EmailModel _emailModel;

        /// <summary>
        /// Constructor Fluent CreationalBuilder
        /// </summary>
        public EmailBuilder()
        {
            _emailModel = new EmailModel();
        }

        #region Email Components
        public EmailBuilder To(string address)
        {
            _emailModel.To = address;
            return this;
        }

        public EmailBuilder From(string address)
        {
            _emailModel.From = address;
            return this;
        }

        public EmailBuilder Subject(string title)
        {
            _emailModel.Subject = title;
            return this;
        }

        public EmailBuilder Body(string content)
        {
            _emailModel.Body = content;
            return this;
        }
        #endregion

        /// <summary>
        /// Must be called at the end of the chain of method calls when building the object.
        /// </summary>
        /// <returns> returns the builded object </returns>
        public EmailModel Build() => _emailModel;
    }
}
