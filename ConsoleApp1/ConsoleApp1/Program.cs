using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Diak
    {
        private int evjarat;
        private char csoport;
        private string nev;

        public Diak(int evjarat, char csoport, string nev)
        {
            this.evjarat = evjarat;
            this.csoport = csoport;
            this.nev = nev;
        }
        int Evjarat { get => evjarat; set => evjarat = value; }        
        public char Csoport { get => csoport; set => csoport = value; }
        public string Nev { get => nev; set => nev = value; }

    }

    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
