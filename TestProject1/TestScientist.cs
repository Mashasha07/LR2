using lab;
namespace TestProject1;

public class TestScientist
{
    [Test]
    public void ScientistFirstNameTest()
    {
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Мария", "Земцова", medicament);
        Assert.That(scientist.FirstName, Is.EqualTo("Мария"));
    }

    [Test]
    public void ScientistLastNameTest()
    {
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Мария", "Земцова", medicament);
        Assert.That(scientist.LastName, Is.EqualTo("Земцова"));
    }
    
    [Test]
    public void ScientistMedicamentTest()
    {
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Мария", "Земцова", medicament);
        Assert.That(scientist.Medicament, Is.EqualTo(medicament));
    }
    
    [Test]
    public void ScientistBusyTest()
    {
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Мария", "Земцова", medicament);
        scientist.ScientistBusy(medicament);
        Assert.AreEqual(scientist.IsBusy, true);
    }
    
    [Test]
    public void ScientistNotBusyTest()
    {
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Мария", "Земцова", medicament);
        scientist.ScientistNotBusy();
        Assert.AreEqual(scientist.IsBusy, false);
    }
}