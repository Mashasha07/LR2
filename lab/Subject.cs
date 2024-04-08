namespace lab;

public class Subject
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Age { get; set; }
    public string Health { get; set; }
    public string HealthAfterMedicament { get; set; }
    public bool IsBusy { get; set; }
    
    public Subject(string firstName, string lastName, string age, string health, string healthAfterMedicament = null)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Health = health;
        HealthAfterMedicament = healthAfterMedicament;
    }
    
    public void SubjectBusy()
    {
        IsBusy = true;
        Console.WriteLine($"Испытуемый {FirstName} {LastName} проверяет действие препарата");
    }

    public void SubjectNotBusy()
    {
        IsBusy = false;
        Console.WriteLine($"Испытуемый {FirstName} {LastName} не проверяет действие препарата");
    }
}