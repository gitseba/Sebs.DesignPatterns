namespace Sebs.Creational.FactoryMethod.Factories
{
    /// <summary>
    /// Purpose: 
    /// Created by: sebde
    /// Created at: 5/28/2023 1:25:38 PM
    /// </summary>
    public class ObjectFactory
    {
        /// <summary>
        /// Get specific object 
        /// </summary>
        /// <returns> Created object </returns>
        public static T? Instance<T>()
           where T : class
        {
            var obj = Activator.CreateInstance<T>();
            return obj ?? null; //obj != null ? obj : null;
        }

        /// <summary>
        /// Get specific object 
        /// </summary>
        /// <param name="param"> dependencies </param>
        /// <returns> Created object </returns>
        public static T? Instance<T>(object[] param)
            where T : class
        {
            var obj = Activator.CreateInstance(typeof(T), param);
            return obj as T ?? null; //obj != null ? obj : null;
        }
    }
}
