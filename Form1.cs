using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Charlie_Elize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            double Mobile;
            string Name;
            string Email;
            string Surname;
            string Date;
            string Time1;
            string Time2;
            string Time;
            string Meeting;

            Name = textBox1Name.Text;
            Surname = textBox2Surname.Text;
            Mobile = double.Parse(textBox3Mobile.Text);
            Email = textBox4Email.Text;
            Date = dateTimePicker1.Text;
            Time1 = Convert.ToString(numericUpDown1);
            Time2 = Convert.ToString(numericUpDown2);
            Time = Convert.ToInt32 (Time1, Time2);
            Meeting = comboBox2.Text;
            

            listBox1.Items.Add("----- New Sign In ----");
            listBox1.Items.Add(Name);
            listBox1.Items.Add(Surname);
            listBox1.Items.Add(Mobile);
            listBox1.Items.Add(Email);
            listBox1.Items.Add(Date);
            listBox1.Items.Add(Time);
            listBox1.Items.Add(Meeting);
            listBox1.Items.Add("-------------------------");
        }





        private void button2_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.ShowDialog();

            if (F2.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void textBox1Name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

