using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final
{
    public partial class WorldMap : Form
    {
        ToolTip t;
        string txt;
        public WorldMap()
        {
            InitializeComponent();
            t = new ToolTip();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txt = NORTH.Text;
            Continent con = new Continent(txt);
            con.ShowDialog();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            txt = EURASIA.Text;
            Continent con = new Continent(txt);
            con.ShowDialog();
        }
        private void AFRICA_Click(object sender, EventArgs e)
        {
            txt = AFRICA.Text;
            Continent con = new Continent(txt);
            con.ShowDialog();
        }
        private void AUSTRALIA_Click(object sender, EventArgs e)
        {
            txt = AUSTRALIA.Text;
            Continent con = new Continent(txt);
            con.ShowDialog();
        }
        private void ANTARCTIC_Click(object sender, EventArgs e)
        {
            txt = ANTARCTIC.Text;
            Continent con = new Continent(txt);
            con.ShowDialog();
        }
        private void SOUTH_Click(object sender, EventArgs e)
        {
             txt = SOUTH.Text;
            Continent con = new Continent(txt);
            con.ShowDialog();
        }
        private void NORTH_MouseHover(object sender, EventArgs e)
        {

            t.Show($"North America covers an area of about 24,709,000 square kilometers (9,540,000 square miles), \nabout 16.5% of the Earth's land area and about 4.8% of its total surface.\nNorth America is the third-largest continent by area", NORTH);
        }
        private void SOUTH_MouseHover(object sender, EventArgs e)
        {
            t.Show($"South America has an area of 17,840,000 square kilometers (6,890,000 sq mi). \nIts population as of 2018 has been estimated at more than 423 million.\nSouth America ranks fourth in area (after Asia, Africa, and North America) \nand fifth in population (after Asia, Africa, Europe, and North America).", SOUTH);
        }
        private void AFRICA_MouseHover(object sender, EventArgs e)
        {
            t.Show($"Africa is the world's second-largest and second-most populous continent, \nafter Asia in both cases. At about 30.3 million km including adjacent islands, \nit covers 6% of Earth's total surface area and 20% of its land area.", AFRICA);
        }
        private void EURASIA_MouseHover(object sender, EventArgs e)
        {
            t.Show($"Eurasia is the largest continental area on Earth, comprising all of Europe and Asia. \nPrimarily in the Northern and Eastern Hemispheres", EURASIA);
        }
        private void AUSTRALIA_MouseHover(object sender, EventArgs e)
        {
            t.Show($"Australia is the largest country in Oceania and the world's sixth-largest country. \nAustralia's population of nearly 26 million,\nin an area of 7,617,930 square kilometres", AUSTRALIA);
        }
        private void ANTARCTIC_MouseHover(object sender, EventArgs e)
        {
            t.Show($"Antarctic is Earth's southernmost continent. \nIt contains the geographic South Pole and is situated in the Antarctic region of the Southern Hemisphere, \nalmost entirely south of the Antarctic Circle, and is surrounded by the Southern Ocean. \nAt 14,200,000 square kilometres , it is the fifth-largest continent and nearly twice the size of Australia.", ANTARCTIC);
        }
        private void btnallanimals_Click(object sender, EventArgs e)
        {
            AllAnimals all = new AllAnimals();
            all.ShowDialog();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
