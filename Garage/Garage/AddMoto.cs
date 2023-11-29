using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Garage
{
    public partial class AddMoto : Form
    {
        public Moto m;
        public AddMoto(Moto m)
        {
            InitializeComponent();
            this.m = m;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.Annee = int.Parse(textBox1.Text);
            m.Immatriculation = textBox5.Text;
            m.VitesseMax = float.Parse(textBox4.Text);
            m.Cylindre = float.Parse(textBox2.Text);

            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
