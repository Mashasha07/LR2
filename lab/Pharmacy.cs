namespace lab;

public class Pharmacy
{
    public string Name { get; set; }
    public string Address { get; set; }
    public Dictionary<Pharmacist, int> Pharmacists { get; set; }
    public Dictionary<Medicament, int> Medicaments { get; set; }
    public bool IsWork { get; set; }

    public Pharmacy(string name, string address)
    {
        Name = name;
        Address = address;
        Pharmacists = new Dictionary<Pharmacist, int>();
        Medicaments = new Dictionary<Medicament, int>();
    }

    public void AddPharmacist(Pharmacist pharmacist)
    {
        Pharmacists.Add(pharmacist, 0);
        Console.WriteLine($"Фармацевт {pharmacist.FirstName} {pharmacist.LastName} устроен на работу");
    }

    public void DeletePharmacist(Pharmacist pharmacist)
    {
        Pharmacists.Remove(pharmacist);
        Console.WriteLine($"Фармацевт {pharmacist.FirstName} {pharmacist.LastName} уволен с работы");
    }
    
    public void AddMedicament(Medicament medicament)
    {
        Medicaments.Add(medicament, 0);
        Console.WriteLine($"Препарат {medicament.Name} добавлен");
    }
    
    public void DeleteMedicament(Medicament medicament)
    {
        Medicaments.Remove(medicament);
        Console.WriteLine($"Препарат {medicament.Name} продан");
    }

    public void PharmacyWork()
    {
        IsWork = true;
        Console.WriteLine($"Аптека {Name} по адресу {Address} еще работает");
    }

    public void PharmacyNotWork()
    {
        IsWork = false;
        Console.WriteLine($"Аптека {Name} по адресу {Address} уже закрылась");
    }
}