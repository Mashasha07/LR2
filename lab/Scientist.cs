namespace lab;

public class Scientist
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public Medicament Medicament { get; set; }
    public string TestMedicament { get; set; }
    public bool IsBusy { get; set; }

    public Scientist(string firstName, string lastName, Medicament medicament, string testMedicament=null)
    {
        FirstName = firstName;
        LastName = lastName;
        Medicament = medicament;
        TestMedicament = testMedicament;
    }
    
    public void ScientistBusy(Medicament medicament)
    {
        IsBusy = true;
        Console.WriteLine($"Ученый {FirstName} {LastName} создает лекарственный препарат {Medicament.Name}");
    }

    public void ScientistNotBusy()
    {
        IsBusy = false;
        Console.WriteLine($"Ученый {FirstName} {LastName} не занят созданием препарата");
    }
}