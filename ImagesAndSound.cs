using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ImageAndSound_Project
{
    public partial class ImagesAndSound : Form
    {
        WelcomeForm welcome_obj = new WelcomeForm();
        public ImagesAndSound()
        {
            InitializeComponent();
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("ImageAndSound_Project.Resources.bullet-image.jpg");
            Bitmap bmp_Object = new Bitmap(myStream);
            PicBox_Images.Image = bmp_Object;

            //code to play soundwhen click on Load button  
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(ImageAndSound_Project.Properties.Resources.bullet_load);
            Sound_Object.Play();

            Btn_Spin.Enabled = true;
            Btn_Load.Enabled = false;
        }

        private void Btn_Spin_Click(object sender, EventArgs e)
        {
            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("ImageAndSound_Project.Resources.player-image1.jpg");
            Bitmap bmp_Object = new Bitmap(myStream);
            PicBox_Images.Image = bmp_Object;

            //code to play soundwhen click on Load button  
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(ImageAndSound_Project.Properties.Resources.barrel_spin);
            Sound_Object.Play();
        }

        private void Btn_Load_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L)
            {
                Btn_Load.PerformClick();
            }
        }


        private void btn_Exit_Click(object sender, EventArgs e)
        {

            welcome_obj.Show();

            this.Close();
        }
    }
}
