namespace Sebs.OpenClosePrinciple
{
    public class TemporaryEmployeeModel : BaseEmployeeModel
    {
        public TemporaryEmployeeModel(string id, string name) 
            : base(id, name)
        {

        }

        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.025m;
        }
    }
}
