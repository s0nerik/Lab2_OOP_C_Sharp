using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var labels = new List<Label>();
            foreach (var control in Controls)
            {
                if (control.GetType() == typeof(Label))
                {
                    labels.Add((Label) control);
                }
            }

            foreach (var label in labels)
            {
                Controls.Remove(label);
            }
        }
    }
}
