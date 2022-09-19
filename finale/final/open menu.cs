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
    public partial class open_menu : Form
    {
        public open_menu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            WorldMap world = new WorldMap();
            world.ShowDialog();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ON THE GAME: \nIn this program you will be displayed the map of the world.\n" +
                             "You will be asked to choose a continent and inside it will present you the animals of this continent" +
                             "You will be able to INSERT, UPDATE  and  DELETE animal from the list" +
                             "and sorted them by their weight and name.If you will press on the button 'ALL THE ANIMALS' " +
                             "you will be able to see all the animals from all of the 6 continents and you will have the choise of see the animals above and under weight you entered.\n We hope you enjoy  ");
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for visiting :) please come again.");
            Application.Exit();
        }
    }
}
