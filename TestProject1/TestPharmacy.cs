using lab;
namespace TestProject1;

public class TestPharmacy
{
     [Test]
     public void PharmacyNameTest()
     { 
         var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
         Assert.That(pharmacy.Name, Is.EqualTo("Бережная аптека"));
     }

     [Test]
     public void PharmacyAddressTest()
     {
         var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
         Assert.That(pharmacy.Address, Is.EqualTo("7 Подлесная,20"));
     }

     [Test]
     public void PharmacyPharmacistsTest()
     {
         var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
         Assert.IsNotNull(pharmacy.Pharmacists);
     }

     [Test]
     public void AddPharmacistTest()
     {
         var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
         pharmacy.AddPharmacist(new Pharmacist("Иван", "Иванов"));
         pharmacy.AddPharmacist(new Pharmacist("Петр", "Петров"));
         Assert.AreEqual(pharmacy.Pharmacists.Count, 2);
     }

     [Test]
     public void DeletePharmacistTest()
     {
         var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
         var pharmacist = new Pharmacist("Иван", "Иванов");
         pharmacy.AddPharmacist(pharmacist);
         pharmacy.AddPharmacist(new Pharmacist("Петр", "Петров"));
         Assert.AreEqual(pharmacy.Pharmacists.Count, 2);
         pharmacy.DeletePharmacist(pharmacist);
         Assert.AreEqual(pharmacy.Pharmacists.Count, 1);
     }
     
     [Test]
     public void AddMedicamentTest()
     {
         var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
         pharmacy.AddMedicament(new Medicament("Ибупрофен", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
             "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель."));
         Assert.AreEqual(pharmacy.Medicaments.Count, 1);
     }
     
     [Test]
     public void DeleteMedicamentTest()
     {
         var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
         var medicament = new Medicament("Нурофен", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
             "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель.");
         pharmacy.AddMedicament(medicament);
         pharmacy.AddMedicament(new Medicament("Ибупрофен", "ибупрофен - 200,000 мг", "головная боль, мигрень, зубная боль", 
             "Внутрь по 200 мг (по 1 таблетке) до 3-4 раз в сутки", "Беременность в сроке более 20 недель."));
         Assert.AreEqual(pharmacy.Medicaments.Count, 2);
         pharmacy.DeleteMedicament(medicament);
         Assert.AreEqual(pharmacy.Medicaments.Count, 1);
     }


     [Test]
     public void PharmacyWorkTest()
     {
         var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
         pharmacy.PharmacyWork();
         Assert.AreEqual(pharmacy.IsWork, true);
     }

     [Test]
     public void PharmacyNotWorkTest()
     {
         var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
         pharmacy.PharmacyNotWork();
         Assert.AreEqual(pharmacy.IsWork, false);
     }
     
     [Test]
     public void PharmacyStateTest()
     {
         var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
         pharmacy.PharmacyWork();
         Assert.AreEqual(pharmacy.IsWork, true);
         pharmacy.PharmacyNotWork();
         Assert.AreEqual(pharmacy.IsWork, false);
     }
        
}