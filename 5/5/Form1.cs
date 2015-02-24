using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5
{
    public partial class Form1 : Form
    {
        private List<Color> _colors;
        private int _chosenFilling = 0;

        public Form1()
        {
            InitializeComponent();
            _colors = new List<Color>()
            {
                Color.Red,
                Color.Yellow,
                Color.Blue
            };
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.Green;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackColor = _colors[_chosenFilling];
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _chosenFilling = ((ListBox) sender).SelectedIndex;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = 0;
        }

    }
}
