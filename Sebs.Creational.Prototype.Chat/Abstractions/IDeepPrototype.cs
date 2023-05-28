namespace Sebs.Creational.Prototype.ChatService.Abstractions
{
    internal interface IDeepPrototype
    {
        object DeepClone(int stars);
    }
}
