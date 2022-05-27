using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    class Program
    {
        static void Main(string[] args)
        {
            byte i, numAlumnos;
            double calificacion, sumaCalif = 0, promedio;
            Console.Write("Ingresa el numero de alumnos: ");
            numAlumnos = Convert.ToByte(Console.ReadLine());

            for (i = 1; i <= numAlumnos; i++)
            {
                Console.Write("Ingresa la calificacion: ");
                calificacion = Convert.ToDouble(Console.ReadLine());
                sumaCalif += calificacion;
            }
            promedio = sumaCalif / numAlumnos;
            Console.WriteLine("El promedio es: {0}", promedio);
            Console.ReadKey();
        }
    }
}
