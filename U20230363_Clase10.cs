using System;
using System.Diagnostics;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {

          //programa que al ingresar el número del mes del primer semestre donde enero es el mes 1 y julio el mes 6 mostrando el nombre del mes.
        
            //Menu de opciones aplicando la estructura selectiva switch-case. 

            Console.WriteLine("\n----- MENÚ DE OPCIONES -----\n");

            Console.WriteLine("Opción del mes 1\n"+"Opción del mes 2\n"+"Opción del mes 3\n"+"Opción del mes 4\n"+"Opción del mes 5\n"+"Opción del mes 6\n"+"\nIngrese el número del mes del primer semestre del año.\n");

            int numMes = Convert.ToInt32(Console.ReadLine());

            string? nombreMes = "";

            switch(numMes)
            
            {
                case 1:
                nombreMes = "Enero";
                break;

                case 2:
                nombreMes = "Febrero";
                break;

                case 3:
                nombreMes = "Marzo";
                break;

                case 4:
                nombreMes = "Abril";
                break;

                case 5:
                nombreMes = "Mayo";
                break;

                case 6:
                nombreMes = "Junio";
                break;
                
                default:
                Console.WriteLine("\nNúmero del mes inválido. Por favor ingrese el número del mes correcto\n");
                return;

            }

            Console.WriteLine("\nEl número de mes "+numMes+" correspornde a "+nombreMes+"\n");
            Console.WriteLine("\n----- Fin del programa -----\n");
                     

        }
    }
}