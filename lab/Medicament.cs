namespace lab;

public class Medicament
{
    public string Name { get; set; }
    public string Composition { get; set; }
    public string Indication { get; set; }
    public string ModeOfApplication { get; set; }
    public string Contraindications { get; set; }
    public Pharmacist Pharmacist { get; set; }
    public bool IsSold { get; set; }
    
    public Medicament(string name, string composition, string indication, string modeOfApplication, string contraindications, Pharmacist pharmacist)
    {
        Name = name;
        Composition = composition;
        Indication = indication;
        ModeOfApplication = modeOfApplication;
        Contraindications = contraindications;
        Pharmacist = pharmacist;
    }
    
    public void SoldMedicament()
    {
        IsSold = true;
        Console.WriteLine($"Фармавцевт {Pharmacist.FirstName} {Pharmacist.LastName} продает лекарственный препарат {Name}");
    }
    
    public void NotSoldMedicament()
    {
        IsSold = false;
        Console.WriteLine($"Фармавцевт {Pharmacist.FirstName} {Pharmacist.LastName} не продает лекарственный препарат {Name}");
    }
}