using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uni_proj
{
    
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.form1.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.name.Add(textBox1.Text);
            Form1.email.Add(textBox2.Text);
            Form1.Password.Add(textBox3.Text);
            Form1.id.Add(textBox4.Text);
            Form1.state.Add(textBox5.Text);
            Form1.Bdate.Add(textBox6.Text);
            MessageBox.Show("Data Added Successfully");

            Form1.form1.Show();
            this.Close();
        }
    }
}
