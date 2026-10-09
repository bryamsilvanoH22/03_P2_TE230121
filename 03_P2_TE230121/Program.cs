Console.WriteLine("=============================================");
Console.WriteLine("     MONITOREO DE TEMPERATURA DEL MOTOR");
Console.WriteLine("=============================================");
Console.WriteLine();

// Instanciar el objeto de la clase MonitoreoTemperatura
MonitoreoTemperatura monitor = new MonitoreoTemperatura();

Console.WriteLine("Ingrese las 5 lecturas de temperatura en °C:");

// Solicitar las 5 mediciones con un ciclo for
for (int i = 0; i < 5; i++)
{
    Console.Write($"Lectura {i + 1}: ");
    monitor.Temperaturas[i] = Convert.ToDouble(Console.ReadLine());
}

// Solicitar los cálculos al objeto
double promedio = monitor.CalcularPromedio();
string estado = monitor.ObtenerEstado();

// Mostrar resultados formateados con sus unidades
Console.WriteLine();
Console.WriteLine("=============================================");
Console.WriteLine("             RESULTADOS DE EVALUACIÓN         ");
Console.WriteLine("=============================================");
Console.WriteLine($"Temperatura Promedio: {promedio:F2} °C");
Console.WriteLine($"Estado del Motor:     {estado}");
Console.WriteLine("=============================================");

Console.ReadKey();


// Definición de la Clase
class MonitoreoTemperatura
{
    // Propiedad (Arreglo para almacenar las 5 lecturas)
    public double[] Temperaturas { get; set; } = new double[5];

    // Método para calcular el promedio de las temperaturas
    public double CalcularPromedio()
    {
        double suma = 0;

        for (int i = 0; i < Temperaturas.Length; i++)
        {
            suma += Temperaturas[i];
        }

        return suma / Temperaturas.Length;
    }

    // Método para determinar el estado del motor
    public string ObtenerEstado()
    {
        double promedio = CalcularPromedio();

        if (promedio <= 70.0)
        {
            return "NORMAL";
        }
        else
        {
            return "ALERTA DE TEMPERATURA";
        }
    }
}