using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyRPG
{
    public class Mago : Motor
    {
        public Mago()
        {
            id = 0;
            arma1 = 0;
            arma2 = 0;
            personaje = "Wizard";
            seleccion = false;
            armas[0] = "Wand";
            armas[1] = "Spell";
            armas[2] = "Magic Spear";
            armas[3] = "Lighting Sword";
        }
        public int id { get; set; }
        public string personaje { get; set; }
        public bool seleccion { get; set; }
        public string[] armas = new string[4];
        public static bool salir = false;
        int wpn1, wpn2;
        public int arma1
        {
            get { return wpn1; }
            set { wpn1 = value; }
        }
        public int arma2
        {
            get { return wpn2; }
            set { wpn2 = value; }
        }
        public void ElegirArma()
        {
            Console.WriteLine();
            Console.WriteLine("It's danger to go alone, take this: ");
            Console.WriteLine();
            Console.WriteLine("Your " + personaje + "'s weapons are: ");
            Console.WriteLine();
            for (int i = 0; i < armas.Length; i++)
            {
                Console.WriteLine(armas[i]);
            }
            Console.WriteLine("Weapon 1: ");
            arma1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Weapon 2: ");
            arma2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            this.seleccion = true;
            string ar1 = armas[arma1];
            string ar2 = armas[arma2];
            Atacar(ar1, ar2);
        }
        public void Atacar(string arm1, string arm2)
        {
            Console.WriteLine("ATTACK!!");
            while (!salir)
            {
                Console.WriteLine("Choose your attack!:");
                Console.WriteLine("1.- Normal attack whit " + arm1);
                Console.WriteLine("2.- Special attack whit " + arm2 + "!!");
                Console.WriteLine("3.- Exit");
                Console.WriteLine();
                int opc = Int32.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("The " + personaje + "has killed the enemy whit " + arm1);
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("The " + personaje + "has killed the enemy whit " + arm2);
                        Console.WriteLine();
                        break;
                    case 3:
                        salir = true;
                        break;
                }
            }
        }
    }
}