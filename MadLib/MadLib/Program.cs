using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a Noun :");
            string NounOne = Console.ReadLine();
            
            Console.Write("Please enter a Prepostion :");
            string Preposition = Console.ReadLine();
            
            Console.Write("Please enter a adjective :");
            string adjectiveOne = Console.ReadLine();
            
            Console.Write("Please enter another Noun :");
            string NounTwo = Console.ReadLine();

            Console.Write("Please enter another adjective :");
            string adjectiveTwo = Console.ReadLine();


            Console.Write($"A {NounOne} was walking {Preposition} the street. A big { adjectiveOne} {NounTwo} was coming the other direction.The moon was {adjectiveTwo}.");


            Console.ReadKey();
        
        }

    }
}
