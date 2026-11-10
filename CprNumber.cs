using System.Text.RegularExpressions;

public class CprNumber
{
    private readonly string cprNumber;

    private bool cprStatus;

    // Konstruktør
    public CprNumber(string cprNumber)
    {
        IsCprNumberValid(cprNumber);
        this.cprNumber = cprNumber;
    }

    // Metode til at få CPR-nummeret
    public string GetValue()
    {
        if (cprStatus == true )
        {
               throw new ArgumentException(
                "CPR-nummer er allerede hentet før");
        }
        cprStatus = true;

         return cprNumber;
      
    }

    // Privat metode til validering af CPR-nummerets invariant
    private void IsCprNumberValid(string cprNumber)
    {
        if (!Regex.IsMatch(cprNumber, @"^\d{6}-\d{4}$"))
        {
            throw new ArgumentException(
                "CPR-nummer skal være på formatet DDMMÅÅ-XXXX.");
        }
    }
}