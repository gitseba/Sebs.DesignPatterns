namespace Sebs.OpenClosePrinciple
{
    public abstract class BaseEmployeeModel
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public BaseEmployeeModel()
        {

        }

        public BaseEmployeeModel(string id, string name)
        {
            Id = id;
            Name = name;
        }

        public abstract decimal CalculateBonus(decimal salary);

        public override string ToString()
        {
            return string.Format("Id: {0} - Name: {1}", this.Id, this.Name);
        }
    }
}
