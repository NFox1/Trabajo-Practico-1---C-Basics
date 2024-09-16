public class Program
{
    static void Main()
    {
        Console.WriteLine("Aplicacion de consola: Trabajo Practico 1 - C# Basics\n" + "Elija el programa:\n" + "1. Cuenta Bancaria | 2. Persona | 3. Electrodomestico");
        decimal.TryParse(Console.ReadLine(), out decimal AplicacionSeleccionada);
        if (AplicacionSeleccionada == 1)
        {
            Cuenta cuenta = new Cuenta("Marcos", 1000);
            Console.WriteLine("Bienvenido " + cuenta.Titular + ", indique si va a realizar un deposito (ingresando 1) o una extraccion (ingresando 2)");
            Console.WriteLine("Su saldo actual es de: " + cuenta.Cantidad);
            decimal.TryParse(Console.ReadLine(), out decimal OperacionElegida);
            if (OperacionElegida == 1)
            {
                Console.WriteLine("Por favor ingrese la cantidad a ingresar");
                decimal.TryParse(Console.ReadLine(), out decimal SaldoPorAgregar);
                cuenta.Deposito(SaldoPorAgregar);
                Console.WriteLine(cuenta.MostrarSaldo());
            }
            else
            {
                if (OperacionElegida == 2)
                {
                    Console.WriteLine("Por favor ingrese la cantidad a retirar");
                    decimal.TryParse(Console.ReadLine(), out decimal SaldoPorRetirar);
                    cuenta.Retiro(SaldoPorRetirar);
                    Console.WriteLine(cuenta.MostrarSaldo());
                }
                else
                {
                    Console.WriteLine("Invalido");
                }
            }
        }
        else
        {
            if (AplicacionSeleccionada == 2)
            {
                Console.WriteLine("En desarrollo");
            }
            else
            {
                if (AplicacionSeleccionada == 3)
                {
                    Console.WriteLine("En desarrollo");
                }
                else
                {
                    Console.WriteLine("Invalido");
                }
            }
        }
        
    }
}