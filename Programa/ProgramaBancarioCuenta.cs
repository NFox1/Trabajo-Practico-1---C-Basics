public class ProgramaBancario
{
    static void Main()
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
}