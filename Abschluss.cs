using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CCPTimer
{
    public partial class Abschluss : UserControl
    {
        private double difference = 0;
        private double minus;
        private List<KeyValuePair<DateTime, DateTime>> entries;

        public Abschluss()
        {
            InitializeComponent();
        }

        internal void SetEntries(List<KeyValuePair<DateTime, DateTime>> entries)
        {
            this.entries = entries;
            foreach (KeyValuePair<DateTime, DateTime> keyValuePair in entries)
            {
                DateTime from = keyValuePair.Key;
                DateTime to = keyValuePair.Value;

                if (from.Day == to.Day && from.Month == to.Month && from.Year == to.Year)
                {
                    listBox1.Items.Add("Von: " + from.ToString("T") + " | Bis: " + to.ToString("T"));
                }
                else
                {
                    listBox1.Items.Add("Von: " + from.ToString("G") + " | Bis: " + to.ToString("G"));
                }

                difference += (to - from).TotalSeconds;
            }
            MakeAbschluss();
        }

        private void MakeAbschluss()
        {
            TimeSpan t = TimeSpan.FromSeconds(difference);

            string abschlussString;
            abschlussString = t.ToString(@"hh\:mm\:ss");
            if (t.Days > 0)
            {
                abschlussString = t.ToString(@"d\d\,\ hh\:mm\:ss");
            }

            timestamp.Text = DateTime.Now.ToString("F");
            abschlussText.Text = "Arbeitszeit: " + abschlussString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string minus = Microsoft.VisualBasic.Interaction.InputBox("Wieviele Minuten möchtest du von deiner Arbeitszeit abziehen?", "Arbeitszeit abziehen", "30");
            bool valid = double.TryParse(minus, out double result);
            if (result != 0 && valid)
            {
                difference = difference - (result * 60);
                this.minus = result;
                string abzugString = " Minuten Abzug";
                if (minus == "1")
                {
                    abzugString = " Minute Abzug";
                }
                listBox1.Items.Add("- " + minus + abzugString);
                button1.Visible = false;
                MakeAbschluss();
            }
            else
            {
                MessageBox.Show("Es wurde keine Zeit abgezogen");
            }
        }
    }
}
