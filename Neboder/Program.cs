﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neboder
{
    class Neboder
    {
        private int visina, brojKatova;

        public int Visina { get => visina; set => visina = value; }
        public int BrojKatova { get => brojKatova; set => brojKatova = value; }

        public override string ToString()
        {
            return "Broj Katova: " + BrojKatova + " m\nVisina: " + Visina + " m\nProsjecna Visina Kata: " + ((float)Visina / (float)BrojKatova)+" m.";

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Neboder Tower = new Neboder();
            Tower.Visina = 200;
            Tower.BrojKatova = 100;
            Tower.Visina += 10;
            Tower.BrojKatova+=1;
            Console.WriteLine(Tower.ToString());

            Console.ReadKey();
        }
    }
}
