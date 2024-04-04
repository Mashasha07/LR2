namespace lab;

public class Pharmacist
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsBusy { get; set; }

    public Pharmacist(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public void PharmacistBusy()
    {
        IsBusy = true;
        Console.WriteLine($"Фармавцевт {FirstName} {LastName} консультирует покупателя");
    }

    public void PharmacistNotBusy()
    {
        IsBusy = false;
        Console.WriteLine($"Фармавцевт {FirstName} {LastName} не консультирует покупателя");
    }
}