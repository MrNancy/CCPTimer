using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CCPTimer
{
    public partial class TimerBuchungControl : UserControl
    {
        private Buchung buchung;
        private DateTime currentTime;
        private Button currentButton = null;
        private DateTime currentButtonTime;
        private Button startButton = null;
        private List<KeyValuePair<DateTime, DateTime>> entries = new List<KeyValuePair<DateTime, DateTime>>();

        public TimerBuchungControl()
        {
            InitializeComponent();
        }

        private void NewTimerButton(DateTime started)
        {
            currentButtonTime = started;
            var button = new Button
            {
                Text = started.ToString("T") + "-" + currentTime.ToString("T"),
                AutoSize = true,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand,
                BackColor = Color.FromArgb(255, 51, 217, 132),
                ForeColor = Color.White,
            };
            button.FlatAppearance.BorderSize = 0;
            button.MouseClick += Button_MouseClick;
            currentButton = button;
            flowLayoutPanel1.Controls.Add(currentButton);
        }

        private void Button_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentButton == null)
            {
                return;
            }
            StopCurrentButton();
        }

        private void StopCurrentButton()
        {
            currentButton.BackColor = Color.Maroon;
            currentButton.Enabled = false;
            currentButton = null;
            entries.Add(new KeyValuePair<DateTime, DateTime>(currentButtonTime, DateTime.Now));
        }

        private void StartButton_MouseClick(object sender, MouseEventArgs e)
        {
            NewTimerButton(DateTime.Now);
        }

        internal void SetBuchung(Buchung buchung)
        {
            this.buchung = buchung;
            NewTimerButton(this.buchung.GetTimeStamp());
        }

        private void DateRefresh_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now;
            if (currentButton == null)
            {
                startButton.Visible = true;
                startButton.Enabled = true;
                return;
            }
            startButton.Visible = false;
            startButton.Enabled = false;
            currentButton.Text = currentButton.Text.Replace(" ", "").Split('-')[0] + " - " + currentTime.ToString("T");
        }

        private void abschlussButton_Click(object sender, EventArgs e)
        {
            if (currentButton != null)
            {
                StopCurrentButton();
            }

            if (entries.Count == 0)
            {
                MessageBox.Show("Erstelle zuerst einen Beitrag", "Abschluss fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Controls.Clear();

            var abschluss = new Abschluss();
            abschluss.Dock = DockStyle.Fill;
            abschluss.SetEntries(entries);
            Controls.Add(abschluss);
        }
    }
}
