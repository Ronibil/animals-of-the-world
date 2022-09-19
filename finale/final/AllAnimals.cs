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
    public partial class AllAnimals : Form
    {
        DBConnection db;
        
        public AllAnimals()
        {
            InitializeComponent();
        }

        private void btnAboveWeight_Click(object sender, EventArgs e)
        {
            float weight =float.Parse(txtWeightup.Text);
           dataGridView1.DataSource = db.FilterByAbovePrice(weight);

        }

        private void AllAnimals_Load(object sender, EventArgs e)
        {
            db = new DBConnection();
            dataGridView1.DataSource = db.CreateAllAnimalsDT();
            
            
        }

        private void btnUnderWeight_Click(object sender, EventArgs e)
        {
            float weight = float.Parse(txtweightunder.Text);
            dataGridView1.DataSource = db.FilterByUnderPrice(weight);
        }
    }
}
