using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FTCScoring
{
    public partial class Scoring : Form
    {
        String score;
        Random rand = new Random();
        int seconds = 30;
        int mins = 2;
        int transTime = 3;
        int counter = 0;

        int autoScore = 0;
        int teleScore = 0;
        int endScore = 0;
        int totalScore = 0;

        //Auto
        int prevHighAuto = 0;
        int prevMidAuto = 0;
        int prevLowAuto = 0;
        int prevPowerAuto = 0;

        //Tele
        int prevHighTele = 0;
        int prevMidTele = 0;
        int prevLowTele = 0;

        //End Game
        int prevRings = 0;
        int prevPower = 0;
        int prevLowEnd = 0;
        int prevMidEnd = 0;
        int prevHighEnd = 0;

        public Scoring()
        {
            InitializeComponent();
            label5.Text = "AutoScore: " + autoScore;
            label6.Text = "TeleScore: " + teleScore;
            label11.Text = "EndScore: " + endScore;
            label15.Text = "Total: " + totalScore;
            this.TopMost = true;
            Application.DoEvents();
            this.TopMost = false;
        }
        private void updateScores()
        {
            label5.Text = "AutoScore: " + autoScore;
            label6.Text = "TeleScore: " + teleScore;
            label11.Text = "EndScore: " + endScore;
            totalScore = autoScore + teleScore + endScore;
            label15.Text = "Total: " + totalScore;
        }
        private void checkLessThan(TextBox input)
        {
            if (input.TextLength < 1)
            {
                score = "0";
            }

        }
        private int parseScore(String score)
        {
            int yes = 0;
            if (score == null)
                return 0;
            if (Int32.TryParse(score, out yes))
                return Int32.Parse(score);
            else
                return 0;
        }

        private void addScore(Button subButton, int input, Label label)
        {
            label.Text = "" + input;
            if(input == 0)
            {
                subButton.Enabled = false;
            }
            else if(input > 0)
            {
                subButton.Enabled = true;
            }
            updateScores();
        }

        private void subtractScore(Button subButton, int input, Label label)
        {
            label.Text = "" + input;
            if (input == 0)
            {
                subButton.Enabled = false;
            }
            else if (input > 0)
            {
                subButton.Enabled = true;
            }
            updateScores();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button7.Enabled = false;
            button9.Enabled = false;
            button11.Enabled = false;
            button13.Enabled = false;
            button15.Enabled = false;
            button17.Enabled = false;
            button19.Enabled = false;
            button21.Enabled = false;
            button23.Enabled = false;
            timerStop.Enabled = false;
            mainScrn.BackColor = System.Drawing.Color.DarkRed;
            this.TopMost = true;
            Application.DoEvents();
            this.TopMost = false;
        }

        private void panel1_Paint(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                autoScore += 15;
                updateScores();
            }
            else
            {
                autoScore -= 15;
                updateScores();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                autoScore += 15;
                updateScores();
            }
            else
            {
                autoScore -= 15;
                updateScores();
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                autoScore += 5;
                updateScores();
            }
            else
            {
                autoScore -= 5;
                updateScores();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                endScore += 20;
                checkBox7.Enabled = false;
                updateScores();
            }
            else
            {
                endScore -= 20;
                checkBox7.Enabled = true;
                updateScores();
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                endScore += 20;
                checkBox4.Enabled = false;
                updateScores();
            }
            else
            {
                endScore -= 20;
                checkBox4.Enabled = true;
                updateScores();
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                endScore += 5;
                checkBox6.Enabled = false;
                updateScores();
            }
            else
            {
                endScore -= 5;
                checkBox6.Enabled = true;
                updateScores();
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                endScore += 5;
                checkBox5.Enabled = false;
                updateScores();
            }
            else
            {
                endScore -= 5;
                checkBox5.Enabled = true;
                updateScores();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prevHighAuto++;
            autoScore += 12;
            addScore(button2, prevHighAuto, label21);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            prevHighAuto--;
            autoScore -= 12;
            subtractScore(button2, prevHighAuto, label21);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            prevMidAuto--;
            autoScore -= 6;
            subtractScore(button3, prevMidAuto, label22);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            prevMidAuto++;
            autoScore += 6;
            addScore(button3, prevMidAuto, label22);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            prevLowAuto--;
            autoScore -= 3;
            subtractScore(button5, prevLowAuto, label23);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            prevLowAuto++;
            autoScore += 3;
            addScore(button5, prevLowAuto, label23);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            prevPowerAuto--;
            autoScore -= 15;
            subtractScore(button7, prevPowerAuto, label24);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            prevPowerAuto++;
            autoScore += 15;
            addScore(button7, prevPowerAuto, label24);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            prevHighTele--;
            teleScore -= 6;
            subtractScore(button13, prevHighTele, label27);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            prevHighTele++;
            teleScore += 6;
            addScore(button13, prevHighTele, label27);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            prevMidTele--;
            teleScore -= 4;
            subtractScore(button11, prevMidTele, label26);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            prevMidTele++;
            teleScore += 4;
            addScore(button11, prevMidTele, label26);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            prevLowTele--;
            teleScore -= 2;
            subtractScore(button9, prevLowTele, label25);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            prevLowTele++;
            teleScore += 2;
            addScore(button9, prevLowTele, label25);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            prevRings--;
            endScore -= 5;
            subtractScore(button15, prevRings, label28);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            prevRings++;
            endScore += 5;
            addScore(button15, prevRings, label28);
            System.IO.Stream str = Properties.Resources.monkeys1;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            prevPower--;
            endScore -= 15;
            subtractScore(button17, prevPower, label29);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            prevPower++;
            endScore += 15;
            addScore(button17, prevPower, label29);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            prevHighEnd--;
            endScore -= 6;
            subtractScore(button19, prevHighEnd, label30);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            prevHighEnd++;
            endScore += 6;
            addScore(button19, prevHighEnd, label30);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            prevMidEnd--;
            endScore -= 4;
            addScore(button21, prevMidEnd, label31);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            prevMidEnd++;
            endScore += 4;
            addScore(button21, prevMidEnd, label31);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            prevLowEnd--;
            endScore -= 2;
            addScore(button23, prevLowEnd, label32);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            prevLowEnd++;
            endScore += 2;
            addScore(button23, prevLowEnd, label32);
        }

        private void timerStart_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.Start;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            timerStop.Enabled = true;
            timerStart.Enabled = false;
            transitions.Start();
            randRings.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds--;
            if (seconds == 0 && mins == 2)
            {
                timer1.Stop();
                transitions.Start();
                System.IO.Stream str = Properties.Resources.Transition;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            if (seconds < 1)
            {
                seconds = 60;
            }
            if(seconds < 10)
            {
               timeLabel.Text = "Time: " + mins + ":0" + seconds;
            }
            else if(seconds == 60)
            {
                timeLabel.Text = "Time: " + mins + ":00";
                mins--;
            }
            else
            {
                timeLabel.Text = "Time: " + mins + ":" + seconds;
            }
            if (mins == 0 && seconds == 31)
            {
                System.IO.Stream str = Properties.Resources.Endgame;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            if(mins == 0 && seconds == 30)
            {
                curPeriod.Text = "Current Period: End Game";
            }


            if (mins == 0 && seconds == 1)
            {
                System.IO.Stream str = Properties.Resources.Finish;
                System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
                snd.Play();
            }
            if(mins < 0)
            {
                timer1.Stop();
                mins = 2;
                seconds = 30;
                timeLabel.Text = "Time: 2:30";
                timerStop.Enabled = false;
                timerStart.Enabled = true;
            }
        }

        private void randRings_Click(object sender, EventArgs e)
        {
            int gen = rand.Next(0, 100);
            if(gen>= 0 && gen <= 35)
            {
                ringAmount.Text = "0 Rings";
            }else if(gen >= 36 && gen <= 80)
            {
                ringAmount.Text = "1 Ring";
            }
            else
            {
                ringAmount.Text = "4 Rings";
            }
        }

        private void timerStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            transitions.Stop();
            mins = 2;
            seconds = 30;
            timeLabel.Text = "Time: 2:30";
            timeUntil.Text = "Time Until Next Round: 3";
            curPeriod.Text = "Current Period: None";
            transTime = 3;
            counter = 0;
            timerStop.Enabled = false;
            timerStart.Enabled = true;
            randRings.Enabled = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
            String tmpPdfFilePath = System.IO.Path.Combine(System.IO.Path.GetTempPath(), String.Format("{0}.pdf", System.IO.Path.GetTempFileName()));
            System.IO.File.WriteAllBytes(tmpPdfFilePath, Properties.Resources.scoring);
            axAcroPDF1.LoadFile(tmpPdfFilePath);
            mainScrn.BackColor = System.Drawing.Color.Maroon;
            scrnTwoBtn.BackColor = System.Drawing.Color.DarkRed;
        }

        private void mainScrn_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            scrnTwoBtn.BackColor = System.Drawing.Color.Maroon;
            mainScrn.BackColor = System.Drawing.Color.DarkRed;
        }

        private void transitions_Tick(object sender, EventArgs e)
        {
            curPeriod.Text = "Current Period: Transition";
            transTime--;
            timeUntil.Text = "Time Until Next Round: " + transTime;
            if (transTime == 0 && counter == 0)
            {
                transitions.Stop();
                timer1.Start();
                counter++;
                transTime = 8;
                curPeriod.Text = "Current Period: Auto";
            }else if(transTime == 0 && counter != 0)
            {
                transitions.Stop();
                timer1.Start();
                counter = 0;
                transTime = 3;
                curPeriod.Text = "Current Period: Teleop";
            }

        }

        private void axAcroPDF1_Enter(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}


