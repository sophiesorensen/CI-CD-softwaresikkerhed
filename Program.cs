Console.Write("Indtast fornavn: ");
string firstnameInput = Console.ReadLine()!;
Firstname firstname = new Firstname(firstnameInput);

Console.Write("Indtast efternavn: ");
string lastnameInput = Console.ReadLine()!;
Lastname lastname = new Lastname(lastnameInput);

Console.Write("Indtast alder: ");
int ageInput = int.Parse(Console.ReadLine()!);
Age age = new Age(ageInput);

Console.Write("Indtast CPR-nummer: ");
string cprInput = Console.ReadLine()!;
CprNumber cprNumber = new CprNumber(cprInput);

Person person = new Person(
    firstname,
    lastname,
    age,
    cprNumber);

Console.WriteLine();
Console.WriteLine(person.GetFirstname());
Console.WriteLine(person.GetLastname());
Console.WriteLine(person.GetAge());
Console.WriteLine(person.GetCprNumber());