using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CCPTimer
{
    public partial class TimerControl : UserControl
    {
        private List<Kunde> kunden = new List<Kunde>();
        private Kunde kunde = null;
        private string kundeString = "Kein Kunde gewählt";
        private string projektString = "Kein Projekt gewählt";
        private string verrechnungString = "Kein Variante gewählt";

        public TimerControl()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                List<Projekt> projektListe = new List<Projekt>();

                projektListe.Add(new Projekt("Projekt 1"));
                projektListe.Add(new Projekt("Projekt 2"));
                projektListe.Add(new Projekt("Projekt 3"));
                projektListe.Add(new Projekt("Projekt 4"));
                projektListe.Add(new Projekt("Projekt 5"));

                kunden.Add(new Kunde("Winzer " + i, projektListe));
            }

            foreach (Kunde kunde in kunden)
            {
                comboBox1.Items.Add(kunde.GetName());
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1 && comboBox3.SelectedItem.ToString() == "------------------------------")
            {
                comboBox3.SelectedIndex = -1;
            }
        }

        private void statusUpdate_Tick(object sender, EventArgs e)
        {
            status.Text = "";
            bool validKunde = comboBox1.SelectedIndex != -1;
            if (validKunde)
            {
                kundeString = comboBox1.SelectedItem.ToString();
                status.Text += "Kunde: " + kundeString;
            }

            bool validProjekt = comboBox2.SelectedIndex != -1;
            if (validProjekt)
            {
                projektString = comboBox2.SelectedItem.ToString();
                status.Text += Environment.NewLine;
                status.Text += Environment.NewLine;
                status.Text += "Projekt: " + projektString;
            }

            bool validVerrechnung = comboBox3.SelectedIndex != -1 || comboBox3.Text != "";
            if (validVerrechnung)
            {
                verrechnungString = comboBox3.Text;

                status.Text += Environment.NewLine;
                status.Text += Environment.NewLine;
                status.Text += "Verrechnung: " + verrechnungString;
                status.Text += Environment.NewLine;
                status.Text += Environment.NewLine;
                status.Text += "Datum: " + DateTime.Now.ToString("F");
            }

            buchen.Visible = validKunde && validProjekt && validVerrechnung;
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;

            if (comboBox1.SelectedIndex == -1)
            {
                return;
            }

            foreach (Kunde kunde in kunden)
            {
                if (kunde.GetName() != comboBox1.SelectedItem.ToString())
                {
                    continue;
                }
                
                this.kunde = kunde;

                break;
            }

            if (kunde == null)
            {
                MessageBox.Show("Der Kunde konnte nicht ausgewählt werden.");

                comboBox1.SelectedIndex = -1;

                return;
            }

            foreach (Projekt projekt in kunde.GetProjekte())
            {
                comboBox2.Items.Add(projekt.GetName());
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = -1;
        }

        private void buchen_Click(object sender, EventArgs e)
        {
            var buchung = new Buchung(kundeString, projektString, verrechnungString, DateTime.Now);
            Controls.Clear();
            var timerBuchungControl = new TimerBuchungControl();
            timerBuchungControl.SetBuchung(buchung);
            timerBuchungControl.Dock = DockStyle.Fill;
            Controls.Add(timerBuchungControl);
        }
    }
}
