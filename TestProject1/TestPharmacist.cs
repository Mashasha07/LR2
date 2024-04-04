using lab;
namespace TestProject1;

public class Tests
{
    [Test]
    public void PharmacistFirstNameTest()
    {
        var pharmacist = new Pharmacist("Мария", "Земцова");
        Assert.That(pharmacist.FirstName, Is.EqualTo("Мария"));
    }

    [Test]
    public void PharmacistLastNameTest()
    {
        var pharmacist = new Pharmacist("Мария", "Земцова");
        Assert.That(pharmacist.LastName, Is.EqualTo("Земцова"));
    }

    [Test]
    public void PharmacistSoldMedicamentTest()
    {
        var pharmacist = new Pharmacist("Мария", "Земцова");
        pharmacist.SoldMedicament();
        Assert.AreEqual(pharmacist.IsSold, true);
    }

    [Test]
    public void PharmacistNotSoldMedicamentTest()
    {
        var pharmacist = new Pharmacist("Мария", "Земцова");
        pharmacist.NotSoldMedicament();
        Assert.AreEqual(pharmacist.IsSold, false);
    }
}