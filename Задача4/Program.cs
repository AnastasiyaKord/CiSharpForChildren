Person Petr;
Petr = new Person();
Petr.LuckyNumber(24, 14);
class Person
{
    // Поля
    string firstName;
    string lastName;
    // Метод
    public void LuckyNumber(int numberOfTeeth, int age)
    {
        Console.WriteLine("Счастливое число " + numberOfTeeth * age);
    }
}

