using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoplanDB
{
    public partial class NewService : Form
    {
        public NewService()
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
                int rc = main.servicesDataGridView.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = NsName.Text;
                nRow[2] = NsPrice.Text;
                nRow[3] = NsDesc.Text;
                nRow[4] = NsCatID.Text;
                main.gEOPLAN_VKRDataSet.Tables[0].Rows.Add(nRow);
                main.servicesTableAdapter.Update(main.gEOPLAN_VKRDataSet.Services);
                main.gEOPLAN_VKRDataSet.Tables[0].AcceptChanges();
                main.servicesDataGridView.Refresh();
                NsName.Text = "";
                NsPrice.Text = "";
                NsDesc.Text = "";
                NsCatID.Text = "";
            }
        }
    }
}
