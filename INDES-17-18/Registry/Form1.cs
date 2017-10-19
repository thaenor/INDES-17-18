using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registry
{
    public partial class Registry : Form
    {
        public Registry()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fName = textBox1.Text.ToString();
            string lName = textBox2.Text.ToString();
            string lang = comboBox1.Text.ToString();
            string exp = "default";
            if (radioButton1.Checked)
            {
                exp = radioButton1.Text.ToString();
            }
            if (radioButton2.Checked)
            {
                exp = radioButton2.Text.ToString();
            }
            string date = dateTimePicker1.Value.ToString();

            richTextBox1.Text = richTextBox1.Text.ToString() + "\n" + fName + " - " + lName + " - " + lang + " - " + exp + " - " + date;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }
    }
}
