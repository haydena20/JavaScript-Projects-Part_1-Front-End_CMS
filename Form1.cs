using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JavaScript_Projects_Part_1_Front_End_CMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            foreach(KnownColor color in Enum.GetValues(typeof(KnownColor)))
            {
                comboBox1.Items.Add(color);
                comboBox2.Items.Add(color);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            checkValid();
        }
        private void checkValid()
        {
            if ( textBox1.Text.Length != 0 && 
                 textBox2.Text.Length != 0 && 
                 richTextBox1.Text.Length != 0 && 
                 comboBox1.SelectedIndex != -1 && 
                 comboBox2.SelectedIndex != -1 )
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            checkValid();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            checkValid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_TabIndexChanged(object sender, EventArgs e)
        {
            checkValid();
        }

        private void comboBox2_TabIndexChanged(object sender, EventArgs e)
        {
            checkValid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RichTextBox entry = new RichTextBox();
            entry.Text = $"{textBox1.Text} - {dateTimePicker1.Value} \n Posted by {textBox2.Text} \n\n{richTextBox1.Text}";
            entry.Width = (int) (flowLayoutPanel1.Width * 0.48);
            entry.ForeColor = Color.FromName(comboBox1.Text);
            entry.BackColor = Color.FromName(comboBox2.Text);

            flowLayoutPanel1.Controls.Add(entry);
        }
    }
}
