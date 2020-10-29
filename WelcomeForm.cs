using System;
using System.Windows.Forms;

namespace ImageAndSound_Project
{
    public partial class WelcomeForm : Form
    {
        InstructionForm ins_obj = new InstructionForm();
        ImagesAndSound game_obj = new ImagesAndSound();
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void Btn_rules_Click(object sender, EventArgs e)
        {
            ins_obj.Show();
        }

        private void Btn_Play_Click(object sender, EventArgs e)
        {
            this.Hide();
            ins_obj.Close();
            game_obj.ShowDialog();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
