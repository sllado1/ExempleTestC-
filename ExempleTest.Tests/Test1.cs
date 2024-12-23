namespace ExempleTest.Tests;

public class Test1
{
    [Fact]
    //Només fa un test de la funció Sumar. Si es fact no es poden passar paràmetres
    public void TestSuma()
    {
        //Inicialitza
        //Crea l'objecte que utilitzarà per cridar la funció
        Calculadora c = new Calculadora();
        //Inicialitza les variables que necessita la funció
        int a = 0;
        int b = 2;
        //Crida la funció
        int resultat = c.Sumar(a, b);
        //Comprova. El resultat ha de ser 2
        Assert.Equal(2, resultat);
    }

    [Theory]
    [InlineData(0, 2, 2)]
    [InlineData(2, 2, 4)]
    [InlineData(2, 0, 2)]
    //Amb aquesta funció podem provar diferents valors de les variables
    //en aquest cas els valors de a i b i el resultat esperat
    //són passats com a paràmetres
    //En  la primera prova a=0, b=2 i el resultat esperat és 2
    //En la segona prova a=2, b=2 i el resultat esperat és 4
    //En la tercera prova a=2, b=0 i el resultat esperat és 2
    public void TestMultipleSuma(int a, int b, int resultatEsperat)
    {
        //Inicialitza
        //Crea l'objecte que utilitzarà per cridar la funció
        Calculadora c = new Calculadora();
        //Crida la funció
        int resultat = c.Sumar(a, b);
        //Comprova. 
        Assert.Equal(resultatEsperat, resultat);
    }
    /// <summary>
    /// Test de límits de la funció Divisio
    /// </summary>
    [Theory]
    //Cas límit: divisió per zero (b == 0): Ha de retornar -1
    [InlineData(10, 0, -1)]
    //Cas límit: divisor igual a 1 (b == 1): Ha de retornar a
    [InlineData(10, 1, 10)]
    //Cas límit: dividend igual a 0 (a == 0):Ha de retornar 0
    [InlineData(0, 10, 0)]
    //Cas límit: números grans (overflow)
    [InlineData(int.MaxValue, 1, int.MaxValue)]
    //Cas límit: Divisió exacte
    [InlineData(10, 2, 5)]
    //Cas límit: Divisió amb residu
    [InlineData(10, 3, 3)]
    //Amb aquest test es proven tots els límits de la funció Dividir. Si passa aquests tests
    //la funció Dividir hauria de funcionar correctament
    public void TestMultiplesLimitsDivisio(int a, int b, int resultatEsperat)
    {
        //Inicialitza
        //Crea l'objecte que utilitzarà per cridar la funció
        Calculadora c = new Calculadora();
        //Crida la funció
        int resultat = c.Dividir(a, b);
        //Comprova. 
        Assert.Equal(resultatEsperat, resultat);
    }

    [Theory]
    //Cas límit: dividend negatiu (a < 0): Ha de retornar -1
    [InlineData(-10, 2, -1)]
    //Cas límit: divisor negatiu (b < 0): Ha de retornar -1
    [InlineData(10, -2, -1)]
    //Cas límit: dividend i divisor negatius (a < 0 i b < 0): Ha de retornar -1
    [InlineData(-10, -2, -1)]
    //Cas límit: divisor més gran que dividend (b > a): Ha de retornar 0
    [InlineData(10, 20, 0)]
    //Cas límit: dividend i divisor iguals (a == b): Ha de retornar 1
    public void TestMultiplesLimitsComptarDivisions(int a, int b, int resultatEsperat)
    {
        //Inicialitza
        //Crea l'objecte que utilitzarà per cridar la funció
        Calculadora c = new Calculadora();
        //Crida la funció
        int resultat = c.ComptarDivisions(a, b);
        //Comprova. 
        Assert.Equal(resultatEsperat, resultat);
    }
}