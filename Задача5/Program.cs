Person Anna;
Anna = new Person();
int num = Anna.LuckyNumber(24, 14);
Console.WriteLine("Счастливое число Анны: " + num);
class Person
{
    // Поля
    string firstName;
    string lastName;
    // Метод
    int LuckyNumber (int numberOfTeeth, int age)
    {
        return (numberOfTeeth * age);
    }
}

