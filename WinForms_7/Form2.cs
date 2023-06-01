using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_7
{
    public partial class Form2 : Form
    {
        private Form1 parent = null;
        public Form2(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            parent.ChildForm_TextChanged(this.textBox1.Text);
        }
    }
}
