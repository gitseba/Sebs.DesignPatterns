using PrototypePattern.ChatService.Models;
using Sebs.Creational.Prototype.ChatService.Abstractions;

namespace Sebs.Creational.Prototype.ChatService.Services
{
    internal class Skype : BaseChatService, IDeepPrototype
    {
        public ReferenceModel Stars { get; set; }
        public Skype(int stars)
        {
            Stars = new ReferenceModel() { RatingStars = stars };
        }

        public override void Send(string message)
        {
            Console.WriteLine($"[{ConsoleColor.Cyan} {message}]");
        }

        public object DeepClone(int stars)
        {
            var clonedSkype = (Skype)this.MemberwiseClone();
            clonedSkype.Stars = new ReferenceModel() { RatingStars = stars };
            return (Skype)clonedSkype;
        }
    }
}
