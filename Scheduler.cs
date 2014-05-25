using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace OBScheduler
{
    public partial class Scheduler : Form
    {
        DateTime lastTime = new DateTime(1970,1,1);
        CultureInfo culture = new CultureInfo("en-GB");
        bool isTomorrow = false;
       
        public Scheduler()
        {
            InitializeComponent();
            startTime.Leave += new EventHandler(startTime_Leave);
            source.Leave += new EventHandler(source_Leave);
            url.Leave += new EventHandler(url_Leave);
            url.Enter += new EventHandler(url_Enter);
        }

        private void url_Leave(object sender, EventArgs e)
        {
            addToSchedule.Focus();
        }

        private void url_Enter(object sender, EventArgs e)
        {
            url.Text = "http://itanium:9000/audio/api/startshow";
        }

        private void source_Leave(object sender, System.EventArgs e)
        {
            if (source.Text == "IRN")
            {
                progTitle.Text = "News (IRN)";
            }
            if (source.Text == "SAM")
            {
                progTitle.Text = "Non-stop 105";
            }
        }

        private void startTime_Leave(object sender, System.EventArgs e)
        {
            try
            {
                if (!startTime.Text.Contains(':'))
                {
                    startTime.Text = startTime.Text.Insert((startTime.Text.Length-2),":");
                }
                DateTime MyDateTime = DateTime.Parse(startTime.Text,culture);
                startTime.ForeColor = Color.Black;
                if ((MyDateTime.Day == DateTime.Now.Day) && (isTomorrow == true))
                {
                    MyDateTime = MyDateTime.AddDays(1);
                }
                startTime.Text = MyDateTime.ToString(culture);
                if (MyDateTime != lastTime && lastTime.Year>2010)
                {
                    // The start time isn't the same as the last programme's end time, so we need to extend the last end time to match
                    scheduleList.Text = scheduleList.Text.Replace(lastTime.ToString(culture), MyDateTime.ToString(culture));
                }
            
            }
            catch (FormatException fe)
            {
                startTime.Text = "0";
                startTime.ForeColor = Color.Red;
            }
            source.Text = "Studio";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addToSchedule_Click(object sender, EventArgs e)
        {
            DateTime endTime = DateTime.Parse(startTime.Text,culture).AddHours(1);
            if (endTime.Minute == 2)
            {
                // Prevents IRN causing the next program to end at xx:02:04
                endTime = DateTime.Parse(startTime.Text,culture).AddSeconds(3476);
            }

            if (source.Text == "IRN")
            {
                DateTime startTimeIrn = DateTime.Parse(startTime.Text,culture);
                if (startTimeIrn.Second == 0)
                {
                    startTimeIrn = startTimeIrn.AddSeconds(-8);
                    // Subtract 8 secs from the previous show
                    scheduleList.Text = scheduleList.Text.Replace(startTime.Text,startTimeIrn.ToString(culture));
                }
                startTime.Text = startTimeIrn.ToString(culture);
                endTime = DateTime.Parse(startTime.Text,culture).AddSeconds(132); // 2 mins = 120 + 8 secs intro + 4 secs outro
            }
            DateTime startTimeDate = DateTime.Parse(startTime.Text, culture);
            if ((startTimeDate.Day != DateTime.Now.Day) && (isTomorrow == false))
            {
                // We should be dealing with tomorrow's schedule but we've lost the date somewhere
                isTomorrow = true;
            }
            else
            {
                isTomorrow = false;
            }
            scheduleList.AppendText("\r\n " + startTimeDate.ToString(culture) + "\t" + endTime.ToString(culture) + "\t" + source.Text + "\t" + progTitle.Text + "\t" + url.Text);
            startTime.Text = endTime.ToString(culture);
            progTitle.Text = "";
            source.Text = "Studio";
            url.Text = "";
            lastTime = endTime;
            startTime.Focus();
        }

        private void saveSchedule_Click(object sender, EventArgs e)
        {
            string xml = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n<schedule>\r\n";


            string[] scheduleLines = scheduleList.Text.Split('\n');
            foreach (string scheduleLine in scheduleLines)
            {
                if (scheduleLine.Length > 1)
                {
                    string[] scheduleLineInfo = scheduleLine.Split('\t');
                    string urlString = "";
                    if (scheduleLineInfo[4].Length > 1)
                    {
                        // There's a URL too
                        urlString = " url=\"" + scheduleLineInfo[4].Trim() + "\"";
                    }
                    xml = xml + "<program starttime=\"" + scheduleLineInfo[0].Trim() + "\" endtime=\"" + scheduleLineInfo[1] + "\" source=\"" + scheduleLineInfo[2].ToLower() + "\"" + urlString + ">" + scheduleLineInfo[3].Trim() + "</program>\r\n";
                }
            }
            xml = xml + "</schedule>";
            System.IO.File.WriteAllText(@"schedule.xml", xml);
            MainForm.schedule = MainForm.loadSchedule();
            this.Close();
        }
    }
}
