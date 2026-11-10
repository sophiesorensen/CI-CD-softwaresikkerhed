using System.ComponentModel.DataAnnotations;

public class Lastname
{
    private string lastname;

    // Konstruktor
    public Lastname(string lastname)
    {
        IsLastnameValid(lastname);
        this.lastname = lastname;
    }

    // Metode til at få Lastname-værdien
    public string GetValue()
    {
        return lastname;
    }

    private void IsLastnameValid(string lastname)
    {
        if (string.IsNullOrWhiteSpace(lastname))
        {
            throw new ArgumentException("Lastname må ikke være tomt.");
        }

        if (lastname.Length < 2 || lastname.Length > 20)
        {
            throw new ArgumentException("Lastname skal være mellem 2 og 20 tegn.");
        }

        if (!System.Text.RegularExpressions.Regex.IsMatch(
                lastname, @"^[a-zA-ZæøåÆØÅ]+$"))
        {
            throw new ArgumentException(
                "Lastname må kun indeholde bogstaver.");
        }
    }
}