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
        {   //Olvasd be a fájlt egy "iskola" nevű Listába ( Turzó Erik)

            //Írasd ki a nevüket azoknak a diákoknak, akik  a 2005-ös évfolyam 'd' osztályába jártak! (Ádám)

            //Hányan jártak a 2004-es évfolyamra? (Máté)

            //Írasd ki az adatait azoknak akik 2007-ben íratkoztak a suliba és a keresztnevük 'I' betűvel kezdődik!(Milan)
            
            //Volt-e "Adam" nevű tanuló a 2006-os évfolyamon? Ha nem, ahhor írasd ki, hogy "Nem volt ilyen nevű diák" egyébként tabulátorokkal elválasztva írasd ki az adatait! (Ha több ilyen volt akkor mindet!) (Marcell)
            

            //Mely osztályokba járnak "Nagy" vezetéknevű tanulók? (Dominik)

            //Melyik osztályba íratkozott be először "László" keresztnevű tanuló. (Ha több László is járt abba az évfolyamba, mindeegyik nevét írasd ki!) (Laci)

            //Írasd ki a 2006 évfolyam 'a' osztályának névsorát a nevsor2006a.txt állományba! (Leventeee)

            //Main?
           
        }
    }
}
