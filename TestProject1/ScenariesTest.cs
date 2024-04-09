using lab;
namespace TestProject1;

public class ScenariesTest
{
    [Test]
    public void Scenary1()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда", "хорошо");
        var pharmacist = new Pharmacist("Иван", "Иванов");
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var laboratory = new Laboratory("Лаборатория 1", "7 Подлесная,30");
        var scientist = new Scientist("Петр", "Петров", medicament);
        laboratory.LaboratoryWork();
        scientist.ScientistBusy(medicament, laboratory);
        subject.SubjectBusy(scientist, laboratory);
        laboratory.CheckQuality(medicament, subject);
        pharmacy.PharmacyWork();
        pharmacist.PharmacistBusy(pharmacy);
        medicament.SoldMedicament(pharmacist, pharmacy);
        var controller = new Controller(subject, scientist, medicament, pharmacist, pharmacy);
    }
    
    [Test]
    public void Scenary2()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда", "плохо");
        var pharmacist = new Pharmacist("Иван", "Иванов");
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var laboratory = new Laboratory("Лаборатория 1", "7 Подлесная,30");
        var scientist = new Scientist("Петр", "Петров", medicament);
        laboratory.LaboratoryWork();
        scientist.ScientistBusy(medicament, laboratory);
        subject.SubjectBusy(scientist, laboratory);
        laboratory.CheckQuality(medicament, subject);
        var controller = new Controller(subject, scientist, medicament, pharmacist, pharmacy);
    }
}