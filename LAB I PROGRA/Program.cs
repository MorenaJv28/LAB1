using Laboratorio1.Entidades;

Persona1 persona1 = new Persona1();

Console.WriteLine("Ingrese su altura en metro: ");
double altura1 = double.Parse(Console.ReadLine());

Console.WriteLine("\nIngrese su peso en kg: ");
double peso1 = double.Parse(Console.ReadLine());

persona1.calcularIMC(peso1, altura1);


Console.WriteLine("\nIngrese su nombre: ");
string Nombre1 = Console.ReadLine();

Console.WriteLine("\nIngrese su sexo: ");
string Sexo1 = Console.ReadLine();

Console.WriteLine("\nIngrese su edad: ");
int Edad1 = Int32.Parse(Console.ReadLine());

persona1.EsMayorDeEdad(Edad1,Nombre1,Sexo1);

