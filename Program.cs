// See https://aka.ms/new-console-template for more information
//adivina el numero del 1 al 100

int numero = -1;
int contadorIntentos = 0;
int numeroAleatorio = 0;
const int numeroMinimo = 1;
const int numeroMaximo = 100;
const int intentosMaximo = 10;	
Random aleatorio = new Random();    
numeroAleatorio = aleatorio.Next(numeroMinimo, numeroMaximo);
Console.Clear();
Console.WriteLine($"Tienes {intentosMaximo} intentos");
Console.WriteLine("Adivina el numero del 1 al 100");


while (numero != numeroAleatorio && contadorIntentos < intentosMaximo)
{   
    contadorIntentos++;
    Console.WriteLine("Ingrese un numero :");
    
    try
    {
       numero =int.Parse(Console.ReadLine());

       if(numero<numeroMinimo || numero>numeroMaximo)
            throw new ArgumentException("Número fuera de rango");

       }
    catch(FormatException ef)
    {
          Console.WriteLine("No ha introcido un número");
          Console.WriteLine(ef.Message);
          continue;

    }
    catch(ArgumentException ea){
        Console.WriteLine(ea.Message);   
    }
    
    
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
        Console.BackgroundColor=ConsoleColor.Green;
        Console.WriteLine("Has acertado");
        Console.BackgroundColor=ConsoleColor.Black;
    }

}

if(contadorIntentos>intentosMaximo){
    Console.BackgroundColor=ConsoleColor.Red;
    Console.WriteLine("Has perdido");
    Console.BackgroundColor=ConsoleColor.Black;
}	
Console.WriteLine($"Numero de intentos : {contadorIntentos}");
Console.WriteLine("Presione cualquier tecla para salir");
Console.ReadKey();

