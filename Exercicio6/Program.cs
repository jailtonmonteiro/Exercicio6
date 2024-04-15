/* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B. */

using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, Square, Triangle, Circle, Trapeze, Rectangle, pi = 3.14159;

            Console.WriteLine("Digite os valores: ");
            string[] value = Console.ReadLine().Split(' ');
            A = double.Parse(value[0]);
            B = double.Parse(value[1]);
            C = double.Parse(value[2]);

            Triangle = (A * C) / 2;
            Circle = (C * C) * pi;
            Trapeze = ((A + B) * C) / 2;
            Square = B * B;
            Rectangle = A * B;

            Console.WriteLine($"Triangulo: {Triangle.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Circulo: {Circle.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Trapezio: {Trapeze.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Quadrado: {Square.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Retangulo: {Rectangle.ToString("F3", CultureInfo.InvariantCulture)}");


        }
    }
}