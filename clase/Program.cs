
class Program
{

    
    static void Main()
    {


    
        Console.Write("Ingrese el primer número: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        
        Console.WriteLine("Seleccione la operación:");
        Console.WriteLine("1. Sumar");
        Console.WriteLine("2. Restar");
        Console.WriteLine("3. Multiplicar");
        Console.WriteLine("4. Divicion");

        Console.Write("Ingrese su opción (1, 2, 3 o 4)");
        int opcion = Convert.ToInt32(Console.ReadLine());

        double resultado = 0;
        bool operacionValida = true;

       
        switch (opcion)
        {
            case 1:
                resultado = num1 + num2;
                Console.WriteLine($"El resultado de la suma es: {resultado}");
                break;
            case 2:
                resultado = num1 - num2;
                Console.WriteLine($"El resultado de la resta es: {resultado}");
                break;
            case 3:
                resultado = num1 * num2;
                Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                break;

            case 4:
                resultado = num1 / num2;
                Console.WriteLine($"El resultado de la division es: {resultado}");
                break;

            default:
                operacionValida = false;
                Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                break;
        }

        
        if (operacionValida)
        {
            Console.WriteLine("todo listo"); 
        }
    }
}












