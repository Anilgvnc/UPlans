﻿using System;
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
            LoadTasks();
        }

        private void LoadWelcome()
        {
            groupWelcome.Text = "Welcome " + System.Windows.Forms.SystemInformation.ComputerName;
            //lblDate.Text = DateTime.Now.ToString("hh:mm");
        }

        //Link Panel Components
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
                        string colorName = button.BackColor.Name;
                        writer.WriteLine($"{name},{url},{colorName}");
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
                    if (parts.Length == 3)
                    {
                        string name = parts[0];
                        string url = parts[1];
                        Color color = Color.FromName(parts[2]);

                        Button button = new Button();
                        button.Text = name;
                        button.Tag = url;
                        button.BackColor = color;
                        button.Click += (s, ev) =>
                        {
                            System.Diagnostics.Process.Start((string)button.Tag);
                        }; 
                        
                        linkPanel.Controls.Add(button);
                    }
                }
            }
        }

        private void btnAddLink_Click(object sender, EventArgs e)
        {
            using (var addLink = new AddLink())
            {
                if (addLink.ShowDialog() == DialogResult.OK)
                {
                    string linkName = addLink.linkName;
                    string linkUrl = addLink.linkUrl;
                    Color buttonColor = addLink.linkColor;

                    Button button = new Button();
                    button.Text = linkName;
                    button.Tag = linkUrl;
                    button.BackColor = buttonColor;
                    button.Click += (s, ev) =>
                    {
                        System.Diagnostics.Process.Start((string)button.Tag);
                    };

                    linkPanel.Controls.Add(button);
                    SaveLinks();
                }
            }
        }

        private void btnDeleteLink_Click(object sender, EventArgs e)
        {
            linkPanel.Controls.Clear();
            File.Delete("links.txt");
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
                MessageBox.Show("Pomodoro time is over.", " Time for a break!", MessageBoxButtons.OK, MessageBoxIcon.Information );
                
                //button conf
                btnPomoStart.Visible = true;
                btnReset.Visible = false;
                return;
            }

            lblPomoDate.Text = remainingTime.ToString("mm\\:ss");
        }

        private void btnPomoStart_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            timer.Start();

            //button conf
            btnPomoStart.Visible = false;
            btnReset.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblPomoDate.Text = pomodoroDuration.ToString("mm\\:ss");

            //button conf
            btnPomoStart.Visible = true;
            btnReset.Visible = false;
        }


        //Task Panel Components
        private void SaveTasks()
        {
            using (StreamWriter writer = new StreamWriter("tasks.txt"))
            {
                foreach (Control control in taskPanel.Controls)
                {
                    if (control is Label label)
                    {
                        string name = label.Text;
                        string colorName = label.ForeColor.Name;
                        writer.WriteLine($"{name}, {colorName}");
                    }
                }
            }
        }

        private void LoadTasks()
        {
            if (File.Exists("tasks.txt"))
            {
                string[] lines = File.ReadAllLines("tasks.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 2)
                    {
                        string name = parts[0];
                        Color color = Color.FromName(parts[1]);

                        Label label = new Label();
                        label.Text = name;
                        label.ForeColor = color;

                        taskPanel.Controls.Add(label);
                    }
                }
            }
        }
        private void btnTaskAdd_Click(object sender, EventArgs e)
        {
            using (var addTask = new AddTask())
            {
                if (addTask.ShowDialog() == DialogResult.OK)
                {
                    string taskName = addTask.taskName;
                    Color taskColor = addTask.taskColor;

                    Label label = new Label();
                    label.Text = taskName;
                    label.ForeColor = taskColor;

                    taskPanel.Controls.Add(label);
                    SaveTasks();
                }
            }
        }

        private void btnTaskDelete_Click(object sender, EventArgs e)
        {
            taskPanel.Controls.Clear();
            File.Delete("tasks.txt");
        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            componentPanel.Visible = false;
        }

        private void btnOpenPanel_Click(object sender, EventArgs e)
        {
            componentPanel.Visible = true;
        }

    }
}
