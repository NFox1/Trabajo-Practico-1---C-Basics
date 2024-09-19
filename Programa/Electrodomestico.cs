using System.Drawing;

public abstract class Electrodomestico
{
    public double PrecioBase { get; set; }
    public enum Colores
    {
        noEspecificado,
        blanco,
        negro,
        rojo,
        azul,
        verde
    }

    public Colores Color { get; set; }

    public enum CalificacionConsumo
    {
        SinCalificacion = 'x',
        ExtremadamenteEficiente = 'A',
        MuyEficiente = 'B',
        Eficiente = 'C',
        Media = 'D',
        Deficiente = 'E',
        MuyDeficiente = 'F'
    }

    public CalificacionConsumo Letra { get; set; }

    public double Peso { get; set; }

    public bool validarConsumoEnergetico(char letra)
    {
        return Enum.IsDefined(typeof(CalificacionConsumo), (CalificacionConsumo)letra) && letra != (char)CalificacionConsumo.SinCalificacion;
    }

    public bool comprobarColor(string color)
    {
        if (Enum.TryParse<Colores>(color, out Colores colorParsed))
        {
            return Enum.IsDefined(typeof(Colores), colorParsed) && colorParsed != Colores.noEspecificado;
        }
        return false;
    }

    public virtual double precioFinal()
    {
        return PrecioBase + precioSegunConsumo() + precioSegunPeso();
    }

    public int precioSegunConsumo()
    {
        if (Letra == (CalificacionConsumo.ExtremadamenteEficiente))
        {
            return 100;
        }
        else
        {
            if (Letra == (CalificacionConsumo.MuyEficiente))
            {
                return 80;
            }
            else
            {
                if (Letra == (CalificacionConsumo.Eficiente))
                {
                    return 60;
                }
                else
                {
                    if (Letra == (CalificacionConsumo.Media))
                    {
                        return 50;
                    }
                    else
                    {
                        if (Letra == (CalificacionConsumo.Deficiente))
                        {
                            return 30;
                        }
                        else
                        {
                            if (Letra == (CalificacionConsumo.MuyEficiente))
                            {
                                return 10;
                            }
                            else
                            {
                                return 0;
                            }
                        }
                    }
                }
            }
        }
    }

    public int precioSegunPeso()
    {
        if (Peso < 20)
        {
            return 10;
        }
        else
        {
            if (Peso < 50)
            {
                return 50;
            }
            else
            {
                if (Peso < 80)
                {
                    return 80;
                }
                else
                {
                    return 100;
                }
            }
        }
    }
}

public class Lavadora : Electrodomestico
{
    public double Carga { get; set; }

    public Lavadora() { }
    public Lavadora(double precio, double peso)
    {
        PrecioBase = precio;
        Peso = peso;
    }

    public Lavadora(double precio, double peso, double carga, char letra, string color)
    {
        Letra = (CalificacionConsumo)letra;
        Color = Enum.Parse<Colores>(color);
        PrecioBase = precio;
        Peso = peso;
        Carga = carga;
    }

    public override double precioFinal()
    {
        double PrecioFinal = base.precioFinal();
        if (Carga > 30)
        {
            PrecioFinal = PrecioFinal + 50;
        }
        return PrecioFinal;
    }
}

public class Television : Electrodomestico
{
    public int Resolucion { get; set; }

    public Television() { }
    public Television(double precio, double peso, int resolucion = 0)
    {
        PrecioBase = precio;
        Peso = peso;
        Resolucion = resolucion;
    }

    public Television(double precio, double peso, int resolucion, char letra, string color)
    {
        Letra = (CalificacionConsumo)letra;
        Color = Enum.Parse<Colores>(color);
        PrecioBase = precio;
        Peso = peso;
        Resolucion = resolucion;
    }

    public override double precioFinal()
    {
        double PrecioFinal = base.precioFinal();
        if (Resolucion > 40)
        {
            PrecioFinal = PrecioFinal + (PrecioFinal * 0.3);
        }
        return PrecioFinal;
    }
}