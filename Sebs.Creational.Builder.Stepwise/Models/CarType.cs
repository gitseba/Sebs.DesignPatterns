namespace Sebs.Creational.Builder.Stepwise.Models
{
    /// <summary>
    /// Motivation for Stepwise builder:
    /// How to implement builders that shows methods in specific order, for example:
    /// If Sedan the wheelsize should be between 15-17 inches
    /// If Crossover, the wheelsize should be between 17-21 inches
    /// So, Implement a builder that knows first the type, and only after that show the wheelsize.
    /// For this type of builder, we can leverage, the Interface Segregation Principle.
    /// </summary>
    public enum CarType
    {
        Sedan,
        Crossover
    }
}