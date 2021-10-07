//Frederico Guilherme Camilli Proença RA:200925
using System;

namespace POO_Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração do vetor Guest baseado na classe Guest.
            Guest[] vect = new Guest[10];
            //Declaração das variáveis string name e email e da int room, que serão depois preenchidas pelo usuário.
            string name, email;
            int room;

            //Inserção do número de quartos a serem alugados.
            Console.WriteLine("Insert the number of rooms to be rented:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i<=n; i++)
            {
                Console.WriteLine();
                //Inserção do nome, e-mail e número de quarto de cada hóspede cujo quarto será alugado.
                Console.WriteLine($"Guest #{i}");
                Console.WriteLine("Name");
                name = Console.ReadLine();
                Console.WriteLine("Email");
                email = Console.ReadLine();
                Console.WriteLine("Room");
                room = int.Parse(Console.ReadLine());
                //Instanciação do vetor room, que instancia os itens name e email da classe Guest.
                vect[room] = new Guest(name, email);
            }
            Console.WriteLine();
            Console.WriteLine("Rented rooms: ");
            //Exposição dos dados inseridos pelo usuário ao usuário, sendo exibidos de forma ascendente baseado no número dos quartos.
            for (int i = 0; i < 10; i ++)

            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}
