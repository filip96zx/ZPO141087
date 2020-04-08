using System;

namespace cw4
{
    class Program
    {
        public class Osoba
        {
            public string imie, nazwisko;

            public Osoba()
            {
                imie = "jan";
                nazwisko = "kowalski";
            }

            public Osoba(string imie, string nazwisko)
            {
                this.imie = imie;
                this.nazwisko = nazwisko;
            }

            public virtual void WypiszInfo()
            {
                Console.WriteLine(imie);
                Console.WriteLine(nazwisko);
            }
        }

        public class Student : Osoba
        {
            public string numerAlbumu, numerGrupy;
            public int rokStudiow;

            public Student()
            {
                imie = "jan";
                nazwisko = "kowalski";
                numerAlbumu = "1231";
                numerGrupy = "1";
                rokStudiow = 2;

            }

            public Student(string imie, string nazwisko, string numerAlbumu, string numerGrupy, int rokStudiow)
            {
                this.imie = imie;
                this.nazwisko = nazwisko;
                this.numerAlbumu = numerAlbumu;
                this.numerGrupy = numerGrupy;
                this.rokStudiow = rokStudiow;
            }

            public override void WypiszInfo()
            {
                base.WypiszInfo();
                Console.WriteLine(numerAlbumu);
                Console.WriteLine(numerGrupy);
                Console.WriteLine(rokStudiow);

            }

            public override string ToString()
            {
                return imie + " " + nazwisko + " " + numerAlbumu + " " + numerGrupy + " " + rokStudiow;
            }

        }

        static void Main(string[] args)
        {
            Osoba student1 = new Student();

            student1.WypiszInfo();
            Console.WriteLine(student1.ToString());
            Console.ReadLine();

        }
    }
}
