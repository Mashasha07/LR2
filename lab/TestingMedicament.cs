namespace lab;

public class TestingMedicament
{
    public string Name { get; set; }
    public string Address { get; set; }
    public Dictionary<Subject, int> Subjects { get; set; }
    public Dictionary<Medicament, int> Medicaments { get; set; }
    public Dictionary<Scientist, int> Scientists { get; set; }
    
    public TestingMedicament(string name, string address)
    {
        Name = name;
        Address = address;
        Subjects = new Dictionary<Subject, int>();
        Medicaments = new Dictionary<Medicament, int>();
        Scientists = new Dictionary<Scientist, int>();
    }
    
    public void AddSubject(Subject subject)
    {
        Subjects.Add(subject, 0);
        Console.WriteLine($"Испытуемый {subject.FirstName} {subject.LastName} добавлен");
    }

    public void DeleteSubject(Subject subject)
    {
        Subjects.Remove(subject);
        Console.WriteLine($"Испытуемый {subject.FirstName} {subject.LastName} удален");
    }
    
    public void AddScientist(Scientist scientist)
    {
        Scientists.Add(scientist, 0);
        Console.WriteLine($"Ученый {scientist.FirstName} {scientist.LastName} задействован в тестировании лекарственного препарата");
    }

    public void DeleteScientist(Scientist scientist)
    {
        Scientists.Remove(scientist);
        Console.WriteLine($"Ученый {scientist.FirstName} {scientist.LastName} не задействован в тестировании лекарственного препарата");
    }
    
    public void CheckQuality(Medicament medicament, Subject subject)
    {
        if (subject.HealthAfterMedicament == "хорошо")
        {
            Medicaments.Add(medicament, 0);
            Console.WriteLine($"Препарат {medicament.Name} действует положительно и добавлен в аптеки");
        }
        else Console.WriteLine($"Препарат {medicament.Name} не действует и снят с производства");
    }
    
  
}