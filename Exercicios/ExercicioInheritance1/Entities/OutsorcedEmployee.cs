
namespace Course.Entities
{
    class OutsorcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }
        public OutsorcedEmployee()
        {
        }
        public OutsorcedEmployee(string name, int hour, double valueperhour, double additionalcharge) 
            : base(name, hour, valueperhour)
        {
            AdditionalCharge = additionalcharge;
        }
        public override double Payment()
        {
            return base.Payment() + 1.10 * AdditionalCharge;
        }
    }
}