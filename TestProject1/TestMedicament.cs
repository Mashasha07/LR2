using lab;
namespace TestProject1;

public class TestMedicament
{
    [Test]
    public void MedicamentNameTest()
    {
        var medicament = new Medicament("Нурофен", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        Assert.That(medicament.Name, Is.EqualTo("Нурофен"));
    }
    
    [Test]
    public void MedicamentCompositionTest()
    {
        var medicament = new Medicament("Нурофен", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        Assert.That(medicament.Composition, Is.EqualTo("ибупрофен - 200,000 мг"));
    }
    
    [Test]
    public void MedicamentIndicationTest()
    {
        var pharmacist = new Pharmacist("Мария", "Земцова");
        var medicament = new Medicament("Нурофен", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        Assert.That(medicament.Indication, Is.EqualTo("головная боль, мигрень, зубная боль"));
    }
    
    [Test]
    public void MedicamentModeOfApplicationTest()
    {
        var pharmacist = new Pharmacist("Мария", "Земцова");
        var medicament = new Medicament("Нурофен", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        Assert.That(medicament.ModeOfApplication, Is.EqualTo("Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки"));
    }
    
    [Test]
    public void MedicamentContraindicationsTest()
    {
        var pharmacist = new Pharmacist("Мария", "Земцова");
        var medicament = new Medicament("Нурофен", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        Assert.That(medicament.Contraindications, Is.EqualTo("Беременность в сроке более 20 недель."));
    }
    
    [Test]
    public void SoldMedicamentTest()
    {
        var pharmacist = new Pharmacist("Мария", "Земцова");
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        var medicament = new Medicament("Нурофен", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        medicament.SoldMedicament(pharmacist, pharmacy);
        Assert.AreEqual(medicament.IsSold, true);
        Assert.AreEqual(pharmacist.IsBusy, true);
    }
    
    [Test]
    public void DeleteMedicamentSoldTest()
    {
        var pharmacist = new Pharmacist("Мария", "Земцова");
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        var medicament = new Medicament("Нурофен", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        medicament.SoldMedicament(pharmacist, pharmacy);
        Assert.AreEqual(pharmacy.Medicaments.Count, 0);
    }
    
    [Test]
    public void NotSoldMedicamentTest()
    {
        var pharmacist = new Pharmacist("Мария", "Земцова");
        var medicament = new Medicament("Нурофен", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        medicament.NotSoldMedicament(pharmacist);
        Assert.AreEqual(medicament.IsSold, false);
    }
    
    [Test]
    public void MedicamentStateTest()
    {
        var pharmacist = new Pharmacist("Мария", "Земцова");
        var medicament = new Medicament("Нурофен", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        medicament.SoldMedicament(pharmacist, pharmacy);
        Assert.AreEqual(medicament.IsSold, true);
        Assert.AreEqual(pharmacist.IsBusy, true);
        Assert.AreEqual(pharmacy.Medicaments.Count, 0);
        medicament.NotSoldMedicament(pharmacist);
        Assert.AreEqual(medicament.IsSold, false);
    }
}