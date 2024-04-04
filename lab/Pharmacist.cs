namespace lab;

public class Pharmacist
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsSold { get; set; }

    public Pharmacist(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public void SoldMedicament()
    {
        IsSold = true;
        Console.WriteLine($"Фармавцевт {FirstName} {LastName} продал лекарственный препарат");
    }

    public void NotSoldMedicament()
    {
        IsSold = false;
        Console.WriteLine($"Фармавцевт {FirstName} {LastName} не продал лекарственный препарат");
    }
}