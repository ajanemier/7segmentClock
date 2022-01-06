using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace _7SegmentClock
{
    public partial class Form1 : Form
    {
        Color LightsOn = ColorTranslator.FromHtml("#CD5C5C");
        Color LightsOff = ColorTranslator.FromHtml("#FFDAB9");


        Color backgroundColor = Color.Transparent;

        int flag = 1;
        string hourFormat = "hh";


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //for seconds
            string seconds = DateTime.Now.ToString("ss");

            int secondsOnes = Convert.ToInt32(seconds.Substring(1));
            int secondsTens = Convert.ToInt32(seconds.Remove(1, 1));

            //for minutes
            string minutes = DateTime.Now.ToString("mm");

            int minutesOnes = Convert.ToInt32(minutes.Substring(1));
            int minutesTens = Convert.ToInt32(minutes.Remove(1, 1));

            //for hours
            string hours = DateTime.Now.ToString(hourFormat);

            int hoursOnes = Convert.ToInt32(hours.Substring(1));
            int hoursTens = Convert.ToInt32(hours.Remove(1, 1));

            //AM or PM
            string meridiem = DateTime.Now.ToString("tt");

          

            //Calling the functions
            clock(secondsOnes, "Seconds", "Ones");
            clock(secondsTens, "Seconds", "Tens");

            clock(minutesOnes, "Minutes", "Ones");
            clock(minutesTens, "Minutes", "Tens");

            clock(hoursOnes, "Hours", "Ones");
            clock(hoursTens, "Hours", "Tens");


           
            Indicator(meridiem);
            

        }

        //for AM or PM indicators
        private void Indicator(string state)
        {
            if (state == "AM")
            {
                lblAMindicator.ForeColor = LightsOn;
                lblPMindicator.ForeColor = LightsOff;
            }
            else if (state == "PM")
            {
                lblAMindicator.ForeColor = LightsOff;
                lblPMindicator.ForeColor = LightsOn;
            }
        }

        private void lblDay_Click(object sender, EventArgs e)
        {
            lblDay.Text = DateTime.Now.ToString("ddd");
            lblDate.Text = DateTime.Now.ToString("MMM  dd,   yyyy");
        }


        private void clock(int num, string indicator, string placeValue)
        {
            switch (indicator)
            {
                case "Minutes":
                    switch (placeValue)
                    {
                        case "Ones":
                            switch (num)
                            {
                                case 0:
                                    btnMinutes8.BackColor = LightsOn;
                                    btnMinutes9.BackColor = LightsOn;
                                    btnMinutes10.BackColor = LightsOn;
                                    btnMinutes11.BackColor = LightsOff;
                                    btnMinutes12.BackColor = LightsOn;
                                    btnMinutes13.BackColor = LightsOn;
                                    btnMinutes14.BackColor = LightsOn;
                                    break;

                                case 1:
                                    btnMinutes8.BackColor = LightsOff;
                                    btnMinutes9.BackColor = LightsOff;
                                    btnMinutes10.BackColor = LightsOn;
                                    btnMinutes11.BackColor = LightsOff;
                                    btnMinutes12.BackColor = LightsOff;
                                    btnMinutes13.BackColor = LightsOn;
                                    btnMinutes14.BackColor = LightsOff;
                                    break;

                                case 2:
                                    btnMinutes8.BackColor = LightsOn;
                                    btnMinutes9.BackColor = LightsOff;
                                    btnMinutes10.BackColor = LightsOn;
                                    btnMinutes11.BackColor = LightsOn;
                                    btnMinutes12.BackColor = LightsOn;
                                    btnMinutes13.BackColor = LightsOff;
                                    btnMinutes14.BackColor = LightsOn;
                                    break;

                                case 3:
                                    btnMinutes8.BackColor = LightsOn;
                                    btnMinutes9.BackColor = LightsOff;
                                    btnMinutes10.BackColor = LightsOn;
                                    btnMinutes11.BackColor = LightsOn;
                                    btnMinutes12.BackColor = LightsOff;
                                    btnMinutes13.BackColor = LightsOn;
                                    btnMinutes14.BackColor = LightsOn;
                                    break;

                                case 4:
                                    btnMinutes8.BackColor = LightsOff;
                                    btnMinutes9.BackColor = LightsOn;
                                    btnMinutes10.BackColor = LightsOn;
                                    btnMinutes11.BackColor = LightsOn;
                                    btnMinutes12.BackColor = LightsOff;
                                    btnMinutes13.BackColor = LightsOn;
                                    btnMinutes14.BackColor = LightsOff;
                                    break;

                                case 5:
                                    btnMinutes8.BackColor = LightsOn;
                                    btnMinutes9.BackColor = LightsOn;
                                    btnMinutes10.BackColor = LightsOff;
                                    btnMinutes11.BackColor = LightsOn;
                                    btnMinutes12.BackColor = LightsOff;
                                    btnMinutes13.BackColor = LightsOn;
                                    btnMinutes14.BackColor = LightsOn;
                                    break;

                                case 6:
                                    btnMinutes8.BackColor = LightsOn;
                                    btnMinutes9.BackColor = LightsOn;
                                    btnMinutes10.BackColor = LightsOff;
                                    btnMinutes11.BackColor = LightsOn;
                                    btnMinutes12.BackColor = LightsOn;
                                    btnMinutes13.BackColor = LightsOn;
                                    btnMinutes14.BackColor = LightsOn;
                                    break;

                                case 7:
                                    btnMinutes8.BackColor = LightsOn;
                                    btnMinutes9.BackColor = LightsOff;
                                    btnMinutes10.BackColor = LightsOn;
                                    btnMinutes11.BackColor = LightsOff;
                                    btnMinutes12.BackColor = LightsOff;
                                    btnMinutes13.BackColor = LightsOn;
                                    btnMinutes14.BackColor = LightsOff;
                                    break;

                                case 8:
                                    btnMinutes8.BackColor = LightsOn;
                                    btnMinutes9.BackColor = LightsOn;
                                    btnMinutes10.BackColor = LightsOn;
                                    btnMinutes11.BackColor = LightsOn;
                                    btnMinutes12.BackColor = LightsOn;
                                    btnMinutes13.BackColor = LightsOn;
                                    btnMinutes14.BackColor = LightsOn;
                                    break;

                                case 9:
                                    btnMinutes8.BackColor = LightsOn;
                                    btnMinutes9.BackColor = LightsOn;
                                    btnMinutes10.BackColor = LightsOn;
                                    btnMinutes11.BackColor = LightsOn;
                                    btnMinutes12.BackColor = LightsOff;
                                    btnMinutes13.BackColor = LightsOn;
                                    btnMinutes14.BackColor = LightsOff;
                                    break;
                            }
                            break;

                        case "Tens":
                            switch (num)
                            {
                                case 0:
                                    btnMinutes1.BackColor = LightsOn;
                                    btnMinutes2.BackColor = LightsOn;
                                    btnMinutes3.BackColor = LightsOn;
                                    btnMinutes4.BackColor = LightsOff;
                                    btnMinutes5.BackColor = LightsOn;
                                    btnMinutes6.BackColor = LightsOn;
                                    btnMinutes7.BackColor = LightsOn;
                                    break;

                                case 1:
                                    btnMinutes1.BackColor = LightsOff;
                                    btnMinutes2.BackColor = LightsOff;
                                    btnMinutes3.BackColor = LightsOn;
                                    btnMinutes4.BackColor = LightsOff;
                                    btnMinutes5.BackColor = LightsOff;
                                    btnMinutes6.BackColor = LightsOn;
                                    btnMinutes7.BackColor = LightsOff;
                                    break;

                                case 2:
                                    btnMinutes1.BackColor = LightsOn;
                                    btnMinutes2.BackColor = LightsOff;
                                    btnMinutes3.BackColor = LightsOn;
                                    btnMinutes4.BackColor = LightsOn;
                                    btnMinutes5.BackColor = LightsOn;
                                    btnMinutes6.BackColor = LightsOff;
                                    btnMinutes7.BackColor = LightsOn;
                                    break;

                                case 3:
                                    btnMinutes1.BackColor = LightsOn;
                                    btnMinutes2.BackColor = LightsOff;
                                    btnMinutes3.BackColor = LightsOn;
                                    btnMinutes4.BackColor = LightsOn;
                                    btnMinutes5.BackColor = LightsOff;
                                    btnMinutes6.BackColor = LightsOn;
                                    btnMinutes7.BackColor = LightsOn;
                                    break;

                                case 4:
                                    btnMinutes1.BackColor = LightsOff;
                                    btnMinutes2.BackColor = LightsOn;
                                    btnMinutes3.BackColor = LightsOn;
                                    btnMinutes4.BackColor = LightsOn;
                                    btnMinutes5.BackColor = LightsOff;
                                    btnMinutes6.BackColor = LightsOn;
                                    btnMinutes7.BackColor = LightsOff;
                                    break;

                                case 5:
                                    btnMinutes1.BackColor = LightsOn;
                                    btnMinutes2.BackColor = LightsOn;
                                    btnMinutes3.BackColor = LightsOff;
                                    btnMinutes4.BackColor = LightsOn;
                                    btnMinutes5.BackColor = LightsOff;
                                    btnMinutes6.BackColor = LightsOn;
                                    btnMinutes7.BackColor = LightsOn;
                                    break;

                                case 6:
                                    btnMinutes1.BackColor = LightsOn;
                                    btnMinutes2.BackColor = LightsOn;
                                    btnMinutes3.BackColor = LightsOff;
                                    btnMinutes4.BackColor = LightsOn;
                                    btnMinutes5.BackColor = LightsOn;
                                    btnMinutes6.BackColor = LightsOn;
                                    btnMinutes7.BackColor = LightsOn;
                                    break;

                                case 7:
                                    btnMinutes1.BackColor = LightsOn;
                                    btnMinutes2.BackColor = LightsOff;
                                    btnMinutes3.BackColor = LightsOn;
                                    btnMinutes4.BackColor = LightsOff;
                                    btnMinutes5.BackColor = LightsOff;
                                    btnMinutes6.BackColor = LightsOn;
                                    btnMinutes7.BackColor = LightsOff;
                                    break;

                                case 8:
                                    btnMinutes1.BackColor = LightsOn;
                                    btnMinutes2.BackColor = LightsOn;
                                    btnMinutes3.BackColor = LightsOn;
                                    btnMinutes4.BackColor = LightsOn;
                                    btnMinutes5.BackColor = LightsOn;
                                    btnMinutes6.BackColor = LightsOn;
                                    btnMinutes7.BackColor = LightsOn;
                                    break;

                                case 9:
                                    btnMinutes1.BackColor = LightsOn;
                                    btnMinutes2.BackColor = LightsOn;
                                    btnMinutes3.BackColor = LightsOn;
                                    btnMinutes4.BackColor = LightsOn;
                                    btnMinutes5.BackColor = LightsOff;
                                    btnMinutes6.BackColor = LightsOn;
                                    btnMinutes7.BackColor = LightsOff;
                                    break;
                            }
                            break;
                    }
                    break;


                case "Hours":
                    switch (placeValue)
                    {
                        case "Ones":
                            switch (num)
                            {
                                case 0:
                                    btnHr8.BackColor = LightsOn;
                                    btnHr9.BackColor = LightsOn;
                                    btnHr10.BackColor = LightsOn;
                                    btnHr11.BackColor = LightsOff;
                                    btnHr12.BackColor = LightsOn;
                                    btnHr13.BackColor = LightsOn;
                                    btnHr14.BackColor = LightsOn;
                                    break;

                                case 1:
                                    btnHr8.BackColor = LightsOff;
                                    btnHr9.BackColor = LightsOff;
                                    btnHr10.BackColor = LightsOn;
                                    btnHr11.BackColor = LightsOff;
                                    btnHr12.BackColor = LightsOff;
                                    btnHr13.BackColor = LightsOn;
                                    btnHr14.BackColor = LightsOff;
                                    break;

                                case 2:
                                    btnHr8.BackColor = LightsOn;
                                    btnHr9.BackColor = LightsOff;
                                    btnHr10.BackColor = LightsOn;
                                    btnHr11.BackColor = LightsOn;
                                    btnHr12.BackColor = LightsOn;
                                    btnHr13.BackColor = LightsOff;
                                    btnHr14.BackColor = LightsOn;
                                    break;

                                case 3:
                                    btnHr8.BackColor = LightsOn;
                                    btnHr9.BackColor = LightsOff;
                                    btnHr10.BackColor = LightsOn;
                                    btnHr11.BackColor = LightsOn;
                                    btnHr12.BackColor = LightsOff;
                                    btnHr13.BackColor = LightsOn;
                                    btnHr14.BackColor = LightsOn;
                                    break;

                                case 4:
                                    btnHr8.BackColor = LightsOff;
                                    btnHr9.BackColor = LightsOn;
                                    btnHr10.BackColor = LightsOn;
                                    btnHr11.BackColor = LightsOn;
                                    btnHr12.BackColor = LightsOff;
                                    btnHr13.BackColor = LightsOn;
                                    btnHr14.BackColor = LightsOff;
                                    break;

                                case 5:
                                    btnHr8.BackColor = LightsOn;
                                    btnHr9.BackColor = LightsOn;
                                    btnHr10.BackColor = LightsOff;
                                    btnHr11.BackColor = LightsOn;
                                    btnHr12.BackColor = LightsOff;
                                    btnHr13.BackColor = LightsOn;
                                    btnHr14.BackColor = LightsOn;
                                    break;

                                case 6:
                                    btnHr8.BackColor = LightsOn;
                                    btnHr9.BackColor = LightsOn;
                                    btnHr10.BackColor = LightsOff;
                                    btnHr11.BackColor = LightsOn;
                                    btnHr12.BackColor = LightsOn;
                                    btnHr13.BackColor = LightsOn;
                                    btnHr14.BackColor = LightsOn;
                                    break;

                                case 7:
                                    btnHr8.BackColor = LightsOn;
                                    btnHr9.BackColor = LightsOff;
                                    btnHr10.BackColor = LightsOn;
                                    btnHr11.BackColor = LightsOff;
                                    btnHr12.BackColor = LightsOff;
                                    btnHr13.BackColor = LightsOn;
                                    btnHr14.BackColor = LightsOff;
                                    break;

                                case 8:
                                    btnHr8.BackColor = LightsOn;
                                    btnHr9.BackColor = LightsOn;
                                    btnHr10.BackColor = LightsOn;
                                    btnHr11.BackColor = LightsOn;
                                    btnHr12.BackColor = LightsOn;
                                    btnHr13.BackColor = LightsOn;
                                    btnHr14.BackColor = LightsOn;
                                    break;

                                case 9:
                                    btnHr8.BackColor = LightsOn;
                                    btnHr9.BackColor = LightsOn;
                                    btnHr10.BackColor = LightsOn;
                                    btnHr11.BackColor = LightsOn;
                                    btnHr12.BackColor = LightsOff;
                                    btnHr13.BackColor = LightsOn;
                                    btnHr14.BackColor = LightsOff;
                                    break;
                            }
                            break;

                        case "Tens":
                            switch (num)
                            {
                                case 0:
                                    btnHr1.BackColor = LightsOn;
                                    btnHr2.BackColor = LightsOn;
                                    btnHr3.BackColor = LightsOn;
                                    btnHr4.BackColor = LightsOff;
                                    btnHr5.BackColor = LightsOn;
                                    btnHr6.BackColor = LightsOn;
                                    btnHr7.BackColor = LightsOn;
                                    break;

                                case 1:
                                    btnHr1.BackColor = LightsOff;
                                    btnHr2.BackColor = LightsOff;
                                    btnHr3.BackColor = LightsOn;
                                    btnHr4.BackColor = LightsOff;
                                    btnHr5.BackColor = LightsOff;
                                    btnHr6.BackColor = LightsOn;
                                    btnHr7.BackColor = LightsOff;
                                    break;

                                case 2:
                                    btnHr1.BackColor = LightsOn;
                                    btnHr2.BackColor = LightsOff;
                                    btnHr3.BackColor = LightsOn;
                                    btnHr4.BackColor = LightsOn;
                                    btnHr5.BackColor = LightsOn;
                                    btnHr6.BackColor = LightsOff;
                                    btnHr7.BackColor = LightsOn;
                                    break;

                                case 3:
                                    btnHr1.BackColor = LightsOn;
                                    btnHr2.BackColor = LightsOff;
                                    btnHr3.BackColor = LightsOn;
                                    btnHr4.BackColor = LightsOn;
                                    btnHr5.BackColor = LightsOff;
                                    btnHr6.BackColor = LightsOn;
                                    btnHr7.BackColor = LightsOn;
                                    break;

                                case 4:
                                    btnHr1.BackColor = LightsOff;
                                    btnHr2.BackColor = LightsOn;
                                    btnHr3.BackColor = LightsOn;
                                    btnHr4.BackColor = LightsOn;
                                    btnHr5.BackColor = LightsOff;
                                    btnHr6.BackColor = LightsOn;
                                    btnHr7.BackColor = LightsOff;
                                    break;

                                case 5:
                                    btnHr1.BackColor = LightsOn;
                                    btnHr2.BackColor = LightsOn;
                                    btnHr3.BackColor = LightsOff;
                                    btnHr4.BackColor = LightsOn;
                                    btnHr5.BackColor = LightsOff;
                                    btnHr6.BackColor = LightsOn;
                                    btnHr7.BackColor = LightsOn;
                                    break;

                                case 6:
                                    btnHr1.BackColor = LightsOn;
                                    btnHr2.BackColor = LightsOn;
                                    btnHr3.BackColor = LightsOff;
                                    btnHr4.BackColor = LightsOn;
                                    btnHr5.BackColor = LightsOn;
                                    btnHr6.BackColor = LightsOn;
                                    btnHr7.BackColor = LightsOn;
                                    break;

                                case 7:
                                    btnHr1.BackColor = LightsOn;
                                    btnHr2.BackColor = LightsOff;
                                    btnHr3.BackColor = LightsOn;
                                    btnHr4.BackColor = LightsOff;
                                    btnHr5.BackColor = LightsOff;
                                    btnHr6.BackColor = LightsOn;
                                    btnHr7.BackColor = LightsOff;
                                    break;

                                case 8:
                                    btnHr1.BackColor = LightsOn;
                                    btnHr2.BackColor = LightsOn;
                                    btnHr3.BackColor = LightsOn;
                                    btnHr4.BackColor = LightsOn;
                                    btnHr5.BackColor = LightsOn;
                                    btnHr6.BackColor = LightsOn;
                                    btnHr7.BackColor = LightsOn;
                                    break;

                                case 9:
                                    btnHr1.BackColor = LightsOn;
                                    btnHr2.BackColor = LightsOn;
                                    btnHr3.BackColor = LightsOn;
                                    btnHr4.BackColor = LightsOn;
                                    btnHr5.BackColor = LightsOff;
                                    btnHr6.BackColor = LightsOn;
                                    btnHr7.BackColor = LightsOff;
                                    break;
                            }
                            break;
                    }
                    break;

                case "Seconds":
                    switch (placeValue)
                    {
                        case "Ones":
                            switch (num)
                            {
                                case 0:
                                    btnSeconds8.BackColor = LightsOn ;
                                    btnSeconds9.BackColor = LightsOn ;
                                    btnSeconds10.BackColor = LightsOn ;
                                    btnSeconds11.BackColor = LightsOff ; 
                                    btnSeconds12.BackColor = LightsOn ;
                                    btnSeconds13.BackColor = LightsOn ;
                                    btnSeconds14.BackColor = LightsOn ;
                                    break;

                                case 1:
                                    btnSeconds8.BackColor = LightsOff ;
                                    btnSeconds9.BackColor = LightsOff ;
                                    btnSeconds10.BackColor = LightsOn ;
                                    btnSeconds11.BackColor = LightsOff ;
                                    btnSeconds12.BackColor = LightsOff ;
                                    btnSeconds13.BackColor = LightsOn ;
                                    btnSeconds14.BackColor = LightsOff ;
                                    break;

                                case 2:
                                    btnSeconds8.BackColor = LightsOn ;
                                    btnSeconds9.BackColor = LightsOff ;
                                    btnSeconds10.BackColor = LightsOn ;
                                    btnSeconds11.BackColor = LightsOn ;
                                    btnSeconds12.BackColor = LightsOn ;
                                    btnSeconds13.BackColor = LightsOff ;
                                    btnSeconds14.BackColor = LightsOn ;
                                    break;

                                case 3:
                                    btnSeconds8.BackColor = LightsOn ;
                                    btnSeconds9.BackColor = LightsOff ;
                                    btnSeconds10.BackColor = LightsOn ;
                                    btnSeconds11.BackColor = LightsOn ;
                                    btnSeconds12.BackColor = LightsOff ;
                                    btnSeconds13.BackColor = LightsOn ;
                                    btnSeconds14.BackColor = LightsOn ;
                                    break;

                                case 4:
                                    btnSeconds8.BackColor = LightsOff ;
                                    btnSeconds9.BackColor = LightsOn ;
                                    btnSeconds10.BackColor = LightsOn ;
                                    btnSeconds11.BackColor = LightsOn ;
                                    btnSeconds12.BackColor = LightsOff ;
                                    btnSeconds13.BackColor = LightsOn ;
                                    btnSeconds14.BackColor = LightsOff ;
                                    break;

                                case 5:
                                    btnSeconds8.BackColor = LightsOn ;
                                    btnSeconds9.BackColor = LightsOn ;
                                    btnSeconds10.BackColor = LightsOff ;
                                    btnSeconds11.BackColor = LightsOn ;
                                    btnSeconds12.BackColor = LightsOff ;
                                    btnSeconds13.BackColor = LightsOn ;
                                    btnSeconds14.BackColor = LightsOn ;
                                    break;

                                case 6:
                                    btnSeconds8.BackColor = LightsOn ;
                                    btnSeconds9.BackColor = LightsOn ;
                                    btnSeconds10.BackColor = LightsOff ;
                                    btnSeconds11.BackColor = LightsOn ;
                                    btnSeconds12.BackColor = LightsOn ;
                                    btnSeconds13.BackColor = LightsOn ;
                                    btnSeconds14.BackColor = LightsOn ;
                                    break;

                                case 7:
                                    btnSeconds8.BackColor = LightsOn ;
                                    btnSeconds9.BackColor = LightsOff ;
                                    btnSeconds10.BackColor = LightsOn ;
                                    btnSeconds11.BackColor = LightsOff ;
                                    btnSeconds12.BackColor = LightsOff ;
                                    btnSeconds13.BackColor = LightsOn ;
                                    btnSeconds14.BackColor = LightsOff ;
                                    break;

                                case 8:
                                    btnSeconds8.BackColor = LightsOn ;
                                    btnSeconds9.BackColor = LightsOn ;
                                    btnSeconds10.BackColor = LightsOn ;
                                    btnSeconds11.BackColor = LightsOn ;
                                    btnSeconds12.BackColor = LightsOn ;
                                    btnSeconds13.BackColor = LightsOn ;
                                    btnSeconds14.BackColor = LightsOn ;
                                    break;

                                case 9:
                                    btnSeconds8.BackColor = LightsOn ;
                                    btnSeconds9.BackColor = LightsOn ;
                                    btnSeconds10.BackColor = LightsOn ;
                                    btnSeconds11.BackColor = LightsOn ;
                                    btnSeconds12.BackColor = LightsOff ;
                                    btnSeconds13.BackColor = LightsOn ;
                                    btnSeconds14.BackColor = LightsOff ;
                                    break;
                            }
                            break;

                        case "Tens":
                            switch (num)
                            {
                                case 0:
                                    btnSeconds1.BackColor = LightsOn ;
                                    btnSeconds2.BackColor = LightsOn ;
                                    btnSeconds3.BackColor = LightsOn ;
                                    btnSeconds4.BackColor = LightsOff ;
                                    btnSeconds5.BackColor = LightsOn ;
                                    btnSeconds6.BackColor = LightsOn ;
                                    btnSeconds7.BackColor = LightsOn ;
                                    break;

                                case 1:
                                    btnSeconds1.BackColor = LightsOff ;
                                    btnSeconds2.BackColor = LightsOff ;
                                    btnSeconds3.BackColor = LightsOn ;
                                    btnSeconds4.BackColor = LightsOff ;
                                    btnSeconds5.BackColor = LightsOff ;
                                    btnSeconds6.BackColor = LightsOn ;
                                    btnSeconds7.BackColor = LightsOff ;
                                    break;

                                case 2:
                                    btnSeconds1.BackColor = LightsOn ;
                                    btnSeconds2.BackColor = LightsOff ;
                                    btnSeconds3.BackColor = LightsOn ;
                                    btnSeconds4.BackColor = LightsOn ;
                                    btnSeconds5.BackColor = LightsOn ;
                                    btnSeconds6.BackColor = LightsOff ;
                                    btnSeconds7.BackColor = LightsOn ;
                                    break;

                                case 3:
                                    btnSeconds1.BackColor = LightsOn ;
                                    btnSeconds2.BackColor = LightsOff ;
                                    btnSeconds3.BackColor = LightsOn ;
                                    btnSeconds4.BackColor = LightsOn ;
                                    btnSeconds5.BackColor = LightsOff ;
                                    btnSeconds6.BackColor = LightsOn ;
                                    btnSeconds7.BackColor = LightsOn ;
                                    break;

                                case 4:
                                    btnSeconds1.BackColor = LightsOff ;
                                    btnSeconds2.BackColor = LightsOn ;
                                    btnSeconds3.BackColor = LightsOn ;
                                    btnSeconds4.BackColor = LightsOn ;
                                    btnSeconds5.BackColor = LightsOff ;
                                    btnSeconds6.BackColor = LightsOn ;
                                    btnSeconds7.BackColor = LightsOff ;
                                    break;

                                case 5:
                                    btnSeconds1.BackColor = LightsOn ;
                                    btnSeconds2.BackColor = LightsOn ;
                                    btnSeconds3.BackColor = LightsOff ;
                                    btnSeconds4.BackColor = LightsOn ;
                                    btnSeconds5.BackColor = LightsOff ;
                                    btnSeconds6.BackColor = LightsOn ;
                                    btnSeconds7.BackColor = LightsOn ;
                                    break;

                                case 6:
                                    btnSeconds1.BackColor = LightsOn ;
                                    btnSeconds2.BackColor = LightsOn ;
                                    btnSeconds3.BackColor = LightsOff ;
                                    btnSeconds4.BackColor = LightsOn ;
                                    btnSeconds5.BackColor = LightsOn ;
                                    btnSeconds6.BackColor = LightsOn ;
                                    btnSeconds7.BackColor = LightsOn ;
                                    break;

                                case 7:
                                    btnSeconds1.BackColor = LightsOn ;
                                    btnSeconds2.BackColor = LightsOff ;
                                    btnSeconds3.BackColor = LightsOn ;
                                    btnSeconds4.BackColor = LightsOff ;
                                    btnSeconds5.BackColor = LightsOff ;
                                    btnSeconds6.BackColor = LightsOn ;
                                    btnSeconds7.BackColor = LightsOff ;
                                    break;

                                case 8:
                                    btnSeconds1.BackColor = LightsOn ;
                                    btnSeconds2.BackColor = LightsOn ;
                                    btnSeconds3.BackColor = LightsOn ;
                                    btnSeconds4.BackColor = LightsOn ;
                                    btnSeconds5.BackColor = LightsOn ;
                                    btnSeconds6.BackColor = LightsOn ;
                                    btnSeconds7.BackColor = LightsOn ;
                                    break;

                                case 9:
                                    btnSeconds1.BackColor = LightsOn ;
                                    btnSeconds2.BackColor = LightsOn ;
                                    btnSeconds3.BackColor = LightsOn ;
                                    btnSeconds4.BackColor = LightsOn ;
                                    btnSeconds5.BackColor = LightsOff ;
                                    btnSeconds6.BackColor = LightsOn ;
                                    btnSeconds7.BackColor = LightsOff ;
                                    break;
                            }
                            break;
                    }
                    break;

                
                

                default:
                    break;
            }

        }

       





    }
}