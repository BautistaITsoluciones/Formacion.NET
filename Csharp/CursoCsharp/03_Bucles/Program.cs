// Bucles

int contador = 0;

Console.WriteLine("Contador: " + contador);
contador = contador + 1;
Console.WriteLine("Contador con suma larga : " + contador);
contador += 1;
Console.WriteLine("Contador con += : " + contador);
contador++;
Console.WriteLine("Contador con ++ : " + contador);

//Bucle FOR
for (int i = 0; i < 5; i++)
{
    int resultado = i;
    Console.WriteLine("Valor de i: " + resultado);
}

//Bucles WHILE y DO WHILE
int j = 0;
while (j < 5)
{
    Console.WriteLine("Valor de j: " + j);
    j++;
}

int k = 0;
do
{
    Console.WriteLine("Valor de k: " + k);
    k++;
} while (k < 5);


// Desafío: Crear un bucle for hasta 10 que indique si el número es par o impar.
for (int i = 0; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i + " es un número par.");
    }
    else
    {
        Console.WriteLine(i + " es un número impar.");
    }
}
