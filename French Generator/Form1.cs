﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Windows.Forms;

namespace French_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }


        private async void button2_Click(object sender, EventArgs e)
        {
            int test = 0;
            int sus = 0;
            string l21 = "";
            string l22 = "";
            string l23 = "";
            string l24 = "";
            string name1 = "";
            string name2 = "";
            string name3 = "";
            string name4 = "";
            string name5 = "";
            string name6 = "";
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            string test11 = "";
            string test10 = "";
            int test14 = 0;
            int test9 = 0;
            string test2 = "";
            string test5 = "";
            int selector5 = 0;
            string final2 = "";
            string final1 = "";
            string verb = "";
            string verb2 = "";
            string reply = "";
            string l17 = "";
            string l16 = "";
            string l1 = "";
            string l2 = "";
            string l3 = "";
            string l4 = "";
            string l5 = "";
            string l6 = "";
            string l7 = "";
            string l8 = "";
            string l9 = "";
            string l10 = "";
            string l11 = "";
            string l12 = "";
            string l13 = "";
            string l14 = "";
            string l15 = "";
            string test1 = "";
            string test7 = "";
            string l18 = "";
            string l19 = "";
            int test8 = 0;
            int selector8 = 0;
            string l20 = "";
            string day = "";
            Random Random1 = new Random();
            int selector1 = Random1.Next(5);
            if (selector1 == 0)
            {
                l1 = "Bonjour! \n";
            }
            if (selector1 == 1)
            {
                l1 = "Enchanté! \n";
            }
            if (selector1 == 2)
            {
                l1 = "Bonsoir! \n";
            }
            if (selector1 == 3)
            {
                l1 = "Salut! \n";
            }
            if (selector1 == 4)
            {
                l1 = "Coucou! \n";
            }
            int selector2 = Random1.Next(4);
            l2 = "Comment ça va? \n";
            if (selector2 == 0)
            {
                l3 = "ça va";
            }
            if (selector2 == 1)
            {
                l3 = "Comme ci comme ça";
            }
            if (selector2 == 2)
            {
                l3 = "ça va mal";
            }
            if (selector2 == 3)
            {
                l3 = "ça va bien";
            }
            int selector3 = Random1.Next(4);
            l2 = "Comment ça va? \n";
            if (selector3 == 0)
            {
                l4 = "ça va \n";
            }
            if (selector3 == 1)
            {
                l4 = "Comme ci comme ça \n";
            }
            if (selector3 == 2)
            {
                l4 = "ça va mal \n";
            }
            if (selector3 == 3)
            {
                l4 = "ça va bien \n";
            }
            int selector4 = Random1.Next(5);
            if (selector4 == 0)
            {
                l5 = "Quel âge as-tu? \n";
            }
            if (selector4 == 1)
            {
                l5 = "Quelle heure est-il? \n";
            }
            if (selector4 == 2)
            {
                l5 = "Quel jour sommes-nous? \n";
            }
            if (selector4 == 3)
            {
                l5 = "Comment vous appelez-vous? \n";
            }
            if (selector4 == 4)
            {
                l5 = "Comment tu t'appelles? \n";
            }


            if (selector4 == 0)
            {
            A:
                selector5 = Random1.Next(30);
                if (selector5 < 5)
                {
                    goto A;
                }
                l6 =  "J'ai " + selector5 + ", et toi? \n";
            B:
                l8 = Convert.ToString(Random1.Next(30));
                test = Convert.ToInt32(l8);
                test1 = "J'ai " + Convert.ToString(test) + " ans \n";
                if (test < 5)
                {
                    goto B;
                }
            }
            if (selector4 == 1)
            {
            C:
                int test3 = Random1.Next(25);
                test2 = Convert.ToString(test3);
                if (test3 < 1)
                {
                    goto C;
                }
                int test4 = Random1.Next(61);
                test5 = Convert.ToString(test4);
                if (test3 == 1)
                {
                    l9 = "Il est " + test2 + " heure " + test5 + "\n";
                }
                if (test3 > 1)
                {
                    l9 = "Il est " + test2 + " heures " + test5 + "\n";
                }
            }
            if (selector4 == 2)
            {
                test9 = Random1.Next(7);
                if (test9 == 0)
                {
                    day = "Nous sommes lundi \n";
                }
                if (test9 == 1)
                {
                    day = "Nous sommes mardi \n";
                }
                if (test9 == 2)
                {
                    day = "Nous sommes mecredi \n";
                }
                if (test9 == 3)
                {
                    day = "Nous sommes jeudi \n";
                }
                if (test9 == 4)
                {
                    day = "Nous sommes vendredi \n";
                }
                if (test9 == 5)
                {
                    day = "Nous sommes samedi \n";
                }
                if (test9 == 6)
                {
                    day = "Nous sommes dimanche \n";
                }
            }
            if (selector4 == 3)
            {
                check1 = true;
                sus = Random1.Next(11);
                if (sus == 9)
                {
                    l7 = "Gaetan";
                }
                if (sus == 10)
                {
                    l7 = "Vianne";
                }
                if (sus == 0)
                {
                    l7 = "Emma";
                }
                if (sus == 1)
                {
                    l7 = "Gabriel";
                }
                if (sus == 2)
                {
                    l7 = "Jade";
                }
                if (sus == 3)
                {
                    l7 = "Léo";
                }
                if (sus == 4)
                {
                    l7 = "Louise";
                }
                if (sus == 5)
                {
                    l7 = "Raphaël";
                }
                if (sus == 6)
                {
                    l7 = "Alice";
                }
                if (sus == 7)
                {
                    l7 = "Arthur ";
                }
                if (sus == 8)
                {
                    l7 = "Lou";
                }
                int sus2 = Random1.Next(99);
                if (sus2 == 42)
                {
                    l7 = "Monsieur Huy";
                }
            C:
                int sus3 = Random1.Next(11);
                if (sus3 == 9)
                {
                    l10 = "Gaetan";
                }
                if (sus3 == 10)
                {
                    l10 = "Vianne";
                }
                if (sus3 == 0)
                {
                    l10 = "Emma";
                }
                if (sus3 == 1)
                {
                    l10 = "Gabriel";
                }
                if (sus3 == 2)
                {
                    l10 = "Jade";
                }
                if (sus3 == 3)
                {
                    l10 = "Léo";
                }
                if (sus3 == 4)
                {
                    l10 = "Louise";
                }
                if (sus3 == 5)
                {
                    l10 = "Raphaël";
                }
                if (sus3 == 6)
                {
                    l10 = "Alice";
                }
                if (sus3 == 7)
                {
                    l10 = "Arthur ";
                }
                if (sus3 == 8)
                {
                    l10 = "Lou";
                }
                int sus4 = Random1.Next(99);
                if (sus4 == 42)
                {
                    l10 = "Monsieur Huy";
                }
                if (sus == sus3)
                {
                    goto C;
                }
                if (sus4 - sus2 == 0)
                {
                    goto C;
                }
            }
            if (selector4 == 4)
            {
                check1 = true;
                sus = Random1.Next(11);
                if (sus == 9)
                {
                    l7 = "Gaetan";
                }
                if (sus == 10)
                {
                    l7 = "Vianne";
                }
                if (sus == 0)
                {
                    l7 = "Emma";
                }
                if (sus == 1)
                {
                    l7 = "Gabriel";
                }
                if (sus == 2)
                {
                    l7 = "Jade";
                }
                if (sus == 3)
                {
                    l7 = "Léo";
                }
                if (sus == 4)
                {
                    l7 = "Louise";
                }
                if (sus == 5)
                {
                    l7 = "Raphaël";
                }
                if (sus == 6)
                {
                    l7 = "Alice";
                }
                if (sus == 7)
                {
                    l7 = "Arthur";
                }
                if (sus == 8)
                {
                    l7 = "Lou";
                }
                int sus2 = Random1.Next(99);
                if (sus2 == 42)
                {
                    l7 = "Monsieur Huy";
                }



            C:
                int sus3 = Random1.Next(11);
                if (sus3 == 9)
                {
                    l10 = "Gaetan";
                }
                if (sus3 == 10)
                {
                    l10 = "Vianne";
                }
                if (sus3 == 0)
                {
                    l10 = "Emma";
                }
                if (sus3 == 1)
                {
                    l10 = "Gabriel";
                }
                if (sus3 == 2)
                {
                    l10 = "Jade";
                }
                if (sus3 == 3)
                {
                    l10 = "Léo";
                }
                if (sus3 == 4)
                {
                    l10 = "Louise";
                }
                if (sus3 == 5)
                {
                    l10 = "Raphaël";
                }
                if (sus3 == 6)
                {
                    l10 = "Alice";
                }
                if (sus3 == 7)
                {
                    l10 = "Arthur";
                }
                if (sus3 == 8)
                {
                    l10 = "Lou";
                }
                int sus4 = Random1.Next(99);
                if (sus4 == 42)
                {
                    l10 = "Monsieur Huy";
                }
                if (sus == sus3)
                {
                    goto C;
                }
                if (sus4 - sus2 == 0)
                {
                    goto C;
                }
            }
        D:
            int selector6 = Random1.Next(5);
            if (selector6 == 0)
            {
                l11 = "Quel âge as-tu? \n";
            }
            if (selector6 == 1)
            {
                l11 = "Quelle heure est-il? \n";
            }
            if (selector6 == 2)
            {
                l11 = "Quel jour sommes-nous? \n";
            }
            if (selector6 == 3)
            {
                l11 = "Comment vous appelez-vous? \n";
            }
            if (selector6 == 4)
            {
                l11 = "Comment tu t'appelles? \n";
            }
            if (l11 == l5)
            {
                goto D;
            }
            if (l11 == "Comment vous appelez-vous? \n")
            {
                if (l5 == "Comment tu t'appelles? \n")
                {
                    goto D;
                }
            }
            if (l11 == "Comment tu t'appelles? \n")
            {
                if (l5 == "Comment vous appelez-vous? \n")
                {
                    goto D;
                }
            }
            if (selector6 == 0)
            {
            A:
                selector8 = Random1.Next(30);
                if (selector8 < 5)
                {
                    goto A;
                }
                l14 = "Moi j'ai " + selector8 + ", et toi? \n";
            B:
                l15 = Convert.ToString(Random1.Next(30));
                test = Convert.ToInt32(l15);
                test7 = "J'ai " + Convert.ToString(test) + " ans \n";
                if (test < 5)
                {
                    goto B;
                }
            }
            if (selector6 == 1)
            {
            C:
                test8 = Random1.Next(25);
                test11 = Convert.ToString(test8);
                if (test8 < 1)
                {
                    goto C;
                }
                test14 = Random1.Next(61);
                test10 = Convert.ToString(test14);
                if (test8 == 1)
                {
                    l14 = "Il est " + test11 + " heure " + test10 + "\n";
                }
                if (test8 > 1)
                {
                    l14 = "Il est " + test11 + " heures " + test10 + "\n";
                }
            }
            if (selector6 == 2)
            {
                test8 = Random1.Next(7);
                if (test8 == 0)
                {
                    l14 = "Nous sommes lundi \n";
                }
                if (test8 == 1)
                {
                    l14 = "Nous sommes mardi \n";
                }
                if (test8 == 2)
                {
                    l14 = "Nous sommes mecredi \n";
                }
                if (test8 == 3)
                {
                    l14 = "Nous sommes jeudi \n";
                }
                if (test8 == 4)
                {
                    l14 = "Nous sommes vendredi \n";
                }
                if (test8 == 5)
                {
                    l14 = "Nous sommes samedi \n";
                }
                if (test8 == 6)
                {
                    l14 = "Nous sommes dimanche \n";
                }
            }
            if (selector6 == 3)
            {
                check2 = true;
                sus = Random1.Next(11);
                if (sus == 9)
                {
                    l12 = "Gaetan";
                }
                if (sus == 10)
                {
                    l12 = "Vianne";
                }
                if (sus == 0)
                {
                    l12 = "Emma";
                }
                if (sus == 1)
                {
                    l12 = "Gabriel";
                }
                if (sus == 2)
                {
                    l12 = "Jade";
                }
                if (sus == 3)
                {
                    l12 = "Léo";
                }
                if (sus == 4)
                {
                    l12 = "Louise";
                }
                if (sus == 5)
                {
                    l12 = "Raphaël";
                }
                if (sus == 6)
                {
                    l12 = "Alice";
                }
                if (sus == 7)
                {
                    l12 = "Arthur";
                }
                if (sus == 8)
                {
                    l12 = "Lou";
                }
                int sus2 = Random1.Next(99);
                if (sus2 == 42)
                {
                    l12 = "Monsieur Huy";
                }
            C:
                int sus3 = Random1.Next(11);
                if (sus3 == 9)
                {
                    l13 = "Gaetan";
                }
                if (sus3 == 10)
                {
                    l13 = "Vianne";
                }
                if (sus3 == 0)
                {
                    l13 = "Emma";
                }
                if (sus3 == 1)
                {
                    l13 = "Gabriel";
                }
                if (sus3 == 2)
                {
                    l13 = "Jade";
                }
                if (sus3 == 3)
                {
                    l13 = "Léo";
                }
                if (sus3 == 4)
                {
                    l13 = "Louise";
                }
                if (sus3 == 5)
                {
                    l13 = "Raphaël";
                }
                if (sus3 == 6)
                {
                    l13 = "Alice";
                }
                if (sus3 == 7)
                {
                    l13 = "Arthur";
                }
                if (sus3 == 8)
                {
                    l13 = "Lou";
                }
                int sus4 = Random1.Next(99);
                if (sus4 == 42)
                {
                    l13 = "Monsieur Huy";
                }
                if (sus == sus3)
                {
                    goto C;
                }
                if (sus4 - sus2 == 0)
                {
                    goto C;
                }
            }
            if (selector6 == 4)
            {
                check2 = true;
                sus = Random1.Next(11);
                if (sus == 9)
                {
                    l12 = "Gaetan";
                }
                if (sus == 10)
                {
                    l12 = "Vianne";
                }
                if (sus == 0)
                {
                    l12 = "Emma";
                }
                if (sus == 1)
                {
                    l12 = "Gabriel";
                }
                if (sus == 2)
                {
                    l12 = "Jade";
                }
                if (sus == 3)
                {
                    l12 = "Léo";
                }
                if (sus == 4)
                {
                    l12 = "Louise";
                }
                if (sus == 5)
                {
                    l12 = "Raphaël";
                }
                if (sus == 6)
                {
                    l12 = "Alice";
                }
                if (sus == 7)
                {
                    l12 = "Arthur ";
                }
                if (sus == 8)
                {
                    l12 = "Lou";
                }
                int sus2 = Random1.Next(99);
                if (sus2 == 42)
                {
                    l12 = "Monsieur Huy";
                }



            C:
                int sus3 = Random1.Next(11);
                if (sus3 == 9)
                {
                    l13 = "Gaetan";
                }
                if (sus3 == 10)
                {
                    l13 = "Vianne";
                }
                if (sus3 == 0)
                {
                    l13 = "Emma";
                }
                if (sus3 == 1)
                {
                    l13 = "Gabriel";
                }
                if (sus3 == 2)
                {
                    l13 = "Jade";
                }
                if (sus3 == 3)
                {
                    l13 = "Léo";
                }
                if (sus3 == 4)
                {
                    l13 = "Louise";
                }
                if (sus3 == 5)
                {
                    l13 = "Raphaël";
                }
                if (sus3 == 6)
                {
                    l13 = "Alice";
                }
                if (sus3 == 7)
                {
                    l13 = "Arthur";
                }
                if (sus3 == 8)
                {
                    l13 = "Lou";
                }
                int sus4 = Random1.Next(99);
                if (sus4 == 42)
                {
                    l13 = "Monsieur Huy";
                }
                if (sus == sus3)
                {
                    goto C;
                }
                if (sus4 - sus2 == 0)
                {
                    goto C;
                }
            }
            int sus10 = Random1.Next(12);
            if (sus10 == 0)
            {
                verb = "manger";
            }
            if (sus10 == 1)
            {
                verb = "danser";
            }
            if (sus10 == 2)
            {
                verb = "dessiner";
            }
            if (sus10 == 3)
            {
                verb = "voyager";
            }
            if (sus10 == 4)
            {
                verb = "courir";
            }
            if (sus10 == 5)
            {
                verb = "marcher";
            }
            if (sus10 == 6)
            {
                verb = "jouer";
            }
            if (sus10 == 7)
            {
                verb = "chanter";
            }
            if (sus10 == 8)
            {
                verb = "dessiner";
            }
            if (sus10 == 9)
            {
                verb = "écrire";
            }
            if (sus10 == 10)
            {
                verb = "lire";
            }
            if (sus10 == 11)
            {
                verb = "travailler";
            }
        E:
            sus10 = Random1.Next(12);
            if (sus10 == 0)
            {
                verb2 = "manger";
            }
            if (sus10 == 1)
            {
                verb2 = "danser";
            }
            if (sus10 == 2)
            {
                verb2 = "dessiner";
            }
            if (sus10 == 3)
            {
                verb2 = "voyager";
            }
            if (sus10 == 4)
            {
                verb2 = "courir";
            }
            if (sus10 == 5)
            {
                verb2 = "marcher";
            }
            if (sus10 == 6)
            {
                verb2 = "jouer";
            }
            if (sus10 == 7)
            {
                verb2 = "chanter";
            }
            if (sus10 == 8)
            {
                verb2 = "dessiner";
            }
            if (sus10 == 9)
            {
                verb2 = "écrire";
            }
            if (sus10 == 10)
            {
                verb2 = "lire";
            }
            if (sus10 == 11)
            {
                verb2 = "travailler";
            }
            if (verb == verb2)
            {
                goto E;
            }
            sus10 = Random1.Next(2);
            if (sus10 == 0)
            {
                reply = "Oui, j'adore " + verb + ", mais je prefer " + verb2;
            }
            if (sus10 == 1)
            {
                reply = "Non, je déteste " + verb + ", je prefer " + verb2;
            }
        F:
            int selector10 = Random1.Next(5);
            if (selector10 == 0)
            {
                l18 = "Quel âge as-tu? \n";
            }
            if (selector10 == 1)
            {
                l18 = "Quelle heure est-il? \n";
            }
            if (selector10 == 2)
            {
                l18 = "Quel jour sommes-nous? \n";
            }
            if (selector10 == 3)
            {
                l18 = "Comment vous appelez-vous? \n";
            }
            if (selector10 == 4)
            {
                l18 = "Comment tu t'appelles? \n";
            }
            if (l18 == l5)
            {
                goto F;
            }
            if (l18 == l11)
            {
                goto F;
            }
            if (l18 == "Comment vous appelez-vous? \n")
            {
                if (l5 == "Comment tu t'appelles? \n")
                {
                    goto F;
                }
                if (l11 == "Comment tu t'appelles? \n")
                {
                    goto F;
                }
            }
            if (l18 == "Comment tu t'appelles? \n")
            {
                if (l5 == "Comment vous appelez-vous? \n")
                {
                    goto F;
                }
                if (l11 == "Comment vous appelez-vous? \n")
                {
                    goto F;
                }
            }
            if (selector10 == 0)
            {
            A:
                selector8 = Random1.Next(30);
                if (selector8 < 5)
                {
                    goto A;
                }
                l23 = "Moi j'ai " + selector8 + ", et toi? \n";
            B:
                l24 = Convert.ToString(Random1.Next(30));
                test = Convert.ToInt32(l24);
                l24 = "J'ai " + Convert.ToString(test) + " ans \n";
                if (test < 5)
                {
                    goto B;
                }
            }
            if (selector10 == 1)
            {
            C:
                test8 = Random1.Next(25);
                string test19 = Convert.ToString(test8);
                if (test8 < 1)
                {
                    goto C;
                }
                test9 = Random1.Next(61);
                string test20 = Convert.ToString(test9);
                if (test8 == 1)
                {
                    l21 = "Il est " + test19 + " heure " + test20 + "\n";
                }
                if (test8 > 1)
                {
                    l22 = "Il est " + test19 + " heures " + test20 + "\n";
                }
            }
            if (selector10 == 2)
            {
                test8 = Random1.Next(7);
                if (test8 == 0)
                {
                    l21 = "Nous sommes lundi \n";
                }
                if (test8 == 1)
                {
                    l21 = "Nous sommes mardi \n";
                }
                if (test8 == 2)
                {
                    l21 = "Nous sommes mecredi \n";
                }
                if (test8 == 3)
                {
                    l21 = "Nous sommes jeudi \n";
                }
                if (test8 == 4)
                {
                    l21 = "Nous sommes vendredi \n";
                }
                if (test8 == 5)
                {
                    l21 = "Nous sommes samedi \n";
                }
                if (test8 == 6)
                {
                    l21 = "Nous sommes dimanche \n";
                }
            }
            if (selector10 == 3)
            {
                check3 = true;
                sus = Random1.Next(11);
                if (sus == 9)
                {
                    l19 = "Gaetan";
                }
                if (sus == 10)
                {
                    l19 = "Vianne";
                }
                if (sus == 0)
                {
                    l19 = "Emma";
                }
                if (sus == 1)
                {
                    l19 = "Gabriel";
                }
                if (sus == 2)
                {
                    l19 = "Jade";
                }
                if (sus == 3)
                {
                    l19 = "Léo";
                }
                if (sus == 4)
                {
                    l19 = "Louise";
                }
                if (sus == 5)
                {
                    l19 = "Raphaël";
                }
                if (sus == 6)
                {
                    l19 = "Alice";
                }
                if (sus == 7)
                {
                    l19 = "Arthur ";
                }
                if (sus == 8)
                {
                    l19 = "Lou";
                }
                int sus2 = Random1.Next(99);
                if (sus2 == 42)
                {
                    l19 = "Monsieur Huy";
                }
            C:
                int sus3 = Random1.Next(11);
                if (sus3 == 9)
                {
                    l20 = "Gaetan";
                }
                if (sus3 == 10)
                {
                    l20 = "Vianne";
                }
                if (sus3 == 0)
                {
                    l20 = "Emma";
                }
                if (sus3 == 1)
                {
                    l20 = "Gabriel";
                }
                if (sus3 == 2)
                {
                    l20 = "Jade";
                }
                if (sus3 == 3)
                {
                    l20 = "Léo";
                }
                if (sus3 == 4)
                {
                    l20 = "Louise";
                }
                if (sus3 == 5)
                {
                    l20 = "Raphaël";
                }
                if (sus3 == 6)
                {
                    l20 = "Alice";
                }
                if (sus3 == 7)
                {
                    l20 = "Arthur";
                }
                if (sus3 == 8)
                {
                    l20 = "Lou";
                }
                int sus4 = Random1.Next(99);
                if (sus4 == 42)
                {
                    l20 = "Monsieur Huy";
                }
                if (sus == sus3)
                {
                    goto C;
                }
                if (sus4 - sus2 == 0)
                {
                    goto C;
                }
            }
            if (selector10 == 4)
            {
                check3 = true; 
                sus = Random1.Next(11);
                if (sus == 9)
                {
                    l19 = "Gaetan";
                }
                if (sus == 10)
                {
                    l19 = "Vianne";
                }
                if (sus == 0)
                {
                    l19 = "Emma";
                }
                if (sus == 1)
                {
                    l19 = "Gabriel";
                }
                if (sus == 2)
                {
                    l19 = "Jade";
                }
                if (sus == 3)
                {
                    l19 = "Léo";
                }
                if (sus == 4)
                {
                    l19 = "Louise";
                }
                if (sus == 5)
                {
                    l19 = "Raphaël";
                }
                if (sus == 6)
                {
                    l19 = "Alice";
                }
                if (sus == 7)
                {
                    l19 = "Arthur";
                }
                if (sus == 8)
                {
                    l19 = "Lou";
                }
                int sus2 = Random1.Next(99);
                if (sus2 == 42)
                {
                    l19 = "Monsieur Huy";
                }
                C:
                int sus3 = Random1.Next(11);
                if (sus3 == 9)
                {
                    l20 = "Gaetan";
                }
                if (sus3 == 10)
                {
                    l20 = "Vianne";
                }
                if (sus3 == 0)
                {
                    l20 = "Emma";
                }
                if (sus3 == 1)
                {
                    l20 = "Gabriel";
                }
                if (sus3 == 2)
                {
                    l20 = "Jade";
                }
                if (sus3 == 3)
                {
                    l20 = "Léo";
                }
                if (sus3 == 4)
                {
                    l20 = "Louise";
                }
                if (sus3 == 5)
                {
                    l20 = "Raphaël";
                }
                if (sus3 == 6)
                {
                    l20 = "Alice";
                }
                if (sus3 == 7)
                {
                    l20 = "Arthur";
                }
                if (sus3 == 8)
                {
                    l20 = "Lou";
                }
                int sus4 = Random1.Next(99);
                if (sus4 == 42)
                {
                    l20 = "Monsieur Huy";
                }
                if (sus == sus3)
                {
                    goto C;
                }
                if (sus4 - sus2 == 0)
                {
                    goto C;
                }
            }
            int finals = Random1.Next(3);
            if (finals == 0)
            {
                final1 = "Au revoir \n";
            }
            if (finals == 1)
            {
                final1 = "à bientôt \n";
            }
            if (finals == 2)
            {
                final1 = "Adieu \n";
            }
            H:
            finals = Random1.Next(3);
            if (finals == 0)
            {
                final2 = "Au revoir \n";
            }
            if (finals == 1)
            {
                final2 = "à bientôt \n";
            }
            if (finals == 2)
            {
                final2 = "Adieu \n";
            }
            if (final1 == final2)
            {
                goto H;
            }
            if (check1 == true)
            {
                name1 = "Je m'appelle " + l7 + " et toi? \n";
                name2 = "Je m'appelle " + l10 + "\n";
            }
            if (check2 == true)
            {
                name3 = "Je m'appelle " + l12 + " et toi? \n";
                name4 = "Je m'appelle " + l13 + "\n";
            }
            if (check3 == true )
            {
                name5 = "Je m'appelle " + l19 + " et toi? \n";
                name6 = "Je m'appelle " + l20 + "\n";
            }
            richTextBox1.Text = l1 + l2 + l3 + ", et toi? \n" + l4 + l5 + l6 + day + name1 + name2 + test1  + l9  + l11 + name3 + name4 + l14 + test7 + "Est-ce que tu aime " + verb + "? \n" + reply + "\n" + l18 + l23 + l24 + name5 + name6 +l21 + l22 + final1 + final2;
                if (checkBox1.Checked == true)
                {
                    string lt1 = "";
                    string lt2 = "";
                    string lt3 = "";
                    string lt4 = "";
                    string lt5 = "";
                    string lt6 = "";
                    string lt7 = "";
                string lt23 = "";
                string lt24 = "";
                    string lt9 = "";
                    string lt10 = "";
                    string lt11 = "";
                    string lt12 = "";
                string lt22 = "";
                    string lt13 = "";
                    string lt14 = "";
                    string testT1 = "";
                    string testT7 = "";
                    string verbt = "";
                    string lt18 = "";
                    string replyt = "";
                    string lt19 = "";
                    string lt20 = "";
                    string final1t = "";
                    string final2t = "";
                    lt1 = "Hello! \n";
                    lt2 = "How are you? \n";
                    if (selector2 == 0)
                    {
                        lt3 = "I'm okay, ";
                    }
                    if (selector2 == 1)
                    {
                        lt3 = "I'm okay, ";
                    }
                    if (selector2 == 2)
                    {
                        lt3 = "I'm bad, ";
                    }
                    if (selector2 == 3)
                    {
                        lt3 = "I'm good, ";
                    }
                    if (selector3 == 0)
                {
                    lt4 = "I'm okay \n";
                }
                    if (selector3 == 1)
                {
                    lt4 = "I'm okay \n";
                }
                    if (selector3 == 2)
                {
                    lt4 = "I'm bad \n";
                }
                if (selector3 == 3)
                {
                    lt4 = "I'm good \n";
                }
                if (selector4 == 0)
                {
                    lt5 = "How old are you? \n";
                    lt6 = "I'm " + selector5 + " years old, and you? \n";
                    testT1 = "I'm " + l8 + " years old \n";
                }
                if (selector4 == 1)
                {
                    lt5 = "What time is it? \n";
                    if (Convert.ToInt32(test5) - 10 < 0)
                    {
                        lt9 = "It is " + test2 + ":0" + test5 + "\n";
                    }
                    else
                    {
                        lt9 = "It is " + test2 + ":" + test5 + "\n";
                    }
                }
                if (selector4 == 2)
                {
                    lt5 = "What day is it? \n";
                    if (test8 == 0)
                    {
                        lt14 = "Today is monday \n";
                    }
                    if (test8 == 1)
                    {
                        lt14 = "Today is tuesday \n";
                    }
                    if (test8 == 2)
                    {
                        lt14 = "Today is wednesday \n";
                    }
                    if (test8 == 3)
                    {
                        lt14 = "Today is thursday \n";
                    }
                    if (test8 == 4)
                    {
                        lt14 = "Today is friday \n";
                    }
                    if (test8 == 5)
                    {
                        lt14 = "Today is saturday \n";
                    }
                    if (test8 == 6)
                    {
                        lt14 = "Today is sunday \n";
                    }
                }
                if (selector4 == 3)
                {
                    lt5 = "What is your name? \n";
                    lt7 = "My name is " + l7 + ", and you? \n";
                    lt10 = "My name is " + l10 + "\n";
                }
                if (selector4 == 4)
                {
                    lt5 = "What is your name? \n";
                    lt7 = "My name is " + l7 + ", and you? \n";
                    lt10 = "My name is " + l10 + "\n";
                }
                if (selector6 == 0)
                {
                    lt12 = "How old are you? \n";
                    lt14 = "I'm " + selector8 + " years old, and you? \n";
                    testT7 = "I'm " + l15 + " years old \n";
                }
                if (selector6 == 1)
                {
                    lt12 = "What time is it? \n";
                    if (Convert.ToInt32(test10) - 10 < 0)
                    {
                        lt14 = "It is " + test11 + ":0" + test10 + "\n";
                    }
                    else
                    {
                        lt14 = "It is " + test11 + ":" + test10 + "\n";
                    }
                }
                if (selector6 == 2)
                {
                    lt12 = "What day is it? \n";
                    if (test8 == 0)
                    {
                        lt14 = "Today is monday \n";
                    }
                    if (test8 == 1)
                    {
                        lt14 = "Today is tuesday \n";
                    }
                    if (test8 == 2)
                    {
                        lt14 = "Today is wednesday \n";
                    }
                    if (test8 == 3)
                    {
                        lt14 = "Today is thursday \n";
                    }
                    if (test8 == 4)
                    {
                        lt14 = "Today is friday \n";
                    }
                    if (test8 == 5)
                    {
                        lt14 = "Today is saturday \n";
                    }
                    if (test8 == 6)
                    {
                        lt14 = "Today is sunday \n";
                    }
                }
                if (selector6 == 3)
                {
                    lt12 = "What is your name? \n";
                    lt7 = "My name is " + l12 + ", and you? \n";
                    lt10 = "My name is " + l13 + "\n";
                }
                if (selector6 == 4)
                {
                    lt12 = "What is your name? \n";
                    lt11 = "My name is " + l12 + ", and you? \n";
                    lt14 = "My name is " + l13 + "\n";
                }
                if (selector10 == 0)
                {
                    lt22 = "How old are you? \n";
                    lt23 = "I'm " + selector8 + " years old, and you? \n";
                    lt24 = "I'm " + test + " years old \n";
                }
                if (selector10 == 1)
                {
                    lt22 = "What time is it? \n";
                    if (Convert.ToInt32(test9) - 10 < 0)
                    {
                        lt14 = "It is " + test11 + ":0" + test10 + "\n";
                    }
                    else
                    {
                        lt14 = "It is " + test11 + ":" + test10 + "\n";
                    }
                }
                if (selector10 == 2)
                {
                    lt22 = "What day is it? \n";
                    if (test8 == 0)
                    {
                        lt24 = "Today is monday \n";
                    }
                    if (test8 == 1)
                    {
                        lt14 = "Today is tuesday \n";
                    }
                    if (test8 == 2)
                    {
                        lt14 = "Today is wednesday \n";
                    }
                    if (test8 == 3)
                    {
                        lt14 = "Today is thursday \n";
                    }
                    if (test8 == 4)
                    {
                        lt14 = "Today is friday \n";
                    }
                    if (test8 == 5)
                    {
                        lt14 = "Today is saturday \n";
                    }
                    if (test8 == 6)
                    {
                        lt14 = "Today is sunday \n";
                    }
                }
                if (selector10 == 3)
                {
                    lt12 = "What is your name? \n";
                    lt7 = "My name is " + l12 + ", and you? \n";
                    lt10 = "My name is " + l13 + "\n";
                }
                if (selector10 == 4)
                {
                    lt12 = "What is your name? \n";
                    lt11 = "My name is " + l12 + ", and you? \n";
                    lt14 = "My name is " + l13 + "\n";
                }
                richTextBox2.Text = lt1 + lt2 + lt3 + "and you? \n" + lt4 + lt5 + lt6 + testT1 + lt7 + lt10 + lt9 + lt12 + lt14 + lt11 + testT7 + lt22 + lt23 + lt24;
                }
                else
                {
                    richTextBox2.Text = "";
                }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
