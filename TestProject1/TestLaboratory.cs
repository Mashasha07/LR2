using lab;
namespace TestProject1;

public class TestLaboratory
{
    [Test]
    public void LaboratoryNameTest()
    { 
        var laboratory = new Laboratory("Лаборатория 1", "7 Подлесная,30");
        Assert.That(laboratory.Name, Is.EqualTo("Лаборатория 1"));
    }
    
    [Test]
    public void LaboratoryAddressTest()
    { 
        var laboratory = new Laboratory("Лаборатория 1", "7 Подлесная,30");
        Assert.That(laboratory.Address, Is.EqualTo("7 Подлесная,30"));
    }

    [Test]
    public void CheckGoodQualityTest()
    {
        var laboratory = new Laboratory("Лаборатория 1", "7 Подлесная,30");
        laboratory.CheckQuality(new Medicament("Ибупрофен", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.", 7));
        Assert.AreEqual(laboratory.Medicaments.Count, 1);
    }
    
    [Test]
    public void CheckBadQualityTest()
    {
        var laboratory = new Laboratory("Лаборатория 1", "7 Подлесная,30");
        laboratory.CheckQuality(new Medicament("Ибупрофен", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.", 4));
        Assert.AreEqual(laboratory.Medicaments.Count, 0);
    }
    
    [Test]
    public void LaboratoryWorkTest()
    {
        var laboratory = new Laboratory("Лаборатория 1", "7 Подлесная,30");
        laboratory.LaboratoryWork();
        Assert.AreEqual(laboratory.IsWork, true);
    }

    [Test]
    public void LaboratoryNotWorkTest()
    {
        var laboratory = new Laboratory("Лаборатория 1", "7 Подлесная,30");
        laboratory.LaboratoryNotWork();
        Assert.AreEqual(laboratory.IsWork, false);
    }
     
    [Test]
    public void LaboratoryStateTest()
    {
        var laboratory = new Laboratory("Лаборатория 1", "7 Подлесная,30");
        laboratory.LaboratoryWork();
        Assert.AreEqual(laboratory.IsWork, true);
        laboratory.LaboratoryNotWork();
        Assert.AreEqual(laboratory.IsWork, false);
    }
}