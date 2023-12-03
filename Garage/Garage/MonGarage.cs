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
            Moto m = new Moto(0,null,0,0);
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
                AddMoto addMotoForm = new AddMoto(m);

                if (addMotoForm.ShowDialog() == DialogResult.OK)
                {
                    m = addMotoForm.m;

                    g.AddAuto(m);

                    listView1.Items.Clear();

                    foreach (Moto moto in g.afficherAuTomobile(SubType.Moto))
                    {
                        listView1.Items.Add(moto.Immatriculation.ToString());
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selectedItem in listView1.SelectedItems)
            {
                Automobile at = g.getAuto(selectedItem.Text);

                
                if (at is Voiture voiture)
                {
                    MessageBox.Show("Immatriculation : " + selectedItem.Text + "\nMarque :"+
                        voiture.Marque+"\n "
                        );
                }
                if (at is Moto moto)
                {
                    MessageBox.Show("Immatriculation : " + selectedItem.Text + "\nCylindre :" +
                        moto.Cylindre + "\n "
                        );
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
                foreach (ListViewItem selectedItem in listView1.SelectedItems)
                {
                    listView1.Items.Remove(selectedItem);
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
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
                Automobile at = g.getAuto(selectedItem.Text);

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
