using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml;
using System.Globalization;
using System.Net;

namespace OBScheduler
{
    
    public partial class MainForm : Form
    {
        Stopwatch objStopWatch = new Stopwatch();
        bool paused = false;
        public static List<scheduleItem> schedule = loadSchedule();
            

        public enum RemoteSources
        {
            irn,
            ob,
            sam,
            studio
        }

        public class scheduleItem
        {
            public DateTime starttime;
            public DateTime endtime;
            public RemoteSources source;
            public string title;
            public string url;
            public bool urlSent = false;
        }

        
        
        public MainForm()
        {
            InitializeComponent();
            clockTimer.Interval = 200;
        }

        public static List<scheduleItem> loadSchedule()
        {

            CultureInfo culture = new CultureInfo("en-GB");
            List<scheduleItem> schedule = new List<scheduleItem>();
            
            XmlDocument scheduleFile = new XmlDocument();
            scheduleFile.Load("schedule.xml");
            XmlNodeList programs = scheduleFile.SelectNodes("//program");
            for (int i=0; i<programs.Count; i++)
            {
                scheduleItem tmpProg = new scheduleItem();
                XmlAttribute starttimeAttribute = (XmlAttribute)programs[i].Attributes.GetNamedItem("starttime");
                XmlAttribute endtimeAttribute = (XmlAttribute)programs[i].Attributes.GetNamedItem("endtime");
                XmlAttribute sourceAttribute = (XmlAttribute)programs[i].Attributes.GetNamedItem("source");
                XmlAttribute urlAttribute = (XmlAttribute)programs[i].Attributes.GetNamedItem("url");
                tmpProg.starttime = DateTime.Parse(starttimeAttribute.Value, culture);
                tmpProg.endtime = DateTime.Parse(endtimeAttribute.Value,culture);
                switch (sourceAttribute.Value) 
                {
                    case "irn": tmpProg.source = RemoteSources.irn; break;
                    case "ob": tmpProg.source = RemoteSources.ob; break;
                    case "sam": tmpProg.source = RemoteSources.sam; break;
                    case "studio": tmpProg.source = RemoteSources.studio; break;
                }
                tmpProg.title = programs[i].InnerText;
                if (urlAttribute != null)
                {
                    tmpProg.url = urlAttribute.Value;
                }
                schedule.Add(tmpProg);
            }


            return schedule;
        }
        
        
        private void clockTimer_Tick(object sender, EventArgs e)
        {
            lt.Text = DateTime.Now.ToString("HH:mm:ss");
            int obDelay = 0;
            try
            {
                obDelay = Convert.ToInt32(delay.Text);
            }
            catch (FormatException)
            {
                obDelay = 0;
            }
            DateTime studioTime = DateTime.Now.AddMilliseconds(obDelay);
            st.Text = studioTime.ToString("HH:mm:ss");
            checkSchedule(studioTime);
        }

        private void checkSchedule(DateTime studioTime)
        {
            for (int i=0; i<schedule.Count; i++)
            {
                scheduleItem thisProgramme = schedule[i];

                if ((studioTime < thisProgramme.endtime) && (studioTime >= thisProgramme.starttime))
                {
                    switchRemote(thisProgramme.source);
                    TimeSpan leaseRemainCalc = studioTime.Subtract(thisProgramme.endtime);
                    if (leaseRemainCalc.TotalSeconds > 0)
                    {
                        // The programme has already finished!
                        leaseRemainCalc = new TimeSpan(0, 0, 0);
                    }
                    int leaseRemaining = Convert.ToInt32(Math.Floor(leaseRemainCalc.TotalSeconds));
                    int leaseRemainingUnsigned = (leaseRemaining - leaseRemaining - leaseRemaining);
                    lease.Text = leaseRemainCalc.ToString(@"hh\:mm\:ss\.f");
                    TimeSpan progDuration = thisProgramme.endtime.Subtract(thisProgramme.starttime);
                    // The (leaseRemaining-leaseRemaining-leaseRemaining) ensures the negative number of secs ends up positive
                    int progDurationSecs = Convert.ToInt32(Math.Floor(progDuration.TotalSeconds));
                    decimal percentRemaining = Convert.ToDecimal(leaseRemainingUnsigned) / Convert.ToDecimal(progDurationSecs);
                    progressBar.Value = Convert.ToInt32(100 - percentRemaining*100);
                    if (leaseRemaining > -300 && thisProgramme.source == RemoteSources.ob)
                    {
                        lease.ForeColor = Color.DarkRed;
                    }
                    else
                    {
                        lease.ForeColor = Color.SlateGray;
                    }
                    progNow.Text = System.Net.WebUtility.HtmlDecode(thisProgramme.title);
                    untilLabel.Text = thisProgramme.endtime.ToString("HH:mm:ss");
                    if ((i + 1) < schedule.Count)
                    {
                        progNext.Text = System.Net.WebUtility.HtmlDecode(schedule[(i + 1)].title);
                        progNext.ForeColor = Color.Black;
                        if (leaseRemaining > -120 && schedule[(i + 1)].source == RemoteSources.ob)
                        {
                            lease.ForeColor = Color.ForestGreen;
                        }
                    }
                    else
                    {
                        progNext.Text = "Unknown programme (not in schedule)";
                        progNext.ForeColor = Color.Red;
                    }
                    if (thisProgramme.url != null && thisProgramme.url.Length>1 && thisProgramme.urlSent == false)
                    {
                        using (var wb = new WebClient())
                        {
                            try
                            {
                                wb.DownloadStringAsync(new Uri(thisProgramme.url));
                            }
                            catch (WebException)
                            {
                                // Do nothing
                            }
                            schedule[i].urlSent = true;
                        }
                    }
                }
            }
        }

        private void switchRemote(RemoteSources rs)
        {
            studio.BackColor = Color.Silver;
            irn.BackColor = Color.Silver;
            obSource.BackColor = Color.Silver;
            sam.BackColor = Color.Silver;
            switch (rs)
            {
                case RemoteSources.irn: irn.BackColor = Color.DarkOrange; break;
                case RemoteSources.studio: studio.BackColor = Color.ForestGreen; break;
                case RemoteSources.sam: sam.BackColor = Color.Orange; break;
                case RemoteSources.ob: obSource.BackColor = Color.Red; break;
            }

        }

        private void delayButton_Click(object sender, EventArgs e)
        {
            if (objStopWatch.IsRunning) 
            { 
                objStopWatch.Stop();
                delay.Modified = true;
                delayButton.Text = "Start";
                objStopWatch.Reset();
                st.Visible = true;
                lease.Visible = true;
            }
            else 
            {
                delay.Text = "0";
                objStopWatch.Start();
                delayButton.Text = "Stop";
                st.Visible = false;
                lease.Visible = false;
            }
        }

        private void swTimer_Tick(object sender, EventArgs e)
        {
            if (objStopWatch.IsRunning)
            {
                TimeSpan objTimeSpan = TimeSpan.FromMilliseconds(objStopWatch.ElapsedMilliseconds);
                delay.Text = Convert.ToInt32(objTimeSpan.TotalMilliseconds).ToString();
                if (paused)
                {
                    paused = false;
                }
            }
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            var openEditor = new Scheduler();
            openEditor.Show();
        } 
    }
}
