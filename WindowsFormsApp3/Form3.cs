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
    public partial class watchli : Form
    {

        public watchli()
        {
            InitializeComponent();
        }

        private void watchli_Load(object sender, EventArgs e)
        {
            NpgsqlConnection conn;
            string query = "select movie.title,movie.movie_id from movie where movie_id in(select movie_id "
                                                            + "from watchlist "
                                                            + "where username=" + "'"+Form1.usernam+"'" + ")";

            using (conn = new NpgsqlConnection(Form1.connectionString))
            using (NpgsqlDataAdapter adaptauros = new NpgsqlDataAdapter(query, conn))
            {
                // Adapter opens a connection
                DataTable results = new DataTable();
                try
                {
                    adaptauros.Fill(results);
                }
                catch (PostgresException ex)
                {
                    MessageBox.Show(ex.Message + "\nDetail: " + ex.Detail);
                }
                //ResultBox.DataSource = results;
                screen.DataSource = results;
                screen.DisplayMember = "title";
                screen.ValueMember = "movie_id";

                /*conn.Open();
                NpgsqlCommand cmnd = new NpgsqlCommand("select movie.title "
                                                       +"from movie where movie_id in(select movie_id "
                                                                                      +"from watchlist "
                                                                                      +"where username=@u)", conn);
                cmnd.Parameters.Add("u", NpgsqlTypes.NpgsqlDbType.Text);
                cmnd.Prepare();
                cmnd.Parameters[0].Value = Form1.usernam;
                cmnd.ExecuteNonQuery();

                try
                {
                }
                catch (PostgresException ex)
                {
                    MessageBox.Show(ex.Message + "\nDetail: " + ex.Detail);
                }
            }*/

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn;
            string queryy = "delete from watchlist where movie_id=@mid and username=" + "'" + Form1.usernam + "'";

            using (conn = new NpgsqlConnection(Form1.connectionString))
            {
                conn.Open();
                NpgsqlCommand cmnd = new NpgsqlCommand(queryy,conn);
                cmnd.Parameters.Add("mid", NpgsqlTypes.NpgsqlDbType.Integer);
                cmnd.Prepare();            
                cmnd.Parameters[0].Value = (int)screen.SelectedValue;
                try
                {
                    cmnd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    this.Close();
                }
                catch (PostgresException ex)
                {
                    MessageBox.Show(ex.Message + "\nDetail: " + ex.Detail);
                }
                //ResultBox.DataSource = results;
                
            }
        }
    }
}
