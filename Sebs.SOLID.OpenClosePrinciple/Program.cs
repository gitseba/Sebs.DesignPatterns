using Sebs.OpenClosePrinciple;

namespace Sebs.SOLID.OpenClosePrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OCP - Open Closed Principle");

            //Instead of creating employees by sending parameters
            //BaseEmployee dummyPermanentEmployee = new BaseEmployee("Permanent");
            //BaseEmployee dummyTemporaryEmployee = new BaseEmployee("Temporary");

            // OCP implies: create classes that represent options/strategies/extensions
            BaseEmployeeModel permanentEmployee = new PermanentEmployeeModel("1", "John");
            Console.WriteLine($"Permanent employee Bonus: {permanentEmployee.CalculateBonus(salary: 10505)}");

            BaseEmployeeModel temporaryEmployee = new TemporaryEmployeeModel("1", "Will");
            Console.WriteLine($"Temporary employee Bonus: {temporaryEmployee.CalculateBonus(salary: 15205)}");

            Console.ReadLine();
        }
    }
}