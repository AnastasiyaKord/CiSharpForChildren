Person Petr;
Petr = new Person();
Petr.firstName = "Petr";
Petr.lastName = "Ivanov";
Petr.ShowFullName();
class Person
{
    public string firstName;
    public string lastName;
    public void ShowFullName()
    {
        Console.WriteLine("Name is " + firstName + " " + lastName);
    }
}



