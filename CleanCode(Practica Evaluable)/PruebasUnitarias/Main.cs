//Ejercicio1:

//Refactoring


// using System.Security.Cryptography.X509Certificates;
// class Program
// {
//     static void Main(string[] args)
//     {
//         //En este codigo utilizamos varios patrones de refactoring para mejorar la legibilidad del codigo:
//         // -Aplicamos el Patron de Extracción de Estructura de Datos , y creamos un struct Con el nombre de PersonData
//         //Que tiene 4 atributos (name,lastName,phone,bloodType),y para gestionar dos personas debemos crear un array de 2 personas.
//         //-Utilizamos el patron de Extracción de bloque para extraer la parte de print el estado de compatibilidad y moverlo a una función 
//         //-Tambien utilizams el patron de Renombrado de Variable para renombrar las variables a ingles.
//         //-Aplicams el patron de Reemplazo de condicional anidado para reemplazar una serie de condicionales
//         //anidados con una estructura de control de flujo switch-case.
//         //-En cada condicion aplicamos el patron de Simpilificación de lógica para simplificar la escritura y la logica de las sentencias if-el
//         //-Tambien aplicamos el patron de Reemplazo de variable Temporal por la variable status.
//         PersonData[] People = new PersonData[2];
//         People[0] = new PersonData { name = "Maria", lastName = "Perez", phone = "123456789", bloodType = "A+" };
//         People[1] = new PersonData { name = "Jose Maria", lastName = "Rocano", phone = "987654321", bloodType = "B-" };
//         bool status;
//         switch (People[0].bloodType)
//         {
//             case "O+":
//                 status = People[1].bloodType == "O-" ? true : false;
//                 PrintCompatibilityStatus(People, status);
//                 break;
//             case "A+":
//                 status = People[1].bloodType == "A-" || People[1].bloodType == "AB+" || People[1].bloodType == "AB-" || People[1].bloodType == "A+" ? true : false;
//                 PrintCompatibilityStatus(People, status);
//                 break;
//             case "A-":
//                 status = People[1].bloodType == "A-" || People[1].bloodType == "AB+" || People[1].bloodType == "AB-" ? true : false;
//                 PrintCompatibilityStatus(People, status);
//                 break;
//             case "B+":
//                 status = People[1].bloodType == "B-" || People[1].bloodType == "AB+" || People[1].bloodType == "AB-" || People[1].bloodType == "B+" ? true : false;
//                 PrintCompatibilityStatus(People, status);
//                 break;
//             case "B-":
//                 status = People[1].bloodType == "B-" || People[1].bloodType == "AB+" || People[1].bloodType == "AB-" ? true : false;
//                 PrintCompatibilityStatus(People, status);
//                 break;
//             case "AB+":
//                 status = People[1].bloodType == "AB+" || People[1].bloodType == "AB-" ? true : false;
//                 PrintCompatibilityStatus(People, status);
//                 break;
//             case "AB-":
//                 goto case "AB+";
//             default:
//                 PrintCompatibilityStatus(People, false);
//                 break;
//         }
//     }

//     static void PrintCompatibilityStatus(PersonData[] people, bool status)
//     {
//         string message = status ? "es Compatibles" : "No es compatibles";
//         Console.WriteLine("El/a"+people[0].name + " " + people[0].lastName + " " + message + " amb " + people[1].name + " " + people[1].lastName);
//     }
// }

// public struct PersonData
// {
//     public string name;
//     public string lastName;
//     public string phone;
//     public string bloodType;
// }



//Ejercicio 2:
//Pruebas Unitarias
using System; 
namespace Programa 
{ 
    public class Program 
    { 
        static void Main(string[]args) 
        { 
        Person[] people = new Person[4]; 
  
        // Rellenar el array de personas 
        people[0] = new Person("John", "Doe", 30, "123-456-7890", 70.5, 175.2); 
        people[1] = new Person("Jane", "Smith", 25, "987-654-3210", 65.2, 162.5); 
        people[2] = new Person("David", "Johnson", 40, "456-789-0123", 80.1, 180.0); 
        people[3] = new Person("Mary", "Brown", 35, "789-012-3456", 55.8, 160.7); 
        //Calculamos la edad promedia 
        double averageAge = Person.CalculateAverageAge(people); 
  
        // Mostrar la información de las personas 
        Console.WriteLine("Personas:"); 
        foreach (var person in people) 
        { 
            person.DisplayInfo(); 
        } 
        //Mostramos la edad promedia 
        Console.WriteLine("La edad promedia es:"+averageAge); 
        } 
    }
    
   
} 