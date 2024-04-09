using lab;
namespace TestProject1;

public class TestPharmacist
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
    public void PharmacistBusyTest()
    {
        var pharmacist = new Pharmacist("Мария", "Земцова");
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        pharmacist.PharmacistBusy(pharmacy);
        Assert.AreEqual(pharmacist.IsBusy, true);
        Assert.AreEqual(pharmacy.IsWork, true);
    }

    [Test]
    public void PharmacistNotBusyTest()
    {
        var pharmacist = new Pharmacist("Мария", "Земцова");
        pharmacist.PharmacistNotBusy();
        Assert.AreEqual(pharmacist.IsBusy, false);
    }
    
    [Test]
    public void PharmacistStateTest()
    {
        var pharmacist = new Pharmacist("Мария", "Земцова");
        var pharmacy = new Pharmacy("Бережная аптека", "7 Подлесная,20");
        pharmacist.PharmacistBusy(pharmacy);
        Assert.AreEqual(pharmacist.IsBusy, true);
        Assert.AreEqual(pharmacy.IsWork, true);
        pharmacist.PharmacistNotBusy();
        Assert.AreEqual(pharmacist.IsBusy, false);
    }
}