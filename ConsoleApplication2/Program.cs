using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//pojecie klasy i obiektu
//solucja to ...
//pola z malej litery, metody i klasy z dozej
//draw.io
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car();
            ////typ nazwa= new typ();
            //car1.marka = "asdfas";
            //car1.UstawRokProdukcji(1993);
            //Console.WriteLine(car1);

            ////car1 = car2;

            //Car car2 = new Car();
            //car2.marka = "sdfasdf";
            //car2.UstawRokProdukcji(1111);
            //Console.WriteLine(car1.Info());
            //car1.sredniespalanie = 5.2;
            //Console.WriteLine(car1.obliczkosztspalania(5.324, 6.231));

            //Osoba dyrektor = new Osoba();
            //dyrektor.imie = "Adam";
            //dyrektor.nazwisko = "Noewadam";
            //dyrektor.RokUrodzenia = 1232;
            //Console.WriteLine(dyrektor.imie + " " + dyrektor.nazwisko);


            //Console.WriteLine(dyrektor.imie);

            Osoba pacjent = new Osoba();
            pacjent.imie = "Mateusz";
            pacjent.nazwisko = "Kowalski";
            pacjent.wzrost = 167;
            pacjent.waga = 70;

            Console.WriteLine(pacjent.imie + " " + pacjent.nazwisko + " " + pacjent.BMI());
            pacjent.info2();

            Console.ReadKey();
        }
    }
}

