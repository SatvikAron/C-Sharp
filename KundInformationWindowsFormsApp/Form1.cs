using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KundInformationWindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var name= textBox1.Text ;
          var telefon=  textBox2.Text ;
           var dateofbirth= dateTimePicker1.Value.ToString("yyyy-MM-dd");
            var getinfo = $"{name} ;{dateofbirth}; {telefon}";
            MessageBox.Show(getinfo);
            
            
        }
    }
}
