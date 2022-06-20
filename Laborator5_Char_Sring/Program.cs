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


        //static void Main(string[] args)
        //{
        //    //  Ex 2
        //    //Scrieti un program care sa verifice daca un sir de caractere citit de la
        //    //tastatura este sau nu palindrom

        //    Console.WriteLine("Introduce-ti sirul de caractere ! ");

        //    string text = Console.ReadLine();

        //    int n = text.Length - 1;

        //    bool stare = true;

        //    VerificareSirCaractere(n, stare, text);

        //}

        //static void VerificareSirCaractere(int n, bool stare, string text)
        //{
        //    for (int i = 0; i < text.Length / 2; i++)
        //    {
        //        if (text[i] != text[n])
        //        {
        //            break;
        //        }

        //        n--;
        //    }

        //    if (stare == true)
        //    {
        //        Console.WriteLine("Textul este palindrom ! ");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Textul nu este palindrom ! ");
        //    }
        //}



        //static void Main(string [] args) ex3
        //{
        //    //Ex 3
        //    //Scrieti un program care va numara toate aparitiile unui caracter intr - un sir
        //    //de caractere.Atat caracterul cautat cat si sirul de caracter vor fi citite de la
        //    //tastatura


        //    Console.WriteLine("Introduce-ti un sir de caractere ! ");

        //    string sir = Console.ReadLine();

        //    Console.WriteLine("Introduce-ti un caracter ! ");

        //    char caracter = Console.ReadKey().KeyChar;

        //    Console.WriteLine();

        //    int aparitieCaracter = NumerotareCaractere(sir, caracter);


        //    Console.WriteLine($"Caracterul '{ caracter}' a aparut de {aparitieCaracter} ori in sirul introdus de utilizator ! ", caracter, aparitieCaracter);

        //}


        //static int NumerotareCaractere( string sir, char caracter)
        //{
        //    int numerotare = 0;

        //    foreach(char simbol in sir)
        //    {
        //        if(simbol == caracter)
        //        {
        //            numerotare++;
        //        } 
        //    }

        //    return numerotare;
        //}



        //static void Main(string[] args) ex4
        //{
        //    //    Ex 4
        //    //  Scrieti un program care va afisa caracterul cu numarul cel mai mare de aparitii dintr - un string citit
        //    //  de la tastatura, ignorand caseing-ul literelor.
        //    //  Exemplu:
        //    //  Input: Elena are mere
        //    //  Output: e apare de 5 ori

        //    int maxim = 0, index = 0;

        //    Console.WriteLine("Introduceti unt string ! ");

        //    string text = Console.ReadLine();

        //    string textLower = text.ToLower();


        //    for(int i = 0; i < text.Length; i++)
        //    {
        //        if(NumarCaracter(text[i], textLower) > maxim)
        //        {
        //            maxim = NumarCaracter(text[i], textLower);

        //            index = i;
        //        }
        //    }

        //    Console.WriteLine($"Caracterul ce se regaseste de cele mai multe ori este \"{text[index]}\", apare de {maxim} ori !  ");

        //    static int NumarCaracter(char x,  string text)
        //    {
        //        int count = 0;

        //        for(int i = 0; i < text.Length; i++)
        //        {
        //            if(x == text[i])
        //            {
        //                count++;
        //            }
        //        }

        //        return count;
        //    }

        //}



        //        static void Main(string[] args) ex 5
        //        {
        //            //Ex 5
        //            //Un program care va normaliza un sir de caractere citit de la tastatura astfel incat fiecare cuvant din
        //            //sir sa inceapa cu MAJUSCULA, restul literelor fiind transformate in litere mici.
        //            //Exemplu:
        //            //Input: Ana ARE mErE
        //            //Rezultat: Ana Are Mere



        //            Console.WriteLine("Introduce-ti un sir de caractere ! ");


        //            string text = Console.ReadLine();

        //            string textLow = text.ToLower();

        //            string[] cuvinte = textLow.Split(' ');

        //            string[] cuvinteFinale = new string[cuvinte.Length];


        //            for(int i = 0; i < cuvinteFinale.Length; i++)
        //            {
        //                cuvinteFinale[i] =LiteraMare(cuvinte[i]);
        //            }

        //            foreach (string cuvant in cuvinteFinale)
        //                Console.Write($"{cuvant} ");
        //        }

        //        static string LiteraMare(string text)
        //        {
        //            return text[0].ToString().ToUpper() + text.Substring(1);
        //        }




    //    static void Main(string[] args)
    //    {
    //        // Ex 6
    //        //Screiti un program care va numara vocalele dintr-un sir de caractere citit de
    //        //la tastatura.



    //        Console.WriteLine("Introduce-ti un sir de caractere ! ");


    //        string sir = Console.ReadLine();

    //        int vocale = NumaraVocale(sir);

    //        Console.WriteLine($"Sirul introdus are {vocale} vocale ", vocale);
    //    }

    //    static int NumaraVocale(string sir)
    //    {
    //        int rezultat = 0;

    //        string vocale = "aeiou";

    //        for (int i = 0; i < sir.Length; i++)
    //        {
    //            if (vocale.Contains(Char.ToLower(sir[i])))
    //            {
    //                rezultat++;
    //            }
                
    //        }

    //        return rezultat;
    //    }





    }

  }
