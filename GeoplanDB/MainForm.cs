using System;
using System.Windows.Forms;

namespace GeoplanDB
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void categoriesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.gEOPLAN_VKRDataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gEOPLAN_VKRDataSet.Workers". При необходимости она может быть перемещена или удалена.
            this.workersTableAdapter.Fill(this.gEOPLAN_VKRDataSet.Workers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gEOPLAN_VKRDataSet.Services". При необходимости она может быть перемещена или удалена.
            this.servicesTableAdapter.Fill(this.gEOPLAN_VKRDataSet.Services);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gEOPLAN_VKRDataSet.Orders". При необходимости она может быть перемещена или удалена.
            this.ordersTableAdapter.Fill(this.gEOPLAN_VKRDataSet.Orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gEOPLAN_VKRDataSet.Coordinates". При необходимости она может быть перемещена или удалена.
            this.coordinatesTableAdapter.Fill(this.gEOPLAN_VKRDataSet.Coordinates);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gEOPLAN_VKRDataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.gEOPLAN_VKRDataSet.Clients);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "gEOPLAN_VKRDataSet.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.gEOPLAN_VKRDataSet.Categories);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.workersTableAdapter.Update(this.gEOPLAN_VKRDataSet.Workers);
            this.servicesTableAdapter.Update(this.gEOPLAN_VKRDataSet.Services);
            this.ordersTableAdapter.Update(this.gEOPLAN_VKRDataSet.Orders);
            this.coordinatesTableAdapter.Update(this.gEOPLAN_VKRDataSet.Coordinates);
            this.clientsTableAdapter.Update(this.gEOPLAN_VKRDataSet.Clients);
            this.categoriesTableAdapter.Update(this.gEOPLAN_VKRDataSet.Categories);
        }

        private void categoriesDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Вы уверены что хотитей выйти?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr != DialogResult.Cancel)
            {
                Close();
            }
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            NewCategory af = new NewCategory();
            af.Owner = this;
            af.Show();
        }

        private void AddClient_Click_1(object sender, EventArgs e)
        {
            NewClient af = new NewClient();
            af.Owner = this;
            af.Show();
        }

        private void AddCoord_Click(object sender, EventArgs e)
        {
            NewCoordinates af = new NewCoordinates();
            af.Owner = this;
            af.Show();
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            NewOrder af = new NewOrder();
            af.Owner = this;
            af.Show();
        }

        private void AddService_Click(object sender, EventArgs e)
        {
            NewService af = new NewService();
            af.Owner = this;
            af.Show();
        }

        private void AddWorker_Click(object sender, EventArgs e)
        {
            NewWorker af = new NewWorker();
            af.Owner = this;
            af.Show();
        }
    }
}