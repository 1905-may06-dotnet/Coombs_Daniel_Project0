namespace BasicOfOops
{
    class Manager : Employee
    {
        decimal perks;
        public Manager(decimal perks)
        {
            this.perks = perks;
        }
        public override decimal GetSalary() {
            return base.salary = base.bsal + base.hra + base.hra + base.bonus - base.tax;
        }
    }
}