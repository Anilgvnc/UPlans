namespace UPlans
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.groupLink = new System.Windows.Forms.GroupBox();
            this.linkPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupPomodoro = new System.Windows.Forms.GroupBox();
            this.lblPomoDate = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPomoStart = new System.Windows.Forms.Button();
            this.groupWelcome = new System.Windows.Forms.GroupBox();
            this.btnOpenPanel = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupTask = new System.Windows.Forms.GroupBox();
            this.taskPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTaskDelete = new System.Windows.Forms.Button();
            this.btnTaskAdd = new System.Windows.Forms.Button();
            this.componentPanel = new System.Windows.Forms.Panel();
            this.btnDeleteLink = new System.Windows.Forms.Button();
            this.btnAddLink = new System.Windows.Forms.Button();
            this.btnClosePanel = new System.Windows.Forms.Button();
            this.noteCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupLink.SuspendLayout();
            this.groupPomodoro.SuspendLayout();
            this.groupWelcome.SuspendLayout();
            this.groupTask.SuspendLayout();
            this.componentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupLink
            // 
            this.groupLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupLink.Controls.Add(this.linkPanel);
            this.groupLink.Font = new System.Drawing.Font("Righteous", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(99)))), ((int)(((byte)(61)))));
            this.groupLink.Location = new System.Drawing.Point(12, 319);
            this.groupLink.Name = "groupLink";
            this.groupLink.Size = new System.Drawing.Size(507, 123);
            this.groupLink.TabIndex = 0;
            this.groupLink.TabStop = false;
            this.groupLink.Text = "Links";
            // 
            // linkPanel
            // 
            this.linkPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.linkPanel.Location = new System.Drawing.Point(7, 20);
            this.linkPanel.Name = "linkPanel";
            this.linkPanel.Size = new System.Drawing.Size(494, 55);
            this.linkPanel.TabIndex = 0;
            // 
            // groupPomodoro
            // 
            this.groupPomodoro.BackColor = System.Drawing.Color.White;
            this.groupPomodoro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupPomodoro.Controls.Add(this.lblPomoDate);
            this.groupPomodoro.Controls.Add(this.btnReset);
            this.groupPomodoro.Controls.Add(this.btnPomoStart);
            this.groupPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupPomodoro.Font = new System.Drawing.Font("Righteous", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPomodoro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(99)))), ((int)(((byte)(61)))));
            this.groupPomodoro.Location = new System.Drawing.Point(12, 145);
            this.groupPomodoro.Name = "groupPomodoro";
            this.groupPomodoro.Size = new System.Drawing.Size(262, 162);
            this.groupPomodoro.TabIndex = 2;
            this.groupPomodoro.TabStop = false;
            this.groupPomodoro.Text = "Pomodoro";
            // 
            // lblPomoDate
            // 
            this.lblPomoDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPomoDate.AutoSize = true;
            this.lblPomoDate.Font = new System.Drawing.Font("Righteous", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPomoDate.Location = new System.Drawing.Point(74, 45);
            this.lblPomoDate.Name = "lblPomoDate";
            this.lblPomoDate.Size = new System.Drawing.Size(114, 44);
            this.lblPomoDate.TabIndex = 1;
            this.lblPomoDate.Text = "25:00";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(70)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Righteous", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(99, 113);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(64, 32);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset\r\n";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnPomoStart
            // 
            this.btnPomoStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPomoStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(70)))));
            this.btnPomoStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPomoStart.Font = new System.Drawing.Font("Righteous", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomoStart.Location = new System.Drawing.Point(99, 113);
            this.btnPomoStart.Name = "btnPomoStart";
            this.btnPomoStart.Size = new System.Drawing.Size(64, 32);
            this.btnPomoStart.TabIndex = 0;
            this.btnPomoStart.Text = "Start";
            this.btnPomoStart.UseVisualStyleBackColor = false;
            this.btnPomoStart.Click += new System.EventHandler(this.btnPomoStart_Click);
            // 
            // groupWelcome
            // 
            this.groupWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupWelcome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupWelcome.BackgroundImage")));
            this.groupWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupWelcome.Controls.Add(this.btnOpenPanel);
            this.groupWelcome.Controls.Add(this.lblDate);
            this.groupWelcome.Font = new System.Drawing.Font("Righteous", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(99)))), ((int)(((byte)(61)))));
            this.groupWelcome.Location = new System.Drawing.Point(12, 12);
            this.groupWelcome.Name = "groupWelcome";
            this.groupWelcome.Size = new System.Drawing.Size(776, 127);
            this.groupWelcome.TabIndex = 1;
            this.groupWelcome.TabStop = false;
            this.groupWelcome.Text = "Welcome";
            // 
            // btnOpenPanel
            // 
            this.btnOpenPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(70)))));
            this.btnOpenPanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOpenPanel.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPanel.Location = new System.Drawing.Point(18, 40);
            this.btnOpenPanel.Name = "btnOpenPanel";
            this.btnOpenPanel.Size = new System.Drawing.Size(32, 32);
            this.btnOpenPanel.TabIndex = 5;
            this.btnOpenPanel.Text = "+";
            this.btnOpenPanel.UseVisualStyleBackColor = false;
            this.btnOpenPanel.Click += new System.EventHandler(this.btnOpenPanel_Click);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Righteous", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(578, 40);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(177, 61);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "<date>";
            // 
            // groupTask
            // 
            this.groupTask.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTask.Controls.Add(this.taskPanel);
            this.groupTask.Font = new System.Drawing.Font("Righteous", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(99)))), ((int)(((byte)(61)))));
            this.groupTask.Location = new System.Drawing.Point(525, 145);
            this.groupTask.Name = "groupTask";
            this.groupTask.Size = new System.Drawing.Size(263, 297);
            this.groupTask.TabIndex = 3;
            this.groupTask.TabStop = false;
            this.groupTask.Text = "Tasks";
            // 
            // taskPanel
            // 
            this.taskPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskPanel.Location = new System.Drawing.Point(7, 23);
            this.taskPanel.Name = "taskPanel";
            this.taskPanel.Size = new System.Drawing.Size(250, 268);
            this.taskPanel.TabIndex = 0;
            // 
            // btnTaskDelete
            // 
            this.btnTaskDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaskDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(70)))));
            this.btnTaskDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTaskDelete.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskDelete.Location = new System.Drawing.Point(20, 230);
            this.btnTaskDelete.Name = "btnTaskDelete";
            this.btnTaskDelete.Size = new System.Drawing.Size(144, 32);
            this.btnTaskDelete.TabIndex = 4;
            this.btnTaskDelete.Text = "Delete all tasks";
            this.btnTaskDelete.UseVisualStyleBackColor = false;
            this.btnTaskDelete.Click += new System.EventHandler(this.btnTaskDelete_Click);
            // 
            // btnTaskAdd
            // 
            this.btnTaskAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTaskAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(70)))));
            this.btnTaskAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTaskAdd.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskAdd.Location = new System.Drawing.Point(20, 180);
            this.btnTaskAdd.Name = "btnTaskAdd";
            this.btnTaskAdd.Size = new System.Drawing.Size(144, 32);
            this.btnTaskAdd.TabIndex = 4;
            this.btnTaskAdd.Text = "Add Task";
            this.btnTaskAdd.UseVisualStyleBackColor = false;
            this.btnTaskAdd.Click += new System.EventHandler(this.btnTaskAdd_Click);
            // 
            // componentPanel
            // 
            this.componentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.componentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(134)))), ((int)(((byte)(206)))));
            this.componentPanel.Controls.Add(this.btnDeleteLink);
            this.componentPanel.Controls.Add(this.btnAddLink);
            this.componentPanel.Controls.Add(this.btnTaskDelete);
            this.componentPanel.Controls.Add(this.btnClosePanel);
            this.componentPanel.Controls.Add(this.btnTaskAdd);
            this.componentPanel.Font = new System.Drawing.Font("Righteous", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.componentPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(99)))), ((int)(((byte)(61)))));
            this.componentPanel.Location = new System.Drawing.Point(0, 0);
            this.componentPanel.Name = "componentPanel";
            this.componentPanel.Size = new System.Drawing.Size(184, 455);
            this.componentPanel.TabIndex = 5;
            this.componentPanel.Visible = false;
            // 
            // btnDeleteLink
            // 
            this.btnDeleteLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(70)))));
            this.btnDeleteLink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteLink.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLink.Location = new System.Drawing.Point(20, 130);
            this.btnDeleteLink.Name = "btnDeleteLink";
            this.btnDeleteLink.Size = new System.Drawing.Size(144, 32);
            this.btnDeleteLink.TabIndex = 6;
            this.btnDeleteLink.Text = "Delete all links";
            this.btnDeleteLink.UseVisualStyleBackColor = false;
            this.btnDeleteLink.Click += new System.EventHandler(this.btnDeleteLink_Click);
            // 
            // btnAddLink
            // 
            this.btnAddLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(70)))));
            this.btnAddLink.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddLink.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLink.Location = new System.Drawing.Point(20, 80);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(144, 32);
            this.btnAddLink.TabIndex = 7;
            this.btnAddLink.Text = "Add link";
            this.btnAddLink.UseVisualStyleBackColor = false;
            this.btnAddLink.Click += new System.EventHandler(this.btnAddLink_Click);
            // 
            // btnClosePanel
            // 
            this.btnClosePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClosePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(70)))));
            this.btnClosePanel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClosePanel.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClosePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(99)))), ((int)(((byte)(61)))));
            this.btnClosePanel.Location = new System.Drawing.Point(20, 13);
            this.btnClosePanel.Name = "btnClosePanel";
            this.btnClosePanel.Size = new System.Drawing.Size(32, 32);
            this.btnClosePanel.TabIndex = 5;
            this.btnClosePanel.Text = "-";
            this.btnClosePanel.UseVisualStyleBackColor = false;
            this.btnClosePanel.Click += new System.EventHandler(this.btnClosePanel_Click);
            // 
            // noteCalendar
            // 
            this.noteCalendar.Location = new System.Drawing.Point(286, 145);
            this.noteCalendar.Name = "noteCalendar";
            this.noteCalendar.TabIndex = 6;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.componentPanel);
            this.Controls.Add(this.noteCalendar);
            this.Controls.Add(this.groupTask);
            this.Controls.Add(this.groupWelcome);
            this.Controls.Add(this.groupLink);
            this.Controls.Add(this.groupPomodoro);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 493);
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPlans";
            this.Load += new System.EventHandler(this.main_Load);
            this.groupLink.ResumeLayout(false);
            this.groupPomodoro.ResumeLayout(false);
            this.groupPomodoro.PerformLayout();
            this.groupWelcome.ResumeLayout(false);
            this.groupWelcome.PerformLayout();
            this.groupTask.ResumeLayout(false);
            this.componentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupLink;
        private System.Windows.Forms.FlowLayoutPanel linkPanel;
        private System.Windows.Forms.GroupBox groupWelcome;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox groupPomodoro;
        private System.Windows.Forms.Label lblPomoDate;
        private System.Windows.Forms.Button btnPomoStart;
        private System.Windows.Forms.GroupBox groupTask;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnTaskDelete;
        private System.Windows.Forms.Button btnTaskAdd;
        private System.Windows.Forms.FlowLayoutPanel taskPanel;
        private System.Windows.Forms.Panel componentPanel;
        private System.Windows.Forms.Button btnOpenPanel;
        private System.Windows.Forms.Button btnClosePanel;
        private System.Windows.Forms.Button btnDeleteLink;
        private System.Windows.Forms.Button btnAddLink;
        private System.Windows.Forms.MonthCalendar noteCalendar;
    }
}

