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
            bool salirmenu = false;
            Elfo elf = new Elfo();
            Guerrero war = new Guerrero();
            Mago wiz = new Mago();

            while (!salirmenu)
            {
                Console.WriteLine("Choose your Hero!!");
                Console.WriteLine("1.- Elf");
                Console.WriteLine("2.- Wizard");
                Console.WriteLine("3.- Warrior");
                Console.WriteLine("0.- Exit");
                int opc = Int32.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 0:
                        salirmenu = true;
                        break;
                    case 1:
                        elf.ElegirArma();
                        break;
                    case 2:
                        wiz.ElegirArma();
                        break;
                    case 3:
                        war.ElegirArma();
                        break;
                }

            }
        }
    }
}