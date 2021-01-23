using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace csharp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog opfd = new OpenFileDialog();
            if (opfd.ShowDialog() == DialogResult.OK)
                textselect.Text = opfd.FileName;
        }

        private void showdata_Click(object sender, EventArgs e)
        {
            string stringconn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + textselect.Text + ";Extended Properties=\"Excel 8.0;HDR=Yes;\";";
            OleDbConnection conn = new OleDbConnection(stringconn);
            if (textselect.Text != "")
            {
                OleDbDataAdapter da = new OleDbDataAdapter("Select * from [" + textchoice.Text + "$]", conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            else
                MessageBox.Show("ER");
        }
    }
}
