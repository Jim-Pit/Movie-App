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
    public partial class Form1 : Form
    {
        public static string boss, dbpass, dbname;

        public static string usernam;

        public static string connectionString;

        public Form1()
        {
            InitializeComponent();
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("select username,password from users where username=@x", conn);
                cmd.Parameters.Add("x", NpgsqlTypes.NpgsqlDbType.Text);
                cmd.Prepare();
                cmd.Parameters[0].Value = logu.Text;
                NpgsqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    rdr.Read();
                    if (rdr.GetString(1) == logp.Text)
                    {
                        usernam = logu.Text;
                        MessageBox.Show("Yo 're a homie");
                        MenuForm form = new MenuForm();
                        form.Show(this);
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Wrong password");
                }
                else
                    MessageBox.Show("This username doesn't exist");
            }
        }

        private void roundedButton2_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            infoo.Text = boss +"\n"+ dbpass +"\n"+ dbname +"\n"+ connectionString;
            button1.Visible = false;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connectionstats form = new Connectionstats();
            form.ShowDialog();
            //form.FormClosing += Connectionstats_Closing; //Συνδέω τη μέθοδο Connectionstats_Closing με το event του FormClosing για τη φόρμα form
        }

        /*private void Connectionstats_Closing(object sender, FormClosingEventArgs e)
        {
            infoo.Text = boss + dbpass + dbname;
            this.Show();
        }*/
    }
}