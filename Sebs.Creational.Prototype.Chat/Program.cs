using Sebs.Creational.Prototype.ChatService.Services;

namespace Sebs.Creational.Prototype.Chat
{
    /// <summary>
    /// Prototype design pattern.
    /// Lets say I am customer of a bank and to open an account I need to provide some documents => ID, Social Insurance Documents
    /// This list can be quiet huge. To create account I have provided this data.
    /// So when after some time I will need some new account I DO NOT need to provide all this information.
    /// Bank can clone data.So the main target of prototype design pattern is saving cost of creating new Object.
    /// Hence the main idea of Prototype pattern is NOT saving efforts on memory allocation 
    /// but on creating your object as it may be data driven or result of a calculation, or holding some stage information.
    /// </summary>
    /// <reference>https://stackoverflow.com/questions/33083700/when-to-use-prototype-design-pattern</reference>
    /// The concepts of deep copy and shallow copy are related to copying objects in programming. They define different ways of duplicating an object and handling its internal references. Here's an explanation of the differences between deep copy and shallow copy:

    ///Shallow Copy:
    ///Shallow copy creates a new object but copies only the references of the original object's internal members.
    ///The new object and the original object share the same internal references, meaning they point to the same memory locations.
    ///Changing a shared reference in one object affects the other object.
    ///Shallow copy is a relatively faster and simpler operation compared to deep copy.
    ///Shallow copy is the default behavior when using the assignment operator or MemberwiseClone() method in C#.

    ///Deep Copy:
    ///Deep copy creates a new object and recursively copies all of the original object's internal members, 
    ///including any nested objects or value types.
    ///The new object and the original object have separate copies of their internal members, 
    ///ensuring that changes in one object do not affect the other.
    ///Deep copy can be a more time-consuming and complex operation, especially for complex object graphs 
    ///with many nested objects or references.
    ///Deep copy requires implementing custom copying logic to handle each internal member appropriately.
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"------------------- Prototype Pattern -----------------\n");

            ///* SHALLOW CLONE */
            Console.WriteLine($" ------------------- SHALLOW CLONE -----------------\n");
            //FormatText.ColorFormatCapability($"1. Create fb messenger object!");
            FacebookMessenger fbMessenger = new(5);
            fbMessenger.Send($"Send message using fb message service! This service has {fbMessenger.Stars.RatingStars} stars rating.");

            Console.WriteLine($"2. Shallow clone fb messenger object.");
            var shallowClonedFbMessenger = (FacebookMessenger)fbMessenger.ShallowClone();
            Console.WriteLine($"3. Shallow clone reference value is {shallowClonedFbMessenger.Stars.RatingStars}");
            Console.WriteLine($"4. Change fb service stars reference object value to {fbMessenger.Stars.RatingStars = 10}");
            Console.WriteLine($"5. Shallow clone reference value is {shallowClonedFbMessenger.Stars.RatingStars}, same as original object!");
            Console.WriteLine("Conclusion: Shallow objects copy also pointers to inside references, so if one of the reference value is changing, the value of the clone will change too.");


            ///* DEEP CLONE */
            Console.WriteLine($"------------------- DEEP CLONE -----------------\n");
            Console.WriteLine($"1. Create skype object!");
            Skype skype = new(25);
            fbMessenger.Send($"Send message using skype service! This service has {skype.Stars.RatingStars} stars rating.");

            Console.WriteLine($"2. Deep clone skype object.");
            var deepClonedSkype = (Skype)skype.DeepClone(50);
            Console.WriteLine($"3. Deep clone reference value is {deepClonedSkype.Stars.RatingStars}");
            Console.WriteLine($"4. Change skype service stars to {skype.Stars.RatingStars = 100}");
            Console.WriteLine($"5. Deep clone reference value is {deepClonedSkype.Stars.RatingStars} not the same as original object!]");

            Console.WriteLine($"Conclusion: Deep cloned objects don't copy the pointers from inside references.]");
            Console.ReadKey();
        }
    }
}
