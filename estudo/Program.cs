using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estudo
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            Console.Write("Digite seu E-mail: ");
            string email = Console.ReadLine();
            Console.Write("Confirme seu E-mail:");
            string emailconf = Console.ReadLine();

            if (emailconf.Equals(email))
            {
                Console.WriteLine("Email Confirmado!");
            }

            else
            {
                Console.WriteLine("Email incorreto.");
            }
                                                   
            Console.ReadLine();
        }
    }
}
