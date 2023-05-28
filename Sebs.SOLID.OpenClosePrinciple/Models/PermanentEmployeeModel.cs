namespace Sebs.OpenClosePrinciple
{
    public class PermanentEmployeeModel : BaseEmployeeModel
    {
        public PermanentEmployeeModel(string id, string name) 
            : base(id, name)
        {

        }
        public override decimal CalculateBonus(decimal salary)
        {
            return salary * 0.05m;
        }
    }
}
