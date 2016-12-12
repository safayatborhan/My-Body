using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;

namespace My_Body
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer talking = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();

            talking.Rate = -6;
            talking.Volume = 100;
            talking.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Child);
        }
      
        private void labelEye2_Click(object sender, EventArgs e)
        {
            labelPartNames.Text = "Eye";
            label2.Image = Image.FromFile("newaup3.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labelMouth_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Mouth";
            label2.Image = Image.FromFile("comic-fi_158.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelhair_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Head";
            label2.Image = Image.FromFile("h90.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labelnose_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Nose";
            label2.Image = Image.FromFile("cgwillamena_e0.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labeleyebrow1_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Eyebrow";
            label2.Image = Image.FromFile("newaup3.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labeleyebrow2_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Eyebrow";
            label2.Image = Image.FromFile("newaup3.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labelforhead_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Forhead";
            label2.Image = Image.FromFile("h90.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labelear1_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Ear";
            label2.Image = Image.FromFile("spookje.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labelear2_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Ear";
            label2.Image = Image.FromFile("spookje.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labelthroat_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Throat";
            label2.Image = Image.FromFile("co120.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labelshoulder1_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Shoulder";
            label2.Image = Image.FromFile("co120.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labelshoulder2_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Shoulder";
            label2.Image = Image.FromFile("co120.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labelchest_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Chest";
            label2.Image = Image.FromFile("spookje.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labelarm1_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Arm";
            label2.Image = Image.FromFile("gohanx.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labelarm2_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Arm";
            label2.Image = Image.FromFile("gohanx.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labelhand1_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Hand";
            label2.Image = Image.FromFile("alice006.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labelhand2_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Hand";
            label2.Image = Image.FromFile("alice006.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labelcheek1_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Cheek";
            label2.Image = Image.FromFile("bubgum.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labelcheek2_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Cheek";
            label2.Image = Image.FromFile("bubgum.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labelstomach_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Stomach";
            label2.Image = Image.FromFile("spookje.gif");
            talking.Speak(labelPartNames.Text);
            
        }

        private void labelbelly_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Belly";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("spookje.gif");
        }

        private void labelelbow1_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Elbow";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("An446.gif");
        }

        private void labelelbow2_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Elbow";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("An446.gif");
        }

        private void labelhair1_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Hair";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("h90.gif");
        }

        private void labelhair2_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Hair";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("h90.gif");
        }

        private void labelwrist1_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Wrist";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("Hand-02-june.gif");
        }

        private void labelwrist2_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Wrist";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("Hand-02-june.gif");
        }

        private void labelfinger1_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Finger";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("An446.gif");
        }

        private void labelfinger2_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Finger";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("An446.gif");
        }

        private void labelleg1_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Leg";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("ysport153.gif");
        }

        private void labelleg2_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Leg";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("ysport153.gif");
        }

        private void labelleg3_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Leg";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("ysport153.gif");
        }

        private void labelknee1_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Knee";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("ysport153.gif");
        }

        private void labelknee2_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Knee";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("ysport153.gif");
        }

        private void labelankle1_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Ankle";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("ysport153.gif");
        }

        private void labelankle2_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Ankle";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("ysport153.gif");
        }

        private void labeltoe1_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Toe";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("ysport153.gif");
        }

        private void labeltoe2_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Toe";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("ysport153.gif");
        }

        private void labelleg0_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Leg";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("ysport153.gif");
        }

        private void labelwaist_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Waist";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("spookje.gif");
        }

        private void labelleg1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelwrist2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Safayat Borhan Zisan.\nDept. of CSE,\nMawlana Bhashani Science and Technology University\nSantosh,Tangail.\nContact No.: 01772952813\nEmail:zisan_cse_mbstu@hotmail.com\nID: CE13024");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application is for children.\nThey can teach themselves about the parts of body\nby clicking randomly\n\nSYSTEM REQUIREMENT: Windows 7 or 8.");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Heart";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("Moving-picture-heart-beating-gif-animation.gif");
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            labelPartNames.Text = "Lung";
            talking.Speak(labelPartNames.Text);
            label2.Image = Image.FromFile("Moving-picture-breathing-lungs-animated-gif.gif");
        }

    }
}
