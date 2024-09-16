class Cuenta
{
    public string Titular { get; set; }
    public decimal Cantidad { get; set; }
    public bool DadaDeBaja { get; set; }


    public Cuenta(string titular, decimal cantidad)
    {
        Titular = titular;
        Cantidad = cantidad;
        DadaDeBaja = false;
    }

    public Cuenta(string titular, bool dadadebaja = false)
    {
        Titular = titular;
        DadaDeBaja = dadadebaja;
    }
    public void Deposito(decimal cantidad)
    {
        if (cantidad > 0)
        {
            Cantidad += cantidad;
        }
    }

    public void Retiro(decimal cantidad)
    {
        if (cantidad > 0)
        {
            if (cantidad > Cantidad)
            {
                Cantidad = 0;
            } else
            {
                Cantidad -= cantidad;
            }
        }
    }

    public string MostrarSaldo()
    { return "Ahora su saldo es de " + Cantidad; }
}