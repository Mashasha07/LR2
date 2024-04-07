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
    public void SubjectBusyTest()
    {
        var subject = new Subject("Мария", "Земцова", "21", "простуда");
        subject.SubjectBusy();
        Assert.AreEqual(subject.IsBusy, true);
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
        subject.SubjectBusy();
        Assert.AreEqual(subject.IsBusy, true);
        subject.SubjectNotBusy();
        Assert.AreEqual(subject.IsBusy, false);
    }
}