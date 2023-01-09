using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace creatingCaptchRubej
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            
            //pictureBox1.Image = Image.FromFile("images/1.png");
            //pictureBox2.Image = Image.FromFile("images/2.png");
            //pictureBox3.Image = Image.FromFile("images/3.png");
            //pictureBox4.Image = Image.FromFile("images/5.png");
            //pictureBox5.Image = Image.FromFile("images/6.png");
            //pictureBox6.Image = Image.FromFile("images/9.png");
            //pictureBox7.Image = Image.FromFile("images/4.png");
            //pictureBox8.Image = Image.FromFile("images/7.png");
            //pictureBox9.Image = Image.FromFile("images/8.png");
            
        }
        
        

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("CAPTHCA пройдена");
            
        }
        
    }
}
