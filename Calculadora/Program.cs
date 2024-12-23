// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bon dia!, Quina taula de multiplicar vols veure?");
int taula = Convert.ToInt32(Console.ReadLine());
//Crea l'objecte calculadora
Calculadora calculadora = new Calculadora();
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{taula} * {i} = {calculadora.Multiplicar(taula, i)}");
}

Console.WriteLine("Quins dos números vols sumar?");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"La suma de {a} i {b} és {calculadora.Sumar(a, b)}");

Console.WriteLine("Quins dos números vols restar?");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"La resta de {a} i {b} és {calculadora.Restar(a, b)}");

Console.WriteLine("Quantes vegades es pot dividir A per B?");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Es pot dividir {a} per {b} {calculadora.ComptarDivisions(a, b)} vegades");
