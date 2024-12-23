// Version: 1.0
/// <summary>
/// Clase que representa una calculadora
/// </summary>
public class Calculadora
{
    /// <summary>
    /// Suma dos números
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>La suma de a i b </returns>
    public int Sumar(int a, int b)
    {
        return a + b;
    }
    /// <summary>
    /// Resta dos números
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns>La resta de a i b </returns>
    public int Restar(int a, int b)
    {
        return a - b;
    }
    /// <summary>
    /// Multiplica dos números
    /// </summary>
    ///  <param name="a"></param>
    ///    <param name="b"></param>
    ///     <returns>La multiplicació de a i b </returns>
    public int Multiplicar(int a, int b)
    {
        return a * b;
    }

    /// <summary>
    /// Divideix dos números
    /// </summary>
    ///  <param name="a">a ha de ser més gran o igual que 0</param>
    ///    <param name="b">b al ser el divisor ha de ser més gran que 0 </param>
    ///     <returns>La divisió de a i b. -1 --> Error  </returns>
    public int Dividir(int a, int b)
    {
        if (b == 0)
        {
            return -1;
        }
        return a / b;
    }
    /// <summary>
    /// Compte les vegades que es pot dividir un dividend entre un divisor
    /// </summary>
    /// <param name="dividend">Ha de ser >=0</param>
    /// <param name="divisor">Ha de ser >0</param>
    /// <returns>Nombre vegades es pot dividir dividend per divisor. -1 --> Error</returns>
    public int ComptarDivisions(int dividend, int divisor)
    {
        int comptador = 0;
        if (dividend < 0 || divisor <= 0)
        {
            return -1;
        }

        while (dividend >= divisor)
        {
            dividend = Dividir(dividend,divisor); // Divideix el dividend pel divisor
            comptador++;         // Incrementa el comptador
        }

        return comptador; // Retorna el nombre de divisions realitzades
    }

    
}
