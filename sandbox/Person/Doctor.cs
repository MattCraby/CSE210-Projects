
class Doctor: Person
{
    private string _tools;

    public Doctor(string firstName, string lastName, int age, double wieght, string tools)
    : base (firstName, lastName, age, wieght)
    {
        _tools = tools;
    }


    public override string GetPersonInformation()
    {
        return $"Doctor Tools: {_tools}, {base.GetPersonInformation()}";
    }


    public override double GetSalary()
    {
        return 300000;
    }
}