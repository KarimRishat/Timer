using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timer
{
    public partial class Form1 : Form
    {
        int s, m, h;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (h == 0 && m == 0 && s == 0)
            {
                timer1.Stop();
                panel2.Visible = false;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                CancelBut.Enabled = false;
                MessageBox.Show("Все!", "таймер все", MessageBoxButtons.OK);
            }
            s = s - 1;
            if (s == -1)
            {
                m = m - 1;
                s = 59;
            }
            if (m == -1)
            {
                h = h - 1;
                m = 59;
            }
            if (h==0&&m==0&&s==0)
            {
                timer1.Stop();
                panel2.Visible = false;
                button1.Visible = true;
                button2.Visible = false;
                button3.Visible = false;
                CancelBut.Enabled = false;
                MessageBox.Show("Все!", "таймер все", MessageBoxButtons.OK);                
            }
            slabel.Text = Convert.ToString(s);
            mLabel.Text = Convert.ToString(m);
            hLabel.Text = Convert.ToString(h);
        }

        private void CancelBut_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            panel2.Visible = false;
            button1.Visible = true;
            button2.Visible = false;
            CancelBut.Enabled = false;
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button2.Visible = false;
            button3.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button3.Visible = false;
            button2.Visible = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CancelBut.Enabled = true;
            s = Int32.Parse(textBox1.Text);
            m = Int32.Parse(textBox2.Text);
            h = Int32.Parse(textBox3.Text);
            slabel.Text = Convert.ToString(s);
            mLabel.Text = Convert.ToString(m);
            hLabel.Text = Convert.ToString(h);
            panel2.Visible = true;
            button1.Visible = false;
            button2.Visible = true;
            timer1.Start();
        }
    }
}
