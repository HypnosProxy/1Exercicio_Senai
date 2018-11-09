using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Volume
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Exercicio 5 Senai pg 53
             Escrever um algoritmo e um programa para calcular e apresentar
             o valor do volume 
             de uma lata de óleo, utilizando a fórmula: 
             VOLUME = PI * r2 * ALTURA. Onde “r” é igual ao raio da circunferência
             da lata.
             */

            double volume;
            int raio, altura;
            Console.Write("Digite o Raio da lata de óleo: ");
            raio = int.Parse(Console.ReadLine());
            Console.Write("Digite a altura: ");
            altura = int.Parse(Console.ReadLine());
            volume = 3.14159 * Math.Pow(raio,2) * altura;
            Console.WriteLine();
            //Console.WriteLine("O volume da lata é " + volume + "m³");
            Console.WriteLine(volume.ToString("Volume: ##,##0.00"+"m³"));

            Console.WriteLine();
            Console.Write("Tecla <enter>");
            Console.ReadLine();
        }
    }
}
