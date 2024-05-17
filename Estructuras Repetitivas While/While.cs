using System;

namespace EstructurasWhile
{
    public class EstructurasWhile
    {
        public void Ejercicio1()
        {
            const int cantidadValores = 10;
            int suma = 0;
            int contador = 0;

            try
            {
                Console.WriteLine("Ingrese 10 valores:");

                while (contador < cantidadValores)
                {
                    Console.Write($"Valor {contador + 1}: ");
                    int valor;
                    if (int.TryParse(Console.ReadLine(), out valor))
                    {
                        suma += valor;
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("Error: Ingrese un valor entero válido.");
                    }
                }

                double promedio = (double)suma / cantidadValores;

                Console.WriteLine($"La suma de los valores ingresados es: {suma}");
                Console.WriteLine($"El promedio de los valores ingresados es: {promedio}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un valor entero válido.");
            }
        }

        public void Ejercicio2()
        {
            int cantidadPiezas;
            int piezasAptas = 0;

            try
            {
                Console.WriteLine("Ingrese la cantidad de piezas a procesar:");
                cantidadPiezas = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la longitud de cada perfil:");

                int contador = 0;
                while (contador < cantidadPiezas)
                {
                    Console.Write($"Longitud de la pieza {contador + 1}: ");
                    double longitud;
                    if (double.TryParse(Console.ReadLine(), out longitud))
                    {
                        if (longitud >= 1.20 && longitud <= 1.30)
                        {
                            piezasAptas++;
                        }
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("Error: Ingrese una longitud válida.");
                    }
                }

                Console.WriteLine($"La cantidad de piezas aptas en el lote es: {piezasAptas}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese una longitud válida.");
            }
        }

        public void Ejercicio3()
        {
            int cantidadPiezas;
            int piezasAptas = 0;

            try
            {
                Console.WriteLine("Ingrese la cantidad de piezas a procesar:");
                cantidadPiezas = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la longitud de cada perfil:");

                int contador = 0;
                while (contador < cantidadPiezas)
                {
                    Console.Write($"Longitud de la pieza {contador + 1}: ");
                    double longitud;
                    if (double.TryParse(Console.ReadLine(), out longitud))
                    {
                        if (longitud >= 1.20 && longitud <= 1.30)
                        {
                            piezasAptas++;
                        }
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("Error: Ingrese una longitud válida.");
                    }
                }

                Console.WriteLine($"La cantidad de piezas aptas en el lote es: {piezasAptas}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese una longitud válida.");
            }
        }

        public void Ejercicio4()
        {
            int cantidadEmpleados;
            int sueldos100a300 = 0;
            int sueldosMas300 = 0;
            double gastoTotal = 0;

            try
            {
                Console.WriteLine("Ingrese la cantidad de empleados:");
                cantidadEmpleados = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese los sueldos de los empleados:");

                int contador = 0;
                while (contador < cantidadEmpleados)
                {
                    Console.Write($"Sueldo del empleado {contador + 1}: ");
                    double sueldo;
                    if (double.TryParse(Console.ReadLine(), out sueldo))
                    {
                        if (sueldo >= 100 && sueldo <= 300)
                        {
                            sueldos100a300++;
                        }
                        else if (sueldo > 300)
                        {
                            sueldosMas300++;
                        }

                        gastoTotal += sueldo;
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("Error: Ingrese un sueldo válido.");
                    }
                }

                Console.WriteLine($"Empleados que cobran entre $100 y $300: {sueldos100a300}");
                Console.WriteLine($"Empleados que cobran más de $300: {sueldosMas300}");
                Console.WriteLine($"Gasto total en sueldos: ${gastoTotal}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Ingrese un sueldo válido.");
            }
        }
    }
}
