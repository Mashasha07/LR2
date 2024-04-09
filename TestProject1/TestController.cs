using lab;
namespace TestProject1;

public class TestController
{
    [Test]
    public void GoodResultTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда", "хорошо");
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Петр", "Петров", medicament);
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        var pharmacist = new Pharmacist("Иван", "Иванов");
        var controller = new Controller(subject, scientist, medicament, pharmacist, pharmacy);
        Assert.That(controller.Result, Is.EqualTo("Испытуемый: Мария Земцова, состояние здоровья после употребления лекарственного препарата: хорошо Ученый: Петр Петров Лекарственный препарат: Гриппферон Отправлен в аптеку: Бережная аптека Фармацевту: Иван Иванов"));
    }
    
    [Test]
    public void BadResultTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда", "плохо");
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Петр", "Петров", medicament);
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        var pharmacist = new Pharmacist("Иван", "Иванов");
        var controller = new Controller(subject, scientist, medicament, pharmacist, pharmacy);
        Assert.That(controller.Result, Is.EqualTo("Испытуемый: Мария Земцова, состояние здоровья после употребления лекарственного препарата: плохо Ученый: Петр Петров Лекарственный препарат: Гриппферон снят с производства"));
    }
    
    [Test]
    public void SubjectFirstNameTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда", "плохо");
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Петр", "Петров", medicament);
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        var pharmacist = new Pharmacist("Иван", "Иванов");
        var controller = new Controller(subject, scientist, medicament, pharmacist, pharmacy);
        Assert.That(controller.subject.FirstName, Is.EqualTo("Мария"));
    }
    
    [Test]
    public void SubjectLastNameTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда", "плохо");
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Петр", "Петров", medicament);
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        var pharmacist = new Pharmacist("Иван", "Иванов");
        var controller = new Controller(subject, scientist, medicament, pharmacist, pharmacy);
        Assert.That(controller.subject.LastName, Is.EqualTo("Земцова"));
    }
    
    [Test]
    public void HealthTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда", "хорошо");
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Петр", "Петров", medicament);
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        var pharmacist = new Pharmacist("Иван", "Иванов");
        var controller = new Controller(subject, scientist, medicament, pharmacist, pharmacy);
        Assert.That(controller.subject.HealthAfterMedicament, Is.EqualTo("хорошо"));
    }
    
    [Test]
    public void MedicamentNameTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда", "плохо");
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Петр", "Петров", medicament);
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        var pharmacist = new Pharmacist("Иван", "Иванов");
        var controller = new Controller(subject, scientist, medicament, pharmacist, pharmacy);
        Assert.That(controller.medicament.Name, Is.EqualTo("Гриппферон"));
    }
    
    [Test]
    public void ScientistFirstNameTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда", "плохо");
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Петр", "Петров", medicament);
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        var pharmacist = new Pharmacist("Иван", "Иванов");
        var controller = new Controller(subject, scientist, medicament, pharmacist, pharmacy);
        Assert.That(controller.scientist.FirstName, Is.EqualTo("Петр"));
    }
    
    [Test]
    public void ScientistLastNameTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда", "плохо");
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Петр", "Петров", medicament);
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        var pharmacist = new Pharmacist("Иван", "Иванов");
        var controller = new Controller(subject, scientist, medicament, pharmacist, pharmacy);
        Assert.That(controller.scientist.LastName, Is.EqualTo("Петров"));
    }
    
    [Test]
    public void PharmacyNameTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда", "хорошо");
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Петр", "Петров", medicament);
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        var pharmacist = new Pharmacist("Иван", "Иванов");
        var controller = new Controller(subject, scientist, medicament, pharmacist, pharmacy);
        Assert.That(controller.pharmacy.Name, Is.EqualTo("Бережная аптека"));
    }
    
    [Test]
    public void PharmacistFirstNameTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда", "хорошо");
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Петр", "Петров", medicament);
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        var pharmacist = new Pharmacist("Иван", "Иванов");
        var controller = new Controller(subject, scientist, medicament, pharmacist, pharmacy);
        Assert.That(controller.pharmacist.FirstName, Is.EqualTo("Иван"));
    }
    
    [Test]
    public void PharmacistLastNameTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда", "хорошо");
        var medicament = new Medicament("Гриппферон", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
            "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
        var scientist = new Scientist("Петр", "Петров", medicament);
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        var pharmacist = new Pharmacist("Иван", "Иванов");
        var controller = new Controller(subject, scientist, medicament, pharmacist, pharmacy);
        Assert.That(controller.pharmacist.LastName, Is.EqualTo("Иванов"));
    }
}

