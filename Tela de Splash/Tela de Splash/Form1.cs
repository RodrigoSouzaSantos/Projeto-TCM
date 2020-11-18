using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_de_Splash
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            try
            {

                progressBar1.ForeColor = Color.Orange;

                if (progressBar1.Value < 100)
                {
                    
                    progressBar1.Value = progressBar1.Value + 1;
                    lblcontador.Text = progressBar1.Value.ToString();
                    lblcontador.Text = progressBar1.Value + "%";

                }
                else
                {

                    lblcontador.Text = progressBar1.Value.ToString();
                    timer1.Stop();
                    lblcontador.Text = progressBar1.Value + "%";


                    timer1.Dispose();

                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }   

        private void progressBar1_Click(object sender, EventArgs e)
        {
            
            progressBar1.Maximum = 100;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
