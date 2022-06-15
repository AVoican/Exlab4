using System;
using System.Linq;

namespace Exlab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            //Ex7();
        }

        //Scrieti un program care va afisa pozitia unui substring intr-un string, ambele siruri fiind citite de la tastatura.
        static void Ex1()
        {
            Console.WriteLine("Introduceti un string");
            string string1 = Console.ReadLine();

            Console.WriteLine("Introduceti un substring");
            string string2 = Console.ReadLine();

            if(string.IsNullOrEmpty(string1) || string.IsNullOrEmpty(string1))
            {
                Console.WriteLine("String invalid");
            }
            else
            {
                if (string1.Contains(string2))
                {
                    string message = $"*{string2}* se afla e pozitia {string1.IndexOf(string2)} in stringul *{string1}*.";
                    Console.WriteLine(message);
                }
                else
                {
                    Console.WriteLine("Substringul dat nu se regaseste in string.");
                }
            }
        }

        //Scrieti un program care sa verifice daca un sir de caractere citit de la tastatura este sau nu palindrom
        static void Ex2()
        {
            Console.WriteLine("Introduceti un sir de caractere");
            string sir = Console.ReadLine();

            string sirIntors="";

            for(int i = sir.Length-1; i >= 0; i--)
            {
                sirIntors += sir[i];
            }

            if (sir == sirIntors)
            {
                string message = $"Sirul de caractere *{sir}* este palindrom";
                Console.WriteLine(message);
            }
            else
            {
                string message = $"Sirul de caractere *{sir}* NU este palindrom";
                Console.WriteLine(message);
            }
        }

        //Scrieti un program care va numara toate aparitiile unui caracter intr-un sir de caractere.
        //Atat caracterul cautat cat s sirul de caractare vor fi citite de la tastatura.
        static void Ex3()
        {
            Console.WriteLine("Introduceti un sir de caractere");
            string sir = Console.ReadLine();

            Console.WriteLine("Introduceti caracterul pe care il vom cauta in sir");
            char x = Console.ReadLine()[0];

            int counter = 0;

            if (string.IsNullOrEmpty(sir))
            {
                Console.WriteLine("String invalid");
            }
            else
            {
                foreach (char aux in sir)
                {
                    if (aux == x)
                    {
                        counter++;
                    }
                }

                string message = $"Caracterul *{x}* se regaseste de {counter} ori in sirul de caractere *{sir}*";
                Console.WriteLine(message);
            }
        }

        //scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr-un string citit de la tastatura, ignorand case
        static void Ex4()
        {
            Console.WriteLine("Introduceti un sir de caractere");
            string sir = Console.ReadLine();

           /* char res = sir.ToCharArray().GroupBy(c => c).Select(c => new { c.Key, count = c.Count() }).OrderByDescending(c=>c.count)
                .FirstOrDefault().Key;
            Console.WriteLine(res);  */

            string lowerSir = sir.ToLower();

            int counter = 0;
            int counterFinal = 0;

            char finalChar=sir[0];

            char currentChar = sir[0];

            for (int i = 0; i < lowerSir.Length; i++)
            {
                currentChar = lowerSir[i];

                foreach(char x in lowerSir)
                {
                    if (x == currentChar)
                    {
                        counter++;
                    }
                }

                if (counter > counterFinal)
                {
                    counterFinal = counter;
                    finalChar = currentChar;
                }

                counter = 0;
            }

            string solution = $"*{finalChar}* apare de {counterFinal} ori.";
            Console.WriteLine(solution);
        }


        static void Ex5()
        {
            Console.WriteLine("Introduceti un sir de caractere");
            string sir = Console.ReadLine();

            string upperSir = sir.ToUpper();
            string lowerSir = sir.ToLower();


            char currentChar = upperSir[0];

            string sirFinal = "";
            
            sirFinal +=currentChar ;

            for(int i = 1; i < upperSir.Length; i++)
            {
                if(char.IsWhiteSpace(currentChar))
                {
                    sirFinal += upperSir[i];
                }
                else
                {
                    sirFinal += lowerSir[i];
                }

                currentChar = sir[i];
            }

            Console.WriteLine(sirFinal);

        }

        //Scrieti un program care va numara cate vocale apar intr-un sir de caractere citit de la tastatura
        static void Ex6()
        {
            //AM INCERCAT FOLOSIREA FUNCTIEI "Contains" dar nu mergea

            Console.WriteLine("Introduceti un sir de caractere");
            string sir = Console.ReadLine();

            int counter = 0;

            string toateVocalele = "aeiouAEIOU";

            for (int i = 0; i < sir.Length; i++)
            { 
                foreach (char aux in toateVocalele)
                {
                    if (sir[i]==aux)
                    {
                     counter++;
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("Sirul introdus nu contine vocale.");
            }
            else
            {
                string solution = $"In sirul *{sir}* apar {counter} vocale.";
                Console.WriteLine(solution);
            }
        }


        static void Ex7()
        {
            Console.WriteLine("Introduceti primul sir de caractere");
            string sir1 = Console.ReadLine();

            Console.WriteLine("Introduceti alt sir de caractere");
            string sir2 = Console.ReadLine();

            if (sir1.Length != sir2.Length)
            {
                Console.WriteLine("cele doua siruri nu sunt anagrame.");
            }
            else
            {
                if (sir1.ToLower().Equals(sir2.ToLower()))
                {
                    string solution = $"Sirurile *{sir1}* si *{sir2}* sunt anagrame";
                    Console.WriteLine(solution);
                }
                else
                {
                    var array1 = sir1.ToCharArray();
                    var array2 = sir2.ToCharArray();

                    Array.Sort(array1);
                    Array.Sort(array2);

                    if (array1 == array2)
                    {
                        string solution = $"Sirurile *{sir1}* si *{sir2}* sunt anagrame";
                        Console.WriteLine(solution);
                    }
                    else
                    {
                        string solution = $"Sirurile *{sir1}* si *{sir2}* NU sunt anagrame";
                        Console.WriteLine(solution);
                    }
                }
            }
        }
    }
}
