using lab;
namespace TestProject1;

public class Test_Subject
{
    [Test]
    public void SubjectFirstNameTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда");
        Assert.That(subject.FirstName, Is.EqualTo("Мария"));
    }
    
    [Test]
    public void SubjectLastNameTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда");
        Assert.That(subject.LastName, Is.EqualTo("Земцова"));
    }
    
    [Test]
    public void SubjectAgeTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда");
        Assert.That(subject.Age, Is.EqualTo("21"));
    }
    
    [Test]
    public void SubjectHealthTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда");
        Assert.That(subject.Health, Is.EqualTo("простуда"));
    }
    
    [Test]
    public void SubjectHealthAfterMedicamentTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда", "хорошо");
        Assert.That(subject.HealthAfterMedicament, Is.EqualTo("хорошо"));
    }
    
    [Test]
    public void SubjectBusyTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда");
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Мария", "Земцова", medicament);
        var laboratory = new Laboratory("Лаборатория 1", "7 Подлесная,30");
        subject.SubjectBusy(scientist, laboratory);
        Assert.AreEqual(subject.IsBusy, true);
        Assert.AreEqual(scientist.IsBusy, true);
        Assert.AreEqual(laboratory.IsWork, true);
    }
    
    [Test]
    public void SubjectNotBusyTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда");
        subject.SubjectNotBusy();
        Assert.AreEqual(subject.IsBusy, false);
    }

    [Test]
    public void SubjectStateTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда");
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Мария", "Земцова", medicament);
        var laboratory = new Laboratory("Лаборатория 1", "7 Подлесная,30");
        subject.SubjectBusy(scientist, laboratory);
        Assert.AreEqual(subject.IsBusy, true);
        Assert.AreEqual(scientist.IsBusy, true);
        Assert.AreEqual(laboratory.IsWork, true);
        subject.SubjectNotBusy();
        Assert.AreEqual(subject.IsBusy, false);
    }
}