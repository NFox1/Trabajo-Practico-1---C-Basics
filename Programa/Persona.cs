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
    public decimal Peso { get; set; }
    public decimal Altura { get; set; }

    Persona() 
    {
        Nombre = "";
        Edad = 0;
        DNI = 0;
        Sexo = 0;
        Peso = 0;
        Altura = 0;
    }

    Persona(string nombre, int edad, SexosNumerados sexo)
    {
        Nombre = nombre;
        Edad = edad;
        Sexo = sexo;
    }

    Persona(string nombre, int edad, SexosNumerados sexo, decimal peso, decimal altura, int dni)
    {
        Nombre = nombre;
        Edad = edad;
        Sexo = sexo;
        Peso = peso;
        Altura = altura;
        DNI = dni;
    }

    public int calcularIMC()
    {
        decimal IMC = Peso / (Altura * Altura);
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
}