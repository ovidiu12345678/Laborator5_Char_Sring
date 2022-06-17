using System;

namespace Laborator5_Char_Sring
{
    class Program
    {
        //static void Main(string[] args) // ex1
        //{
        //    //Ex 1
        //    //Scrieti un program care va afisa pozitia unui substring intr-un string, ambele
        //    //siruri de caractere fiind citite de la tastatura



        //    string input, cautareSir;

        //    Console.WriteLine("Introduce-ti un sir de caractere ! ");

        //    input = Console.ReadLine();

        //    Console.WriteLine("Introduce-ti subsirul dorit ce va fi gasit in sirul ales de dumneavoastra ! ");

        //    cautareSir = Console.ReadLine();

        //    int i = input.IndexOf(cautareSir);

        //    if (i < 0)
        //        Console.WriteLine("Subsirul nu a fost gasit in sirul ales de utilizator ! \n");
        //    else
        //        Console.WriteLine("S-a gasit '{0}' in sirul caractere '{1}' pe pozitia '{2}' ", cautareSir, input, i);
        //}


        static void Main(string[] args)
        {
            //  Ex 2
            //Scrieti un program care sa verifice daca un sir de caractere citit de la
            //tastatura este sau nu palindrom

            Console.WriteLine("Introduce-ti sirul de caractere ! ");

            string text = Console.ReadLine();

            int n = text.Length - 1;

            bool stare = true;

            VerificareSirCaractere(n, stare, text);
           
        }

        static void VerificareSirCaractere(int n, bool stare, string text)
        {
            for (int i = 0; i < text.Length / 2; i++)
            {
                if(text[i] != text[n])
                {
                    break;
                }

                n--;
            }

            if(stare == true)
            {
                Console.WriteLine("Textul este palindrom ! ");
            }
            else
            {
                Console.WriteLine("Textul nu este palindrom ! ");
            }
        }

    }
}
