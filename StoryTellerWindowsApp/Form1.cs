using MultiplierLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryTellerWindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Storyteller obj = new Storyteller();
                tbStory.Text = obj.TellStory(
                    tbNameOfChild.Text,
                    Convert.ToInt32(numAge.Value),
                    cbScary.Checked);
            }
            catch (InvalidOperationException ex)
            {

                MessageBox.Show(" Kann inte berätta story för dig");
            }


            finally
            {

            }
        }
    }
}
