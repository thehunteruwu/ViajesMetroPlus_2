using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;

public class testclass
{
    [Fact]
    public void TesteoObtieneRutaMenorPasajeros()
    {
        string devuelve;
        string[] devuelve1 = { "NombrePrueba1", "NombrePrueba2", "NombrePrueba3", "NombrePrueba4", "NombrePrueba5" };
        int devuelve2 = 0;
        int[] devuelve3 = { 1, 2, 3, 4, 5 };
        Assert.True(ex03_ViajesMetroplus.Program.ObtieneRutaMenorPasajeros(devuelve3,
                devuelve1,
                out devuelve,
                out devuelve2));
    }

    [Fact]
    public void TesteoTotalizaPasajerosRuta()
    {
        string[] devuelve1 = { "NombrePrueba1", "NombrePrueba2", "NombrePrueba3", "NombrePrueba4", "NombrePrueba5" };

        Random aleatorio = new Random();
        ex03_ViajesMetroplus.Viaje[] losViajes = new ex03_ViajesMetroplus.Viaje[100];

        for (int i = 0; i < losViajes.Length; i++)
        {
            losViajes[i] = new ex03_ViajesMetroplus.Viaje();
            losViajes[i].Ruta = devuelve1[aleatorio.Next(devuelve1.Length)];
            losViajes[i].CantidadPasajeros = aleatorio.Next(5, 41);
        }
        Assert.NotEmpty(ex03_ViajesMetroplus.Program.TotalizaPasajerosRuta(losViajes, devuelve1));
    }

}

