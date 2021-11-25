using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using YourRailWayLibrary;
using kursa4vasilev.Modules;

namespace kursa4vasilev
{
    public partial class Form1 : Form
    {
        Simulation S;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            S.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            S = new Simulation();
            S.label = label1;    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
