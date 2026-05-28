namespace Demo_WindowsForms
{
    using Demo_Tag3;
    using System.Text.Json;

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
            lstRechnungen.Items.Clear();
        }

        private void lstRechnungen_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lstRechnungen.SelectedItem != null)
            {
                Rechnung rechnung = lstRechnungen.SelectedItem as Rechnung;
                txtZahl1.Text = rechnung.Zahl1.ToString();
                txtZahl2.Text = rechnung.Zahl2.ToString();
                lblErgebnis.Text = rechnung.Ergebnis.ToString();
                cmbRechenoperation.SelectedIndex = (int)(rechnung.Op - 1);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Möchtest du das Programm schließen?", "Schließen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Dialog zum Speichern der Datei anzeigen
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Json Datei (*.json)|*.json";
            sf.FileName = "rechnungen.json";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sf.FileName))
                {
                    sw.Write(JsonSerializer.Serialize(lstRechnungen.Items.Cast<Rechnung>().ToList()));
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Listbox leeren
            lstRechnungen.Items.Clear();
            // Dialog zum Öffnen der Datei anzeigen
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "Json Datei (*.json)|*.json";
            of.FileName = "rechnungen.json";
            if(of.ShowDialog()==DialogResult.OK)
            {
                // Datei lesen Zeile für Zeile
                using (StreamReader sr = new StreamReader(of.FileName)) {
                    lstRechnungen.Items.AddRange(JsonSerializer.Deserialize<List<Rechnung>>(sr.ReadToEnd()).ToArray());
                    
                  
                }
            }
        }
    }


}
