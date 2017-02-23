using System;
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
    public partial class Form1 : Form
    {
        //need to place all of the Player/Enemy Party code in a singleton
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
        static Player Flynn = new Player("Flynn", FlynnStats, Element.Dark, Element.Light, Element.Slash);
        static Player Nanashi = new Player("Nanashi", NanashiStats, Element.Fire, Element.Electricity, Element.Pierce);
        static Player Hitoshura = new Player("Hitoshura", HitoshuraStats, Element.Light, Element.Strike, Element.Strike);
        static Demon Nekomata = new Demon("Nekomata", NekomataStats, Element.Electricity, Element.Force, Element.Slash);
        static Demon JackFrost = new Demon("Jack Frost", JackStats, Element.Fire, Element.Ice, Element.Strike);
        static Demon Raiju = new Demon("Raiju", RaijuStats, Element.Force, Element.Electricity, Element.Slash);

        //Enemy Party members
        static Player Ashurakai1 = new Player("Ashurakai", Ashurakai1Stats, Element.Dark, Element.Light, Element.Pierce);
        static Player Ashurakai2 = new Player("Ashurakai", Ashurakai2Stats, Element.Dark, Element.Light, Element.Pierce);
        static Player Ashurakai3 = new Player("Ashurakai", Ashurakai3Stats, Element.Dark, Element.Light, Element.Pierce);
        static Demon Nue = new Demon("Nue", NueStats, Element.Force, Element.Electricity, Element.Slash);
        static Demon PyroJack = new Demon("Pyro Jack", PyroJackStats, Element.Ice, 0, Element.Strike);
        static Demon Oni = new Demon("Oni", OniStats, Element.Electricity, Element.Strike, Element.Strike);

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

        public void HPMPUpdate()
        {
            progressBar21.Value = FlynnStats.Health;
            progressBar18.Value = FlynnStats.Mana;
            progressBar22.Value = NekomataStats.Health;
            progressBar17.Value = NekomataStats.Mana;
            progressBar13.Value = NanashiStats.Health;
            progressBar19.Value = NanashiStats.Mana;
            progressBar14.Value = JackStats.Health;
            progressBar20.Value = JackStats.Mana;
            progressBar16.Value = HitoshuraStats.Health;
            progressBar24.Value = HitoshuraStats.Mana;
            progressBar15.Value = RaijuStats.Health;
            progressBar23.Value = RaijuStats.Mana;
            progressBar5.Value = Ashurakai1Stats.Health;
            progressBar7.Value = Ashurakai1Stats.Mana;
            progressBar6.Value = NueStats.Health;
            progressBar8.Value = NueStats.Mana;
            progressBar4.Value = Ashurakai2Stats.Health;
            progressBar3.Value = Ashurakai2Stats.Mana;
            progressBar1.Value = OniStats.Health;
            progressBar2.Value = OniStats.Mana;
            progressBar10.Value = Ashurakai3Stats.Health;
            progressBar11.Value = Ashurakai3Stats.Mana;
            progressBar9.Value = PyroJackStats.Health;
            progressBar12.Value = PyroJackStats.Mana;
        }
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
            Form targetwindow = new TargetWindow();

            Debug.WriteLine("Hunter performs basic attack");
            textBox3.Text = "Hunter performs basic attack, Hunter is now Active";
            HPMPUpdate();

            targetwindow.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
            Form targetwindow = new TargetWindow();

            Debug.WriteLine("Hunter performs a Skill");
            textBox3.Text = "Hunter performs a Skill, Hunter is now Active";
            HPMPUpdate();

            targetwindow.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
            Form targetwindow = new TargetWindow();

            Debug.WriteLine("Demon performs a basic attack");
            textBox3.Text = "Demon performs a basic attack, Demon is now Active";
            HPMPUpdate();

            targetwindow.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Enabled = false;
            Form targetwindow = new TargetWindow();

            Debug.WriteLine("Demon performs a Skill");
            textBox3.Text = "Demon performs a Skill, Demon is now Active";
            HPMPUpdate();

            targetwindow.Show();
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
        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
        private void progressBar13_Click(object sender, EventArgs e)
        {
            
        }
    }
}
