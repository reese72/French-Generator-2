using System;
using System.Windows.Forms;

namespace French_Generator
{
    public partial class Form1 : Form
    {
        bool translate = false;
        int test;
        int decider;
        int sus;
        int sus11;
        string l21 = "";
        string l22 = "";
        int test15;
        int test16;
        string l23 = "";
        string l24 = "";
        string name1 = "";
        string name2 = "";
        int selector2;
        int selector3;
        int selector4;
        int selector6;
        int sus10;
        int selector10;
        string name3 = "";
        string name4 = "";
        string name5 = "";
        string name6 = "";
        bool check1 = false;
        bool check2 = false;
        bool check3 = false;
        string test11 = "";
        string test10 = "";
        int test14;
        int test9;
        string test2 = "";
        string test5 = "";
        int selector5;
        string final2 = "";
        string final1 = "";
        string verb = "";
        string verb2 = "";
        string reply = "";
        string l17 = "";
        int finals1;
        int finals2;
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
        string test19 = "";
        string test20 = "";
        string test7 = "";
        string l18 = "";
        string l19 = "";
        int time;
        int test8;
        int selector8;
        string l20 = "";
        string day = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            T:
            if (checkBox1.Checked == true)
            {
                if (translate == true)
                {
                    string lt1 = "";
                    string lt2 = "";
                    string lt3 = "";
                    string lt4 = "";
                    string lt5 = "";
                    string lt6 = "";
                    string verb2t = "";
                    string lt7 = "";
                    string lt23 = "";
                    string VerbqT = "";
                    string lt24 = "";
                    string lt9 = "";
                    string lt10 = "";
                    string dayt = "";
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
                        if (time - 10 < 0)
                        {
                            lt9 = "It is " + test2 + ":0" + time + "\n";
                        }
                        else
                        {
                            lt9 = "It is " + test2 + ":" + time + "\n";
                        }
                    }
                    if (selector4 == 2)
                    {
                        lt5 = "What day is it? \n";
                        if (test9 == 0)
                        {
                            dayt = "Today is monday \n";
                        }
                        if (test9 == 1)
                        {
                            dayt = "Today is tuesday \n";
                        }
                        if (test9 == 2)
                        {
                            dayt = "Today is wednesday \n";
                        }
                        if (test9 == 3)
                        {
                            dayt = "Today is thursday \n";
                        }
                        if (test9 == 4)
                        {
                            dayt = "Today is friday \n";
                        }
                        if (test9 == 5)
                        {
                            dayt = "Today is saturday \n";
                        }
                        if (test9 == 6)
                        {
                            dayt = "Today is sunday \n";
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
                        if (time - 10 < 0)
                        {
                            lt14 = "It is " + test11 + ":0" + time + "\n";
                        }
                        else
                        {
                            lt14 = "It is " + test11 + ":" + time + "\n";
                        }
                    }
                    if (selector6 == 2)
                    {
                        lt12 = "What day is it? \n";
                        if (test16 == 0)
                        {
                            lt14 = "Today is monday \n";
                        }
                        if (test16 == 1)
                        {
                            lt14 = "Today is tuesday \n";
                        }
                        if (test16 == 2)
                        {
                            lt14 = "Today is wednesday \n";
                        }
                        if (test16 == 3)
                        {
                            lt14 = "Today is thursday \n";
                        }
                        if (test16 == 4)
                        {
                            lt14 = "Today is friday \n";
                        }
                        if (test16 == 5)
                        {
                            lt14 = "Today is saturday \n";
                        }
                        if (test16 == 6)
                        {
                            lt14 = "Today is sunday \n";
                        }
                    }
                    if (selector6 == 3)
                    {
                        lt12 = "What is your name? \n";
                        lt19 = "My name is " + l12 + ", and you? \n";
                        lt20 = "My name is " + l13 + "\n";
                    }
                    if (selector6 == 4)
                    {
                        lt12 = "What is your name? \n";
                        lt19 = "My name is " + l12 + ", and you? \n";
                        lt20 = "My name is " + l13 + "\n";
                    }
                    if (sus10 == 0)
                    {
                        verbt = "eat";
                    }
                    if (sus10 == 1)
                    {
                        verbt = "dance";
                    }
                    if (sus10 == 2)
                    {
                        verbt = "draw";
                    }
                    if (sus10 == 3)
                    {
                        verbt = "travel";
                    }
                    if (sus10 == 4)
                    {
                        verbt = "run";
                    }
                    if (sus10 == 5)
                    {
                        verbt = "walk";
                    }
                    if (sus10 == 6)
                    {
                        verbt = "play";
                    }
                    if (sus10 == 7)
                    {
                        verbt = "sing";
                    }
                    if (sus10 == 8)
                    {
                        verbt = "design";
                    }
                    if (sus10 == 9)
                    {
                        verbt = "write";
                    }
                    if (sus10 == 10)
                    {
                        verbt = "read";
                    }
                    if (sus10 == 11)
                    {
                        verbt = "work";
                    }
                    if (sus11 == 0)
                    {
                        verb2t = "eat";
                    }
                    if (sus11 == 1)
                    {
                        verb2t = "dance";
                    }
                    if (sus11 == 2)
                    {
                        verb2t = "draw";
                    }
                    if (sus11 == 3)
                    {
                        verb2t = "travel";
                    }
                    if (sus11 == 4)
                    {
                        verb2t = "run";
                    }
                    if (sus11 == 5)
                    {
                        verb2t = "walk";
                    }
                    if (sus11 == 6)
                    {
                        verb2t = "play";
                    }
                    if (sus11 == 7)
                    {
                        verb2t = "sing";
                    }
                    if (sus11 == 8)
                    {
                        verb2t = "design";
                    }
                    if (sus11 == 9)
                    {
                        verb2t = "write";
                    }
                    if (sus11 == 10)
                    {
                        verb2t = "read";
                    }
                    if (sus11 == 11)
                    {
                        verb2t = "work";
                    }
                    VerbqT = "Do you like to " + verbt + "? \n";
                    if (decider == 0)
                    {
                        replyt = "Yes, I love to " + verbt + ", but I prefer to " + verb2t + "\n";
                    }
                    if (decider == 1)
                    {
                        replyt = "No, I don't like to " + verbt + ", I prefer to " + verb2t + "\n";
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
                        if (time - 10 < 0)
                        {
                            lt23 = "It is " + test19 + ":0" + time + "\n";
                        }
                        else
                        {
                            lt23 = "It is " + test19 + ":" + time + "\n";
                        }
                    }
                    if (selector10 == 2)
                    {
                        lt22 = "What day is it? \n";
                        if (test15 == 0)
                        {
                            lt23 = "Today is monday \n";
                        }
                        if (test15 == 1)
                        {
                            lt23 = "Today is tuesday \n";
                        }
                        if (test15 == 2)
                        {
                            lt23 = "Today is wednesday \n";
                        }
                        if (test15 == 3)
                        {
                            lt23 = "Today is thursday \n";
                        }
                        if (test15 == 4)
                        {
                            lt23 = "Today is friday \n";
                        }
                        if (test15 == 5)
                        {
                            lt23 = "Today is saturday \n";
                        }
                        if (test15 == 6)
                        {
                            lt23 = "Today is sunday \n";
                        }
                    }
                    if (selector10 == 3)
                    {
                        lt22 = "What is your name? \n";
                        lt23 = "My name is " + l19 + ", and you? \n";
                        lt24 = "My name is " + l20 + "\n";
                    }
                    if (selector10 == 4)
                    {
                        lt22 = "What is your name? \n";
                        lt23 = "My name is " + l19 + ", and you? \n";
                        lt24 = "My name is " + l20 + "\n";
                    }
                    if (finals1 == 0)
                    {
                        final1t = "Goodbye \n";
                    }
                    if (finals1 == 1)
                    {
                        final1t = "See you soon \n";
                    }
                    if (finals1 == 2)
                    {
                        final1t = "Farewell \n";
                    }
                    if (finals2 == 0)
                    {
                        final2t = "Goodbye \n";
                    }
                    if (finals2 == 1)
                    {
                        final2t = "See you soon \n";
                    }
                    if (finals2 == 2)
                    {
                        final2t = "Farewell \n";
                    }
                    richTextBox2.Text = lt1 + lt2 + lt3 + "and you? \n" + lt4 + lt5 + dayt + lt6 + testT1 + lt7 + lt10 + lt9 + lt12 + lt14 + lt19 + lt20 + testT7 + VerbqT + replyt + lt22 + lt23 + lt24 + final1t + final2t;
                }
                else
                {
                    richTextBox2.Text = "Nothing to translate!\nRien à traduire!";
                }
            }
            else
            {
                richTextBox2.Text = "";
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            test = 67;
            decider = 67;
            sus = 67;
            sus11 = 67;
            l21 = "";
            l22 = "";
            test15 = 67;
            test16 = 67;
            l23 = "";
            l24 = "";
            name1 = "";
            name2 = "";
            selector2 = 67;
            selector3 = 67;
            selector4 = 67;
            selector6 = 67;
            sus10 = 67;
            selector10 = 67;
            name3 = "";
            name4 = "";
            name5 = "";
            name6 = "";
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            test11 = "";
            test10 = "";
            test14 = 67;
            test9 = 67;
            test2 = "";
            test5 = "";
            selector5 = 67;
            final2 = "";
            final1 = "";
            verb = "";
            verb2 = "";
            reply = "";
            l17 = "";
            finals1 = 67;
            finals2 = 67;
            l16 = "";
            l1 = "";
            l2 = "";
            l3 = "";
            l4 = "";
            l5 = "";
            l6 = "";
            l7 = "";
            l8 = "";
            l9 = "";
            l10 = "";
            l11 = "";
            l12 = "";
            l13 = "";
            l14 = "";
            l15 = "";
            test1 = "";
            test19 = "";
            test20 = "";
            test7 = "";
            l18 = "";
            l19 = "";
            time = 67;
            test8 = 67;
            selector8 = 67;
            l20 = "";
            day = "";
            richTextBox1.Text = "";
            translate = true;
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
            selector2 = Random1.Next(4);
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
            selector3 = Random1.Next(4);
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
            selector4 = Random1.Next(5);
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
                l6 = "J'ai " + selector5 + ", et toi? \n";
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
                time = Random1.Next(61);
                test5 = Convert.ToString(time);
                if (test3 == 1)
                {
                    l9 = "Il est " + test2 + " heure " + time + "\n";
                }
                if (test3 > 1)
                {
                    l9 = "Il est " + test2 + " heures " + time + "\n";
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
            selector6 = Random1.Next(5);
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
                time = Random1.Next(61);
                test10 = Convert.ToString(test14);
                if (test8 == 1)
                {
                    l14 = "Il est " + test11 + " heure " + time + "\n";
                }
                if (test8 > 1)
                {
                    l14 = "Il est " + test11 + " heures " + time + "\n";
                }
            }
            if (selector6 == 2)
            {
                test8 = Random1.Next(7);
                if (test16 == 0)
                {
                    l14 = "Nous sommes lundi \n";
                }
                if (test16 == 1)
                {
                    l14 = "Nous sommes mardi \n";
                }
                if (test16 == 2)
                {
                    l14 = "Nous sommes mecredi \n";
                }
                if (test16 == 3)
                {
                    l14 = "Nous sommes jeudi \n";
                }
                if (test16 == 4)
                {
                    l14 = "Nous sommes vendredi \n";
                }
                if (test16 == 5)
                {
                    l14 = "Nous sommes samedi \n";
                }
                if (test16 == 6)
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
            sus10 = Random1.Next(12);
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
            sus11 = Random1.Next(12);
            if (sus11 == 0)
            {
                verb2 = "manger";
            }
            if (sus11 == 1)
            {
                verb2 = "danser";
            }
            if (sus11 == 2)
            {
                verb2 = "dessiner";
            }
            if (sus11 == 3)
            {
                verb2 = "voyager";
            }
            if (sus11 == 4)
            {
                verb2 = "courir";
            }
            if (sus11 == 5)
            {
                verb2 = "marcher";
            }
            if (sus11 == 6)
            {
                verb2 = "jouer";
            }
            if (sus11 == 7)
            {
                verb2 = "chanter";
            }
            if (sus11 == 8)
            {
                verb2 = "dessiner";
            }
            if (sus11 == 9)
            {
                verb2 = "écrire";
            }
            if (sus11 == 10)
            {
                verb2 = "lire";
            }
            if (sus11 == 11)
            {
                verb2 = "travailler";
            }
            if (verb == verb2)
            {
                goto E;
            }
            decider = Random1.Next(2);
            if (decider == 0)
            {
                reply = "Oui, j'adore " + verb + ", mais je prefer " + verb2;
            }
            if (decider == 1)
            {
                reply = "Non, je déteste " + verb + ", je prefer " + verb2;
            }
        F:
            selector10 = Random1.Next(5);
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
                test19 = Convert.ToString(test8);
                if (test8 < 1)
                {
                    goto C;
                }
                time = Random1.Next(61);
                test20 = Convert.ToString(test9);
                if (test8 == 1)
                {
                    l21 = "Il est " + test19 + " heure " + time + "\n";
                }
                if (test8 > 1)
                {
                    l22 = "Il est " + test19 + " heures " + time + "\n";
                }
            }
            if (selector10 == 2)
            {
                test15 = Random1.Next(7);
                if (test15 == 0)
                {
                    l21 = "Nous sommes lundi \n";
                }
                if (test15 == 1)
                {
                    l21 = "Nous sommes mardi \n";
                }
                if (test15 == 2)
                {
                    l21 = "Nous sommes mecredi \n";
                }
                if (test15 == 3)
                {
                    l21 = "Nous sommes jeudi \n";
                }
                if (test15 == 4)
                {
                    l21 = "Nous sommes vendredi \n";
                }
                if (test15 == 5)
                {
                    l21 = "Nous sommes samedi \n";
                }
                if (test15 == 6)
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
            finals1 = Random1.Next(3);
            if (finals1 == 0)
            {
                final1 = "Au revoir \n";
            }
            if (finals1 == 1)
            {
                final1 = "à bientôt \n";
            }
            if (finals1 == 2)
            {
                final1 = "Adieu \n";
            }
        H:
            finals2 = Random1.Next(3);
            if (finals2 == 0)
            {
                final2 = "Au revoir \n";
            }
            if (finals2 == 1)
            {
                final2 = "à bientôt \n";
            }
            if (finals2 == 2)
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
            if (check3 == true)
            {
                name5 = "Je m'appelle " + l19 + " et toi? \n";
                name6 = "Je m'appelle " + l20 + "\n";
            }
            richTextBox1.Text = l1 + l2 + l3 + ", et toi? \n" + l4 + l5 + l6 + day + name1 + name2 + test1 + l9 + l11 + name3 + name4 + l14 + test7 + "Est-ce que tu aime " + verb + "? \n" + reply + "\n" + l18 + l21 + l22 + l23 + l24 + name5 + name6 + final1 + final2;
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox1.Checked = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            translate = false;
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            if (checkBox1.Checked == true)
            {
                richTextBox2.Text = "Nothing to translate!\nRien à traduire!";
            }

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox6.Checked = false;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }
    }
}
