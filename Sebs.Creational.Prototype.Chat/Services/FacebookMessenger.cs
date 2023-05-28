using PrototypePattern.ChatService.Models;
using Sebs.Creational.Prototype.ChatService.Abstractions;

namespace Sebs.Creational.Prototype.ChatService.Services
{
    internal class FacebookMessenger : BaseChatService, IShallowPrototype
    {
        public ReferenceModel Stars { get; set; }
        public FacebookMessenger(int stars)
        {
            Stars = new ReferenceModel() { RatingStars = stars };
        }

        public override void Send(string message)
        {
            Console.WriteLine($"[{message}]");
        }

        public object ShallowClone()
        {
            return this.MemberwiseClone();
        }
    }
}
