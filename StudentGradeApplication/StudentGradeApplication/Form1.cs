using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            double english, math, science, filipino, history;
            string grade;

            english = int.Parse(textBox2.Text);
            math = int.Parse(textBox3.Text);
            science = int.Parse(textBox4.Text);
            filipino = int.Parse(textBox5.Text);
            history = int.Parse(textBox6.Text);

            totalgrades = english + math + science + filipino + history;

            average = totalgrades / 5;

            totalgrades.Text = totalgrades.ToString();

            average = average.ToString();

            if (average >= 75)
            {
                grade = "The student passed.";
            }
            else if
            {
                grade = "The student did not passed.";
            }

            grade.Text = grade;

        }
    }
}
