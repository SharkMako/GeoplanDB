using System;
using System.Data;
using System.Windows.Forms;

namespace GeoplanDB
{
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            MainForm main = this.Owner as MainForm;
            if (main != null)
            {
                DataRow nRow = main.gEOPLAN_VKRDataSet.Tables[0].NewRow();
                int rc = main.categoriesDataGridView.RowCount + 1;
                nRow[0] = rc;
                nRow[1] = NcName.Text;
                nRow[2] = NcSurname.Text;
                nRow[3] = NcPhone;
                nRow[4] = NcEmail;
                main.gEOPLAN_VKRDataSet.Tables[0].Rows.Add(nRow);
                main.clientsTableAdapter.Update(main.gEOPLAN_VKRDataSet.Clients);
                main.gEOPLAN_VKRDataSet.Tables[0].AcceptChanges();
                main.clientsDataGridView.Refresh();
                NcName.Text = "";
                NcSurname.Text = "";
                NcPhone.Text = "";
                NcEmail.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gEOPLAN_VKRDataSet);

        }

        private void NewClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gEOPLAN_VKRDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.gEOPLAN_VKRDataSet.Clients);

        }
    }
};
