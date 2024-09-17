﻿using System.Drawing;

public abstract class Electrodomestico
{
    public decimal PrecioBase { get; set; }
    public enum Colores
    {
        NoEspecificado = 0,
        Blanco = 1,
        Negro = 2,
        Rojo = 3,
        Azul = 4,
        Verde = 5
    }

    public Colores Color { get; set; }

    public enum CalificacionConsumo
    {
        SinCalificacion = 0,
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        E = 5,
        F = 6
    }

    public CalificacionConsumo Letra { get; set; }

    public decimal Peso { get; set; }

    public bool validarConsumoEnergetico(char letra)
    {
        return Enum.IsDefined(typeof(CalificacionConsumo), (CalificacionConsumo)letra) && letra != (char)CalificacionConsumo.SinCalificacion;
    }

    public bool comprobarColor(string color)
    {
        if (Enum.TryParse<Colores>(color, out Colores colorParsed))
        {
            return Enum.IsDefined(typeof(Colores), colorParsed) && colorParsed != Colores.NoEspecificado;
        }
        return false;
    }
}

public class Lavadora : Electrodomestico
{
    public decimal Carga { get; set; }

    Lavadora()
    {
        Carga = 0;
    }
    Lavadora(decimal precio, decimal peso)
    {
        PrecioBase = precio;
        Peso = peso;
    }

    Lavadora(CalificacionConsumo letra, Colores color, decimal precio, decimal peso)
    {
        Letra = letra;
        Color = color;
        PrecioBase = precio;
        Peso = peso;
    }
}