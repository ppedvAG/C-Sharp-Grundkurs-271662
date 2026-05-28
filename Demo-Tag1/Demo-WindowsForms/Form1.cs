namespace Demo_WindowsForms
{
    using Demo_Tag3;
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBerechne_Click(object sender, EventArgs e)
        {
            Calculator.Rechenoperation op = (Calculator.Rechenoperation)(cmbRechenoperation.SelectedIndex + 1);
            double zahl1, zahl2, ergebnis;
            if (double.TryParse(txtZahl1.Text, out zahl1) && double.TryParse(txtZahl2.Text, out zahl2))
            {
                ergebnis = Calculator.Berechne(zahl1, zahl2, op);
                if (ergebnis.Equals(double.NaN))
                {
                    MessageBox.Show("Divison durch 0 nicht erlaubt!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lblErgebnis.Text = ergebnis.ToString();
                    Rechnung rechnung = new Rechnung(zahl1, zahl2, op, ergebnis);
                    lstRechnungen.Items.Add(rechnung);
                }
            }
            else
            {
                MessageBox.Show("Zahlen ungültig!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            clearForm();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clearForm();
        }

        private void clearForm()
        {
            txtZahl1.Clear();
            txtZahl2.Text = "";
            lblErgebnis.Text = "Ergebnis";
            cmbRechenoperation.SelectedIndex = 0;
        }

        private void lstRechnungen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstRechnungen.SelectedItem != null)
            {
                Rechnung rechnung = lstRechnungen.SelectedItem as Rechnung;
                txtZahl1.Text = rechnung.Zahl1.ToString();
                txtZahl2.Text = rechnung.Zahl2.ToString();
                lblErgebnis.Text = rechnung.Ergebnis.ToString();
                cmbRechenoperation.SelectedIndex = (int)(rechnung.Op - 1);
            }
        }
    }


}
