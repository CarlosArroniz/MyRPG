using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyRPG
{
    interface Motor
    {
        int id { get; set; }
        bool seleccion { get; set; }
        void ElegirArma();
        void Atacar(string arma1, string arma2);
    }
}