﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CombatForms
{
    /*Desired End Result: 
     * Player1: "Flynn", 300, 200, 22, 27, 22, 17, 17, (Element) 4, (Element) 5, (Element) 6 ;
     * Player2: "Nanashi", 250, 250, 12, 32, 17, 27, 17 (Element) 0, (Element) 2, (Element) 8;
     * Player3: "Hitoshura", 400, 100, 32, 7, 32, 22, 12, (Element) 5, (Element) 7, (Element) 7;
     * Demon1: "Nekomata", 350, 150, 27, 17, 27, 17, 17 (Element) 2, (Element) 3, (Element) 6; 
     * Demon2: "Jack Frost", 200, 300, 12, 32, 17, 22, 17, (Element) 0, (Element) 1, (Element) 7;
     * Demon3: "Raiju", 350, 150, 17, 12, 32, 27, 7, (Element) 3, (Element) 2, (Element) 6;
     * 
     */
    public partial class Form1 : Form
    {
        //Player Party Stats
        static Stats FlynnStats = new Stats(300, 200, 22, 27, 22, 17, 17);
        static Stats NanashiStats = new Stats(250, 250, 12, 32, 17, 27, 17);
        static Stats HitoshuraStats = new Stats(400, 100, 32, 7, 32, 22, 12);
        static Stats NekomataStats = new Stats(350, 150, 27, 17, 27, 17, 17);
        static Stats JackStats = new Stats(200, 300, 12, 32, 17, 22, 17);
        static Stats RaijuStats = new Stats(350, 150, 17, 12, 32, 27, 7);

        //Enemy Party Stats
        static Stats Ashurakai1Stats = new Stats(300, 200, 22, 12, 27, 17, 17);
        static Stats Ashurakai2Stats = new Stats(300, 200, 17, 12, 27, 22, 17);
        static Stats Ashurakai3Stats = new Stats(300, 200, 22, 17, 27, 12, 17);
        static Stats NueStats = new Stats(350, 150, 22, 12, 27, 17, 17);
        static Stats PyroJackStats = new Stats(200, 300, 12, 12, 32, 22, 17);
        static Stats OniStats = new Stats(400, 100, 32, 7, 17, 12, 22);

        //Player Party Members
        static Player Flynn = new Player("Flynn", FlynnStats, (Element)4, (Element)5, (Element)6);
        static Player Nanashi = new Player("Nanashi", NanashiStats, 0, (Element)2, (Element)8);
        static Player Hitoshura = new Player("Hitoshura", HitoshuraStats, (Element)5, (Element)7, (Element)7);
        static Demon Nekomata = new Demon("Nekomata", NekomataStats, (Element)2, (Element)3, (Element)6);
        static Demon JackFrost = new Demon("Jack Frost", JackStats, (Element)0, (Element)1, (Element)7);
        static Demon Raiju = new Demon("Raiju", RaijuStats, (Element)3, (Element)2, (Element)6);

        //Enemy Party members
        static Player Ashurakai1 = new Player("Ashurakai", Ashurakai1Stats, (Element)4, (Element)5, (Element)8);
        static Player Ashurakai2 = new Player("Ashurakai", Ashurakai2Stats, (Element)4, (Element)5, (Element)8);
        static Player Ashurakai3 = new Player("Ashurakai", Ashurakai3Stats, (Element)4, (Element)5, (Element)8);
        static Demon Nue = new Demon("Nue", NueStats, (Element)3, (Element)2, (Element)6);
        static Demon PyroJack = new Demon("Pyro Jack", PyroJackStats, (Element)1, 0, (Element)7);
        static Demon Oni = new Demon("Oni", OniStats, (Element)2, (Element)7, (Element)7);

        //Player Columns
        static Column PlayerColumnCenter = new Column(Flynn, Nekomata);
        static Column PlayerColumnRight = new Column(Hitoshura, Raiju);
        static Column PlayerColumnLeft = new Column(Nanashi, JackFrost);

        //Enemy Columns
        static Column EnemyColumnCenter = new Column(Ashurakai1, Nue);
        static Column EnemyColumnRight = new Column(Ashurakai2, PyroJack);
        static Column EnemyColumnLeft = new Column(Ashurakai3, Oni);
        
        //Player Party
        Party PlayerParty = new Party(PlayerColumnCenter, PlayerColumnRight, PlayerColumnLeft);

        //Enemy Player
        Party EnemyParty = new Party(EnemyColumnCenter, EnemyColumnRight, EnemyColumnLeft);

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Hunter performs basic attack");
            textBox3.Text = "Hunter performs basic attack, Hunter is now Active";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Hunter performs a Skill");
            textBox3.Text = "Hunter performs a Skill, Hunter is now Active";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Demon performs a basic attack");
            textBox3.Text = "Demon performs a basic attack, Demon is now Active";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Demon performs a Skill");
            textBox3.Text = "Demon performs a Skill, Demon is now Active";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
