using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

class Doctor: Person
{
    private string _tools;

    public Doctor(string firstName, string lastName, int age, double wieght, string tools)
    : base (firstName, lastName, age, wieght)
    {
        _tools = tools;
    }


    public string GetDoctorInformation()
    {
        return $"Doctor Tools: {_tools}, {GetPersonInformation()}";
    }
}