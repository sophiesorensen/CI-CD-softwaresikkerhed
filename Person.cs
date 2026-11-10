public class Person
{
    private Firstname firstname;
    private Lastname lastname;
    private Age age;
    private CprNumber cprNumber;

    // Konstruktør
    public Person(
        Firstname firstname,
        Lastname lastname,
        Age age,
        CprNumber cprNumber)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.age = age;
        this.cprNumber = cprNumber;
    }

    // Get-metoder
    public string GetFirstname()
    {
        return firstname.GetValue();
    }

    public string GetLastname()
    {
        return lastname.GetValue();
    }

    public int GetAge()
    {
        return age.GetValue();
    }

    public string GetCprNumber()
    {
        return cprNumber.GetValue();
    }
}