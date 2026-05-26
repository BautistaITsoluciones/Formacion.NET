// See https://aka.ms/new-console-template for more information
/*
Console.WriteLine("Por favor ingresa tu nombre");
string nombre = Console.ReadLine()!;

Console.WriteLine("Ingrese su edad ");
int edad = int.Parse(Console.ReadLine()!);

Console.WriteLine("Hola " + nombre + ", bienvenido a C# a tus " + edad + " años");

Console.WriteLine($"Hola {nombre}, bienvenido a C# a tus {edad} años");
*/

Console.WriteLine("***********************NUMEROS***********************");
int numero1 = 10;
double numero2 = 3.14;

Console.WriteLine(numero1+numero2 );

//Decimales
float numero3 = 1f/3f; // 0.33333334f (aproximadamente)
double numero4 = 1.0 / 3.0; // 0.3333333333333333 (más precisión que float)
decimal numero5 = 1m / 3m; // 0.3333333333333333333333333333m (precisión aún mayor que double)

Console.WriteLine($"Float: {numero3}");
Console.WriteLine($"Double: {numero4}");
Console.WriteLine($"Decimal: {numero5}");

decimal salario = 1205.25m;
decimal aumento = 10.10m;
decimal nuevoSalario = salario + aumento;
float elNuevoSalarioEnFloat = (float)nuevoSalario;

Console.WriteLine($"Salario original: {salario}");
Console.WriteLine($"Aumento: {aumento}");   
Console.WriteLine($"Nuevo salario: {nuevoSalario}");
Console.WriteLine($"Nuevo salario en float: {elNuevoSalarioEnFloat}");

//Operaciones
int a = 10;
int b = 3;  
Console.WriteLine($"Suma: {a + b}"); // 13
Console.WriteLine($"Resta: {a - b}"); // 7  

/*
TAREAS: 
1. Crea un programa que solicite al usuario su nombre, edad y ciudad de residencia, y luego imprima un mensaje personalizado utilizando interpolación de cadenas.
2. Escribe un programa que calcule el área de un círculo dado su radio. El usuario debe ingresar el valor del radio, y el programa debe mostrar el resultado con dos decimales.
3. Crea un programa que convierta una cantidad de dinero de dólares a euros. El usuario debe ingresar la cantidad en dólares y el tipo de cambio actual, y el programa debe mostrar el resultado en euros con dos decimales.
*/
Console.WriteLine("Presione cualquier tecla para salir...");
Console.ReadKey();
