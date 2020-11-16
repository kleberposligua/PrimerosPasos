using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerosPasos
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipos de datos
            int a, b, suma; //declarar una variable tipo entero
            a = 10;
            b = 20;
            suma = a + b;
            Console.WriteLine("La suma de {0} + {1} = {2}", a, b, suma);

            //tipo de dato: número en coma flotante
            float sueldo, egreso, total;
            Console.Write("Ingresa el sueldo de trabajador: ");
            sueldo = float.Parse(Console.ReadLine());

            Console.Write("Ingresa los gastos del trabajador: ");
            egreso = float.Parse(Console.ReadLine());

            total = sueldo - egreso;

            Console.WriteLine("El líquido a recibir es: {0}", total);

            //case sensitive

            //tipo de dato: flotante de doble precisión
            double x1 = 200.5679;
            Console.WriteLine("Tipo dato double: {0}", x1);

            //Tipo de dato: Cadena de caracteres (string)
            String nombre;
            Console.Write("Ingresa tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + ", bienvenido al curso de Programación!!!");

            //tipo dato booleano (tipo lógico: verdadero/falso)  (true/false)
            bool sw;
            sw = (a + 50) > b;
            Console.WriteLine("El valor del booleano sw: {0}", sw);

            //Pilares fundamentales de la programación estructura
            //ejecución de sentencias secuenciales
            //uso estructuras repetitivas
            //uso estructuras selectivas
            saludos(nombre);
            saludos("José Alcívar");
            saludos("María Castro");

            Console.WriteLine();
            Console.WriteLine("Llamada a función que devuelve valor");
            Console.WriteLine("Líquido a recibir para Juan {0}", calcularSueldo(300, 200));
            Console.WriteLine("Líquido a recibir para Carlos {0}", calcularSueldo(2000, 1000));
            Console.WriteLine("Líquido a recibir para Lesli {0}", calcularSueldo(1340, 199));

            Console.WriteLine("El cuadrado de 10 es: ");
            int x2 = cuadrado(10);
            Console.WriteLine(x2);
        
            //Imprimir los pares entre 1 y 10
            for(int i=1; i<=10; i++)
            {
                if (esPar(i) == 1)
                    Console.WriteLine("{0} es par", i);
            }
            Console.WriteLine("Tablas de multiplicar");
            tabla(6);
            Console.WriteLine();
            tabla(5);

            Console.ReadKey();
        }  //fin del main
    
    //funciones: subprocesos - subprogramas - subrutinas
    // dividir el código en módulos
    // reutilizar el código
    // tipo: devuelven valores - no devuelve valores
    static void saludos(String nombre) //parámetro - argumento
    {
        Console.WriteLine("Función que no devuelve valores...");
        Console.WriteLine("HOLA {0} " , nombre);
    }

        //función que devuelve valor
        //la función  devuelve un tipo de dato
        static int calcularSueldo(int ingreso, int egreso)
        {
            return (ingreso-egreso);
        }

        //en clases
        //1)Crear la función que imprima la siguiente figura
        //    *
        //   ***
        //  *****
        // *******

        //2)Crear la función que recibe un parámetro entero y
        //devuelve el cuadrado de este entero
        static int cuadrado(int n)
        {
            return (n * n);
        } 

        //Tarea en casa:
        //======
        //1)prepare un ejercicio, que dentro de una función use una condicional
        //la función puede o no devolver valores
        static int esPar(int n)
        {
            if (n % 2 == 0)
                return 1;
            else
                return -1;

           // return (n % 2==0 ? 1 : -1);
        }

        //2)prepara un ejercio, que dentro de una función utilice 
        //un bucle (puede ser for o while)
        //la función puede o no devolver valores
        static void tabla ( int n)
        {
            for(int i=1; i<=12; i++)
            {
                Console.WriteLine("{0}  x   {1}  =  {2}", n, i, (n * i));
            }
        }

        //Ingrese a github y comparta su código con kleberposligua@hotmail.com
        //https://github.com/kleberposligua

    }
}
