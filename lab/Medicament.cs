namespace lab;

public class Medicament
{
    public string Name { get; set; }
    public string Composition { get; set; }
    public string Indication { get; set; }
    public string ModeOfApplication { get; set; }
    public string Contraindications { get; set; } 
    public bool IsSold { get; set; }
    
    public Medicament(string name, string composition, string indication, string modeOfApplication, string contraindications)
    {
        Name = name;
        Composition = composition;
        Indication = indication;
        ModeOfApplication = modeOfApplication;
        Contraindications = contraindications;
    }
    
    public void SoldMedicament(Pharmacist pharmacist)
    {
        IsSold = true;
        Console.WriteLine($"Фармавцевт {pharmacist.FirstName} {pharmacist.LastName} продал лекарственный препарат {Name}");
    }
    
    public void NotSoldMedicament(Pharmacist pharmacist)
    {
        IsSold = false;
        Console.WriteLine($"Фармавцевт {pharmacist.FirstName} {pharmacist.LastName} не продал лекарственный препарат {Name}");
    }
}