using System;
using System.Data;
using System.Windows.Forms;

namespace GeoplanDB
{
    public partial class NewCoordinates : Form
    {
        public NewCoordinates()
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
                int rc = main.coordinatesDataGridView.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = NcStatus.Text;
                nRow[2] = NcX.Text;
                nRow[3] = NcY.Text;
                nRow[4] = NcPogr.Text;
                nRow[5] = NcOrderID.Text;
                main.gEOPLAN_VKRDataSet.Tables[0].Rows.Add(nRow);
                main.coordinatesTableAdapter.Update(main.gEOPLAN_VKRDataSet.Coordinates);
                main.gEOPLAN_VKRDataSet.Tables[0].AcceptChanges();
                main.coordinatesDataGridView.Refresh();
                NcStatus.Text = "";
                NcX.Text = "";
                NcY.Text = "";
                NcPogr.Text = "";
                NcOrderID.Text = "";
            }
        }
    }
}
