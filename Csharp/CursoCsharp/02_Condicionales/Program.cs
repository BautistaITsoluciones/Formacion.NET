// Condicionales y Operadores Lógicos

int edadPersona1 = 56;
int edadPersona2 = 75;

if (edadPersona1 > edadPersona2)
{
    Console.WriteLine("La persona 1 es mayor que la persona 2");
}
else if (edadPersona1 < edadPersona2)
{
    Console.WriteLine("La persona 2 es mayor que la persona 1");
}
else
{
    Console.WriteLine("Ambas personas tienen la misma edad");
}

int x = 10;
int y = 5;
int z = 3;

if ((x > 5) && (y < 10 || z == 3))
{
    Console.WriteLine("Cumple la condición matemática");
}

/*
Operadores Lógicos:
- && (AND): Devuelve true si ambas condiciones son verdaderas.
- || (OR): Devuelve true si al menos una de las condiciones es verdadera.
- ! (NOT): Invierte el valor de una condición (true a false, o false a true).
*/