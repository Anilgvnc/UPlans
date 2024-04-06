using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPlans
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void main_Load(object sender, EventArgs e)
        {
            LoadWelcome();
            LoadLinks();
        }

        private void LoadWelcome()
        {
            groupWelcome.Text = "Welcome " + System.Windows.Forms.SystemInformation.ComputerName;
            lblDate.Text = DateTime.Now.ToString("hh:mm");
        }

        private void SaveLinks()
        {
            using (StreamWriter writer = new StreamWriter("links.txt"))
            {
                foreach (Control control in linkPanel.Controls)
                {
                    if (control is Button button)
                    {
                        string name = button.Text;
                        string url = (string)button.Tag;
                        writer.WriteLine($"{name},{url}");
                    }
                }
            }
        }

        private void LoadLinks()
        {
            if (File.Exists("links.txt"))
            {
                string[] lines = File.ReadAllLines("links.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        string name = parts[0];
                        string url = parts[1];

                        Button button = new Button();
                        button.Text = name;
                        button.Tag = url;
                        button.Click += (s, ev) =>
                        {
                            System.Diagnostics.Process.Start((string)button.Tag);
                        }; 
                        
                        linkPanel.Controls.Add(button);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            linkPanel.Controls.Clear();
            File.Delete("links.txt");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var addLink = new AddLink())
            {
                if (addLink.ShowDialog() == DialogResult.OK)
                {
                    string linkName = addLink.linkName;
                    string linkUrl = addLink.linkUrl;

                    Button button = new Button();
                    button.Text = linkName;
                    button.Tag = linkUrl;
                    button.Click += (s, ev) =>
                    {
                        System.Diagnostics.Process.Start((string)button.Tag);
                    };

                    linkPanel.Controls.Add(button);
                    SaveLinks();
                }
            }
        }

        //Pomodoro Timer Components
        private Timer timer;
        DateTime startTime;
        private TimeSpan pomodoroDuration = TimeSpan.FromMinutes(25);

        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            TimeSpan remainingTime = pomodoroDuration - elapsedTime;

            if (remainingTime <= TimeSpan.Zero)
            {
                timer.Stop();
                MessageBox.Show("Pomodoro time is over. Time for a break!");
                return;
            }

            lblPomoDate.Text = remainingTime.ToString("mm\\:ss");
        }

        private void btnPomoStart_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            timer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblPomoDate.Text = pomodoroDuration.ToString("mm\\:ss");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblPomoDate.Text = pomodoroDuration.ToString("mm\\:ss");
        }
    }
}
