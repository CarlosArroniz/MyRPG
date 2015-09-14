using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyRPG
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heros = { "1.- Elf", "2.- Wizard", "3.- Warrior", "4.- Exit" };
            bool salirMenu = false;
            Elfo elf = new Elfo();
            Mago wiz = new Mago();
            Guerrero war = new Guerrero();

            while (!salirMenu)
            {
                Console.WriteLine("Select your hero!!");
                Console.WriteLine();
                for (int i = 0; i < heros.Length; i++)
                {
                    Console.WriteLine(heros[i]);
                }
                Console.WriteLine();
                int opc = Int32.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        elf.ElegirArma();
                        break;
                    case 2:
                        wiz.ElegirArma();
                        break;
                    case 3:
                        war.ElegirArma();
                        break;
                    case 4:
                        salirMenu = true;
                        break;
                    default:
                        Console.WriteLine("Choose a HERO!!");
                        break;
               }
            }
        }
    }
}