
int numero = 0;
int contador = 0;

Console.WriteLine("Inserta el numero para indicar si es primo " +
    "\n \n Recuerda que el Numero 1 es la exepcion a la regal asi que no lo pongas ");
numero= Convert.ToInt32(Console.ReadLine());
Console.Clear();
while (true)
{

}
if (numero == 1)
{
    Console.WriteLine("Tes estoy diciendo que el 1 no, como estas wey");

}

    for (int i = 1; i < numero; i++)
    {
        if (numero % i == 0)
        {
            contador++;
        }
    }
    if (contador == 1)
    {
        Console.WriteLine("es un numero primo");
    }
    else
    {
        Console.WriteLine("No es primo");
    }
