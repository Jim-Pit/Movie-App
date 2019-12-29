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
    public partial class SearchForm : Form
    {
        ToolStripItem item;

        public SearchForm()
        {
            InitializeComponent();
        }

        private void dropdownmenu_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(dropdownmenu, 0, dropdownmenu.Height);

            contextMenuStrip1.ItemClicked += new ToolStripItemClickedEventHandler(contexMenu_ItemClicked); //Προσθήκη του event handler contextMenu_ItemClicked
                                                                                                           //στον  event handler του contextMenuStrip1.ItemClicked
        }

        void contexMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            item = e.ClickedItem;
            dropdownmenu.Text = item.ToString();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            MenuForm form = new MenuForm();
            form.Show();
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string par = item.Name;
            string searchkey = searchBox1.Text;
            
            ResultForm res = new ResultForm(par, searchkey);
            res.Show();
            this.Close();
            
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            dropdownmenu.Text = contextMenuStrip1.Items[0].ToString();
            item = contextMenuStrip1.Items[0];
        }
    }
}
