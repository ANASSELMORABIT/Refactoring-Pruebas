using Xunit;
namespace ProgrammaUnitarias;
public class Test
{
    [Fact]
    //Testiar la funcion CalculateBMI
    public void TestCalculateBMI(){
        var PersonDato = new Person("John", "Doe", 30, "123-456-7890", 100, 200);
        var result=PersonDato.CalculateBMI();
        Assert.Equal(25, result); //Se espera que el resultado sea 25
        Assert.NotEqual(26, result);//Se espera que el resultado no sea 26
        Assert.True(result==25);//Se espera que el resultado sea 25
        Assert.False(result!=25);//Se espera que el resultado no sea 25
        Assert.NotNull(result);//Se espera que el resultado no sea nulo
        Assert.IsType<double>(result);//Se espera que el resultado sea de tipo double
    }
    [Fact]
    public void TestCalculateAverageAge(){
        var people=new Person[4];
        people[0] = new Person("John", "Doe", 30, "123-456-7890", 70.5, 175.2); 
        people[1] = new Person("Jane", "Smith", 25, "987-654-3210", 65.2, 162.5); 
        people[2] = new Person("David", "Johnson", 40, "456-789-0123", 80.1, 180.0); 
        people[3] = new Person("Mary", "Brown", 35, "789-012-3456", 55.8, 160.7); 
        var result=Person.CalculateAverageAge(people);
        Assert.Equal(32.5, result); //Se espera que el resultado sea 32.5
        Assert.NotEqual(32, result);//Se espera que el resultado no sea 32
        Assert.True(result==32.5);//Se espera que el resultado sea 32.5
        Assert.False(result!=32.5);//Se espera que el resultado no sea 32.5
        Assert.NotNull(result);//Se espera que el resultado no sea nulo
        Assert.IsType<double>(result);//Se espera que el resultado sea de tipo double
        Assert.Contains(people, p => p.Name =="John");//Se espera que un persona con el nombre John este en el array
        
    }
    
}

