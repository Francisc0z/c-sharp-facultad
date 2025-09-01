using System;
class HelloWorld
{
    static void Main()
    {

        terceraClase();
    }

    static void segundaClase()
    {
        int numero = 0;
        for (int i = 0; i < 3; i++)
        {
            System.Console.WriteLine("Ingrese un numero: ");
            int ingreso = int.Parse(Console.ReadLine());
            if (ingreso > numero)
            {
                numero = ingreso;
            }
        }
        System.Console.WriteLine("El numero mas grande es: ", numero);

        //Segundo ejercicio
        System.Console.WriteLine("Ingrese el termino A: ");
        int a = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Ingrese el termino B: ");
        float b = float.Parse(Console.ReadLine());

        System.Console.WriteLine("Ingrese el termino C: ");
        int c = int.Parse(Console.ReadLine());

        int raizX = (int)(-b + Math.Sqrt(Math.Pow(b, 2.00) - 4 * a * c));
        int raizY = (int)(-b - Math.Sqrt(Math.Pow(b, 2.00) - 4 * a * c));

        System.Console.WriteLine("La 1era raiz es: ", raizX);
        System.Console.WriteLine("La 1era raiz es: ", raizY);

        //Tercer ejercicio
        System.Console.WriteLine("Ingrese la base: ");
        int baseNum = int.Parse(Console.ReadLine());


        System.Console.WriteLine("Ingrese el exponente: ");
        int exponente = int.Parse(Console.ReadLine());

        int exponenciado = 0;
        for (int i = 0; i < exponente; i++)
        {
            exponenciado += baseNum;
        }

        //4to ejercicio
        System.Console.WriteLine("Ingrese el candidato a primo: ");
        int posiblePrimo = int.Parse(Console.ReadLine());
        bool esPrimo = false;
        for (int i = 2; i < posiblePrimo; i++)
        {
            if (posiblePrimo / i == 1)
            {
                esPrimo = true;
            }
        }
        if (esPrimo)
        {
            System.Console.WriteLine("Es primo");
        }
        else
        {
            System.Console.WriteLine("No es primo");
        }

        //Ejercicio 5
        System.Console.WriteLine("Ingrese el numero a listar: ");
        int numeroAListar = int.Parse(Console.ReadLine());

        for (int i = 0; i < numeroAListar; i++)
        {
            System.Console.WriteLine("Este numero es ", i);
        }

        //Ejercicio 6
        System.Console.WriteLine("Ingrese su deuda");
        int deuda = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Ingrese su pago mensual");
        int pago = int.Parse(Console.ReadLine());
        int totalPagado = deuda;
        do
        {
            deuda -= pago;
            System.Console.WriteLine("Su deuda actual es: " + deuda);
            System.Console.WriteLine("Total pagado: " + ((deuda - totalPagado) * -1));

        } while (deuda > 0);

        //Ejercicio 7
        int fibo = 0;
        int fiboAnterior = 1;
        for (int i = 0; i <= 30; i++)
        {
            System.Console.WriteLine(fibo);
            int temp = fibo;
            fibo = fiboAnterior;
            fiboAnterior = temp + fiboAnterior;
        }
    }

    static void terceraClase()
    {
        
    }
}