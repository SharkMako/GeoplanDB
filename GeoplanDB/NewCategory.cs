using System;
using System.Data;
using System.Windows.Forms;

namespace GeoplanDB
{
    public partial class NewCategory : Form
    {
        public NewCategory()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                DataRow nRow = main.gEOPLAN_VKRDataSet.Tables[0].NewRow();
                int rc = main.categoriesDataGridView.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = NewCatName.Text;
                main.gEOPLAN_VKRDataSet.Tables[0].Rows.Add(nRow);
                main.categoriesTableAdapter.Update(main.gEOPLAN_VKRDataSet.Categories);
                main.gEOPLAN_VKRDataSet.Tables[0].AcceptChanges();
                main.categoriesDataGridView.Refresh();
                NewCatName.Text = "";
            }
        }
    }
};
