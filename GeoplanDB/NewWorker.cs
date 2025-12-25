using System;
using System.Data;
using System.Windows.Forms;

namespace GeoplanDB
{
    public partial class NewWorker : Form
    {
        public NewWorker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                DataRow nRow = main.gEOPLAN_VKRDataSet.Tables[0].NewRow();
                int rc = main.workersDataGridView.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = NwName.Text;
                nRow[2] = NwSurname.Text;
                nRow[3] = NwPhone.Text;
                nRow[4] = NwAge.Text;
                nRow[5] = NwEmail.Text;
                main.gEOPLAN_VKRDataSet.Tables[0].Rows.Add(nRow);
                main.workersTableAdapter.Update(main.gEOPLAN_VKRDataSet.Workers);
                main.gEOPLAN_VKRDataSet.Tables[0].AcceptChanges();
                main.workersDataGridView.Refresh();
                NwName.Text = "";
                NwSurname.Text = "";
                NwPhone.Text = "";
                NwAge.Text = "";
                NwEmail.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
