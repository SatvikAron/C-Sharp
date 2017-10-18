using PracticeLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeApp
{
    public partial class Form1 : Form
    {
        private Personinformation personobj = new Personinformation();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dateofbirth = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            var name = textBox1.Text;
            var telefonno = textBox2.Text;


            personobj.EnterDetails(dateofbirth,name,telefonno);
            label5.Text = personobj.Greeting;
           
            System.IO.File.WriteAllText(@"C:\Users\iceso\Desktop\Csharp\CSharp\PracticeApp\Personinformation.txt", personobj.Greeting);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\iceso\Desktop\Csharp\CSharp\PracticeApp\Personinformation.txt");

            
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                MessageBox.Show("\t" + line);
            }
        }

      
        
    }
}
