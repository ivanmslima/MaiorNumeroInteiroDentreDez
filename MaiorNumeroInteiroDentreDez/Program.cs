using System;

namespace curso
{
    class Progam
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um número: ");
            int numero = int.Parse(Console.ReadLine());
            int maior = numero;
            int cont = 1;

            while(cont < 10)
            {
                Console.Write("Informe um número: ");
                numero = int.Parse(Console.ReadLine());

                if(numero > maior)
                {
                    maior = numero;
                }
                cont++;
            }
            Console.WriteLine("O maior numero: " + maior);


        }
    }
}