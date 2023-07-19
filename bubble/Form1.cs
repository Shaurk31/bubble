using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bubble
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string userInput = richTextBox1.Text;

           label1.Text = userInput;

           richTextBox1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.AutoEllipsis = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string labelText = label1.Text;
            Clipboard.SetText(labelText);
        }
    }
}
