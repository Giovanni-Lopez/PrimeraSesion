using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraSesion
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1.Escribir un programa que pregunte al usuario su nombre, apellido, DUI, edad, teléfono y dirección, y que lo
            muestre en pantalla. 
            string nombre = "";
            string apellido = "";
            string dui = "";
            int edad = 0;
            int telefono = 0;
            string direccion = "";

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ingrese su apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ingrese su numero de DUI: ");
            dui = Console.ReadLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ingrese su edad: ");
            edad =  int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ingrese numero de telefono: ");
            telefono = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ingrese su Direccion: ");
            direccion = Console.ReadLine();
            Console.WriteLine("------------------------------------ \n \n");

            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Su apellido es: " + apellido);
            Console.WriteLine("Su numero de DUI: " + dui);
            Console.WriteLine("Su edad es: " + edad);
            Console.WriteLine("Su numero de telefono es: " + telefono);
            Console.WriteLine("Su direccion es: " + direccion);
            Console.WriteLine("------------------------------------");
            Console.WriteLine("------------------------------------");

            Console.ReadKey();

    */
            /*2. Calcular el perímetro y área de un rectángulo dada su base y su altura.
            int b, a, area, perimetro;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ingrese base del rectangulo: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ingrese la altura del rectangulo: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------ \n \n");

            area = b * a;
            perimetro = 2 * (b + a);

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Area del rectangulo: " + area);
            Console.WriteLine("Perimetro del rectangulo: " + perimetro);
            Console.WriteLine("------------------------------------");

            Console.ReadKey();

    */

            /*3. Dados los catetos de un triángulo rectángulo, calcular su hipotenusa.

            double a, b, r1, r2, suma, raizCuadrada;

            Console.WriteLine("Ingrese cateto a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese cateto b:");
            b = double.Parse(Console.ReadLine());

            r1 = Math.Pow( a, 2);
            r2 = Math.Pow(b, 2);
            suma = r1 + r2;
            raizCuadrada = Math.Sqrt(suma);

            Console.WriteLine("Valor de la Hipotenusa: " + raizCuadrada);

            Console.ReadKey();
            */

            /*4. Dados dos números, mostrar la suma, resta, división y multiplicación de ambos

            int a, b, suma, resta, multiplicacion;
            double divicion;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ingrese valor 1: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ingrese valor 2: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------ \n \n");
            suma = a + b;
            resta = a - b;

            if (b != 0){
                divicion = a / b;
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Resultado de la division: " + divicion);
            }
            else {
                Console.WriteLine("No es posible realizar la division");
            }
                        
            multiplicacion = a * b;

            Console.WriteLine("Resultado de la suma: " + suma);
            Console.WriteLine("Resultado de la resta: " + resta);            
            Console.WriteLine("Resultado de la multiplicacion: " + multiplicacion);
            Console.WriteLine("------------------------------------");
            Console.ReadKey();

            */

            /*5. Escribir un programa que convierta un valor dado en grados Fahrenheit a grados Celsius. Recordar que la
                 fórmula para la conversión es: C = (F-32) *5/9

            double f, c;

            Console.WriteLine("Ingrese grados Fahrenheit: ");
            f = double.Parse(Console.ReadLine());

            c = ((f - 32) * 5 / 9);

            Console.WriteLine("Grados celsius: " + c);

            Console.ReadKey();*/

            /*6. Calcular la media de tres números pedidos por teclado.         

            int a, b, c;
            double r;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ingrese su primer valor: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ingrese su segundo valor: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ingrese su tercer valor: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------ \n \n");
            r = (a + b + c) / 3;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Su media es: " + r);
            Console.WriteLine("------------------------------------");

            Console.ReadKey();

    */

            /*7. Un vendedor recibe un sueldo base,,,, más un 10% extra por comisión de sus ventas,,, el vendedor desea saber
            cuánto dinero obtendrá por concepto de ,,,comisiones por las tres ventas que realiza en el mes,,,, y el total que
            recibirá en el mes tomando en cuenta su ,,sueldo base y comisiones,,.

            double com1, com2, com3, sumComision, sueldoBase, salFinal;
            int v1, v2, v3;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ingrese Sueldo Base: ");
            sueldoBase = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Valor de venta 1");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Valor de venta 2");
            v2 = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Valor de venta 3");
            v3 = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------ \n \n");
            com1 = (v1 * 0.10);
            com2 = (v2 * 0.10);
            com3 = (v3 * 0.10);

            sumComision = com1 + com2 + com3;
            salFinal = sumComision + sueldoBase;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Comision: " + sumComision);
            Console.WriteLine("Salario base mas comision: " + salFinal);
            Console.WriteLine("------------------------------------");

            Console.ReadKey();
            */

            /*8.Una tienda ofrece un descuento del 15 % sobre el total de la compra y un cliente desea 
                saber cuanto deberá pagar finalmente por su compra.

            double a, b;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Ingrese total de compra");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------------");

            b = a - (a * 0.15);
            Console.WriteLine("\n");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Su total a pagar es: " + b + ", Se aplico el 15% descuento");
            Console.WriteLine("------------------------------------");

            Console.ReadKey();*/

            /*
             9. Un alumno desea saber cuál será su calificación final en la materia de lógica de programación.
              
                Dicha calificación se compone de los siguientes porcentajes:
                
                55% del promedio de sus tres calificaciones parciales.
                30% de la calificación del examen final.
                15% de la calificación de un trabajo final.
             
             */
            double n1, n2, n3, a, b, exFinal, trabFinal, NotaFinal;

            Console.WriteLine("Ingrese Nota1");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Nota2");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Nota3");
            n3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese Nota Final");
            exFinal = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrse Trabajo Final");
            trabFinal = double.Parse(Console.ReadLine());

            a = exFinal * 0.30;

            b = trabFinal * 0.15;

            NotaFinal  = ((n1 + n2 + n3) / 3)* 0.55 + a + b;            

            Console.WriteLine("Su Nota Final es: " + NotaFinal);
            



            Console.ReadKey();

        }
    }
}
