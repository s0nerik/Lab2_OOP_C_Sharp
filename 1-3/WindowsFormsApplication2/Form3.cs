using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form3 : Form
    {
        private readonly Form2 _parent;

        public Form3(Form2 parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            if (_parent != null) _parent.Close();
        }
    }
}
