using System;
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


        private void button2_Click(object sender, EventArgs e)
        {
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
            string test1 = "";
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
                int selector5 = Random1.Next(30);
                if (selector5 < 5)
                {
                    goto A;
                }
                l6 = selector5 + ", et toi? \n";
            B:
                l8 = Convert.ToString(Random1.Next(30));
                int test = Convert.ToInt32(l8);
                test1 = "J'ai " + Convert.ToString(test) + " ans \n";
                if ( test < 5)
                {
                    goto B;
                }
            }
            if (selector4 == 1)
            {
                C:
                int test3 = Random1.Next(25);
                string test2 = Convert.ToString(test3); 
                if (test3 < 1)
                {
                    goto C;
                }
                int test4 = Random1.Next(61);
                string test5 = Convert.ToString(test4);
                if (test3 == 1)
                {
                    l9 = "Il est " + test2 + " heure " +test5 + "\n";
                }
                if (test3 > 1)
                {
                    l9 = "Il est " + test2 + " heures " + test5 + "\n";
                }
            }
            if (selector4 == 2)
            {
                int test5 = Random1.Next(7);
                if (test5 == 0)
                {
                    l7 = "Nous sommes lundi \n";
                }
                if (test5 == 1)
                {
                    l7 = "Nous sommes mardi \n";
                }
                if (test5 == 2)
                {
                    l7 = "Nous sommes mecredi \n";
                }
                if (test5 == 3)
                {
                    l7 = "Nous sommes jeudi \n";
                }
                if (test5 == 4)
                {
                    l7 = "Nous sommes vendredi \n";
                }
                if (test5 == 5)
                {
                    l7 = "Nous sommes samedi \n";
                }
                if (test5 == 6)
                {
                    l7 = "Nous sommes dimanche \n";
                }
            }
            if (selector4 == 3)
            {
                l7 = "Comment vous appelez-vous? \n";
            }
            if (selector4 == 4)
            {
                int sus = Random1.Next(11);
                if (sus == 9)
                {
                    l10 = "Je m'appelle " + "Gaetan" + " \n";
                }
                if (sus == 10)
                {
                    l10 = "Je m'appelle " + "Vianne" + " \n";
                }
                if (sus == 0)
                {
                    l7 = "Je m'appelle " + "Emma" + " et toi? \n";
                }
                if (sus == 1)
                {
                    l7 = "Je m'appelle " + "Gabriel " + " et toi? \n";
                }
                if (sus == 2)
                {
                    l7 = "Je m'appelle " + "Jade" + " et toi? \n";
                }
                if (sus == 3)
                {
                    l7 = "Je m'appelle " + "Léo" + " et toi? \n";
                }
                if (sus == 4)
                {
                    l7 = "Je m'appelle " + "Louise" + " et toi? \n";
                }
                if (sus == 5)
                {
                    l7 = "Je m'appelle " + "Raphaël" + " et toi? \n";
                }
                if (sus == 6)
                {
                    l7 = "Je m'appelle " + "Alice" + " et toi? \n";
                }
                if (sus == 7)
                {
                    l7 = "Je m'appelle " + "Arthur " + " et toi? \n";
                }
                if (sus == 8)
                {
                    l7 = "Je m'appelle " + "Lou" + " et toi? \n";
                }
                int sus2 = Random1.Next(99);
                if (sus2 == 42)
                {
                    l7 = "Je m'appelle " + "Monsieur Huy" + " et toi? \n";
                }



                C:
                int sus3 = Random1.Next(11);
                if  (sus3 == 9)
                {
                    l10 = "Je m'appelle " + "Gaetan" + " \n";
                }
                if (sus3 == 10)
                {
                    l10 = "Je m'appelle " + "Vianne" + " \n";
                }
                if (sus3 == 0)
                {
                    l10 = "Je m'appelle " + "Emma" + " \n";
                }
                if (sus3 == 1)
                {
                    l10 = "Je m'appelle " + "Gabriel " + "\n";
                }
                if (sus3 == 2)
                {
                    l10 = "Je m'appelle " + "Jade" + "\n";
                }
                if (sus3 == 3)
                {
                    l10 = "Je m'appelle " + "Léo" + "\n";
                }
                if (sus3 == 4)
                {
                    l10 = "Je m'appelle " + "Louise" + "\n";
                }
                if (sus3 == 5)
                {
                    l10 = "Je m'appelle " + "Raphaël" + "\n";
                }
                if (sus3 == 6)
                {
                    l10 = "Je m'appelle " + "Alice" + "\n";
                }
                if (sus3 == 7)
                {
                    l10 = "Je m'appelle " + "Arthur " + "\n";
                }
                if (sus3 == 8)
                {
                    l10 = "Je m'appelle " + "Lou" + "\n";
                }
                int sus4 = Random1.Next(99);
                if (sus4 == 42)
                {
                    l10 = "Je m'appelle " + "Monsieur Huy" + "\n";
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
            richTextBox1.Text = l1 + l2 + l3 + ", et toi? \n" + l4 + l5 + l6 + test1 +l9 + l7 + l10;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
