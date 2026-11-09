class Police: Person
{
    private string _weapons;

    public Police(string firstName, string lastName, int age, double wieght, string weapons)
    : base (firstName, lastName, age, wieght)
    {
        _weapons = weapons;
    }


    public override string GetPersonInformation()
    {
        return $"Police: Weapons: {_weapons}, {base.GetPersonInformation()}";
    }


    public override double GetSalary()
    {
        return 80000;
    }
}