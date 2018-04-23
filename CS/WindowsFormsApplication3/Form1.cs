using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("Column", typeof(string));
            dt.Rows.Add("String 1");
            dt.Rows.Add("String 2");
            dt.Rows.Add("String 3");

            bs.DataSource = dt;
            gridControl1.DataSource = bs;

            RepositoryItemInplaceDataNavigator repo = barEditItem1.Edit as RepositoryItemInplaceDataNavigator;
            repo.EditNavigator.DataSource = bs;

            InplaceDataNavigatorHelper dnHelper = new InplaceDataNavigatorHelper(barEditItem1);  //This helper class is required to refresh bar edit item when position changes          
        }
    }
}
