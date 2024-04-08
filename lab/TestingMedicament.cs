namespace lab;

public class TestingMedicament
{
    public Subject Subject { get; set; }
    public Medicament Medicament { get; set; }
    public Scientist Scientist { get; set; }
    public bool IsTest { get; set; }
    
    public TestingMedicament(Subject subject, Medicament medicament, Scientist scientist)
    {
        Subject = subject;
        Medicament = medicament;
        Scientist = scientist;
    }
    
    public void MedicamentTest(Medicament medicament, Subject subject, Scientist scientist)
    {
        IsTest = true;
        Console.WriteLine($"Медикамент {medicament.Name} тестируется ученым {scientist.FirstName} {scientist.LastName} и испытуемым {subject.FirstName} {subject.LastName}");
    }

    public void MedicamentNotTest(Medicament medicament)
    {
        IsTest = false;
        Console.WriteLine($"Медикамент {medicament.Name} не тестируется");
    }
}