using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkockoKonzolna
{
    class Program
    {
        static void Main(string[] args)
        {
            int brPoz0 = 0;
            int brPoz1 = 0;
            int brPoz2 = 0;
            int brPoz3 = 0;



            Znakovi[] trazeniNiz = new Znakovi[4];

            Random rand = new Random();

            for (int i = 0; i < 4; i++)
            {
                trazeniNiz[i] = VratiZnak(rand.Next(1, 7));
            }


            Console.WriteLine("/*SKLONITI*/");

            for (int i = 0; i < 4; i++)

            {

                Console.WriteLine(trazeniNiz[i]);


            }


            Console.WriteLine("****DOBRO DOŠLI U IGRU SKOČKO****");
            Console.WriteLine("Imate 6 pokušaja da pogodite tačnu kombinaciju");
            Console.WriteLine("pik = 1, tref = 2,herc = 3,karo = 4,zvezda = 5,skocko = 6");
            Console.WriteLine("Unesite npr. 1133 za pik pik herc herc");
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Pokusaj broj 1: ");
            string prvi = Console.ReadLine();

            char[] prviniz = prvi.ToCharArray();

            Znakovi[] prvii = new Znakovi[4];



            prvii[0] = VratiZnak(Convert.ToInt32(prviniz[0].ToString()));
            prvii[1] = VratiZnak(Convert.ToInt32(prviniz[1].ToString()));
            prvii[2] = VratiZnak(Convert.ToInt32(prviniz[2].ToString()));
            prvii[3] = VratiZnak(Convert.ToInt32(prviniz[3].ToString()));




            Console.WriteLine("{0} {1} {2} {3}", prvii[0], prvii[1], prvii[2], prvii[3]);




            if (trazeniNiz[0] == prvii[0]) brPoz0++;
            if (trazeniNiz[1] == prvii[1]) brPoz1++;
            if (trazeniNiz[2] == prvii[2]) brPoz2++;
            if (trazeniNiz[3] == prvii[3]) brPoz3++;


            if (brPoz0 == 1 && brPoz1 == 1 && brPoz2 == 1 && brPoz3 == 1)
            {
                Console.WriteLine("Pobedili ste. Tačna kombinacija!");
                string s = Console.ReadLine();
                if (s != null) return;
            }

            int naMestu = brPoz0 + brPoz1 + brPoz2 + brPoz3;


            Console.WriteLine("Na tačnom mestu je: " + naMestu);

            //   var presek = trazeniNiz.Intersect(prvii);

            var presek1 = Intersect2(trazeniNiz, prvii);

            int pogodjeni = presek1.Count();

            Console.WriteLine("Pogodjenih je : " + pogodjeni);

            brPoz0 = 0;
            brPoz1 = 0;
            brPoz2 = 0;
            brPoz3 = 0;



            pogodjeni = 0;
            naMestu = 0;


            /************************************************************************************************/
            Console.WriteLine("******************************");
            Console.WriteLine("Pokusaj broj 2: ");
            string drugi = Console.ReadLine();

            char[] druginiz = drugi.ToCharArray();

            Znakovi[] drugii = new Znakovi[4];



            drugii[0] = VratiZnak(Convert.ToInt32(druginiz[0].ToString()));
            drugii[1] = VratiZnak(Convert.ToInt32(druginiz[1].ToString()));
            drugii[2] = VratiZnak(Convert.ToInt32(druginiz[2].ToString()));
            drugii[3] = VratiZnak(Convert.ToInt32(druginiz[3].ToString()));




            Console.WriteLine("{0} {1} {2} {3}", drugii[0], drugii[1], drugii[2], drugii[3]);




            if (trazeniNiz[0] == drugii[0]) brPoz0++;
            if (trazeniNiz[1] == drugii[1]) brPoz1++;
            if (trazeniNiz[2] == drugii[2]) brPoz2++;
            if (trazeniNiz[3] == drugii[3]) brPoz3++;


            if (brPoz0 == 1 && brPoz1 == 1 && brPoz2 == 1 && brPoz3 == 1)
            {
                Console.WriteLine("Pobedili ste. Tačna kombinacija!");

                string s = Console.ReadLine();
                if (s != null) return;
            }

            naMestu = brPoz0 + brPoz1 + brPoz2 + brPoz3;


            Console.WriteLine("Na tačnom mestu je: " + naMestu);


            var presek2 = Intersect2(trazeniNiz, drugii);


            pogodjeni = presek2.Count();

            Console.WriteLine("Pogodjenih je : " + pogodjeni);

            brPoz0 = 0;
            brPoz1 = 0;
            brPoz2 = 0;
            brPoz3 = 0;


            pogodjeni = 0;
            naMestu = 0;

            /************************************************************************************/
            Console.WriteLine("******************************");
            Console.WriteLine("Pokusaj broj 3: ");
            string treci = Console.ReadLine();

            char[] treciiniz = treci.ToCharArray();

            Znakovi[] trecii = new Znakovi[4];



            trecii[0] = VratiZnak(Convert.ToInt32(treciiniz[0].ToString()));
            trecii[1] = VratiZnak(Convert.ToInt32(treciiniz[1].ToString()));
            trecii[2] = VratiZnak(Convert.ToInt32(treciiniz[2].ToString()));
            trecii[3] = VratiZnak(Convert.ToInt32(treciiniz[3].ToString()));




            Console.WriteLine("{0} {1} {2} {3}", trecii[0], trecii[1], trecii[2], trecii[3]);




            if (trazeniNiz[0] == trecii[0]) brPoz0++;
            if (trazeniNiz[1] == trecii[1]) brPoz1++;
            if (trazeniNiz[2] == trecii[2]) brPoz2++;
            if (trazeniNiz[3] == trecii[3]) brPoz3++;


            if (brPoz0 == 1 && brPoz1 == 1 && brPoz2 == 1 && brPoz3 == 1)
            {
                Console.WriteLine("Pobedili ste. Tačna kombinacija!");
                string s = Console.ReadLine();
                if (s != null) return;
            }

            naMestu = brPoz0 + brPoz1 + brPoz2 + brPoz3;


            Console.WriteLine("Na tačnom mestu je: " + naMestu);


            var presek3 = Intersect2(trazeniNiz, trecii);


            pogodjeni = presek3.Count();

            Console.WriteLine("Pogodjenih je : " + pogodjeni);

            brPoz0 = 0;
            brPoz1 = 0;
            brPoz2 = 0;
            brPoz3 = 0;



            pogodjeni = 0;
            naMestu = 0;
            /***********************************************************************************************************/
            Console.WriteLine("******************************");
            Console.WriteLine("Pokusaj broj 4: ");
            string cetvrti = Console.ReadLine();

            char[] cetvrtiniz = cetvrti.ToCharArray();

            Znakovi[] cetvrtii = new Znakovi[4];



            cetvrtii[0] = VratiZnak(Convert.ToInt32(cetvrtiniz[0].ToString()));
            cetvrtii[1] = VratiZnak(Convert.ToInt32(cetvrtiniz[1].ToString()));
            cetvrtii[2] = VratiZnak(Convert.ToInt32(cetvrtiniz[2].ToString()));
            cetvrtii[3] = VratiZnak(Convert.ToInt32(cetvrtiniz[3].ToString()));




            Console.WriteLine("{0} {1} {2} {3}", cetvrtii[0], cetvrtii[1], cetvrtii[2], cetvrtii[3]);




            if (trazeniNiz[0] == cetvrtii[0]) brPoz0++;
            if (trazeniNiz[1] == cetvrtii[1]) brPoz1++;
            if (trazeniNiz[2] == cetvrtii[2]) brPoz2++;
            if (trazeniNiz[3] == cetvrtii[3]) brPoz3++;


            if (brPoz0 == 1 && brPoz1 == 1 && brPoz2 == 1 && brPoz3 == 1)
            {
                Console.WriteLine("Pobedili ste. Tačna kombinacija!");
                string s = Console.ReadLine();
                if (s != null) return;
            }

            naMestu = brPoz0 + brPoz1 + brPoz2 + brPoz3;


            Console.WriteLine("Na tačnom mestu je: " + naMestu);


            var presek4 = Intersect2(trazeniNiz, cetvrtii);


            pogodjeni = presek4.Count();

            Console.WriteLine("Pogodjenih je : " + pogodjeni);

            brPoz0 = 0;
            brPoz1 = 0;
            brPoz2 = 0;
            brPoz3 = 0;



            pogodjeni = 0;
            naMestu = 0;

            /**********************************************************************************************/
            Console.WriteLine("******************************");
            Console.WriteLine("Pokusaj broj 5: ");
            string peti = Console.ReadLine();

            char[] petiniz = peti.ToCharArray();

            Znakovi[] petii = new Znakovi[4];



            petii[0] = VratiZnak(Convert.ToInt32(petiniz[0].ToString()));
            petii[1] = VratiZnak(Convert.ToInt32(petiniz[1].ToString()));
            petii[2] = VratiZnak(Convert.ToInt32(petiniz[2].ToString()));
            petii[3] = VratiZnak(Convert.ToInt32(petiniz[3].ToString()));




            Console.WriteLine("{0} {1} {2} {3}", petii[0], petii[1], petii[2], petii[3]);




            if (trazeniNiz[0] == petii[0]) brPoz0++;
            if (trazeniNiz[1] == petii[1]) brPoz1++;
            if (trazeniNiz[2] == petii[2]) brPoz2++;
            if (trazeniNiz[3] == petii[3]) brPoz3++;


            if (brPoz0 == 1 && brPoz1 == 1 && brPoz2 == 1 && brPoz3 == 1)
            {
                Console.WriteLine("Pobedili ste. Tačna kombinacija!");
                string s = Console.ReadLine();
                if (s != null) return;

            }

            naMestu = brPoz0 + brPoz1 + brPoz2 + brPoz3;


            Console.WriteLine("Na tačnom mestu je: " + naMestu);

            var presek5 = Intersect2(trazeniNiz, petii);



            pogodjeni = presek5.Count();



            Console.WriteLine("Pogodjenih je : " + pogodjeni);

            brPoz0 = 0;
            brPoz1 = 0;
            brPoz2 = 0;
            brPoz3 = 0;



            pogodjeni = 0;
            naMestu = 0;



            /****************************************************************************************/
            Console.WriteLine("******************************");
            Console.WriteLine("Pokusaj broj 6: ");
            string sesti = Console.ReadLine();

            char[] sestiniz = sesti.ToCharArray();

            Znakovi[] sestii = new Znakovi[4];



            sestii[0] = VratiZnak(Convert.ToInt32(sestiniz[0].ToString()));
            sestii[1] = VratiZnak(Convert.ToInt32(sestiniz[1].ToString()));
            sestii[2] = VratiZnak(Convert.ToInt32(sestiniz[2].ToString()));
            sestii[3] = VratiZnak(Convert.ToInt32(sestiniz[3].ToString()));




            Console.WriteLine("{0} {1} {2} {3}", sestii[0], sestii[1], sestii[2], sestii[3]);



            if (trazeniNiz[0] == sestii[0]) brPoz0++;
            if (trazeniNiz[1] == sestii[1]) brPoz1++;
            if (trazeniNiz[2] == sestii[2]) brPoz2++;
            if (trazeniNiz[3] == sestii[3]) brPoz3++;


            if (brPoz0 == 1 && brPoz1 == 1 && brPoz2 == 1 && brPoz3 == 1)
            {
                Console.WriteLine("Pobedili ste. Tačna kombinacija!");
                string s = Console.ReadLine();
                if (s != null) return;
            }

            naMestu = brPoz0 + brPoz1 + brPoz2 + brPoz3;


            Console.WriteLine("Na tačnom mestu je: " + naMestu);


            var presek6 = Intersect2(trazeniNiz, sestii);



            pogodjeni = presek6.Count();

            Console.WriteLine("Pogodjenih je : " + pogodjeni);

            Console.WriteLine("******************************");
            Console.WriteLine("KRAJ IGRE. IZGUBILI STE!");


            Console.ReadLine();











        }



        public enum Znakovi
        {
            pik = 1,
            tref = 2,
            herc = 3,
            karo = 4,
            zvezda = 5,
            skocko = 6
        }







        public static Znakovi VratiZnak(int i)
        {
            if (i == 1) return Znakovi.pik;
            if (i == 2) return Znakovi.tref;
            if (i == 3) return Znakovi.herc;
            if (i == 4) return Znakovi.karo;
            if (i == 5) return Znakovi.zvezda;
            if (i == 6) return Znakovi.skocko;

            return Znakovi.karo;



        }

        public static IEnumerable<T> Intersect2<T>(IEnumerable<T> source, IEnumerable<T> target)
        {
            List<T> list = target.ToList();
            foreach (T item in source)
            {
                if (list.Contains(item))
                {
                    list.Remove(item);
                    yield return item;
                }
            }
        }
    }
}
