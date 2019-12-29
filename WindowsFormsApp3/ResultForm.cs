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
    public partial class ResultForm : Form
    {
        string param, searchK;

        public ResultForm()
        {
            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            bool isStringContainedInList = new[] { "actor", "writer", "director" }.Contains(param);

            if (isStringContainedInList)
            {
                AddWatch.Visible = false;
                RateBtn.Visible = false;
            }
            screen.Click += new EventHandler(screen_Click);
            label1.Text = param + searchK;

            string query = "select * from movie";
            if (param == "language")
            {
                query = "select * from movie " + "where (movie.lang_code in (select languages.lang_code " +
                                                           "from languages " +
                                                           "where languages.language_name like " + "'" + searchK + "%'))";
            }
            else if (param == "movie")
            {
                query = "select * from movie where movie.title ~* " + "'" + searchK + "'";
            }else if (param == "country")
            {
                query = "select * from movie " + "where (movie.coun_code in (select countries.coun_code " +
                                                           "from countries " +
                                                           "where countries.country ~* " + "'" + searchK + "'))";
            }else if(param == "actor")
            {
               query = " SELECT distinct employee.first_name,employee.last_name,movie.title FROM employee,worked_at,movie " +
                       " WHERE ((employee.first_name ~* "+"'"+searchK+"'"+" or employee.last_name ~* " +"'"+searchK+"')"+" and "
                       + "employee.id IN (SELECT worked_at.employee_id FROM worked_at WHERE worked_at.job_code = 1) and worked_at.movie_id=movie.movie_id and worked_at.employee_id=employee.id)";
            }else if (param == "writer")
            {
                query = " SELECT employee.last_name,employee.first_name FROM employee " +
                       " WHERE ((employee.first_name ~* " + "'" + searchK + "'" + " or employee.last_name ~* " + "'" + searchK + "')" + " and "
                       + "employee.id IN (SELECT worked_at.employee_id FROM worked_at WHERE worked_at.job_code = 2))";
            }
            else if (param == "director")
            {
                query = " SELECT employee.last_name,employee.first_name FROM employee " +
                       " WHERE ((employee.first_name ~* " + "'" + searchK + "'" + " or employee.last_name ~* " + "'" + searchK + "')" + " and "
                       + "employee.id IN (SELECT worked_at.employee_id FROM worked_at WHERE worked_at.job_code = 4))";
            }


            NpgsqlConnection conn;
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
                if (param == "movie" || param == "language" || param == "country")
                {
                    screen.DataSource = results;
                    screen.DisplayMember = "title";
                    screen.ValueMember = "movie_id";
                }else
                    ResultBox.DataSource = results;

            }
        }
        private void screen_Click(object sender, EventArgs e)
        {
            info.Clear();
            ListBox bx = sender as ListBox;
            if (bx.Items.Count != 0)
            {
                // MessageBox.Show(bx.SelectedValue.ToString());

                using (NpgsqlConnection conn = new NpgsqlConnection(Form1.connectionString))
                {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("select movie.title,movie.runtime,movie.plot,movie.release_year,genres.genre,languages.language_name,countries.country "
                                                         + "from movie, genres, languages, countries "
                                                         + "where movie.g_code = genres.g_code and movie.lang_code = languages.lang_code and countries.coun_code = movie.coun_code and movie_id=@id", conn);
                    cmd.Parameters.Add("id", NpgsqlTypes.NpgsqlDbType.Integer);
                    cmd.Prepare();
                    cmd.Parameters[0].Value = bx.SelectedValue; //selected value <-> moviid

                    NpgsqlDataReader rdr;
                    rdr = cmd.ExecuteReader();

                    rdr.Read();
                    info.AppendText("Title: " + rdr.GetString(0) + "\n" +
                    "Duration: " + rdr.GetInt16(1) + "'" + "\n" +
                    "Plot: " + rdr.GetString(2) + "\n" +
                    "Released at: " + rdr.GetInt16(3) + "\n" +
                    "Genre: " + rdr.GetString(4) + "\n" +
                    "Spoken language: " + rdr.GetString(5) + "\n" +
                    "Country: " + rdr.GetString(6 ) + "\n");
                }
                /*
                string factors = " SELECT employee.last_name,employee.first_name,employee.id "
                + "FROM employee "
                + "WHERE(employee.id IN(SELECT worked_at.employee_id "
                + "FROM worked_at  "
                + "WHERE worked_at.job_code = 1))";
                */
                using (NpgsqlConnection conn = new NpgsqlConnection(Form1.connectionString))
                {
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand("SELECT employee.last_name,employee.first_name,jobs.job_name "
                                                          + "FROM employee, worked_at, jobs "
                                                          + "WHERE worked_at.employee_id = employee.id and worked_at.job_code = jobs.job_code and worked_at.movie_id = @id", conn);
                    cmd.Parameters.Add("id", NpgsqlTypes.NpgsqlDbType.Integer);
                    cmd.Prepare();
                    cmd.Parameters[0].Value = bx.SelectedValue; //selected value <-> moviid
                    NpgsqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        info.AppendText(rdr.GetString(2)+": "+rdr.GetString(0)+" "+rdr.GetString(1)+" "+"\n");
                        info.AppendText("\n");
                    }
                }
            }
            else
                info.AppendText("No Results");
        }

        private void RateBtn_Click(object sender, EventArgs e)
        {
            int mid= (int)this.screen.SelectedValue;
            Rats form  = new Rats(mid);
            form.ShowDialog(this);
        }

        private void AddWatch_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection(Form1.connectionString))
            {
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand("insert into watchlist values(@u,@mid)", conn);
                cmd.Parameters.Add("u", NpgsqlTypes.NpgsqlDbType.Text);
                cmd.Parameters.Add("mid", NpgsqlTypes.NpgsqlDbType.Integer);
                cmd.Prepare();
                cmd.Parameters[0].Value = Form1.usernam;
                cmd.Parameters[1].Value = (int)screen.SelectedValue;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("added");
                }
                catch (PostgresException folty)
                {
                    string folt = folty.Message;
                    //if (folt.StartsWith("23505")) { }

                }
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            MenuForm form = new MenuForm();
            form.Show();
            this.Close();
        }

        public ResultForm(string txt1,string txt2)
        {
            InitializeComponent();
            param = txt1;
            searchK = txt2.ToLower();
        }
    }
}
