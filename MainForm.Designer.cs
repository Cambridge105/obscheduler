namespace OBScheduler
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ltLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.delay = new System.Windows.Forms.TextBox();
            this.stLabel = new System.Windows.Forms.Label();
            this.lt = new System.Windows.Forms.Label();
            this.st = new System.Windows.Forms.Label();
            this.clockTimer = new System.Windows.Forms.Timer(this.components);
            this.obSource = new System.Windows.Forms.Button();
            this.irn = new System.Windows.Forms.Button();
            this.sam = new System.Windows.Forms.Button();
            this.studio = new System.Windows.Forms.Button();
            this.leaseLabel = new System.Windows.Forms.Label();
            this.lease = new System.Windows.Forms.Label();
            this.delayButton = new System.Windows.Forms.Button();
            this.swTimer = new System.Windows.Forms.Timer(this.components);
            this.nowLabel = new System.Windows.Forms.Label();
            this.nextLabel = new System.Windows.Forms.Label();
            this.progNow = new System.Windows.Forms.Label();
            this.progNext = new System.Windows.Forms.Label();
            this.sourceLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.untilLabel = new System.Windows.Forms.Label();
            this.scheduleButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ltLabel
            // 
            this.ltLabel.AutoSize = true;
            this.ltLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ltLabel.Location = new System.Drawing.Point(101, 45);
            this.ltLabel.Name = "ltLabel";
            this.ltLabel.Size = new System.Drawing.Size(58, 13);
            this.ltLabel.TabIndex = 0;
            this.ltLabel.Text = "Local time:";
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(303, 45);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(102, 13);
            this.dLabel.TabIndex = 1;
            this.dLabel.Text = "Delay (milliseconds):";
            // 
            // delay
            // 
            this.delay.Location = new System.Drawing.Point(306, 64);
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(87, 20);
            this.delay.TabIndex = 2;
            this.delay.Text = "3000";
            // 
            // stLabel
            // 
            this.stLabel.AutoSize = true;
            this.stLabel.Location = new System.Drawing.Point(101, 104);
            this.stLabel.Name = "stLabel";
            this.stLabel.Size = new System.Drawing.Size(62, 13);
            this.stLabel.TabIndex = 3;
            this.stLabel.Text = "Studio time:";
            this.stLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lt
            // 
            this.lt.AutoSize = true;
            this.lt.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.lt.Location = new System.Drawing.Point(99, 57);
            this.lt.Name = "lt";
            this.lt.Size = new System.Drawing.Size(95, 30);
            this.lt.TabIndex = 4;
            this.lt.Text = "00:00:00";
            // 
            // st
            // 
            this.st.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.st.AutoSize = true;
            this.st.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.st.ForeColor = System.Drawing.SystemColors.Highlight;
            this.st.Location = new System.Drawing.Point(96, 117);
            this.st.Name = "st";
            this.st.Size = new System.Drawing.Size(158, 47);
            this.st.TabIndex = 5;
            this.st.Text = "00:00:00";
            // 
            // clockTimer
            // 
            this.clockTimer.Enabled = true;
            this.clockTimer.Interval = 1;
            this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
            // 
            // obSource
            // 
            this.obSource.BackColor = System.Drawing.Color.Silver;
            this.obSource.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.obSource.Location = new System.Drawing.Point(104, 4);
            this.obSource.Name = "obSource";
            this.obSource.Size = new System.Drawing.Size(75, 23);
            this.obSource.TabIndex = 6;
            this.obSource.Text = "OB Source";
            this.obSource.UseVisualStyleBackColor = false;
            // 
            // irn
            // 
            this.irn.BackColor = System.Drawing.Color.Silver;
            this.irn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.irn.Location = new System.Drawing.Point(203, 4);
            this.irn.Name = "irn";
            this.irn.Size = new System.Drawing.Size(75, 23);
            this.irn.TabIndex = 7;
            this.irn.Text = "IRN";
            this.irn.UseVisualStyleBackColor = false;
            // 
            // sam
            // 
            this.sam.BackColor = System.Drawing.Color.Silver;
            this.sam.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.sam.Location = new System.Drawing.Point(306, 4);
            this.sam.Name = "sam";
            this.sam.Size = new System.Drawing.Size(75, 23);
            this.sam.TabIndex = 8;
            this.sam.Text = "SAM";
            this.sam.UseVisualStyleBackColor = false;
            // 
            // studio
            // 
            this.studio.BackColor = System.Drawing.Color.Silver;
            this.studio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.studio.Location = new System.Drawing.Point(409, 4);
            this.studio.Name = "studio";
            this.studio.Size = new System.Drawing.Size(75, 23);
            this.studio.TabIndex = 9;
            this.studio.Text = "Studio";
            this.studio.UseVisualStyleBackColor = false;
            // 
            // leaseLabel
            // 
            this.leaseLabel.AutoSize = true;
            this.leaseLabel.Location = new System.Drawing.Point(303, 104);
            this.leaseLabel.Name = "leaseLabel";
            this.leaseLabel.Size = new System.Drawing.Size(87, 13);
            this.leaseLabel.TabIndex = 10;
            this.leaseLabel.Text = "Lease remaining:";
            // 
            // lease
            // 
            this.lease.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lease.AutoSize = true;
            this.lease.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lease.ForeColor = System.Drawing.Color.SlateGray;
            this.lease.Location = new System.Drawing.Point(297, 117);
            this.lease.Name = "lease";
            this.lease.Size = new System.Drawing.Size(172, 47);
            this.lease.TabIndex = 11;
            this.lease.Text = "-00:00:00";
            this.lease.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delayButton
            // 
            this.delayButton.Location = new System.Drawing.Point(409, 64);
            this.delayButton.Name = "delayButton";
            this.delayButton.Size = new System.Drawing.Size(75, 20);
            this.delayButton.TabIndex = 12;
            this.delayButton.Text = "Start";
            this.delayButton.UseVisualStyleBackColor = true;
            this.delayButton.Click += new System.EventHandler(this.delayButton_Click);
            // 
            // swTimer
            // 
            this.swTimer.Enabled = true;
            this.swTimer.Interval = 50;
            this.swTimer.Tick += new System.EventHandler(this.swTimer_Tick);
            // 
            // nowLabel
            // 
            this.nowLabel.AutoSize = true;
            this.nowLabel.Location = new System.Drawing.Point(6, 24);
            this.nowLabel.Name = "nowLabel";
            this.nowLabel.Size = new System.Drawing.Size(32, 13);
            this.nowLabel.TabIndex = 13;
            this.nowLabel.Text = "Now:";
            // 
            // nextLabel
            // 
            this.nextLabel.AutoSize = true;
            this.nextLabel.Location = new System.Drawing.Point(6, 47);
            this.nextLabel.Name = "nextLabel";
            this.nextLabel.Size = new System.Drawing.Size(32, 13);
            this.nextLabel.TabIndex = 14;
            this.nextLabel.Text = "Next:";
            // 
            // progNow
            // 
            this.progNow.AutoSize = true;
            this.progNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progNow.Location = new System.Drawing.Point(45, 24);
            this.progNow.Name = "progNow";
            this.progNow.Size = new System.Drawing.Size(126, 13);
            this.progNow.TabIndex = 15;
            this.progNow.Text = "Unknown Programme";
            this.progNow.UseMnemonic = false;
            // 
            // progNext
            // 
            this.progNext.AutoSize = true;
            this.progNext.Location = new System.Drawing.Point(109, 47);
            this.progNext.Name = "progNext";
            this.progNext.Size = new System.Drawing.Size(109, 13);
            this.progNext.TabIndex = 16;
            this.progNext.Text = "Unknown Programme";
            this.progNext.UseMnemonic = false;
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Location = new System.Drawing.Point(12, 8);
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(79, 13);
            this.sourceLabel.TabIndex = 17;
            this.sourceLabel.Text = "Current source:";
            this.sourceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.untilLabel);
            this.groupBox1.Controls.Add(this.scheduleButton);
            this.groupBox1.Controls.Add(this.progNext);
            this.groupBox1.Controls.Add(this.nextLabel);
            this.groupBox1.Controls.Add(this.nowLabel);
            this.groupBox1.Controls.Add(this.progNow);
            this.groupBox1.Location = new System.Drawing.Point(15, 200);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(469, 71);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Schedule";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(290, -22);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(183, 20);
            this.progressBar1.TabIndex = 19;
            // 
            // untilLabel
            // 
            this.untilLabel.AutoSize = true;
            this.untilLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.untilLabel.Location = new System.Drawing.Point(45, 47);
            this.untilLabel.Name = "untilLabel";
            this.untilLabel.Size = new System.Drawing.Size(49, 13);
            this.untilLabel.TabIndex = 18;
            this.untilLabel.Text = "00:00:00";
            // 
            // scheduleButton
            // 
            this.scheduleButton.Location = new System.Drawing.Point(369, 48);
            this.scheduleButton.Name = "scheduleButton";
            this.scheduleButton.Size = new System.Drawing.Size(100, 23);
            this.scheduleButton.TabIndex = 17;
            this.scheduleButton.Text = "Edit schedule...";
            this.scheduleButton.UseVisualStyleBackColor = true;
            this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(104, 175);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(380, 19);
            this.progressBar.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 284);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sourceLabel);
            this.Controls.Add(this.delayButton);
            this.Controls.Add(this.lease);
            this.Controls.Add(this.leaseLabel);
            this.Controls.Add(this.studio);
            this.Controls.Add(this.sam);
            this.Controls.Add(this.irn);
            this.Controls.Add(this.obSource);
            this.Controls.Add(this.st);
            this.Controls.Add(this.lt);
            this.Controls.Add(this.stLabel);
            this.Controls.Add(this.delay);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.ltLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Cambridge 105 - OB Scheduler";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ltLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.TextBox delay;
        private System.Windows.Forms.Label stLabel;
        private System.Windows.Forms.Label lt;
        private System.Windows.Forms.Label st;
        private System.Windows.Forms.Timer clockTimer;
        private System.Windows.Forms.Button obSource;
        private System.Windows.Forms.Button irn;
        private System.Windows.Forms.Button sam;
        private System.Windows.Forms.Button studio;
        private System.Windows.Forms.Label leaseLabel;
        private System.Windows.Forms.Label lease;
        private System.Windows.Forms.Button delayButton;
        private System.Windows.Forms.Timer swTimer;
        private System.Windows.Forms.Label nowLabel;
        private System.Windows.Forms.Label nextLabel;
        private System.Windows.Forms.Label progNow;
        private System.Windows.Forms.Label progNext;
        private System.Windows.Forms.Label sourceLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button scheduleButton;
        private System.Windows.Forms.Label untilLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

