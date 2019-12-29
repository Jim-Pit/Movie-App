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
    public partial class Rats : Form
    {
        int mid;

        public Rats()
        {
            InitializeComponent();
        }

        public Rats(int x)
        {
            InitializeComponent();
            mid = x;
        }


        private void hitrate_Click(object sender, EventArgs e)
        {

            int rate = 1;
            foreach (RadioButton control in rates.Controls)
            {
                if (control.Checked)
                    // MessageBox.Show(i.ToString()); ( lame->5 ... kikass->1 )
                    break;
                rate++;
            }
            if (rate != 6)
            {
                using (NpgsqlConnection conn = new NpgsqlConnection(Form1.connectionString))
                {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("insert into rates values(@r,@u,@mid)", conn);
                    cmd.Parameters.Add("r", NpgsqlTypes.NpgsqlDbType.Integer);
                    cmd.Parameters.Add("u", NpgsqlTypes.NpgsqlDbType.Text);
                    cmd.Parameters.Add("mid", NpgsqlTypes.NpgsqlDbType.Integer);
                    cmd.Prepare();
                    cmd.Parameters[0].Value = 6 - rate;
                    cmd.Parameters[1].Value = Form1.usernam;
                    cmd.Parameters[2].Value = mid;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("rated");
                        this.Close();
                    }
                    catch (PostgresException folty)
                    {
                        string folt = folty.Message;
                        if (folt.StartsWith("23505"))
                        {
                            NpgsqlCommand cmmd = new NpgsqlCommand("update rates set rating=@r  where username=@u and movie_id =@mid", conn);
                            cmmd.Parameters.Add("r", NpgsqlTypes.NpgsqlDbType.Integer);
                            cmmd.Parameters.Add("u", NpgsqlTypes.NpgsqlDbType.Text);
                            cmmd.Parameters.Add("mid", NpgsqlTypes.NpgsqlDbType.Integer);
                            cmmd.Prepare();
                            cmmd.Parameters[0].Value = 6 - rate;
                            cmmd.Parameters[1].Value = Form1.usernam;
                            cmmd.Parameters[2].Value = mid;
                            try
                            {
                                cmmd.ExecuteNonQuery();
                                MessageBox.Show("Your rating has been updated");
                                this.Close();
                            }
                            catch (Exception fukdup)
                            {
                                MessageBox.Show(fukdup.Message);
                            }
                        }
                        else
                            MessageBox.Show(folty.Message + "\nDetails:" + folty.Detail);
                    }
                }
            }
            else
                MessageBox.Show("Forgot to put a rate on");
        }
    }
}