using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp3
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            SubmitBtn.Enabled = false;
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show(this);
            this.Hide();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Form1.connectionString))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into users values(@u,@p,@e,@bDay)", conn);
                cmd.Parameters.Add("u", NpgsqlTypes.NpgsqlDbType.Text);
                cmd.Parameters.Add("p", NpgsqlTypes.NpgsqlDbType.Text);
                cmd.Parameters.Add("e", NpgsqlTypes.NpgsqlDbType.Text);
                cmd.Parameters.Add("bDay", NpgsqlTypes.NpgsqlDbType.Date);
                cmd.Prepare();
                cmd.Parameters[0].Value = usr.Text;
                cmd.Parameters[1].Value = pass.Text;
                cmd.Parameters[2].Value = email.Text;
                cmd.Parameters[3].Value = cal.Value.ToString("yyyy-MM-dd");
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration Completed Bro");
                    this.Close();
                }
                catch (PostgresException err)
                {
                    string rror = err.Message;
                    if (rror.StartsWith("23505"))
                        MessageBox.Show("This username already exists");
                    else
                        MessageBox.Show(err.Message + "\nDetail:" + err.Detail);
                }
            }
        }
        private bool validInfo()
        {
            bool valid = true;
            foreach (Control control in rgstr.Controls)
            {
                if (control is TextBox)
                {
                    // TextBox textbox = control as TextBox;
                    valid &= !string.IsNullOrWhiteSpace(control.Text);
                }
            }

            return valid;
        }

        private void termtsek_CheckedChanged_1(object sender, EventArgs e)
        {
            if (validInfo() == true && termtsek.Checked == true)
            {
                SubmitBtn.Enabled = true;
            }
            else if ((validInfo() == false && termtsek.Checked == true))
            {
                MessageBox.Show("Insert All Info Fields & then Accept My Terms");
                termtsek.Checked = false;
            }
            else if (termtsek.Checked == false)
            {
                SubmitBtn.Enabled = false;
            }
        }
    }
}
