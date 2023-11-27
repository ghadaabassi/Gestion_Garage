using BLL;


namespace Garage
{
    public partial class MonGarage : Form
    {
        private List<Automobile> autos = new List<Automobile>();
        public BLL.Garage g;
        public MonGarage()
        {
            InitializeComponent();
            g = new BLL.Garage("Adresse", autos);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Voiture v = new Voiture(0, null, null, null, null);
            if (radioButton1.Checked)
            {
                AddVoiture addVoitureForm = new AddVoiture(v);

                if (addVoitureForm.ShowDialog() == DialogResult.OK)
                {

                    v = addVoitureForm.v;

                    g.AddAuto(v);

                    listView1.Items.Clear();

                    foreach (Voiture voiture in g.afficherAuTomobile(SubType.Voiture))
                    {
                        listView1.Items.Add(voiture.Immatriculation.ToString());
                    }
                }

            }
            else
            {

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listView1.SelectedItems)
            {
                MessageBox.Show(selectedItem.Text);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (ListViewItem selectedItem in listView1.SelectedItems)
                {
                    listView1.Items.Remove(selectedItem);
                    g.deleteAuto(selectedItem.Text);
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {

                listView1.Items.Clear();
                foreach (Voiture voiture in g.afficherAuTomobile(SubType.Voiture))
                {
                    listView1.Items.Add(voiture.Immatriculation.ToString());
                }
            }

            label2.Text = "Immatriculation : ";
            label3.Text = "Annee : ";
            label4.Text = "Type : ";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked)
            {

                listView1.Items.Clear();
                foreach (Moto moto in g.afficherAuTomobile(SubType.Moto))
                {
                    listView1.Items.Add(moto.Immatriculation.ToString());
                }
            }

            label2.Text = "Immatriculation : ";
            label3.Text = "Annee : " ;
            label4.Text = "Vitesse : " ;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listView1.SelectedItems)
            {

                Automobile at = (Voiture)g.getAuto(selectedItem.Text);

                label2.Text = "Immatriculation : " + at.Immatriculation;
                label3.Text = "Annee : " + at.Annee.ToString();
                if (at is Voiture voiture)
                {
                    label4.Text = "Type : " + voiture.TypeV;
                }
                if (at is Moto moto)
                {
                    label4.Text = "Vitesse : " + moto.VitesseMax;
                }

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
