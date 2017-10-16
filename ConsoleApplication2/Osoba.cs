using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Osoba
    {
        internal string imie;
        public string nazwisko;
        public int RokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        public string plec;

        public int ObliczWiek()
        {
            return DateTime.Now.Year - RokUrodzenia; // DateTime.Now.Year
        }

        public string pan_pani()
        {
            if(plec =="M") return "Pan";
            else return "pani";
        }
        public double BMI()
        {
            return waga / (wzrost * wzrost);
        }
        public void info2()
        {
            if (BMI() > 18.5 && BMI() < 24.99) Console.WriteLine("BMI prawidlowe");
            else Console.WriteLine("BMI nie prawidlowe");
        }
    }
}
