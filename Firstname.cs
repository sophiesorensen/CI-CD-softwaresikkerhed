using System.ComponentModel.DataAnnotations; 

public class Firstname 
{
    private string firstname; 

    //konstruktør 
    public Firstname(string firstname)
    {
        IsFirstnameValid(firstname);
        this.firstname = firstname;
    }

    //Metode til at få Firstname-værdien 
    public string GetValue()
    {
        return firstname;
    }

    private void IsFirstnameValid(string firstname)
    {
          if (string.IsNullOrWhiteSpace(firstname))
        {
            throw new ArgumentException("Firstname må ikke være tomt.");
        }

        if (firstname.Length < 2 || firstname.Length > 20)
        {
            throw new ArgumentException("Firstname skal være mellem 2 og 20 tegn.");
        }

        if (!System.Text.RegularExpressions.Regex.IsMatch(
                firstname, @"^[a-zA-ZæøåÆØÅ]+$"))
        {
            throw new ArgumentException(
                "Firstname må kun indeholde bogstaver.");
        }
    }
}