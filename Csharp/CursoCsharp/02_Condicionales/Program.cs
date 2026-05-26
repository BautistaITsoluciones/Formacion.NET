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

string sexo = "Femenino";

if(sexo == "Masculino" || sexo == "Femenino")
{
    Console.WriteLine("El sexo es válido");
    if (sexo != "Masculino")
    {
        Console.WriteLine("El sexo es Femenino");
    }
    else
    {
        Console.WriteLine("El sexo es Masculino");
    }
}
else
{
    Console.WriteLine("El sexo no es válido");
}

Console.WriteLine("*************************Switch************************");

string nacionalidad = "Argentina";

//Evalúa la variable nacionalidad y ejecuta el bloque de código correspondiente con if
if (nacionalidad == "Argentina")
{
    Console.WriteLine("La persona es Argentina");
}
else if (nacionalidad == "Brasil")
{
    Console.WriteLine("La persona es Brasilera");
}
else if (nacionalidad == "Chile")
{
    Console.WriteLine("La persona es Chilena");
}
else
{
    Console.WriteLine("Nacionalidad no reconocida");
}

//Evalúa la variable nacionalidad y ejecuta el bloque de código correspondiente con switch
nacionalidad = "Brasil";
switch (nacionalidad)
{
    case "Argentina":
        Console.WriteLine("La persona es Argentina");
        break;
    case "Brasil":
        Console.WriteLine("La persona es Brasilera");
        break;
    case "Chile":
        Console.WriteLine("La persona es Chilena");
        break;
    default:
        Console.WriteLine("Nacionalidad no reconocida");
        break;
}

// 1°  Escribe un programa que ingrese por teclado la edad, el nombre y el sexo.
//Si es mayor de 18 y es hombre, que muestre Felicitaciones NOMBRE_AQUI eres mayor de edad y eres hombre
//Si es mayor de 18 y es mujer, que muestre Felicitaciones NOMBRE_AQUI eres mayor de edad y eres mujer
//Si es menor de 18 y es hombre, que muestre Lo siento NOMBRE_AQUI eres menor de edad y eres hombre
//Si es menor de 18 y es mujer, que muestre Lo siento NOMBRE_AQUI eres menor de edad y eres mujer

// 2°  Escribe un programa que busque en la cadena "esto es una cadena de prueba porque estoy empezando a programar en Csharp" 
//las palabras prueba y programar, y si lo encuentra que imprima por pantalla "encontrado"
    
// 1°
Console.WriteLine("Ingrese su nombre:");
string nombre = Console.ReadLine()!;
Console.WriteLine("Ingrese su edad:");
int edad = int.Parse(Console.ReadLine()!);
Console.WriteLine("Ingrese su sexo (Masculino/Femenino):");
string sexoUsuario = Console.ReadLine()!;

if(edad > 18 && sexoUsuario == "Masculino")
{
    Console.WriteLine($"Felicitaciones {nombre} eres mayor de edad y eres hombre");
}
else if(edad > 18 && sexoUsuario == "Femenino")
{
    Console.WriteLine($"Felicitaciones {nombre} eres mayor de edad y eres mujer");
}
else if(edad < 18 && sexoUsuario == "Masculino")
{
    Console.WriteLine($"Lo siento {nombre} eres menor de edad y eres hombre");
}
else if(edad < 18 && sexoUsuario == "Femenino")
{
    Console.WriteLine($"Lo siento {nombre} eres menor de edad y eres mujer");
}
else
{
    Console.WriteLine("Datos ingresados no válidos");
}


// 2°
string cadena = "esto es una cadena de prueba porque estoy empezando a programar en Csharp";
if (cadena.Contains("prueba") && cadena.Contains("programar"))
{
    Console.WriteLine("encontrado");
}
else
{
    Console.WriteLine("no encontrado");
}
