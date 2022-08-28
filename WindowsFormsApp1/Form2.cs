using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        int index = 0;
        Student[] students = new Student[3];
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            Student student = new Student();
            student.Name = textBox1.Text;
            student.Address = textBox2.Text;
            student.Email = textBox3.Text;
            students[index] = student;
            index++;


        }
    }
}
