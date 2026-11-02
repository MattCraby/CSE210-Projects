using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

class Police: Person
{
    private string _weapons;

    public Police(string firstName, string lastName, int age, double wieght, string weapons)
    : base (firstName, lastName, age, wieght)
    {
        _weapons = weapons;
    }


    public string GetPoliceInformation()
    {
        return $"Weapons: {_weapons}, {GetPersonInformation()}";
    }
}