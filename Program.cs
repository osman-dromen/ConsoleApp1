
internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Bienvenidos al curso de C#"); //Esto imprime un mensaje en Consola
        //int edad = 19;

        //edad+=8;

        //Console.WriteLine("Tienes una edad de: " + ++edad + " años");
        //Console.WriteLine($"Tienes una edad de: {edad} años");

        //edad -= 5;

        //Console.WriteLine("Tienes una edad de: " + edad++ + " años");

        Console.WriteLine("DECLARACION DE VARIABLES");
        int edadPersona1;
        int edadPersona2;
        int edadPersona3;
        int edadPersona4;

        edadPersona1 = edadPersona2 = edadPersona3 = edadPersona4 = 27;

        int edadPersona5, edadPersona6, edadPersona7, edadPersona8 = 55;

        edadPersona5 = 2;
        edadPersona6 = 7;
        edadPersona7 = 12;

        Console.WriteLine(edadPersona7);


        //Declaración implicita de variables
        var edadPersona = 27;

        

        Console.WriteLine(edadPersona);

        Console.WriteLine("EJEMPLO CONVERSION IMPLICITA Y EXPLICITA");
        double temperatura = 34.5;
        
        //conversión explicita
        //casting

        int temperaturaMadrid = (int)temperatura;

        Console.WriteLine(temperaturaMadrid);

        //Conversión implicita
        int habitantesCiudad = 10000000;
        long habitantesCiudad2018 = habitantesCiudad;

        Console.WriteLine(habitantesCiudad2018);

        float pesoMaterial = 5.78F;
        double pesoMaterialPrec = pesoMaterial;

        Console.WriteLine(pesoMaterialPrec);

        Console.WriteLine("Introduce el primer numero: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Introduce el segundo numero: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"El resultado de la suma de {num1} + {num2} = " + (num1 + num2));

        Console.WriteLine("EJEMPLO DE CONSTANTES");
        const int VALOR = 5;

        const int VALOR2 = 7;

        Console.WriteLine("El valor de la constante es: {0}",VALOR);

        Console.WriteLine("UTILIDAD DE UNA CONSTANTE");

        const double PI = 3.1416;

        Console.WriteLine("Cual es el radio del circulo: ");
        double radio = double.Parse(Console.ReadLine());

        //double area = radio*radio * PI;

        double area = Math.Pow(radio, 2)*PI;

        Console.WriteLine($"El area del circulo es: {area}");
         
    }

}