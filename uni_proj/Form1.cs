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
    public partial class Form1 : Form
    {   public static List<string> name = new List<string>();
        public static List<string> email = new List<string>();
        public static List<string> Password = new List<string>();
        public static List<string> id = new List<string>();
        public static List<string> state = new List<string>();
        public static List<string> Bdate = new List<string>();
        public static List<string> aus = new List<string>();
        public static List<string> apass = new List<string>();

        public static Form1 form1 = new Form1();
       
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aus.Add("mohammad@");
            aus.Add("aziz@");
            aus.Add("amro@");
            apass.Add("1234");
            apass.Add("12345");
            apass.Add("123456");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int foundUser = 0;
            for (int i = 0; i < email.Count; i++)
            {
                if (email[i] == textBox1.Text && Password[i] == textBox2.Text)
                {
                    
                    foundUser = 1;
                    break;
                }
            }
            for (int i = 0; i < aus.Count; i++)
            {
                if (aus[i] == textBox1.Text && apass[i] == textBox2.Text)
                {
                    
                    foundUser = 2;
                    break;
                }
            }
            
            if (foundUser == 1)
            {
                Form3 form3 = new Form3();
                form3.Show();
                form1 = this;
                this.Hide();

            }
            
            else if (foundUser == 2)
            {
                Form4 f4 = new Form4();
                f4.Show();
                form1 = this;
                this.Hide();

            }
            else
                MessageBox.Show("Invalid Login");
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
    }

