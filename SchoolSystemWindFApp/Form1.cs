using SchoolLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystemWindFApp
{
    public partial class Form1 : Form
    {
        SchoolSystem obj = new SchoolSystem();
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            
            var classname = textBox1.Text;
            var numberofstudent = int.Parse(textBox2.Text);
            obj.AddClass(classname, numberofstudent);
          



        }

        private void button2_Click(object sender, EventArgs e)
        {
            var scolname = textBox3.Text;
            MessageBox.Show($"school name {scolname} total class name is= {obj.ClassCount} anr the total student num is= {obj.StudentCount}");
        }
    }
}
