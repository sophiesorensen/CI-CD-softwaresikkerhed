public class Age {
    private int age;

    // Konstruktør 
    public Age(int age) {
        IsAgeValid(age);
        this.age = age;
    }

    // Metode til at få age-værdien 
    public int GetValue() {
        return age;
    }

    // Privat metode til validering af age invariant 
    private void IsAgeValid(int age) {
        if (age < 18 || age > 99) {
            throw new ArgumentException("Age must be between 18 and 99");
        }
    }
}