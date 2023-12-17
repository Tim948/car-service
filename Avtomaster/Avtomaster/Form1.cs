using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avtomaster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private F12 Av;
        private void button2_Click(object sender, EventArgs e)
        {
            Av = new F12();
            Av.Visible = true;
        }
        private F10 A;
        private void button4_Click(object sender, EventArgs e)
        {
            A = new F10();
            A.Visible = true;

        }
        private F2 avto;
        private void button3_Click(object sender, EventArgs e)
        {
            avto = new F2();
            avto.Visible = true;
        }
        private F4 avt;
        private void button1_Click(object sender, EventArgs e)
        {
            avt = new F4();
            avt.Visible = true;
        }
        private F6 av;
        private void button6_Click(object sender, EventArgs e)
        {
            av = new F6();
            av.Visible = true;
        }
        private F8 a;
        private void button5_Click(object sender, EventArgs e)
        {
            a = new F8();
            a.Visible = true;
        }
    }
}
