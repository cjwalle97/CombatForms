using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombatForms
{
    /*Desired End Result: 
     * Player1: "Flynn", 300, 200, 22, 27, 22, 17, 17, (Element) 4, (Element) 5, (Element) 6 ;
     * Player2: "Nanashi", 250, 250, 12, 32, 17, 27, 17 (Element) 0, (Element) 2, (element) 8;
     * Player3: "Hitoshura", 400, 100, 32, 7, 32, 22, 12, (Element) 5, (Element) 7, (Element) 7;
     * Demon1: "Nekomata", 350, 150, 27, 17, 27, 17, 17 (Element) 2, (Element) 3, (Element) 6; 
     * Demon2: "Jack Frost", 200, 300, 12, 32, 17, 22, 17, (Element) 0, (Element) 1, (Element) 7;
     * Demon3: "Raiju", 350, 150, 17, 12, 32, 27, 7, (Element) 3, (Element) 2, (Element) 6;
     */
    public partial class Form1 : Form
    {
        //public Stats FlynnStats = new Stats(200, 100, 22, 27, 22, 17, 17);

        //Player Flynn = new Player("Flynn", FlynnStats, (Element)4, (Element)5, (Element)6);
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
