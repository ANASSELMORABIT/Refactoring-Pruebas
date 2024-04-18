public class Person 
{ 
    public string Name ; 
    public string LastName ; 
    public int Age ; 
    public string PhoneNumber; 
    public double Weight ; 
    public double Height ; 
  
  
  
    public Person(string name, string lastName, int age, string phoneNumber, double weight, double height) 
    { 
        Name = name; 
        LastName = lastName; 
        Age = age; 
        PhoneNumber = phoneNumber; 
        Weight = weight; 
        Height = height; 
    } 
  
    //Calculo del indice de masa corporal (BMI) 
    public double CalculateBMI() 
    { 
        double heighInMeters = Height / 100.0; 
  
  
        double bmi = Weight / (heighInMeters * heighInMeters); 
  
        return bmi; 
    } 
    //Calculo edad media 
    public static double CalculateAverageAge (Person[] people) 
    { 
        if(people.Length == 0) 
        { 
            return 0; 
  
        } 
  
        int totalAge = 0; 
  
        foreach (var person in people) 
        { 
            totalAge += person.Age; 
  
        } 
  
        return (double) totalAge / people.Length; 
  
    } 
  
    public void DisplayInfo() 
    { 
        Console.WriteLine($"Nombre: {Name} {LastName}"); 
        Console.WriteLine($"Edad: {Age}"); 
        Console.WriteLine($"Teléfono: {PhoneNumber}"); 
        Console.WriteLine($"Peso: {Weight} kg"); 
        Console.WriteLine($"Altura: {Height} cm\n"); 
        Console.WriteLine($"BMI: {CalculateBMI():F2}\n");//F2 mostramos 2 decimales 
    } 
} 