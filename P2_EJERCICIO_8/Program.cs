using System;

class Tanque
{
    public double Capacidad { get; set; }
    public double Volumen { get; set; }
    public double Incremento { get; set; }

    public void AgregarLiquido()
    {
        Volumen = Volumen + Incremento;

        if (Volumen > Capacidad)
        {
            Volumen = Capacidad;
        }
    }

    public double CalcularPorcentaje()
    {
        double porcentaje;

        porcentaje = (Volumen / Capacidad) * 100;

        return porcentaje;
    }

    public bool EstaLleno()
    {
        if (Volumen >= Capacidad)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

class Program
{
    static void Main()
    {
        Tanque tanque1 = new Tanque();

        Console.Write("Ingrese la capacidad máxima del tanque en L: ");
        tanque1.Capacidad = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el volumen inicial en L: ");
        tanque1.Volumen = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el volumen agregado por ciclo en L: ");
        tanque1.Incremento = Convert.ToDouble(Console.ReadLine());

        int ciclo = 0;

        Console.WriteLine();
        Console.WriteLine("--- LLENADO DEL TANQUE ---");

        while (tanque1.EstaLleno() == false)
        {
            ciclo = ciclo + 1;

            tanque1.AgregarLiquido();

            double porcentaje;
            porcentaje = tanque1.CalcularPorcentaje();

            Console.WriteLine("Ciclo: " + ciclo);
            Console.WriteLine("Volumen: " + tanque1.Volumen + " L");
            Console.WriteLine("Llenado: " + porcentaje + "%");
            Console.WriteLine();
        }

        Console.WriteLine("El tanque está lleno.");
    }
}