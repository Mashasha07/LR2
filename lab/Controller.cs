using System.Text;

namespace lab;

public class Controller
{
    public string Result;
    public Subject subject { get; set; }
    public Scientist scientist { get; set; }
    public Medicament medicament { get; set; }
    public Pharmacist pharmacist { get; set; }
    public Pharmacy pharmacy { get; set; }

    public Controller(Subject subject, Scientist scientist, Medicament medicament, Pharmacist pharmacist, Pharmacy pharmacy)
    {
        this.subject = subject;
        this.scientist = scientist;
        this.medicament = medicament;
        this.pharmacist = pharmacist;
        this.pharmacy = pharmacy;
        Result = GetResult();
    }

    public string GetResult()
    {
        if (subject.HealthAfterMedicament == "хорошо")
        {
            Result = "Испытуемый: " + subject.FirstName + " " + subject.LastName + ", состояние здоровья после употребления лекарственного препарата: " + subject.HealthAfterMedicament + 
                     " " + "Ученый: " + scientist.FirstName + " " + scientist.LastName + 
                     " " + "Лекарственный препарат: " + medicament.Name + 
                     " " + "Отправлен в аптеку: " + pharmacy.Name + 
                     " " + "Фармацевту: " + pharmacist.FirstName + " " + pharmacist.LastName;
        }
        else
        {
            Result = "Испытуемый: " + subject.FirstName + " " + subject.LastName + ", состояние здоровья после употребления лекарственного препарата: " + subject.HealthAfterMedicament +
                     " " + "Ученый: " + scientist.FirstName + " " + scientist.LastName + 
                     " " + "Лекарственный препарат: " + medicament.Name + " снят с производства";
        }
        Console.WriteLine($"{Result}");
        return Result;
    }
}