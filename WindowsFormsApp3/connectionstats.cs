using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Connectionstats : Form
    {
        public Connectionstats()
        {
            InitializeComponent();
        }

        private bool validInfo()
        {
            bool valid = true;
            foreach (Control control in panel1.Controls)
            {
                if (control is TextBox)
                {
                    // TextBox textbox = control as TextBox;
                    valid &= !string.IsNullOrWhiteSpace(control.Text);
                }
            }
            return valid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validInfo() == true)
            {
                var response = MessageBox.Show("Are yo sure the information you have entered is correct?", "Submit", MessageBoxButtons.YesNo);
                if (response == DialogResult.Yes)
                {
                    Form1.boss = textBox1.Text;
                    Form1.dbpass = textBox2.Text;
                    Form1.dbname = textBox3.Text;
                    Form1.connectionString = "Server=127.0.0.1;User Id=" + Form1.boss + ";Password=" + Form1.dbpass + ";Database=" + Form1.dbname + ";";
                    this.Close();
                }
            }
            else
                MessageBox.Show("All fields are required to proceed");
        }

        private void Connectionstats_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(!validInfo())
                Application.Exit();
        }
    }
}
