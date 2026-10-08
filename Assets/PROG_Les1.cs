using System;
using System.Diagnostics;
using System.Collections.Generic;

class Speler
{
    public string Naam;
    public int HP;
    public int Score;

    //public void Vertel()
    //{
    //    Console.WriteLine("Ik ben " + Naam + ", mijn HP is " + HP + " en mijn score is " + Score + ".");
    //}
}

class PROG_Les1
{
    static void Main(string[] args)
    {
        List<string> vijanden = new List<string>();
        vijanden.Add("Orc");
        vijanden.Add("Knight");
        vijanden.Add("Wizard");
        vijanden.Add("Ogre");
        vijanden.Add("Dragon");

        vijanden.Remove("Wizard");

        foreach (string vijand in vijanden)
        {
            Console.WriteLine(vijand);
        }

        Console.WriteLine("Aantal vijanden: " + vijanden.Count);

        //Speler[] spelers =
        //{
        //    new Speler { Naam = "Mario", HP = 10, Score = 1000 },
        //    new Speler { Naam = "Luigi", HP = 4, Score = 500 },
        //    new Speler { Naam = "Peach", HP = 8, Score = 800 }
        //};

        //DrukSpelersAf(spelers);

        //Speler speler1 = new Speler();
        //speler1.Naam = "Mario";
        //speler1.HP = 10;
        //speler1.Score = 1000;

        //Speler speler2 = new Speler();
        //speler2.Naam = "Luigi";
        //speler2.HP = 4;
        //speler2.Score = 500;

        //int[] scores = {
        //    5,
        //    10,
       //     20,
        //    84,
        //    96,
        //};
        //int hoogsteScore = scores[0];
        //for (int i = 1; i < scores.Length; i++)
        //{
        //    if (scores[i] > hoogsteScore)
        //    {
        //        hoogsteScore = scores[i];
        //    }
        //}
        //Console.WriteLine(hoogsteScore);

        //string[] vijanden = {
        //    "Orc",
        //    "Knight",
        //    "Wizard",
        //    "Ogre",
        //    "Dragon",
        //};
        //foreach (string vijand in vijanden)
        //{
        //    Console.WriteLine(vijand);
        //}

        //int getal1 = 50;
        //int getal2 = 80;

       //Console.WriteLine("welom " + naam);

        //int aanval = 100;
        //int verdediging = 50;
        //int BerekenSchade(int aanval, int verdediging)
        //{
        //    return aanval - verdediging;
        //}
        //Console.WriteLine(BerekenSchade(aanval, verdediging));

       //Console.WriteLine(getal1);
       //Console.WriteLine(getal2);
       //Console.WriteLine(Math.Max(getal1, getal2));

        //Console.WriteLine(naam);
        //Console.WriteLine(score);
        //Console.WriteLine(alive);

        //Console.WriteLine("Speler.name : " + speler1.Naam);
        //Console.WriteLine("Speler.HP : " + speler1.HP);
        //Console.WriteLine("Speler.Score : " + speler1.Score);
        //Console.WriteLine();
        //Console.WriteLine("Speler.name : " + speler2.Naam);
        //Console.WriteLine("Speler.HP : " + speler2.HP);
        //Console.WriteLine("Speler.Score : " + speler2.Score);
        //speler1.Vertel();
        //speler2.Vertel();

        //Console.WriteLine(HP);

        //if (HP > 0)
        //{
            //Console.WriteLine("speler leeft nog");
        //}
    }

    //static void DrukSpelersAf(Speler[] spelers)
    //{
    //    foreach (Speler speler in spelers)
    //    {
    //        speler.Vertel();
    //    }
    //}
}