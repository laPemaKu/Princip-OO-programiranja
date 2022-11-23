using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiOOProgramiranja
{
    class GeometrijskoTijelo
    {
        double volumen, oplosje;
        public static int brojacTijela=0;
        public GeometrijskoTijelo()
        {

        }
        public GeometrijskoTijelo(double volumen, double oplosje)
        {
            this.volumen = volumen;
            this.oplosje = oplosje;
            brojacTijela++;
        }
        public override string ToString()
        {
            return "Tijelo je volumena od " + this.volumen + " i oplošja " + this.oplosje;
        }
        
    }
    class Kugla : GeometrijskoTijelo
    {
        public Kugla(double volumen, double oplosje) : base(volumen, oplosje)
        {
        
        }
    }
    class Kvadar : GeometrijskoTijelo
    {
        public Kvadar(double volumen, double oplosje) : base(volumen, oplosje)
        {

        }
    }
    class Kocka : Kvadar
    {
        public Kocka(double volumen, double oplosje) : base(volumen, oplosje)
        {

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Kugla x = new Kugla(4, 5);
            Kvadar y = new Kvadar(5, 6);
            Kocka z = new Kocka(7, 8);

            Console.WriteLine(x.ToString());
            Console.WriteLine(y.ToString());
            Console.WriteLine(z.ToString());

            Console.WriteLine(GeometrijskoTijelo.brojacTijela);

            Console.ReadKey();
        }
    }
}
