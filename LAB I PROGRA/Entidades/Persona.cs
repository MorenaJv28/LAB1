using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio1.Entidades
{
    public class Persona1
    {

        public void calcularIMC1(double peso1, double altura1)
        {
            double Imc1 = peso1 / Math.Pow(altura1, 2);
            
            if(Imc1 >= 25)
            {
                Console.WriteLine("Tienes un IMC de " + Imc1 + "usted tienes sobrepeso");
            }
            else 
            {
                Console.WriteLine("Tienes un IMC de " + Imc1 + " usted tiene un peso normal");
            }
            
        }

        public void EsMayorDeEdad(int Edad1, string Nombre1, string Sexo1)
        {
            Console.WriteLine("n" + Nombre1 + "\n" + "Sexo:" +Sexo1 + "\n");
            if(Edad1 >= 18 ) 
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }
        }

    }
}
