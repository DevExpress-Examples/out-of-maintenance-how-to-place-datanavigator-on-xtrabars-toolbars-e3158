using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DataNavigatorInBar
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Column",typeof(string));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bs.DataSource = dt;
            dt.Rows.Add("String 1");
            dt.Rows.Add("String 2");
            dt.Rows.Add("String 3");
            gridControl1.DataSource = bs;
            barEditItem1.EditValue = bs;
        }
    }
}
