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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.linkPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupPomodoro = new System.Windows.Forms.GroupBox();
            this.lblPomoDate = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPomoStart = new System.Windows.Forms.Button();
            this.groupWelcome = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupTask = new System.Windows.Forms.GroupBox();
            this.groupLink.SuspendLayout();
            this.groupPomodoro.SuspendLayout();
            this.groupWelcome.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupLink
            // 
            this.groupLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupLink.Controls.Add(this.btnAdd);
            this.groupLink.Controls.Add(this.btnDelete);
            this.groupLink.Controls.Add(this.linkPanel);
            this.groupLink.Font = new System.Drawing.Font("Righteous", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(99)))), ((int)(((byte)(61)))));
            this.groupLink.Location = new System.Drawing.Point(12, 298);
            this.groupLink.Name = "groupLink";
            this.groupLink.Size = new System.Drawing.Size(507, 144);
            this.groupLink.TabIndex = 0;
            this.groupLink.TabStop = false;
            this.groupLink.Text = "Links";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(70)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Righteous", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(469, 34);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(32, 32);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(70)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Righteous", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(469, 91);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(32, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // linkPanel
            // 
            this.linkPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.linkPanel.Location = new System.Drawing.Point(7, 20);
            this.linkPanel.Name = "linkPanel";
            this.linkPanel.Size = new System.Drawing.Size(456, 118);
            this.linkPanel.TabIndex = 0;
            // 
            // groupPomodoro
            // 
            this.groupPomodoro.BackColor = System.Drawing.Color.White;
            this.groupPomodoro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupPomodoro.Controls.Add(this.lblPomoDate);
            this.groupPomodoro.Controls.Add(this.btnReset);
            this.groupPomodoro.Controls.Add(this.btnStop);
            this.groupPomodoro.Controls.Add(this.btnPomoStart);
            this.groupPomodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupPomodoro.Font = new System.Drawing.Font("Righteous", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupPomodoro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(99)))), ((int)(((byte)(61)))));
            this.groupPomodoro.Location = new System.Drawing.Point(12, 145);
            this.groupPomodoro.Name = "groupPomodoro";
            this.groupPomodoro.Size = new System.Drawing.Size(215, 147);
            this.groupPomodoro.TabIndex = 2;
            this.groupPomodoro.TabStop = false;
            this.groupPomodoro.Text = "Pomodoro";
            // 
            // lblPomoDate
            // 
            this.lblPomoDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPomoDate.AutoSize = true;
            this.lblPomoDate.Font = new System.Drawing.Font("Righteous", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPomoDate.Location = new System.Drawing.Point(57, 46);
            this.lblPomoDate.Name = "lblPomoDate";
            this.lblPomoDate.Size = new System.Drawing.Size(97, 37);
            this.lblPomoDate.TabIndex = 1;
            this.lblPomoDate.Text = "25:00";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(70)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Righteous", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(145, 109);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(64, 32);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset\r\n";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(70)))));
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Font = new System.Drawing.Font("Righteous", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(75, 109);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(64, 32);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPomoStart
            // 
            this.btnPomoStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnPomoStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(70)))));
            this.btnPomoStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPomoStart.Font = new System.Drawing.Font("Righteous", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomoStart.Location = new System.Drawing.Point(5, 109);
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
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Righteous", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(593, 27);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(177, 61);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "<date>";
            // 
            // groupTask
            // 
            this.groupTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupTask.Font = new System.Drawing.Font("Righteous", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(99)))), ((int)(((byte)(61)))));
            this.groupTask.Location = new System.Drawing.Point(525, 145);
            this.groupTask.Name = "groupTask";
            this.groupTask.Size = new System.Drawing.Size(263, 297);
            this.groupTask.TabIndex = 3;
            this.groupTask.TabStop = false;
            this.groupTask.Text = "Tasks";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.groupTask);
            this.Controls.Add(this.groupPomodoro);
            this.Controls.Add(this.groupWelcome);
            this.Controls.Add(this.groupLink);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UPlans";
            this.Load += new System.EventHandler(this.main_Load);
            this.groupLink.ResumeLayout(false);
            this.groupPomodoro.ResumeLayout(false);
            this.groupPomodoro.PerformLayout();
            this.groupWelcome.ResumeLayout(false);
            this.groupWelcome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupLink;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.FlowLayoutPanel linkPanel;
        private System.Windows.Forms.GroupBox groupWelcome;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupPomodoro;
        private System.Windows.Forms.Label lblPomoDate;
        private System.Windows.Forms.Button btnPomoStart;
        private System.Windows.Forms.GroupBox groupTask;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStop;
    }
}

