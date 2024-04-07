namespace lab;

public class Laboratory
{
    public string Name { get; set; }
    public string Address { get; set; }
    public Dictionary<Subject, int> Subjects { get; set; }
    public Dictionary<Medicament, int> Medicaments { get; set; }
    public Dictionary<Scientist, int> Scientists { get; set; }
    public bool IsWork { get; set; }
    
    public Laboratory(string name, string address)
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
        Console.WriteLine($"Ученый {scientist.FirstName} {scientist.LastName} устроен на работу");
    }

    public void DeleteScientist(Scientist scientist)
    {
        Scientists.Remove(scientist);
        Console.WriteLine($"Ученый {scientist.FirstName} {scientist.LastName} уволен с работы");
    }
    
    public void CheckQuality(Medicament medicament)
    {
        if (medicament.QualityOfMedicament > 5)
        {
            Medicaments.Add(medicament, 0);
            Console.WriteLine($"Препарат {medicament.Name} добавлен в аптеки");
        }
        else Console.WriteLine($"Препарат {medicament.Name} не добавлен в аптеки");
    }
    
    public void LaboratoryWork()
    {
        IsWork = true;
        Console.WriteLine($"Лаборатория {Name} по адресу {Address} еще работает");
    }

    public void LaboratoryNotWork()
    {
        IsWork = false;
        Console.WriteLine($"Лаборатория {Name} по адресу {Address} уже закрылась");
    }
}