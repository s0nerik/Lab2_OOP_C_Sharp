using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6
{
    public partial class Form1 : Form
    {
        private int _lastIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var l = new Label {Text = _lastIndex.ToString()};
            l.Font = new Font("Arial", 10f, FontStyle.Italic|FontStyle.Bold);
            l.Location = new Point(50, l.Height * _lastIndex + 24);
            l.Click += (o, args) =>
            {
                label2.Text = ((Label) o).Text;
            };

            Controls.Add(l);

            _lastIndex++;
        }
    }
}
