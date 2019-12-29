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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void searchBtn1_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm();
            form.Show();
            this.Close();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WatchListBtn_Click(object sender, EventArgs e)
        {
            watchli watchlist = new watchli();
            watchlist.ShowDialog();
        }
    }
}
