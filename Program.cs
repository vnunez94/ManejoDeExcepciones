// See https://aka.ms/new-console-template for more information
//adivina el numero del 1 al 100

int numero = -1;
int contadorIntentos = 0;
int numeroAleatorio = 0;
const int numeroMinimo = 1;
const int numeroMaximo = 100;
const int intentosMaximo = 5;	
Random aleatorio = new Random();    
numeroAleatorio = aleatorio.Next(numeroMinimo, numeroMaximo);
Console.WriteLine($"Tienes {intentosMaximo} intentos");
Console.WriteLine("Adivina el numero del 1 al 100");
Console.Clear();

while (numero != numeroAleatorio && contadorIntentos < intentosMaximo)
{
    Console.WriteLine("Adivina el numero del 1 al 100");
     try{
        numero =int.Parse(Console.ReadLine());
     }
        catch(Exception e){
            Console.WriteLine("No has introducido un numero");
            continue;
        }
    contadorIntentos++;
    if (numero < numeroAleatorio)
    {
        Console.WriteLine("El numero es mayor");
    }
    else if (numero > numeroAleatorio)
    {
        Console.WriteLine("El numero es menor");
    }
    else
    {
        Console.WriteLine("Has acertado");
    }
}

	
Console.WriteLine($"Numero de intentos : {contadorIntentos}");
Console.WriteLine("Presione cualquier tecla para salir");
Console.ReadKey();

