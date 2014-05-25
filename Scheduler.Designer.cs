namespace OBScheduler
{
    partial class Scheduler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scheduler));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.TextBox();
            this.source = new System.Windows.Forms.ComboBox();
            this.progTitle = new System.Windows.Forms.TextBox();
            this.addToSchedule = new System.Windows.Forms.Button();
            this.scheduleList = new System.Windows.Forms.TextBox();
            this.saveSchedule = new System.Windows.Forms.Button();
            this.urlLabel = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start time:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Programme name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Source:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(16, 244);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(125, 20);
            this.startTime.TabIndex = 1;
            // 
            // source
            // 
            this.source.FormattingEnabled = true;
            this.source.Items.AddRange(new object[] {
            "Studio",
            "OB",
            "SAM",
            "IRN"});
            this.source.Location = new System.Drawing.Point(147, 244);
            this.source.Name = "source";
            this.source.Size = new System.Drawing.Size(97, 21);
            this.source.TabIndex = 2;
            // 
            // progTitle
            // 
            this.progTitle.Location = new System.Drawing.Point(258, 243);
            this.progTitle.Name = "progTitle";
            this.progTitle.Size = new System.Drawing.Size(182, 20);
            this.progTitle.TabIndex = 3;
            // 
            // addToSchedule
            // 
            this.addToSchedule.Location = new System.Drawing.Point(457, 242);
            this.addToSchedule.Name = "addToSchedule";
            this.addToSchedule.Size = new System.Drawing.Size(34, 20);
            this.addToSchedule.TabIndex = 4;
            this.addToSchedule.Text = "Add";
            this.addToSchedule.UseVisualStyleBackColor = true;
            this.addToSchedule.Click += new System.EventHandler(this.addToSchedule_Click);
            // 
            // scheduleList
            // 
            this.scheduleList.Location = new System.Drawing.Point(13, 12);
            this.scheduleList.Multiline = true;
            this.scheduleList.Name = "scheduleList";
            this.scheduleList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.scheduleList.Size = new System.Drawing.Size(559, 197);
            this.scheduleList.TabIndex = 5;
            this.scheduleList.WordWrap = false;
            // 
            // saveSchedule
            // 
            this.saveSchedule.Location = new System.Drawing.Point(497, 242);
            this.saveSchedule.Name = "saveSchedule";
            this.saveSchedule.Size = new System.Drawing.Size(75, 20);
            this.saveSchedule.TabIndex = 6;
            this.saveSchedule.Text = "Save";
            this.saveSchedule.UseVisualStyleBackColor = true;
            this.saveSchedule.Click += new System.EventHandler(this.saveSchedule_Click);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Location = new System.Drawing.Point(16, 283);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(122, 13);
            this.urlLabel.TabIndex = 7;
            this.urlLabel.Text = "URL at programme start:";
            // 
            // url
            // 
            this.url.Location = new System.Drawing.Point(147, 280);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(293, 20);
            this.url.TabIndex = 5;
            // 
            // Scheduler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 308);
            this.Controls.Add(this.url);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.saveSchedule);
            this.Controls.Add(this.scheduleList);
            this.Controls.Add(this.addToSchedule);
            this.Controls.Add(this.progTitle);
            this.Controls.Add(this.source);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Scheduler";
            this.Text = "Schedule Editor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startTime;
        private System.Windows.Forms.ComboBox source;
        private System.Windows.Forms.TextBox progTitle;
        private System.Windows.Forms.Button addToSchedule;
        private System.Windows.Forms.TextBox scheduleList;
        private System.Windows.Forms.Button saveSchedule;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.TextBox url;
    }
}