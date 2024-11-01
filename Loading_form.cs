using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiny_language_project
{
    public partial class Loading_form : Form
    {
        Form1 Editor=new Form1();   
        public Loading_form()
        {
            InitializeComponent();
            
        }

        private void Loading_form_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            Precentage_lb.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == 10)
            {
                Status_lb.Text = "Set Environment.";
            }
            else if (progressBar1.Value == 30)
            {
                Status_lb.Text = "repair compilers..";

            }
            else if (progressBar1.Value == 50)
            {
                Status_lb.Text = "repair compilers...";

            }
            else if (progressBar1.Value == 70)
            {
                Status_lb.Text = "repair Debuggers....";

            }
            else if (progressBar1.Value == 90)
            {
                Status_lb.Text = "repair text editor.....";

            }
            else if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                Editor.Show();
            }

        }

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
