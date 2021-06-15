using System;
using System.Windows.Forms;

namespace CCPTimer
{
    public partial class Main : Form
    {
        private static bool isLoggedIn;
        private TabControl tabControl1;

        public Main()
        {
            InitializeComponent();
            Hide();
        }

        public static bool IsLoggedIn { get => isLoggedIn; set => isLoggedIn = value; }

        private void NewProjectTabPage()
        {
            var tabPage = new TabPage
            {
                Text = "Projekt " + tabControl1.TabPages.Count
            };
            var tc = new TimerControl
            {
                Dock = DockStyle.Fill
            };
            tabPage.Controls.Add(tc);

            tabControl1.TabPages.Insert(tabControl1.Controls.Count - 1, tabPage);
        }

        private void LoginCheck_Tick(object sender, EventArgs e)
        {
            if (!Main.IsLoggedIn)
            {
                return;
            }

            LoginCheck.Stop();
            LoginCheck.Dispose();
            login1.Dispose();
            pictureBox1.Dispose();

            tabControl1 = new TabControl
            {
                Dock = DockStyle.Fill
            };
            tabControl1.Selecting += TabControl1_Selecting;
            tabControl1.TabPages.Clear();
            Controls.Add(tabControl1);

            var addNewProject = new TabPage
            {
                Text = "+",
                Width = 40
            };
            tabControl1.TabPages.Add(addNewProject);
            NewProjectTabPage();
            tabControl1.SelectedIndex = 0;
        }

        private void TabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex != tabControl1.TabCount - 1)
            {
                return;
            }
            NewProjectTabPage();
            e.Cancel = true;
        }
    }
}