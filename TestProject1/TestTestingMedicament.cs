using lab;
namespace TestProject1;

public class TestTestingMedicament
{
    [Test]
    public void LaboratoryNameTest()
    {
        var laboratory = new lab.TestingMedicament("Лаборатория 1", "7 Подлесная,30");
        Assert.That(laboratory.Name, Is.EqualTo("Лаборатория 1"));
    }

    [Test]
    public void LaboratoryAddressTest()
    { 
        var laboratory = new lab.TestingMedicament("Лаборатория 1", "7 Подлесная,30");
        Assert.That(laboratory.Address, Is.EqualTo("7 Подлесная,30"));
    }

    [Test]
    public void CheckGoodQualityTest()
    {
        var laboratory = new lab.TestingMedicament("Лаборатория 1", "7 Подлесная,30");
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var subject = new Subject("Мария", "Земцова", "21", "головная боль", "хорошо");
        laboratory.CheckQuality(medicament, subject);
        Assert.AreEqual(laboratory.Medicaments.Count, 1);
    }
    
    [Test]
    public void CheckBadQualityTest()
    {
        var laboratory = new lab.TestingMedicament("Лаборатория 1", "7 Подлесная,30");
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var subject = new Subject("Мария", "Земцова", "21", "головная боль", "плохо");
        laboratory.CheckQuality(medicament, subject);
        Assert.AreEqual(laboratory.Medicaments.Count, 0);
    }
   
}