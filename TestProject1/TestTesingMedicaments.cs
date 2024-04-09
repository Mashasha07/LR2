using lab;
namespace TestProject1;

public class TestTesingMedicaments
{
    [Test]
    public void MedicamentTestTest()
    {
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Иван", "Иванов", medicament);
        var subject = new Subject("Мария", "Земцова", "21", "простуда");
        var testingMedicament = new TestingMedicament(subject, medicament, scientist);
        testingMedicament.MedicamentTest(medicament, subject, scientist);
        Assert.AreEqual(testingMedicament.IsTest, true);
        Assert.AreEqual(subject.IsBusy, true);
        Assert.AreEqual(scientist.IsBusy, true);
    }
    
    [Test]
    public void MedicamentNotTestTest()
    {
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Иван", "Иванов", medicament);
        var subject = new Subject("Мария", "Земцова", "21", "простуда");
        var testingMedicament = new TestingMedicament(subject, medicament, scientist);
        testingMedicament.MedicamentNotTest(medicament);
        Assert.AreEqual(testingMedicament.IsTest, false);
    }
    
    [Test]
    public void MedicamentTestStateTest()
    {
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Иван", "Иванов", medicament);
        var subject = new Subject("Мария", "Земцова", "21", "простуда");
        var testingMedicament = new TestingMedicament(subject, medicament, scientist);
        testingMedicament.MedicamentTest(medicament, subject, scientist);
        Assert.AreEqual(testingMedicament.IsTest, true);
        Assert.AreEqual(subject.IsBusy, true);
        Assert.AreEqual(scientist.IsBusy, true);
        testingMedicament.MedicamentNotTest(medicament);
        Assert.AreEqual(testingMedicament.IsTest, false);
    }
}