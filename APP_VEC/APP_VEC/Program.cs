using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APP_VEC
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] dato = new char[10];
            char buscar;

            //dato[0] = 'a'; 

            for (int i=0; i<=9; i++)
            {
                Console.WriteLine("i: "+i);
                Console.Write("Ingrese una letra: ");
                dato[i] = char.Parse(Console.ReadLine());
            }
            Console.WriteLine("----------------------" );
            Console.WriteLine(" ADINSON");
    
            /*
             * Crearemos otro ciclo for para accesar 
             * Crearemos otro ciclo for para accesar 
             * a todas las posiciones del vector (0-9)
             * luego mostraremos lo que hay en cada
             * posicion, como indice usaremos la
             * variable del for "x" esta dara cada
             * posicion al vector 
             */ 

            for (int x=0;x<=9 ;x++)
            {
                /*
                 * mostramos en pantalla los datos del
                 * vector
                 */ 
                Console.WriteLine(dato[x]);

            }

            Console.WriteLine("----------------------");

            Console.Write("ingrese caracter a buscar: ");
            buscar = char.Parse(Console.ReadLine());

            for (int z=0; z<=9; z++)
            {
                if(dato[z]==buscar)
                {
                    Console.Write("dato "+buscar+" encontrado");
                }
            }


            Console.ReadKey();
        }
    }
}

//vec
/*0->a
 *1->j
 *2->c 
 *3->b
 * 
 * buscar: j
 * 
 * vec[x]=buscar     x= 0 - 3
 * 
 * vec[0]=buscar
 * vec[1]=buscar ok
 * vec[2]=buscar
 * vec[3]=buscar 
 * 
 */
