using BLL;


namespace Garage
{
    public partial class AddVoiture : Form
    {
        public Voiture v;
        public AddVoiture(Voiture v)
        {
            InitializeComponent();
            this.v = v;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            v.Annee = int.Parse(textBox1.Text);
            v.Immatriculation = textBox5.Text;
            v.Couleur = textBox4.Text;
            v.Marque = textBox2.Text;
            v.TypeV = textBox3.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();


        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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
