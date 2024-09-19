using static Electrodomestico;

public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public int DNI { get; set; }

    public enum SexosNumerados
    {
        SinDatos = 'x', Hombre = 'H', Mujer = 'M', NoBinario = 'N'
    }

    public SexosNumerados Sexo { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }

    public Persona() 
    {
        Nombre = "";
    }

    public Persona(string nombre, int edad, char sexo)
    {
        Nombre = nombre;
        Edad = edad;
        Sexo = (SexosNumerados)sexo;
    }

    public Persona(string nombre, int edad, char sexo, double peso, double altura, int dni)
    {
        Nombre = nombre;
        Edad = edad;
        Sexo = (SexosNumerados)sexo;
        Peso = peso;
        Altura = altura;
        DNI = dni;
    }

    public int calcularIMC()
    {
        double IMC = Peso / (Altura * Altura);
        if (IMC < 20)
        {
            return -1;
        }
        else
        {
            if (IMC <= 25)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }

    public bool esMayorDeEdad()
    {
        if (Edad > 18)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static bool validarSexo (char sexo)
    {
        return Enum.IsDefined(typeof(SexosNumerados), (SexosNumerados)sexo) && sexo != (char)SexosNumerados.SinDatos;
    }

    public string toString()
    {
        return "\nEl nombre es: " + Nombre + " \nSu edad es: " + Edad + " años\nSu sexo es: " + Sexo + " \nSu peso es: " + Peso + " KG\nSu altura es: " + Altura + " M\nSu DNI es: " + DNI;
    }
}