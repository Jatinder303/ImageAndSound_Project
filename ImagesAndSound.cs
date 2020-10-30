using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ImageAndSound_Project
{
    public partial class ImagesAndSound : Form
    {

        LogicClass logic_obj = new LogicClass();
        public ImagesAndSound()
        {
            InitializeComponent();
        }

        private void Btn_Load_Click(object sender, EventArgs e)
        {
            logic_obj.load();

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
            MessageBox.Show(logic_obj.spin().ToString());

            //code to display image in picture box on button click  

            Assembly myAssembly = Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream("ImageAndSound_Project.Resources.player-image1.jpg");
            Bitmap bmp_Object = new Bitmap(myStream);
            PicBox_Images.Image = bmp_Object;

            //code to play soundwhen click on Load button  
            System.Media.SoundPlayer Sound_Object = new System.Media.SoundPlayer(ImageAndSound_Project.Properties.Resources.barrel_spin);
            Sound_Object.Play();
            Btn_Spin.Enabled = false;
            btn_shoot.Enabled = true;
            btn_shootAway.Enabled = true;
        }

        private void btn_shoot_Click(object sender, EventArgs e)
        {
            if (logic_obj.shoot() == 0)
            {
                MessageBox.Show("best of luck for next time");
            }
            else
            {
                MessageBox.Show("empty shoot");
            }
        }

        private void btn_shootAway_Click(object sender, EventArgs e)
        {
            if (logic_obj.chance < 2)
            {
                if (logic_obj.shoot() == 0)
                {
                    MessageBox.Show("You won the game");
                    btn_shoot.Enabled = false;
                    btn_shootAway.Enabled = false;
                }
                else
                {
                    logic_obj.chance++;
                    if (logic_obj.chance == 2)
                    {
                        MessageBox.Show("best of luck for next time");
                        btn_shoot.Enabled = false;
                        btn_shootAway.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("empty shoot");
                    }
                }
            }
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
            Application.Exit();
        }
    }
}
