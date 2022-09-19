using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace final
{
    public partial class Continent : Form
    {
        string continentName;
        DBConnection db;
        DataTable dt3;
       
        public Continent(string txt)
        {
            InitializeComponent();
            db = new DBConnection(txt);
            dt3 = db.FillTable();
            continentName = txt;
            dataGridView1.DataSource = db.FillTable();
        }
        private void Continent_Load(object sender, EventArgs e)
        {
            lblcontinent.Text = continentName;
            lbl2.Text += continentName;
        }
        private void btnUpdateDB_Click(object sender, EventArgs e)
        {
            db.UpdateToDatabase();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Insert(txtName.Text, float.Parse(txtWeight.Text), bool.Parse(cmbool.SelectedItem.ToString()));
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.DeleteFromDT(txtID.Text);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = db.Updatetable(txtID.Text, txtName.Text, float.Parse(txtWeight.Text), bool.Parse(cmbool.SelectedItem.ToString()));
            MessageBox.Show("DB is Updeted ! ");
        }
        private void btnSort_Click(object sender, EventArgs e)
        {
            bool sortByName = false;
            if (rdoName.Checked == false && rdoWeight.Checked == false)
            {
                MessageBox.Show("Please check a sorting option first");
                return;
            }
            else if (rdoName.Checked)
            {
                sortByName = true;
                dataGridView1.DataSource = db.SortDT(sortByName);
            }
            else dataGridView1.DataSource = db.SortDT(sortByName);
        }
        private void exportToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

            XDocument animalList = new XDocument();
            XElement root = new XElement($"Animals");
            animalList.Add(root);
            for (int i = 0; i < dt3.Rows.Count; i++)
            {

                animalList.Root.Add(
                new XElement("Animal_" + (i + 1),
                new XElement("Name", dt3.Rows[i]["Name"].ToString()),
                new XElement("Weight", dt3.Rows[i]["Weight"].ToString()),
                new XElement("EatMeat", dt3.Rows[i]["EatMeat"].ToString()),
                new XElement("Continent", continentName)));
            }
            animalList.Save(@".\XMLFiles\" + continentName + ".xml");
        }
        private void exportToTextToolStripMenuItem_Click(object sender, EventArgs e)
        {

            StreamWriter sw = new StreamWriter(@".\textfiles\" + continentName + ".txt");
            string txt= db.DataReader();
            sw.WriteLine(txt);
            sw.Close();
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

